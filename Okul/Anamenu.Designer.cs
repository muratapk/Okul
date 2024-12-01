namespace Okul
{
    partial class Anamenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.okulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.okulEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.okulToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(846, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // okulToolStripMenuItem
            // 
            this.okulToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.okulEkleToolStripMenuItem});
            this.okulToolStripMenuItem.Name = "okulToolStripMenuItem";
            this.okulToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.okulToolStripMenuItem.Text = "Okul";
            // 
            // okulEkleToolStripMenuItem
            // 
            this.okulEkleToolStripMenuItem.Name = "okulEkleToolStripMenuItem";
            this.okulEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.okulEkleToolStripMenuItem.Text = "Okul Ekle";
            this.okulEkleToolStripMenuItem.Click += new System.EventHandler(this.okulEkleToolStripMenuItem_Click);
            // 
            // Anamenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Anamenu";
            this.Text = "Anamenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem okulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem okulEkleToolStripMenuItem;
    }
}