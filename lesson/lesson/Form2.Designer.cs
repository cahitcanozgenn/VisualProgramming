
namespace lesson
{
    partial class Form2
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
            this.büyükHarfeÇevirmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkDeğiştirmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listboxVeriEkleme1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yüzdeAlmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listboxVeriEkleme2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.büyükHarfeÇevirmeToolStripMenuItem,
            this.renkDeğiştirmeToolStripMenuItem,
            this.listboxVeriEkleme1ToolStripMenuItem,
            this.yüzdeAlmaToolStripMenuItem,
            this.listboxVeriEkleme2ToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(653, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // büyükHarfeÇevirmeToolStripMenuItem
            // 
            this.büyükHarfeÇevirmeToolStripMenuItem.Name = "büyükHarfeÇevirmeToolStripMenuItem";
            this.büyükHarfeÇevirmeToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.büyükHarfeÇevirmeToolStripMenuItem.Text = "Büyük Harfe Çevirme";
            this.büyükHarfeÇevirmeToolStripMenuItem.Click += new System.EventHandler(this.büyükHarfeÇevirmeToolStripMenuItem_Click);
            // 
            // renkDeğiştirmeToolStripMenuItem
            // 
            this.renkDeğiştirmeToolStripMenuItem.Name = "renkDeğiştirmeToolStripMenuItem";
            this.renkDeğiştirmeToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.renkDeğiştirmeToolStripMenuItem.Text = "Renk Değiştirme";
            this.renkDeğiştirmeToolStripMenuItem.Click += new System.EventHandler(this.renkDeğiştirmeToolStripMenuItem_Click);
            // 
            // listboxVeriEkleme1ToolStripMenuItem
            // 
            this.listboxVeriEkleme1ToolStripMenuItem.Name = "listboxVeriEkleme1ToolStripMenuItem";
            this.listboxVeriEkleme1ToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.listboxVeriEkleme1ToolStripMenuItem.Text = "Listbox Veri Ekleme 1";
            this.listboxVeriEkleme1ToolStripMenuItem.Click += new System.EventHandler(this.listboxVeriEkleme1ToolStripMenuItem_Click);
            // 
            // yüzdeAlmaToolStripMenuItem
            // 
            this.yüzdeAlmaToolStripMenuItem.Name = "yüzdeAlmaToolStripMenuItem";
            this.yüzdeAlmaToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.yüzdeAlmaToolStripMenuItem.Text = "Yüzde Alma";
            this.yüzdeAlmaToolStripMenuItem.Click += new System.EventHandler(this.yüzdeAlmaToolStripMenuItem_Click);
            // 
            // listboxVeriEkleme2ToolStripMenuItem
            // 
            this.listboxVeriEkleme2ToolStripMenuItem.Name = "listboxVeriEkleme2ToolStripMenuItem";
            this.listboxVeriEkleme2ToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.listboxVeriEkleme2ToolStripMenuItem.Text = "Combo Veri Ekleme ";
            this.listboxVeriEkleme2ToolStripMenuItem.Click += new System.EventHandler(this.listboxVeriEkleme2ToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 108);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem büyükHarfeÇevirmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkDeğiştirmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listboxVeriEkleme1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yüzdeAlmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listboxVeriEkleme2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}