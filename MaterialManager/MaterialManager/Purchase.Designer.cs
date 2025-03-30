namespace MaterialManager
{
    partial class Purchase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.textName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.lblFactory = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dataGridPurchase = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialtypeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialtypename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.textName);
            this.panelTop.Controls.Add(this.btnAdd);
            this.panelTop.Controls.Add(this.comboBoxType);
            this.panelTop.Controls.Add(this.lblFactory);
            this.panelTop.Controls.Add(this.lbltype);
            this.panelTop.Controls.Add(this.btnQuery);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1261, 64);
            this.panelTop.TabIndex = 0;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(106, 18);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(163, 28);
            this.textName.TabIndex = 22;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1136, 15);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 34);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "新增采购";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(371, 19);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(163, 26);
            this.comboBoxType.TabIndex = 18;
            // 
            // lblFactory
            // 
            this.lblFactory.AutoSize = true;
            this.lblFactory.Location = new System.Drawing.Point(279, 21);
            this.lblFactory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFactory.Name = "lblFactory";
            this.lblFactory.Size = new System.Drawing.Size(98, 18);
            this.lblFactory.TabIndex = 17;
            this.lblFactory.Text = "材料类型：";
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Location = new System.Drawing.Point(12, 23);
            this.lbltype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(98, 18);
            this.lbltype.TabIndex = 16;
            this.lbltype.Text = "材料名称：";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(1015, 15);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(112, 34);
            this.btnQuery.TabIndex = 15;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dataGridPurchase
            // 
            this.dataGridPurchase.AllowUserToAddRows = false;
            this.dataGridPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.materialid,
            this.materialname,
            this.supplierid,
            this.suppliername,
            this.materialtypeid,
            this.materialtypename,
            this.num,
            this.pay,
            this.unit,
            this.description,
            this.createtime});
            this.dataGridPurchase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridPurchase.Location = new System.Drawing.Point(0, 64);
            this.dataGridPurchase.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridPurchase.Name = "dataGridPurchase";
            this.dataGridPurchase.RowHeadersWidth = 62;
            this.dataGridPurchase.RowTemplate.Height = 30;
            this.dataGridPurchase.Size = new System.Drawing.Size(1261, 855);
            this.dataGridPurchase.TabIndex = 1;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 150;
            // 
            // materialid
            // 
            this.materialid.DataPropertyName = "materialid";
            this.materialid.HeaderText = "材料id";
            this.materialid.MinimumWidth = 8;
            this.materialid.Name = "materialid";
            this.materialid.Visible = false;
            this.materialid.Width = 80;
            // 
            // materialname
            // 
            this.materialname.DataPropertyName = "materialname";
            this.materialname.HeaderText = "材料名称";
            this.materialname.MinimumWidth = 8;
            this.materialname.Name = "materialname";
            this.materialname.Width = 160;
            // 
            // supplierid
            // 
            this.supplierid.DataPropertyName = "supplierid";
            this.supplierid.HeaderText = "supplierid";
            this.supplierid.Name = "supplierid";
            this.supplierid.ReadOnly = true;
            this.supplierid.Visible = false;
            // 
            // suppliername
            // 
            this.suppliername.DataPropertyName = "suppliername";
            this.suppliername.HeaderText = "供应商";
            this.suppliername.Name = "suppliername";
            this.suppliername.Width = 200;
            // 
            // materialtypeid
            // 
            this.materialtypeid.DataPropertyName = "materialtypeid";
            this.materialtypeid.HeaderText = "材料类型id";
            this.materialtypeid.MinimumWidth = 8;
            this.materialtypeid.Name = "materialtypeid";
            this.materialtypeid.ReadOnly = true;
            this.materialtypeid.Visible = false;
            this.materialtypeid.Width = 80;
            // 
            // materialtypename
            // 
            this.materialtypename.DataPropertyName = "materialtypename";
            this.materialtypename.HeaderText = "材料类型";
            this.materialtypename.MinimumWidth = 8;
            this.materialtypename.Name = "materialtypename";
            this.materialtypename.Width = 160;
            // 
            // num
            // 
            this.num.DataPropertyName = "num";
            this.num.HeaderText = "数量";
            this.num.MinimumWidth = 8;
            this.num.Name = "num";
            this.num.Width = 120;
            // 
            // pay
            // 
            this.pay.DataPropertyName = "pay";
            this.pay.HeaderText = "金额";
            this.pay.MinimumWidth = 8;
            this.pay.Name = "pay";
            this.pay.Width = 120;
            // 
            // unit
            // 
            this.unit.DataPropertyName = "unit";
            this.unit.HeaderText = "规格单位";
            this.unit.MinimumWidth = 8;
            this.unit.Name = "unit";
            this.unit.Width = 150;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "备注信息";
            this.description.MinimumWidth = 8;
            this.description.Name = "description";
            this.description.Width = 520;
            // 
            // createtime
            // 
            this.createtime.DataPropertyName = "createtime";
            this.createtime.HeaderText = "创建时间";
            this.createtime.MinimumWidth = 8;
            this.createtime.Name = "createtime";
            this.createtime.ReadOnly = true;
            this.createtime.Visible = false;
            this.createtime.Width = 80;
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 919);
            this.Controls.Add(this.dataGridPurchase);
            this.Controls.Add(this.panelTop);
            this.Name = "Purchase";
            this.Text = "采购管理";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPurchase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label lblFactory;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridView dataGridPurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialid;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialname;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierid;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliername;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialtypeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialtypename;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn pay;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn createtime;
    }
}