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
    public partial class Material : Form
    {
        public Material()
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
                string sqlType = "select * from materialtype order by id asc";
                DataTable dtType = DbHelperMySQL.Query(sqlType).Tables[0];
                DataRow drType = dtType.NewRow();
                drType["id"] = "-1";
                drType["name"] = "-请选择-";
                dtType.Rows.InsertAt(drType, 0);
                comboBoxType.DataSource = dtType;
                comboBoxType.DisplayMember = "name";
                comboBoxType.ValueMember = "id";
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
                string sql = "select id,name,typeid,typename,supplierid,suppliername,num,price,unit,description from material where 1=1 ";
                string materialtype = comboBoxType.SelectedValue.ToString();//材料类型
                if (materialtype != "-1")
                {
                    sql += "and typeid='" + materialtype + "' ";
                }
                string materialname = textName.Text.Trim();//材料名称
                if (materialname != "")
                {
                    sql += "and name like '%" + materialname + "%' ";
                }
                sql += "order by id desc";
                DataTable dt = DbHelperMySQL.Query(sql).Tables[0];
                dataGridMaterial.DataSource = dt;
                dataGridMaterial.AutoGenerateColumns = false;
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
            AddMaterial frm = new AddMaterial();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                BindList();
                DataGridBind();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int count = this.dataGridMaterial.SelectedRows.Count;
            if (count == 0)
            {
                MessageBox.Show("请先选择一行数据！");
                return;
            }
            foreach (DataGridViewRow row in dataGridMaterial.SelectedRows)
            {
                if (String.IsNullOrEmpty(row.Cells[0].Value.ToString()))
                {
                    MessageBox.Show("无效的选择行！");
                }
                else
                {
                    string selectid = row.Cells[0].Value.ToString();//获取当前选中行的id
                    AddMaterial frm = new AddMaterial(selectid);
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
            int count = this.dataGridMaterial.SelectedRows.Count;
            if (count == 0)
            {
                MessageBox.Show("请先选择一行数据！");
                return;
            }
            foreach (DataGridViewRow row in dataGridMaterial.SelectedRows)
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
                        string sqlDel = "delete from material where id='" + selectid + "'";
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
