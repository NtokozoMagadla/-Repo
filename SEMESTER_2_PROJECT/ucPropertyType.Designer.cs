namespace SEMESTER_2_PROJECT
{
    partial class ucPropertyType
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
            this.dgvPropertyType = new System.Windows.Forms.DataGridView();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPropertyTypeDesc = new System.Windows.Forms.TextBox();
            this.txtPropertyTypeID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropertyType)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPropertyType);
            this.groupBox1.Controls.Add(this.btnDisplay);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtPropertyTypeDesc);
            this.groupBox1.Controls.Add(this.txtPropertyTypeID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(873, 526);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PropertyType";
            // 
            // dgvPropertyType
            // 
            this.dgvPropertyType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPropertyType.Location = new System.Drawing.Point(6, 193);
            this.dgvPropertyType.Name = "dgvPropertyType";
            this.dgvPropertyType.Size = new System.Drawing.Size(861, 298);
            this.dgvPropertyType.TabIndex = 14;
            this.dgvPropertyType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPropertyType_CellContentClick);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(338, 129);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(148, 41);
            this.btnDisplay.TabIndex = 13;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(115, 129);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 41);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPropertyTypeDesc
            // 
            this.txtPropertyTypeDesc.Location = new System.Drawing.Point(225, 80);
            this.txtPropertyTypeDesc.Name = "txtPropertyTypeDesc";
            this.txtPropertyTypeDesc.Size = new System.Drawing.Size(152, 26);
            this.txtPropertyTypeDesc.TabIndex = 11;
            // 
            // txtPropertyTypeID
            // 
            this.txtPropertyTypeID.Enabled = false;
            this.txtPropertyTypeID.Location = new System.Drawing.Point(225, 36);
            this.txtPropertyTypeID.Name = "txtPropertyTypeID";
            this.txtPropertyTypeID.Size = new System.Drawing.Size(152, 26);
            this.txtPropertyTypeID.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "PropertyTypeDescription";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "PropertyTypeID";
            // 
            // ucPropertyType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ucPropertyType";
            this.Size = new System.Drawing.Size(879, 532);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropertyType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPropertyType;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPropertyTypeDesc;
        private System.Windows.Forms.TextBox txtPropertyTypeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
