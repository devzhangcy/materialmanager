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
    public partial class Register : Form
    {
        public string getid = "";
        public Register()
        {
            InitializeComponent();
        }

        public Register(string id)
        {
            InitializeComponent();
            this.getid = id;
            string sql = "select * from user where id='" + getid + "'";
            DataTable dt = DbHelperMySQL.Query(sql).Tables[0];
            if (dt.Rows.Count > 0)
            {
                this.txtUserName.Text = dt.Rows[0]["username"].ToString();
                this.txtLoginName.Text = dt.Rows[0]["loginname"].ToString();
                this.txtLoginPwd.Text = dt.Rows[0]["password"].ToString();
                this.txtPwdAgain.Text = dt.Rows[0]["password"].ToString();
            }
        }

        /// <summary>
        /// 取消注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtUserName.Text = "";
            this.txtLoginName.Text = "";
            this.txtLoginPwd.Text = "";
            this.txtPwdAgain.Text = "";
            this.Close();
        }

        /// <summary>
        /// 提交注册信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = this.txtUserName.Text.Trim();
            if (username == "")
            {
                MessageBox.Show("请填写用户昵称！");
                return;
            }
            string loginname = this.txtLoginName.Text.Trim();
            if (loginname == "")
            {
                MessageBox.Show("请填写登录账户！");
                return;
            }
            string loginpwd = this.txtLoginPwd.Text.Trim();
            if (loginpwd == "")
            {
                MessageBox.Show("请填写登录密码！");
                return;
            }
            string againpwd = this.txtPwdAgain.Text.Trim();
            if (againpwd == "")
            {
                MessageBox.Show("请填写确认密码！");
                return;
            }
            DataTable dt = null;
            string sql = "";
            if (string.IsNullOrEmpty(getid))
            {
                //判断账户是否已存在
                sql = "select * from user where username='" + username + "'";
                dt = DbHelperMySQL.Query(sql).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("账号昵称已存在！");
                    return;
                }
                sql = "select * from user where loginname='" + loginname + "'";
                dt = DbHelperMySQL.Query(sql).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("登录账号已存在！");
                    return;
                }
                //判断密码是否一致
                if (loginpwd != againpwd)
                {
                    MessageBox.Show("两次输入的密码不一致！");
                    return;
                }
                string times = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                //开始创建
                sql = "insert into user (username,loginname,password,createtime) values ";
                sql += "('" + username + "','" + loginname + "','" + loginpwd + "','" + times + "')";
                int adds = DbHelperMySQL.ExecuteSql(sql);
                if (adds > 0)
                {
                    MessageBox.Show("新建成功！");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("新建失败！");
                    return;
                }
            }
            else
            {
                //判断账户是否已存在
                sql = "select * from user where username='" + username + "' and id !='" + getid + "'";
                dt = DbHelperMySQL.Query(sql).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("账号昵称已存在！");
                    return;
                }
                sql = "select * from user where loginname='" + loginname + "' and id !='" + getid + "'";
                dt = DbHelperMySQL.Query(sql).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("登录账号已存在！");
                    return;
                }
                //判断密码是否一致
                if (loginpwd != againpwd)
                {
                    MessageBox.Show("两次输入的密码不一致！");
                    return;
                }
                string times = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                //开始创建
                sql = "update user set username='" + username + "',loginname='" + loginname + "',password='" + loginpwd + "',createtime='" + times + "' where id='" + getid + "' ";
                int res = DbHelperMySQL.ExecuteSql(sql);
                if (res > 0)
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
    }
}
