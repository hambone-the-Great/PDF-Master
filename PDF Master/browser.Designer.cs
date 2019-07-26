namespace PDF_Master
{
    partial class browser
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
            this.browserCtrl = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // browserCtrl
            // 
            this.browserCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserCtrl.Location = new System.Drawing.Point(0, 0);
            this.browserCtrl.MinimumSize = new System.Drawing.Size(20, 20);
            this.browserCtrl.Name = "browserCtrl";
            this.browserCtrl.Size = new System.Drawing.Size(800, 450);
            this.browserCtrl.TabIndex = 0;
            // 
            // browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.browserCtrl);
            this.Name = "browser";
            this.Text = "About Max PDF";
            this.Load += new System.EventHandler(this.Browser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser browserCtrl;
    }
}