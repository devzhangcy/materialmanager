using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MaterialManager
{
    public partial class AddMaterial : Form
    {
        public string getid = "";
        public string supplierid = "-1";
        public string suppliername = "";
        public AddMaterial()
        {
            InitializeComponent();
            InitAddList("");
        }

        public AddMaterial(string materialid)
        {
            InitializeComponent();
            this.getid = materialid;
            InitAddList(getid);
        }

        /// <summary>
        /// 初始化下拉框
        /// 
        /// </summary>
        public void InitAddList(string id)
        {
            try
            {
                //设备类型
                string sqlType = "select * from materialtype";
                DataTable dtType = DbHelperMySQL.Query(sqlType).Tables[0];
                DataRow drType = dtType.NewRow();
                drType["id"] = "-1";
                drType["name"] = "-请选择-";
                dtType.Rows.InsertAt(drType, 0);
                comboBoxType.DataSource = dtType;
                comboBoxType.DisplayMember = "name";
                comboBoxType.ValueMember = "id";
                string sqlSup = "select * from supplier";
                DataTable dtSup = DbHelperMySQL.Query(sqlSup).Tables[0];
                DataRow drSup = dtSup.NewRow();
                drSup["id"] = "-1";
                drSup["name"] = "-请选择-";
                dtSup.Rows.InsertAt(drSup, 0);
                comboBoxSupplier.DataSource = dtSup;
                comboBoxSupplier.DisplayMember = "name";
                comboBoxSupplier.ValueMember = "id";
                if (!string.IsNullOrEmpty(id))
                {
                    string sql = "select * from material where id='" + id + "'";
                    DataTable dt = DbHelperMySQL.Query(sql).Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        comboBoxType.SelectedValue = int.Parse(dt.Rows[0]["typeid"].ToString());
                        comboBoxSupplier.SelectedValue = int.Parse(dt.Rows[0]["supplierid"].ToString());
                        txtName.Text = dt.Rows[0]["name"].ToString();
                        txtNum.Text = dt.Rows[0]["num"].ToString();
                        txtPrice.Text = dt.Rows[0]["price"].ToString();
                        txtUnit.Text = dt.Rows[0]["unit"].ToString();
                        textDescription.Text = dt.Rows[0]["description"].ToString();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void btnSumbit_Click(object sender, EventArgs e)
        {
            string typeid = comboBoxType.SelectedValue.ToString();
            if (typeid == "-1")
            {
                MessageBox.Show("请选择材料类型！");
                return;
            }
            string typename = comboBoxType.Text;
            supplierid = comboBoxSupplier.SelectedValue.ToString();
            if (supplierid == "-1")
            {
                MessageBox.Show("请选择供应商！");
                return;
            }
            suppliername = comboBoxSupplier.Text;
            string materialname = txtName.Text.Trim();
            if (materialname == "")
            {
                MessageBox.Show("材料名称不能为空！");
                return;
            }
            string num = txtNum.Text.Trim();
            if (num == "")
            {
                MessageBox.Show("库存数量不能为空！");
                return;
            }
            if (!checkNum(num))
            {
                MessageBox.Show("库存数量应该为整形数字！");
                return;
            }
            if (int.Parse(num) < 0)
            {
                MessageBox.Show("库存数量不能小于0！");
                return;
            }
            string price = txtPrice.Text.Trim();
            if (price == "")
            {
                MessageBox.Show("材料价格不能为空！");
                return;
            }
            if (!checkFloat(price))
            {
                MessageBox.Show("材料价格应该为数字！");
                return;
            }
            if (Convert.ToDecimal(price) < 0)
            {
                MessageBox.Show("库存价格不能小于0！");
                return;
            }
            string unit = txtUnit.Text.Trim();
            if (unit == "")
            {
                MessageBox.Show("规格单位不能为空！");
                return;
            }
            string remark = textDescription.Text.Trim();
            DataTable dt = null;
            string sql = "";
            string times = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            if (string.IsNullOrEmpty(getid))
            {
                sql = "select * from material where name='" + materialname + "'";
                dt = DbHelperMySQL.Query(sql).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("材料已存在！");
                    return;
                }
                sql = "insert into material (name,typeid,typename,supplierid,suppliername,num,price,unit,description,createtime) values ('" + materialname + "','" + typeid + "','" + typename + "','" + supplierid + "','" + suppliername + "','" + num + "','" + price + "','" + unit + "','" + remark + "','" + times + "')";
                int add = DbHelperMySQL.ExecuteSql(sql);
                if (add > 0)
                {
                    MessageBox.Show("新增成功！");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("新增失败！");
                    return;
                }
            }
            else
            {
                sql = "select * from material where name='" + materialname + "' and id !='" + getid + "'";
                dt = DbHelperMySQL.Query(sql).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("材料已存在！");
                    return;
                }
                sql = "update material set name='" + materialname + "',typeid='" + typeid + "',typename='" + typename + "',supplierid='" + supplierid + "',suppliername='" + suppliername + "',num='" + num + "',price='" + price + "',unit='" + unit + "',description='" + remark + "',createtime='" + times + "' where id='" + getid + "'";
                int update = DbHelperMySQL.ExecuteSql(sql);
                if (update > 0)
                {
                    MessageBox.Show("修改成功！");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败！");
                    return;
                }
            }
        }

        public bool checkNum(string str)
        {
            bool res = false;
            int number;
            bool isNumber = int.TryParse(str, out number);
            if (isNumber)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }

        public bool checkFloat(string str)
        {
            bool res = false;
            double dNumber;
            bool isNumber = double.TryParse(str, out dNumber);
            if (isNumber)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            comboBoxType.SelectedValue = -1;
            txtName.Text = "";
            txtNum.Text = "";
            txtUnit.Text = "";
            textDescription.Text = "";
            this.Close();
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedValue.ToString() != "-1")
            {
                if (checkNum(comboBoxType.SelectedValue.ToString()))
                {
                    string sql = "select * from materialtype where id='" + comboBoxType.SelectedValue.ToString() + "'";
                    DataTable dt = DbHelperMySQL.Query(sql).Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        comboBoxSupplier.SelectedValue = int.Parse(dt.Rows[0]["supplierid"].ToString());
                        supplierid = dt.Rows[0]["supplierid"].ToString();
                        suppliername = dt.Rows[0]["suppliername"].ToString();
                    }
                }
            }
        }

    }
}
