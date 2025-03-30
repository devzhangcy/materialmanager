using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MaterialManager
{
    public partial class AddPurchase : Form
    {
        public AddPurchase()
        {
            InitializeComponent();
            InitAddList("");
        }

        /// <summary>
        /// 初始化下拉框
        /// 
        /// </summary>
        public void InitAddList(string id)
        {
            try
            {
                string sqlType = "select * from material where num>0 order by id asc";
                DataTable dtType = DbHelperMySQL.Query(sqlType).Tables[0];
                DataRow drType = dtType.NewRow();
                drType["id"] = "-1";
                drType["name"] = "-请选择-";
                dtType.Rows.InsertAt(drType, 0);
                comboBoxName.DataSource = dtType;
                comboBoxName.DisplayMember = "name";
                comboBoxName.ValueMember = "id";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void btnSumbit_Click(object sender, EventArgs e)
        {
            DataTable dt = null;
            string sql = "";
            string materialid = comboBoxName.SelectedValue.ToString();
            if (materialid == "-1")
            {
                MessageBox.Show("请选择材料！");
                return;
            }
            string materialname = comboBoxName.Text;
            if (materialname == "")
            {
                MessageBox.Show("材料类型不能为空！");
                return;
            }
            string num = txtNum.Text.Trim();
            if (num == "")
            {
                MessageBox.Show("采购数量不能为空！");
                return;
            }
            if (!checkNum(num))
            {
                MessageBox.Show("采购数量应该为整形数字！");
                return;
            }
            if (int.Parse(num) < 1)
            {
                MessageBox.Show("采购数量不能小于1！");
                return;
            }
            string restnum = "";//剩余库存
            string typeid = "";
            string supplierid = "";
            sql = "select * from material where id='" + materialid + "'";
            dt = DbHelperMySQL.Query(sql).Tables[0];
            if (dt.Rows.Count > 0)
            {
                typeid = dt.Rows[0]["typeid"].ToString();
                txtUnit.Text = dt.Rows[0]["unit"].ToString();
                supplierid = dt.Rows[0]["supplierid"].ToString();
                if (int.Parse(dt.Rows[0]["num"].ToString()) < int.Parse(num))
                {
                    MessageBox.Show("采购数量不能超过库存数量！");
                    return;
                }
                decimal price = Convert.ToDecimal(dt.Rows[0]["price"].ToString()) * int.Parse(num);
                txtPrice.Text = price.ToString();
                restnum = (int.Parse(dt.Rows[0]["num"].ToString()) - int.Parse(num)).ToString();
            }
            string remark = textDescription.Text.Trim();
            string times = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            sql = "insert into purchase (materialid,materialname,supplierid,suppliername,materialtypeid,materialtypename,num,pay,unit,description,createtime) values ('" + materialid + "','" + materialname + "','" + supplierid + "','" + txtSup.Text + "','" + typeid + "','" + txtType.Text + "','" + num + "','" + txtPrice.Text + "','" + txtUnit.Text + "','" + remark + "','" + times + "')";
            int add = DbHelperMySQL.ExecuteSql(sql);
            if (add > 0)
            {
                //采购成功，扣减库存
                sql = "update material set num='" + restnum + "' where id='" + materialid + "'";
                int okk = DbHelperMySQL.ExecuteSql(sql);
                if (okk > 0)
                {
                    MessageBox.Show("采购成功！");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("采购失败！");
                    return;
                }
            }
            else
            {
                MessageBox.Show("采购失败！");
                return;
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
            comboBoxName.SelectedValue = -1;
            txtType.Text = "";
            txtNum.Text = "";
            txtPrice.Text = "";
            txtUnit.Text = "";
            textDescription.Text = "";
            this.Close();
        }

        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxName.SelectedValue.ToString() != "-1")
            {
                if (checkNum(comboBoxName.SelectedValue.ToString()))
                {
                    string sql = "select * from material where id='" + comboBoxName.SelectedValue.ToString() + "'";
                    DataTable dt = DbHelperMySQL.Query(sql).Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        txtType.Text = dt.Rows[0]["typename"].ToString();
                        txtSup.Text = dt.Rows[0]["suppliername"].ToString();
                        txtUnit.Text = dt.Rows[0]["unit"].ToString();
                        txtPrice.Text = dt.Rows[0]["price"].ToString();
                    }
                }
            }
        }
    }
}
