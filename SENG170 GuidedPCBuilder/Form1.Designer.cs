﻿namespace SENG170_GuidedPCBuilder
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
            this.btnAMD = new System.Windows.Forms.Button();
            this.btnIntel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAMD
            // 
            this.btnAMD.Location = new System.Drawing.Point(108, 77);
            this.btnAMD.Name = "btnAMD";
            this.btnAMD.Size = new System.Drawing.Size(89, 83);
            this.btnAMD.TabIndex = 0;
            this.btnAMD.Text = "AMD";
            this.btnAMD.UseVisualStyleBackColor = true;
            this.btnAMD.Click += new System.EventHandler(this.btnAMD_Click);
            // 
            // btnIntel
            // 
            this.btnIntel.Location = new System.Drawing.Point(421, 77);
            this.btnIntel.Name = "btnIntel";
            this.btnIntel.Size = new System.Drawing.Size(89, 80);
            this.btnIntel.TabIndex = 1;
            this.btnIntel.Text = "Intel";
            this.btnIntel.UseVisualStyleBackColor = true;
            this.btnIntel.Click += new System.EventHandler(this.btnIntel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Your Build Here!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(551, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose a processor manufacturer for your build.  AMD tend to be cheaper while Int" +
    "el is more stable and runs cooler.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 345);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIntel);
            this.Controls.Add(this.btnAMD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAMD;
        private System.Windows.Forms.Button btnIntel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

