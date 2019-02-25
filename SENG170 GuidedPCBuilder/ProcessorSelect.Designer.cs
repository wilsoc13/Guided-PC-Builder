namespace SENG170_GuidedPCBuilder
{
    partial class ProcessorSelect
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
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Single");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Dual");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Quad Core");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("6 Core");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("8 Core");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("10 Core");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("12 Cores");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("14 Core");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("16 Core");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("18 Cores");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Cores", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27});
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("1.0-1.49GHz");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("1.5-1.99GHz");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("2-2.49GHz");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("2.5-2.99GHz");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("3.0 GHz and Higher");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Operating Frequency", new System.Windows.Forms.TreeNode[] {
            treeNode29,
            treeNode30,
            treeNode31,
            treeNode32,
            treeNode33});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(32, 58);
            this.treeView1.Name = "treeView1";
            treeNode18.Name = "snglCore";
            treeNode18.Text = "Single";
            treeNode19.Name = "DualCore";
            treeNode19.Text = "Dual";
            treeNode20.Name = "QuadCore";
            treeNode20.Text = "Quad Core";
            treeNode21.Name = "6Core";
            treeNode21.Text = "6 Core";
            treeNode22.Name = "8Core";
            treeNode22.Text = "8 Core";
            treeNode23.Name = "10Core";
            treeNode23.Text = "10 Core";
            treeNode24.Name = "12Core";
            treeNode24.Text = "12 Cores";
            treeNode25.Name = "14Core";
            treeNode25.Text = "14 Core";
            treeNode26.Name = "16Core";
            treeNode26.Text = "16 Core";
            treeNode27.Name = "18 Core";
            treeNode27.Text = "18 Cores";
            treeNode28.Name = "Core";
            treeNode28.Text = "Cores";
            treeNode29.Name = "lowFreq";
            treeNode29.Text = "1.0-1.49GHz";
            treeNode30.Name = "medLowFreq";
            treeNode30.Text = "1.5-1.99GHz";
            treeNode31.Name = "medFreq";
            treeNode31.Text = "2-2.49GHz";
            treeNode32.Name = "medHighFreq";
            treeNode32.Text = "2.5-2.99GHz";
            treeNode33.Name = "highFreq";
            treeNode33.Text = "3.0 GHz and Higher";
            treeNode34.Name = "OperFreq";
            treeNode34.Text = "Operating Frequency";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode28,
            treeNode34});
            this.treeView1.Size = new System.Drawing.Size(151, 251);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(425, 58);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(217, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(172, 251);
            this.listBox1.TabIndex = 3;
            // 
            // ProcessorSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 408);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.treeView1);
            this.Name = "ProcessorSelect";
            this.Text = "ProcessorSelect";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listBox1;
    }
}