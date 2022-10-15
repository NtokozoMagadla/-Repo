namespace SEMESTER_2_PROJECT
{
    partial class Form1
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
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ucAgent1 = new SEMESTER_2_PROJECT.ucAgent();
            this.ucCity1 = new SEMESTER_2_PROJECT.ucCity();
            this.SuspendLayout();
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(23, 432);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(117, 36);
            this.button11.TabIndex = 21;
            this.button11.Text = "PropertyAgent";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(23, 390);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(117, 36);
            this.button10.TabIndex = 20;
            this.button10.Text = "Surbub";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(23, 348);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(117, 36);
            this.button9.TabIndex = 19;
            this.button9.Text = "Rental";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(23, 306);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(117, 36);
            this.button8.TabIndex = 18;
            this.button8.Text = "PropertyType";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(23, 264);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(117, 36);
            this.button7.TabIndex = 17;
            this.button7.Text = "Property";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(23, 222);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(117, 36);
            this.button6.TabIndex = 16;
            this.button6.Text = "Tenants";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(23, 180);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 36);
            this.button5.TabIndex = 15;
            this.button5.Text = "City";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(23, 138);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 36);
            this.button4.TabIndex = 14;
            this.button4.Text = "Agencies";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 36);
            this.button3.TabIndex = 13;
            this.button3.Text = "Agency";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 36);
            this.button2.TabIndex = 12;
            this.button2.Text = "Province";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ucAgent1
            // 
            this.ucAgent1.Location = new System.Drawing.Point(167, 5);
            this.ucAgent1.Name = "ucAgent1";
            this.ucAgent1.Size = new System.Drawing.Size(743, 508);
            this.ucAgent1.TabIndex = 22;
            // 
            // ucCity1
            // 
            this.ucCity1.Location = new System.Drawing.Point(167, 12);
            this.ucCity1.Name = "ucCity1";
            this.ucCity1.Size = new System.Drawing.Size(761, 501);
            this.ucCity1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(967, 525);
            this.Controls.Add(this.ucCity1);
            this.Controls.Add(this.ucAgent1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private ucAgent ucAgent1;
        private ucCity ucCity1;
    }
}