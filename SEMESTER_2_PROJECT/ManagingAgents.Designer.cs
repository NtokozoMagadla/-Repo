namespace SEMESTER_2_PROJECT
{
    partial class ManagingAgents
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
            this.btnProperty = new System.Windows.Forms.Button();
            this.btnRentals = new System.Windows.Forms.Button();
            this.btnPropertyType = new System.Windows.Forms.Button();
            this.btnPropertyAgent = new System.Windows.Forms.Button();
            this.ucProperty1 = new SEMESTER_2_PROJECT.ucProperty();
            this.ucRental1 = new SEMESTER_2_PROJECT.ucRental();
            this.ucPropertyType1 = new SEMESTER_2_PROJECT.ucPropertyType();
            this.ucPropertyAgent1 = new SEMESTER_2_PROJECT.ucPropertyAgent();
            this.SuspendLayout();
            // 
            // btnProperty
            // 
            this.btnProperty.Location = new System.Drawing.Point(12, 27);
            this.btnProperty.Name = "btnProperty";
            this.btnProperty.Size = new System.Drawing.Size(116, 55);
            this.btnProperty.TabIndex = 0;
            this.btnProperty.Text = "Property";
            this.btnProperty.UseVisualStyleBackColor = true;
            this.btnProperty.Click += new System.EventHandler(this.btnProperties_Click);
            // 
            // btnRentals
            // 
            this.btnRentals.Location = new System.Drawing.Point(13, 88);
            this.btnRentals.Name = "btnRentals";
            this.btnRentals.Size = new System.Drawing.Size(116, 54);
            this.btnRentals.TabIndex = 1;
            this.btnRentals.Text = "Rentals";
            this.btnRentals.UseVisualStyleBackColor = true;
            this.btnRentals.Click += new System.EventHandler(this.btnRentals_Click);
            // 
            // btnPropertyType
            // 
            this.btnPropertyType.Location = new System.Drawing.Point(12, 148);
            this.btnPropertyType.Name = "btnPropertyType";
            this.btnPropertyType.Size = new System.Drawing.Size(116, 55);
            this.btnPropertyType.TabIndex = 6;
            this.btnPropertyType.Text = "PropertyType";
            this.btnPropertyType.UseVisualStyleBackColor = true;
            this.btnPropertyType.Click += new System.EventHandler(this.btnPropertyType_Click);
            // 
            // btnPropertyAgent
            // 
            this.btnPropertyAgent.Location = new System.Drawing.Point(13, 209);
            this.btnPropertyAgent.Name = "btnPropertyAgent";
            this.btnPropertyAgent.Size = new System.Drawing.Size(116, 55);
            this.btnPropertyAgent.TabIndex = 7;
            this.btnPropertyAgent.Text = "PropertyAgent";
            this.btnPropertyAgent.UseVisualStyleBackColor = true;
            this.btnPropertyAgent.Click += new System.EventHandler(this.btnPropertyAgent_Click);
            // 
            // ucProperty1
            // 
            this.ucProperty1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucProperty1.Location = new System.Drawing.Point(135, 3);
            this.ucProperty1.Margin = new System.Windows.Forms.Padding(4);
            this.ucProperty1.Name = "ucProperty1";
            this.ucProperty1.Size = new System.Drawing.Size(879, 532);
            this.ucProperty1.TabIndex = 11;
            // 
            // ucRental1
            // 
            this.ucRental1.Location = new System.Drawing.Point(134, 3);
            this.ucRental1.Name = "ucRental1";
            this.ucRental1.Size = new System.Drawing.Size(879, 532);
            this.ucRental1.TabIndex = 10;
            // 
            // ucPropertyType1
            // 
            this.ucPropertyType1.Location = new System.Drawing.Point(134, 3);
            this.ucPropertyType1.Name = "ucPropertyType1";
            this.ucPropertyType1.Size = new System.Drawing.Size(879, 532);
            this.ucPropertyType1.TabIndex = 9;
            // 
            // ucPropertyAgent1
            // 
            this.ucPropertyAgent1.Location = new System.Drawing.Point(134, 3);
            this.ucPropertyAgent1.Name = "ucPropertyAgent1";
            this.ucPropertyAgent1.Size = new System.Drawing.Size(879, 532);
            this.ucPropertyAgent1.TabIndex = 8;
            // 
            // ManagingAgents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1024, 559);
            this.Controls.Add(this.ucProperty1);
            this.Controls.Add(this.ucRental1);
            this.Controls.Add(this.ucPropertyType1);
            this.Controls.Add(this.ucPropertyAgent1);
            this.Controls.Add(this.btnPropertyAgent);
            this.Controls.Add(this.btnPropertyType);
            this.Controls.Add(this.btnRentals);
            this.Controls.Add(this.btnProperty);
            this.Name = "ManagingAgents";
            this.Text = "ManagingAgents";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProperty;
        private System.Windows.Forms.Button btnRentals;
        private System.Windows.Forms.Button btnPropertyType;
        private System.Windows.Forms.Button btnPropertyAgent;
        private ucPropertyAgent ucPropertyAgent1;
        private ucPropertyType ucPropertyType1;
        private ucRental ucRental1;
        private ucProperty ucProperty1;
    }
}