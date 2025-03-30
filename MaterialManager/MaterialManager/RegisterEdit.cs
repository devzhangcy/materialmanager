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
    public partial class RegisterEdit : Form
    {
        public RegisterEdit()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 取消，退出窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtLoginName.Text = "";
            this.txtPassword.Text = "";
            this.txtAgainPassword.Text = "";
            this.Close();
        }

        /// <summary>
        /// 提交修改信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string loginname = this.txtLoginName.Text.Trim();
            if (loginname == "")
            {
                MessageBox.Show("请填写登录账号信息！");
                return;
            }
            string loginpwd = this.txtPassword.Text.Trim();
            if (loginpwd == "")
            {
                MessageBox.Show("请填写登录密码！");
                return;
            }
            string againpwd = this.txtAgainPassword.Text.Trim();
            if (againpwd == "")
            {
                MessageBox.Show("请填写确认密码！");
                return;
            }
            if (loginpwd != againpwd)
            {
                MessageBox.Show("两次输入的密码不一致！");
                return;
            }
            string sql = "";
            DataTable dt = null;
            //判断信息是否存在
            sql = "select * from user where loginname='" + loginname + "'";
            dt = DbHelperMySQL.Query(sql).Tables[0];
            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("账号信息不存在！");
                return;
            }
            //开始重置
            sql = "update user set password='" + loginpwd + "' where loginname='" + loginname + "'";
            int updates = DbHelperMySQL.ExecuteSql(sql);
            if (updates > 0)
            {
                MessageBox.Show("重置密码成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("重置密码失败！");
                return;
            }
        }
    }
}
