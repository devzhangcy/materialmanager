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
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
            DataGridBind();
        }

        /// <summary>
        /// 绑定datagridview
        /// </summary>
        public void DataGridBind()
        {
            try
            {
                string sql = "select * from supplier where 1=1 ";
                string materialname = textName.Text.Trim();//材料名称
                if (materialname != "")
                {
                    sql += "and name like '%" + materialname + "%' ";
                }
                sql += "order by id desc";
                DataTable dt = DbHelperMySQL.Query(sql).Tables[0];
                dataGridSupplier.DataSource = dt;
                dataGridSupplier.AutoGenerateColumns = false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DataGridBind();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSupplier frm = new AddSupplier();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                DataGridBind();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int count = this.dataGridSupplier.SelectedRows.Count;
            if (count == 0)
            {
                MessageBox.Show("请先选择一行数据！");
                return;
            }
            foreach (DataGridViewRow row in dataGridSupplier.SelectedRows)
            {
                if (String.IsNullOrEmpty(row.Cells[0].Value.ToString()))
                {
                    MessageBox.Show("无效的选择行！");
                }
                else
                {
                    string selectid = row.Cells[0].Value.ToString();//获取当前选中行的id
                    AddSupplier frm = new AddSupplier(selectid);
                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                    {
                        DataGridBind();
                    }
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int count = this.dataGridSupplier.SelectedRows.Count;
            if (count == 0)
            {
                MessageBox.Show("请先选择一行数据！");
                return;
            }
            foreach (DataGridViewRow row in dataGridSupplier.SelectedRows)
            {
                if (String.IsNullOrEmpty(row.Cells[0].Value.ToString()))
                {
                    MessageBox.Show("无效的选择行！");
                }
                else
                {
                    string selectid = row.Cells[0].Value.ToString();//获取当前选中行的id
                    if (MessageBox.Show("你确定要删除此条记录吗？", "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        string sqlDel = "delete from supplier where id='" + selectid + "'";
                        int del = DbHelperMySQL.ExecuteSql(sqlDel);
                        if (del > 0)
                        {
                            MessageBox.Show("删除成功！");
                            DataGridBind();
                        }
                        else
                        {
                            MessageBox.Show("删除失败！");
                            DataGridBind();
                        }
                    }
                    else
                    {
                        DataGridBind();
                    }
                }
            }
        }
    }
}
