using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialManager
{
    public partial class MainForm : Form
    {
        public int[] s = { 0, 0, 0, 0, 0, 0 };//子窗体数
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("你确定要退出系统吗？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                this.Dispose();
                Application.ExitThread();
                System.Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void tabWindows_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (s[tabWindows.SelectedIndex] == 0)
            {
                btnX_Click(sender, e);
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            string formClass = ((TabControl)sender).SelectedTab.Tag.ToString();
            GenerateForm(formClass, sender);
        }

        public void GenerateForm(string form, object sender)
        {
            try
            {
                //反射生成窗体
                Form fm = (Form)Assembly.GetExecutingAssembly().CreateInstance(form);
                //设置窗体没有边框，加入到选项卡中
                fm.FormBorderStyle = FormBorderStyle.None;
                fm.TopLevel = false;
                fm.Parent = ((TabControl)sender).SelectedTab;
                fm.ControlBox = false;
                fm.Dock = DockStyle.Fill;
                fm.Show();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string formClass = "MaterialManager.MaterialInfo";
            GenerateForm(formClass, tabWindows);
        }
    }
}
