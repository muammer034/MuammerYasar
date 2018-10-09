namespace WindowsFormsApplication35
{
    partial class Muammer
    {
        /// <summary>
        ///Gerekli designer değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        ///Designer desteği için gerekli metottur; bu metodun
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resimAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griSkalaYöntemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bT709AlgoritmasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lumaYöntemiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açıklıkYöntemiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResimKutusu1 = new System.Windows.Forms.PictureBox();
            this.ResimKutusu2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.kanalÇıkarımıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResimKutusu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResimKutusu2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem,
            this.griSkalaYöntemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(271, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resimAlToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // resimAlToolStripMenuItem
            // 
            this.resimAlToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.resimAlToolStripMenuItem.Name = "resimAlToolStripMenuItem";
            this.resimAlToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.resimAlToolStripMenuItem.Text = "Resim Al";
            this.resimAlToolStripMenuItem.Click += new System.EventHandler(this.resimAlToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // griSkalaYöntemleriToolStripMenuItem
            // 
            this.griSkalaYöntemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bT709AlgoritmasıToolStripMenuItem,
            this.lumaYöntemiToolStripMenuItem,
            this.açıklıkYöntemiToolStripMenuItem,
            this.kanalÇıkarımıToolStripMenuItem});
            this.griSkalaYöntemleriToolStripMenuItem.Name = "griSkalaYöntemleriToolStripMenuItem";
            this.griSkalaYöntemleriToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.griSkalaYöntemleriToolStripMenuItem.Text = "Gri Skala Yöntemleri";
            // 
            // bT709AlgoritmasıToolStripMenuItem
            // 
            this.bT709AlgoritmasıToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bT709AlgoritmasıToolStripMenuItem.Name = "bT709AlgoritmasıToolStripMenuItem";
            this.bT709AlgoritmasıToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.bT709AlgoritmasıToolStripMenuItem.Text = "BT-709 Algoritması";
            this.bT709AlgoritmasıToolStripMenuItem.Click += new System.EventHandler(this.bT709AlgoritmasıToolStripMenuItem_Click);
            // 
            // lumaYöntemiToolStripMenuItem
            // 
            this.lumaYöntemiToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lumaYöntemiToolStripMenuItem.Name = "lumaYöntemiToolStripMenuItem";
            this.lumaYöntemiToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.lumaYöntemiToolStripMenuItem.Text = "Luma Yöntemi";
            this.lumaYöntemiToolStripMenuItem.Click += new System.EventHandler(this.lumaYöntemiToolStripMenuItem_Click);
            // 
            // açıklıkYöntemiToolStripMenuItem
            // 
            this.açıklıkYöntemiToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.açıklıkYöntemiToolStripMenuItem.Name = "açıklıkYöntemiToolStripMenuItem";
            this.açıklıkYöntemiToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.açıklıkYöntemiToolStripMenuItem.Text = "Açıklık Yöntemi";
            this.açıklıkYöntemiToolStripMenuItem.Click += new System.EventHandler(this.açıklıkYöntemiToolStripMenuItem_Click);
            // 
            // ResimKutusu1
            // 
            this.ResimKutusu1.Location = new System.Drawing.Point(23, 45);
            this.ResimKutusu1.Name = "ResimKutusu1";
            this.ResimKutusu1.Size = new System.Drawing.Size(218, 204);
            this.ResimKutusu1.TabIndex = 1;
            this.ResimKutusu1.TabStop = false;
            // 
            // ResimKutusu2
            // 
            this.ResimKutusu2.Location = new System.Drawing.Point(23, 287);
            this.ResimKutusu2.Name = "ResimKutusu2";
            this.ResimKutusu2.Size = new System.Drawing.Size(218, 204);
            this.ResimKutusu2.TabIndex = 1;
            this.ResimKutusu2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // kanalÇıkarımıToolStripMenuItem
            // 
            this.kanalÇıkarımıToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.kanalÇıkarımıToolStripMenuItem.Name = "kanalÇıkarımıToolStripMenuItem";
            this.kanalÇıkarımıToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.kanalÇıkarımıToolStripMenuItem.Text = "Kanal Çıkarımı";
            this.kanalÇıkarımıToolStripMenuItem.Click += new System.EventHandler(this.kanalÇıkarımıToolStripMenuItem_Click);
            // 
            // Muammer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 513);
            this.Controls.Add(this.ResimKutusu2);
            this.Controls.Add(this.ResimKutusu1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Muammer";
            this.Text = "Skala İşlemleri";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResimKutusu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResimKutusu2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resimAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griSkalaYöntemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bT709AlgoritmasıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lumaYöntemiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açıklıkYöntemiToolStripMenuItem;
        private System.Windows.Forms.PictureBox ResimKutusu1;
        private System.Windows.Forms.PictureBox ResimKutusu2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem kanalÇıkarımıToolStripMenuItem;
    }
}

