namespace SEMESTER_2_PROJECT
{
    partial class ucSurbub
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCityID = new System.Windows.Forms.ComboBox();
            this.dgvSurbub = new System.Windows.Forms.DataGridView();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtSurbubDesc = new System.Windows.Forms.TextBox();
            this.txtSurbubID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSurbub)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCityID);
            this.groupBox1.Controls.Add(this.dgvSurbub);
            this.groupBox1.Controls.Add(this.btnDisplay);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtPostalCode);
            this.groupBox1.Controls.Add(this.txtSurbubDesc);
            this.groupBox1.Controls.Add(this.txtSurbubID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(873, 515);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Surbub";
            // 
            // cmbCityID
            // 
            this.cmbCityID.FormattingEnabled = true;
            this.cmbCityID.Location = new System.Drawing.Point(170, 136);
            this.cmbCityID.Name = "cmbCityID";
            this.cmbCityID.Size = new System.Drawing.Size(192, 28);
            this.cmbCityID.TabIndex = 24;
            // 
            // dgvSurbub
            // 
            this.dgvSurbub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSurbub.Location = new System.Drawing.Point(6, 253);
            this.dgvSurbub.Name = "dgvSurbub";
            this.dgvSurbub.Size = new System.Drawing.Size(861, 267);
            this.dgvSurbub.TabIndex = 23;
            this.dgvSurbub.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSurbub_CellContentClick);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(331, 184);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 36);
            this.btnDisplay.TabIndex = 21;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(138, 184);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 36);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(170, 104);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(152, 26);
            this.txtPostalCode.TabIndex = 19;
            // 
            // txtSurbubDesc
            // 
            this.txtSurbubDesc.Location = new System.Drawing.Point(170, 72);
            this.txtSurbubDesc.Name = "txtSurbubDesc";
            this.txtSurbubDesc.Size = new System.Drawing.Size(152, 26);
            this.txtSurbubDesc.TabIndex = 18;
            // 
            // txtSurbubID
            // 
            this.txtSurbubID.Enabled = false;
            this.txtSurbubID.Location = new System.Drawing.Point(170, 40);
            this.txtSurbubID.Name = "txtSurbubID";
            this.txtSurbubID.Size = new System.Drawing.Size(152, 26);
            this.txtSurbubID.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "CityID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Postal Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "SurbubDescription";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "SurbubID";
            // 
            // ucSurbub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ucSurbub";
            this.Size = new System.Drawing.Size(879, 532);
            this.Load += new System.EventHandler(this.ucSurbub_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSurbub)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCityID;
        private System.Windows.Forms.DataGridView dgvSurbub;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtSurbubDesc;
        private System.Windows.Forms.TextBox txtSurbubID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
