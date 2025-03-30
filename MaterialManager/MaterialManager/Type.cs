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
    public partial class Type : Form
    {
        public Type()
        {
            InitializeComponent();
            BindList();
            DataGridBind();
        }

        /// <summary>
        /// 初始化下拉框
        /// </summary>
        public void BindList()
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
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }


        /// <summary>
        /// 绑定datagridview
        /// </summary>
        public void DataGridBind()
        {
            try
            {
                string sql = "select * from materialtype where 1=1 ";
                string supplier = comboBoxSup.SelectedValue.ToString();//材料类型
                if (supplier != "-1")
                {
                    sql += "and supplierid='" + supplier + "' ";
                }
                string name = textName.Text.Trim();//材料名称
                if (name != "")
                {
                    sql += "and name like '%" + name + "%' ";
                }
                sql += "order by id desc";
                DataTable dt = DbHelperMySQL.Query(sql).Tables[0];
                dataGridViewType.DataSource = dt;
                dataGridViewType.AutoGenerateColumns = false;
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
            MaterialType frm = new MaterialType();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                BindList();
                DataGridBind();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int count = this.dataGridViewType.SelectedRows.Count;
            if (count == 0)
            {
                MessageBox.Show("请先选择一行数据！");
                return;
            }
            foreach (DataGridViewRow row in dataGridViewType.SelectedRows)
            {
                if (String.IsNullOrEmpty(row.Cells[0].Value.ToString()))
                {
                    MessageBox.Show("无效的选择行！");
                }
                else
                {
                    string selectid = row.Cells[0].Value.ToString();//获取当前选中行的id
                    MaterialType frm = new MaterialType(selectid);
                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                    {
                        BindList();
                        DataGridBind();
                    }
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int count = this.dataGridViewType.SelectedRows.Count;
            if (count == 0)
            {
                MessageBox.Show("请先选择一行数据！");
                return;
            }
            foreach (DataGridViewRow row in dataGridViewType.SelectedRows)
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
                        string sqlDel = "delete from materialtype where id='" + selectid + "'";
                        int del = DbHelperMySQL.ExecuteSql(sqlDel);
                        if (del > 0)
                        {
                            MessageBox.Show("删除成功！");
                            BindList();
                            DataGridBind();
                        }
                        else
                        {
                            MessageBox.Show("删除失败！");
                            BindList();
                            DataGridBind();
                        }
                    }
                    else
                    {
                        BindList();
                        DataGridBind();
                    }
                }
            }
        }
    }
}
