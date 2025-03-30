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
    public partial class Purchase : Form
    {
        public Purchase()
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
                string sql = "select * from purchase where 1=1 ";
                string materialtype = comboBoxType.SelectedValue.ToString();//材料类型
                if (materialtype != "-1")
                {
                    sql += "and materialtypeid='" + materialtype + "' ";
                }
                string materialname = textName.Text.Trim();//材料名称
                if (materialname != "")
                {
                    sql += "and materialname like '%" + materialname + "%' ";
                }
                sql += "order by id desc";
                DataTable dt = DbHelperMySQL.Query(sql).Tables[0];
                dataGridPurchase.DataSource = dt;
                dataGridPurchase.AutoGenerateColumns = false;
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
            AddPurchase frm = new AddPurchase();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                BindList();
                DataGridBind();
            }
        }
    }
}
