namespace SEMESTER_2_PROJECT
{
    partial class ManagingTenant
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
            this.btnTenant = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ucTenant1 = new SEMESTER_2_PROJECT.ucTenant();
            this.ucProperty1 = new SEMESTER_2_PROJECT.ucProperty();
            this.SuspendLayout();
            // 
            // btnTenant
            // 
            this.btnTenant.Location = new System.Drawing.Point(12, 86);
            this.btnTenant.Name = "btnTenant";
            this.btnTenant.Size = new System.Drawing.Size(113, 47);
            this.btnTenant.TabIndex = 1;
            this.btnTenant.Text = "Tenant";
            this.btnTenant.UseVisualStyleBackColor = true;
            this.btnTenant.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Property";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ucTenant1
            // 
            this.ucTenant1.Location = new System.Drawing.Point(147, 3);
            this.ucTenant1.Name = "ucTenant1";
            this.ucTenant1.Size = new System.Drawing.Size(879, 532);
            this.ucTenant1.TabIndex = 3;
            // 
            // ucProperty1
            // 
            this.ucProperty1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucProperty1.Location = new System.Drawing.Point(147, 3);
            this.ucProperty1.Margin = new System.Windows.Forms.Padding(4);
            this.ucProperty1.Name = "ucProperty1";
            this.ucProperty1.Size = new System.Drawing.Size(879, 532);
            this.ucProperty1.TabIndex = 4;
            // 
            // ManagingTenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1029, 538);
            this.Controls.Add(this.ucProperty1);
            this.Controls.Add(this.ucTenant1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTenant);
            this.Name = "ManagingTenant";
            this.Text = "ManagingTenant";
            this.Load += new System.EventHandler(this.ManagingTenant_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTenant;
        private System.Windows.Forms.Button button2;
        private ucTenant ucTenant1;
        private ucProperty ucProperty1;
    }
}