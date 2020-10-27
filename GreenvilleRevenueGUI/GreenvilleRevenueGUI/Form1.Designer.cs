namespace GreenvilleRevenueGUI
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnDisplayData = new System.Windows.Forms.Button();
            this.txtLastYear = new System.Windows.Forms.TextBox();
            this.txtThisYear = new System.Windows.Forms.TextBox();
            this.lblResponse1 = new System.Windows.Forms.Label();
            this.lblResponse2 = new System.Windows.Forms.Label();
            this.lblResponse3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(23, 32);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(249, 17);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Enter number of contestants last year:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(22, 85);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(311, 21);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Enter number of contestants this year:";
            // 
            // btnDisplayData
            // 
            this.btnDisplayData.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDisplayData.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnDisplayData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayData.Location = new System.Drawing.Point(242, 132);
            this.btnDisplayData.Name = "btnDisplayData";
            this.btnDisplayData.Size = new System.Drawing.Size(173, 36);
            this.btnDisplayData.TabIndex = 2;
            this.btnDisplayData.Text = "Display data";
            this.btnDisplayData.UseVisualStyleBackColor = false;
            this.btnDisplayData.Click += new System.EventHandler(this.btnDisplayData_Click);
            // 
            // txtLastYear
            // 
            this.txtLastYear.Location = new System.Drawing.Point(286, 32);
            this.txtLastYear.Name = "txtLastYear";
            this.txtLastYear.Size = new System.Drawing.Size(100, 22);
            this.txtLastYear.TabIndex = 3;
            // 
            // txtThisYear
            // 
            this.txtThisYear.Location = new System.Drawing.Point(284, 84);
            this.txtThisYear.Name = "txtThisYear";
            this.txtThisYear.Size = new System.Drawing.Size(100, 22);
            this.txtThisYear.TabIndex = 4;
            // 
            // lblResponse1
            // 
            this.lblResponse1.AutoSize = true;
            this.lblResponse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponse1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblResponse1.Location = new System.Drawing.Point(281, 261);
            this.lblResponse1.Name = "lblResponse1";
            this.lblResponse1.Size = new System.Drawing.Size(0, 25);
            this.lblResponse1.TabIndex = 5;
            // 
            // lblResponse2
            // 
            this.lblResponse2.AutoSize = true;
            this.lblResponse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponse2.Location = new System.Drawing.Point(281, 183);
            this.lblResponse2.Name = "lblResponse2";
            this.lblResponse2.Size = new System.Drawing.Size(0, 25);
            this.lblResponse2.TabIndex = 6;
            // 
            // lblResponse3
            // 
            this.lblResponse3.AutoSize = true;
            this.lblResponse3.Location = new System.Drawing.Point(281, 228);
            this.lblResponse3.Name = "lblResponse3";
            this.lblResponse3.Size = new System.Drawing.Size(0, 21);
            this.lblResponse3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 450);
            this.Controls.Add(this.lblResponse3);
            this.Controls.Add(this.lblResponse2);
            this.Controls.Add(this.lblResponse1);
            this.Controls.Add(this.txtThisYear);
            this.Controls.Add(this.txtLastYear);
            this.Controls.Add(this.btnDisplayData);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Greenville Idol Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnDisplayData;
        private System.Windows.Forms.TextBox txtLastYear;
        private System.Windows.Forms.TextBox txtThisYear;
        private System.Windows.Forms.Label lblResponse1;
        private System.Windows.Forms.Label lblResponse2;
        private System.Windows.Forms.Label lblResponse3;
    }
}

