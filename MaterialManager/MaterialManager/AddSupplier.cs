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
    public partial class AddSupplier : Form
    {
        public string getid = "";
        public AddSupplier()
        {
            InitializeComponent();
        }

        public AddSupplier(string id)
        {
            InitializeComponent();
            this.getid = id;
            string sql = "select * from supplier where id='" + getid + "'";
            DataTable dt = DbHelperMySQL.Query(sql).Tables[0];
            if (dt.Rows.Count > 0)
            {
                txtName.Text = dt.Rows[0]["name"].ToString();
                txtAddress.Text = dt.Rows[0]["address"].ToString();
                txtTelPhone.Text = dt.Rows[0]["telphone"].ToString();
                txtRemark.Text = dt.Rows[0]["description"].ToString();
            }
        }

        private void btnSumbit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (name == "")
            {
                MessageBox.Show("供应商名称不能为空！");
                return;
            }
            string address = txtAddress.Text.Trim();
            if (address == "")
            {
                MessageBox.Show("供应商地址不能为空！");
                return;
            }
            string telphone = txtTelPhone.Text.Trim();
            if (telphone == "")
            {
                MessageBox.Show("供应商联系方式不能为空！");
                return;
            }
            string sql = "";
            DataTable dt = null;
            string remark = txtRemark.Text.Trim();
            string times = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            if (string.IsNullOrEmpty(getid))
            {
                sql = "select * from supplier where name='" + name + "'";
                dt = DbHelperMySQL.Query(sql).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("供应商已存在！");
                    return;
                }
                sql = "insert into supplier (name,address,telphone,description,createtime) values ('" + name + "','" + address + "','" + telphone + "','" + remark + "','" + times + "')";
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
                sql = "select * from supplier where name='" + name + "' and id !='" + getid + "'";
                dt = DbHelperMySQL.Query(sql).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("供应商已存在！");
                    return;
                }
                sql = "update supplier set name='" + name + "',address='" + address + "',telphone='" + telphone + "',description='" + remark + "',createtime='" + times + "' where id='" + getid + "'";
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
            txtAddress.Text = "";
            txtTelPhone.Text = "";
            txtRemark.Text = "";
            this.Close();
        }
    }
}
