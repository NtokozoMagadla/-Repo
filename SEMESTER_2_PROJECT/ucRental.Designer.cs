namespace SEMESTER_2_PROJECT
{
    partial class ucRental
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
            this.dtaEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtaStartdate = new System.Windows.Forms.DateTimePicker();
            this.dgvRental = new System.Windows.Forms.DataGridView();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtRentalID = new System.Windows.Forms.TextBox();
            this.cmbTenantID = new System.Windows.Forms.ComboBox();
            this.cmbPropertyTenantID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRental)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtaEndDate);
            this.groupBox1.Controls.Add(this.dtaStartdate);
            this.groupBox1.Controls.Add(this.dgvRental);
            this.groupBox1.Controls.Add(this.btnDisplay);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtRentalID);
            this.groupBox1.Controls.Add(this.cmbTenantID);
            this.groupBox1.Controls.Add(this.cmbPropertyTenantID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(873, 505);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rental";
            // 
            // dtaEndDate
            // 
            this.dtaEndDate.Location = new System.Drawing.Point(197, 176);
            this.dtaEndDate.Name = "dtaEndDate";
            this.dtaEndDate.Size = new System.Drawing.Size(268, 26);
            this.dtaEndDate.TabIndex = 31;
            // 
            // dtaStartdate
            // 
            this.dtaStartdate.Location = new System.Drawing.Point(197, 138);
            this.dtaStartdate.Name = "dtaStartdate";
            this.dtaStartdate.Size = new System.Drawing.Size(268, 26);
            this.dtaStartdate.TabIndex = 30;
            // 
            // dgvRental
            // 
            this.dgvRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRental.Location = new System.Drawing.Point(6, 270);
            this.dgvRental.Name = "dgvRental";
            this.dgvRental.Size = new System.Drawing.Size(857, 240);
            this.dgvRental.TabIndex = 29;
            this.dgvRental.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRental_CellContentClick);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(429, 223);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(97, 32);
            this.btnDisplay.TabIndex = 27;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(288, 223);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 32);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(143, 223);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 32);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtRentalID
            // 
            this.txtRentalID.Enabled = false;
            this.txtRentalID.Location = new System.Drawing.Point(197, 33);
            this.txtRentalID.Name = "txtRentalID";
            this.txtRentalID.Size = new System.Drawing.Size(161, 26);
            this.txtRentalID.TabIndex = 22;
            // 
            // cmbTenantID
            // 
            this.cmbTenantID.FormattingEnabled = true;
            this.cmbTenantID.Location = new System.Drawing.Point(197, 99);
            this.cmbTenantID.Name = "cmbTenantID";
            this.cmbTenantID.Size = new System.Drawing.Size(176, 28);
            this.cmbTenantID.TabIndex = 21;
            // 
            // cmbPropertyTenantID
            // 
            this.cmbPropertyTenantID.FormattingEnabled = true;
            this.cmbPropertyTenantID.Location = new System.Drawing.Point(197, 62);
            this.cmbPropertyTenantID.Name = "cmbPropertyTenantID";
            this.cmbPropertyTenantID.Size = new System.Drawing.Size(176, 28);
            this.cmbPropertyTenantID.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "EndDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "StartDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "TenantID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "PropertyTenantID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "RentalID";
            // 
            // ucRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ucRental";
            this.Size = new System.Drawing.Size(879, 532);
            this.Load += new System.EventHandler(this.ucRental_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRental)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRental;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtRentalID;
        private System.Windows.Forms.ComboBox cmbTenantID;
        private System.Windows.Forms.ComboBox cmbPropertyTenantID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtaEndDate;
        private System.Windows.Forms.DateTimePicker dtaStartdate;
    }
}
