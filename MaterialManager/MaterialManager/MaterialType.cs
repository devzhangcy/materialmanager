using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialManager
{
    public partial class MaterialType : Form
    {
        public string getid = "";
        public MaterialType()
        {
            InitializeComponent();
            BindList("");
        }

        public MaterialType(string id)
        {
            InitializeComponent();
            this.getid = id;
            BindList(getid);
        }

        /// <summary>
        /// 初始化下拉框
        /// </summary>
        public void BindList(string id)
        {
            try
            {
                //材料类型
                string sqlType = "select * from supplier order by id asc";
                DataTable dtType = DbHelperMySQL.Query(sqlType).Tables[0];
                DataRow drType = dtType.NewRow();
                drType["id"] = "-1";
                drType["name"] = "-请选择-";
                dtType.Rows.InsertAt(drType, 0);
                comboBoxSup.DataSource = dtType;
                comboBoxSup.DisplayMember = "name";
                comboBoxSup.ValueMember = "id";
                if (!string.IsNullOrEmpty(id))
                {
                    string sql = "select * from materialtype where id='" + id + "'";
                    DataTable dt = DbHelperMySQL.Query(sql).Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        comboBoxSup.SelectedValue = int.Parse(dt.Rows[0]["supplierid"].ToString());
                        txtName.Text = dt.Rows[0]["name"].ToString();
                        txtRemark.Text = dt.Rows[0]["description"].ToString();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void btnSumbit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (name == "")
            {
                MessageBox.Show("种类名称不能为空！");
                return;
            }
            string typeid = comboBoxSup.SelectedValue.ToString();
            if (typeid == "-1")
            {
                MessageBox.Show("请选择供应商！");
                return;
            }
            string typename = comboBoxSup.Text;
            string sql = "select * from materialtype where name='" + name + "'";
            DataTable dt = DbHelperMySQL.Query(sql).Tables[0];
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("类目已存在！");
                return;
            }
            string remark = txtRemark.Text.Trim();
            string times = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            if (string.IsNullOrEmpty(getid))
            {
                sql = "insert into materialtype (name,supplierid,suppliername,description,createtime) values ('" + name + "','" + typeid + "','" + typename + "','" + remark + "','" + times + "')";
                int add = DbHelperMySQL.ExecuteSql(sql);
                if (add > 0)
                {
                    MessageBox.Show("添加成功！");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加失败！");
                    return;
                }
            }
            else
            {
                string sqls = "select * from materialtype where name='" + name + "' and id !='" + getid + "'";
                DataTable dts = DbHelperMySQL.Query(sqls).Tables[0];
                if (dts.Rows.Count > 0)
                {
                    MessageBox.Show("类目已存在！");
                    return;
                }
                sql = "update materialtype set name='" + name + "',supplierid='" + typeid + "',suppliername='" + typename + "',description='" + remark + "',createtime='" + times + "' where id='" + getid + "'";
                int updates = DbHelperMySQL.ExecuteSql(sql);
                if (updates > 0)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            comboBoxSup.SelectedValue = -1;
            txtRemark.Text = "";
            this.Close();
        }
    }
}
