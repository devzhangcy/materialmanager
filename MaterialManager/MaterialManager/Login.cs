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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 关闭窗体释放进程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            System.Environment.Exit(0);
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUser.Text.Trim();
                if (username == "")
                {
                    MessageBox.Show("账号不能为空！");
                    return;
                }
                string password = txtPassword.Text.Trim();
                if (password == "")
                {
                    MessageBox.Show("密码不能为空！");
                    return;
                }
                //判断账号密码是否正确
                string sql = "select * from user where loginname='" + username + "' and password='" + password + "'";
                DataTable dt = DbHelperMySQL.Query(sql).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    MainForm frm = new MainForm();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("登录失败，账号不存在或账号登录信息错误！");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("登录异常！");
            }
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.Environment.Exit(0);
        }

        /// <summary>
        /// 忘记密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblForget_Click(object sender, EventArgs e)
        {
            RegisterEdit frm = new RegisterEdit();
            frm.ShowDialog();
        }

        /// <summary>
        /// 注册账号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblRegister_Click(object sender, EventArgs e)
        {
            Register frm = new Register();
            frm.ShowDialog();
        }
    }
}
