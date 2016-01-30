namespace Pharmachy
{
    partial class FrmUnitConversion
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
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.cboUnitType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.colUnitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRelativeFactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBaseUOM = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.button1);
            this.pnlAdd.Controls.Add(this.btnSave);
            this.pnlAdd.Controls.Add(this.cboUnitType);
            this.pnlAdd.Controls.Add(this.label5);
            this.pnlAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdd.Location = new System.Drawing.Point(0, 0);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(591, 52);
            this.pnlAdd.TabIndex = 13;
            // 
            // cboUnitType
            // 
            this.cboUnitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnitType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnitType.FormattingEnabled = true;
            this.cboUnitType.Items.AddRange(new object[] {
            "Taxable",
            "Multi-Tax",
            "Tax Paid",
            "Tax Free",
            "Exempt",
            "Against ST Form"});
            this.cboUnitType.Location = new System.Drawing.Point(120, 7);
            this.cboUnitType.Name = "cboUnitType";
            this.cboUnitType.Size = new System.Drawing.Size(232, 22);
            this.cboUnitType.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(10, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Unit Group";
            // 
            // dgvInfo
            // 
            this.dgvInfo.BackgroundColor = System.Drawing.Color.White;
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUnitId,
            this.colUnitName,
            this.colRelativeFactor,
            this.colBaseUOM,
            this.colRemove});
            this.dgvInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInfo.Location = new System.Drawing.Point(0, 52);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfo.Size = new System.Drawing.Size(591, 326);
            this.dgvInfo.TabIndex = 14;
            // 
            // colUnitId
            // 
            this.colUnitId.HeaderText = "UnitId";
            this.colUnitId.Name = "colUnitId";
            // 
            // colUnitName
            // 
            this.colUnitName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUnitName.HeaderText = "Unit Name";
            this.colUnitName.Name = "colUnitName";
            // 
            // colRelativeFactor
            // 
            this.colRelativeFactor.HeaderText = "RelativeFactor";
            this.colRelativeFactor.Name = "colRelativeFactor";
            // 
            // colBaseUOM
            // 
            this.colBaseUOM.HeaderText = "Base ?";
            this.colBaseUOM.Name = "colBaseUOM";
            // 
            // colRemove
            // 
            this.colRemove.HeaderText = "";
            this.colRemove.Name = "colRemove";
            this.colRemove.Width = 70;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(414, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmUnitConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 378);
            this.Controls.Add(this.dgvInfo);
            this.Controls.Add(this.pnlAdd);
            this.Name = "FrmUnitConversion";
            this.Text = "FrmUnitConversion";
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboUnitType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRelativeFactor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colBaseUOM;
        private System.Windows.Forms.DataGridViewButtonColumn colRemove;
    }
}