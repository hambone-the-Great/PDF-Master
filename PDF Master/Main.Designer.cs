namespace PDF_Master
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnProtect = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Convert XPS to PDF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Split PDF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Merge PDF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(600, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Protect PDF";
            // 
            // btnProtect
            // 
            this.btnProtect.Image = global::PDF_Master.Properties.Resources.pdf_protect_logo_100;
            this.btnProtect.Location = new System.Drawing.Point(568, 65);
            this.btnProtect.Name = "btnProtect";
            this.btnProtect.Size = new System.Drawing.Size(150, 113);
            this.btnProtect.TabIndex = 6;
            this.btnProtect.UseVisualStyleBackColor = true;
            this.btnProtect.Click += new System.EventHandler(this.BtnProtect_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.Image = global::PDF_Master.Properties.Resources.pdf_merge_logo_100;
            this.btnMerge.Location = new System.Drawing.Point(393, 65);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(150, 113);
            this.btnMerge.TabIndex = 4;
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.BtnMerge_Click);
            // 
            // btnSplit
            // 
            this.btnSplit.Image = global::PDF_Master.Properties.Resources.pdf_split_logo_100;
            this.btnSplit.Location = new System.Drawing.Point(219, 65);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(150, 113);
            this.btnSplit.TabIndex = 2;
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.BtnSplit_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Image = global::PDF_Master.Properties.Resources.pdf_convert_100;
            this.btnConvert.Location = new System.Drawing.Point(46, 65);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(150, 113);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(787, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 270);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnProtect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "PDF Master";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProtect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

