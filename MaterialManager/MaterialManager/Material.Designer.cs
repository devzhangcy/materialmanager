namespace MaterialManager
{
    partial class Material
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
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.lblFactory = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.dataGridMaterial = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.类型id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTop.Controls.Add(this.textName);
            this.panelTop.Controls.Add(this.btnDel);
            this.panelTop.Controls.Add(this.btnEdit);
            this.panelTop.Controls.Add(this.btnAdd);
            this.panelTop.Controls.Add(this.comboBoxType);
            this.panelTop.Controls.Add(this.lblFactory);
            this.panelTop.Controls.Add(this.lbltype);
            this.panelTop.Controls.Add(this.btnQuery);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1261, 68);
            this.panelTop.TabIndex = 1;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(97, 19);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(163, 28);
            this.textName.TabIndex = 14;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(1128, 16);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(112, 34);
            this.btnDel.TabIndex = 13;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1006, 16);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 34);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(884, 16);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 34);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(362, 20);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(163, 26);
            this.comboBoxType.TabIndex = 5;
            // 
            // lblFactory
            // 
            this.lblFactory.AutoSize = true;
            this.lblFactory.Location = new System.Drawing.Point(270, 22);
            this.lblFactory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFactory.Name = "lblFactory";
            this.lblFactory.Size = new System.Drawing.Size(98, 18);
            this.lblFactory.TabIndex = 4;
            this.lblFactory.Text = "材料类型：";
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Location = new System.Drawing.Point(3, 24);
            this.lbltype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(98, 18);
            this.lbltype.TabIndex = 1;
            this.lbltype.Text = "材料名称：";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(763, 16);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(112, 34);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.dataGridMaterial);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 68);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1261, 851);
            this.panelContent.TabIndex = 2;
            // 
            // dataGridMaterial
            // 
            this.dataGridMaterial.AllowUserToAddRows = false;
            this.dataGridMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.类型id,
            this.typename,
            this.supplierid,
            this.suppliername,
            this.num,
            this.price,
            this.unit,
            this.description});
            this.dataGridMaterial.Location = new System.Drawing.Point(0, 0);
            this.dataGridMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridMaterial.Name = "dataGridMaterial";
            this.dataGridMaterial.RowHeadersWidth = 62;
            this.dataGridMaterial.RowTemplate.Height = 30;
            this.dataGridMaterial.Size = new System.Drawing.Size(1261, 851);
            this.dataGridMaterial.TabIndex = 0;
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
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "材料名称";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.Width = 140;
            // 
            // 类型id
            // 
            this.类型id.DataPropertyName = "typeid";
            this.类型id.HeaderText = "typeid";
            this.类型id.MinimumWidth = 8;
            this.类型id.Name = "类型id";
            this.类型id.ReadOnly = true;
            this.类型id.Visible = false;
            this.类型id.Width = 150;
            // 
            // typename
            // 
            this.typename.DataPropertyName = "typename";
            this.typename.HeaderText = "种类名称";
            this.typename.MinimumWidth = 8;
            this.typename.Name = "typename";
            this.typename.Width = 140;
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
            // num
            // 
            this.num.DataPropertyName = "num";
            this.num.HeaderText = "数量";
            this.num.MinimumWidth = 8;
            this.num.Name = "num";
            this.num.Width = 120;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "材料价格";
            this.price.MinimumWidth = 8;
            this.price.Name = "price";
            this.price.Width = 120;
            // 
            // unit
            // 
            this.unit.DataPropertyName = "unit";
            this.unit.HeaderText = "规格单位";
            this.unit.MinimumWidth = 8;
            this.unit.Name = "unit";
            this.unit.Width = 120;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "备注信息";
            this.description.MinimumWidth = 8;
            this.description.Name = "description";
            this.description.Width = 230;
            // 
            // Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 919);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTop);
            this.Name = "Material";
            this.Text = "库存管理";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMaterial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblFactory;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.DataGridView dataGridMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn 类型id;
        private System.Windows.Forms.DataGridViewTextBoxColumn typename;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierid;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliername;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
    }
}