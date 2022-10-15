namespace SEMESTER_2_PROJECT
{
    partial class ucPropertyAgent
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
            this.dtaPropertyAgent = new System.Windows.Forms.DateTimePicker();
            this.dgvPropertyAgent = new System.Windows.Forms.DataGridView();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPropertyAgentID = new System.Windows.Forms.TextBox();
            this.cmbAgentID = new System.Windows.Forms.ComboBox();
            this.cmbPropertyID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropertyAgent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtaPropertyAgent);
            this.groupBox1.Controls.Add(this.dgvPropertyAgent);
            this.groupBox1.Controls.Add(this.btnDisplay);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtPropertyAgentID);
            this.groupBox1.Controls.Add(this.cmbAgentID);
            this.groupBox1.Controls.Add(this.cmbPropertyID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(873, 509);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PropertyAgent";
            // 
            // dtaPropertyAgent
            // 
            this.dtaPropertyAgent.Location = new System.Drawing.Point(203, 180);
            this.dtaPropertyAgent.Name = "dtaPropertyAgent";
            this.dtaPropertyAgent.Size = new System.Drawing.Size(261, 26);
            this.dtaPropertyAgent.TabIndex = 26;
            // 
            // dgvPropertyAgent
            // 
            this.dgvPropertyAgent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPropertyAgent.Location = new System.Drawing.Point(6, 277);
            this.dgvPropertyAgent.Name = "dgvPropertyAgent";
            this.dgvPropertyAgent.Size = new System.Drawing.Size(861, 243);
            this.dgvPropertyAgent.TabIndex = 25;
            this.dgvPropertyAgent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPropertyAgent_CellContentClick);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(370, 228);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(94, 43);
            this.btnDisplay.TabIndex = 23;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(230, 228);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 43);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(97, 228);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 43);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPropertyAgentID
            // 
            this.txtPropertyAgentID.Enabled = false;
            this.txtPropertyAgentID.Location = new System.Drawing.Point(203, 36);
            this.txtPropertyAgentID.Name = "txtPropertyAgentID";
            this.txtPropertyAgentID.Size = new System.Drawing.Size(143, 26);
            this.txtPropertyAgentID.TabIndex = 19;
            // 
            // cmbAgentID
            // 
            this.cmbAgentID.FormattingEnabled = true;
            this.cmbAgentID.Location = new System.Drawing.Point(203, 128);
            this.cmbAgentID.Name = "cmbAgentID";
            this.cmbAgentID.Size = new System.Drawing.Size(170, 28);
            this.cmbAgentID.TabIndex = 18;
            // 
            // cmbPropertyID
            // 
            this.cmbPropertyID.FormattingEnabled = true;
            this.cmbPropertyID.Location = new System.Drawing.Point(203, 80);
            this.cmbPropertyID.Name = "cmbPropertyID";
            this.cmbPropertyID.Size = new System.Drawing.Size(170, 28);
            this.cmbPropertyID.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "AgentID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "PropertyID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "PropertyAgentID";
            // 
            // ucPropertyAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ucPropertyAgent";
            this.Size = new System.Drawing.Size(879, 532);
            this.Load += new System.EventHandler(this.ucPropertyAgent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropertyAgent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPropertyAgent;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPropertyAgentID;
        private System.Windows.Forms.ComboBox cmbAgentID;
        private System.Windows.Forms.ComboBox cmbPropertyID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtaPropertyAgent;
    }
}
