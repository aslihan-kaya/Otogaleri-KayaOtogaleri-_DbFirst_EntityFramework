namespace Otogaleri_KayaOtogaleri__DbFirst_EntityFramework
{
    partial class Raporlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raporlar));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.polikliniklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.polikliniklerToolStripMenuItem,
            this.doktorlarToolStripMenuItem,
            this.hastalarToolStripMenuItem,
            this.raporlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(984, 46);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // polikliniklerToolStripMenuItem
            // 
            this.polikliniklerToolStripMenuItem.BackColor = System.Drawing.Color.MidnightBlue;
            this.polikliniklerToolStripMenuItem.Font = new System.Drawing.Font("Niagara Engraved", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polikliniklerToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.polikliniklerToolStripMenuItem.Name = "polikliniklerToolStripMenuItem";
            this.polikliniklerToolStripMenuItem.Size = new System.Drawing.Size(91, 42);
            this.polikliniklerToolStripMenuItem.Text = "Subeler";
            this.polikliniklerToolStripMenuItem.Click += new System.EventHandler(this.polikliniklerToolStripMenuItem_Click);
            // 
            // doktorlarToolStripMenuItem
            // 
            this.doktorlarToolStripMenuItem.Font = new System.Drawing.Font("Niagara Engraved", 26.25F);
            this.doktorlarToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.doktorlarToolStripMenuItem.Name = "doktorlarToolStripMenuItem";
            this.doktorlarToolStripMenuItem.Size = new System.Drawing.Size(89, 42);
            this.doktorlarToolStripMenuItem.Text = "Araclar";
            this.doktorlarToolStripMenuItem.Click += new System.EventHandler(this.doktorlarToolStripMenuItem_Click);
            // 
            // hastalarToolStripMenuItem
            // 
            this.hastalarToolStripMenuItem.Font = new System.Drawing.Font("Niagara Engraved", 26.25F);
            this.hastalarToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.hastalarToolStripMenuItem.Name = "hastalarToolStripMenuItem";
            this.hastalarToolStripMenuItem.Size = new System.Drawing.Size(114, 42);
            this.hastalarToolStripMenuItem.Text = "Musteriler";
            this.hastalarToolStripMenuItem.Click += new System.EventHandler(this.hastalarToolStripMenuItem_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.Font = new System.Drawing.Font("Niagara Engraved", 26.25F);
            this.raporlarToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(99, 42);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            this.raporlarToolStripMenuItem.Click += new System.EventHandler(this.raporlarToolStripMenuItem_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(815, 430);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 89);
            this.button5.TabIndex = 13;
            this.button5.Text = "Araçlar Şubeler Müşteriler tablosunu join işlemi birleştirme";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(623, 430);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 89);
            this.button4.TabIndex = 12;
            this.button4.Text = "Araç Ve Şubeleri Join Birleştirme";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(417, 430);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 89);
            this.button3.TabIndex = 11;
            this.button3.Text = "Araç Yıla Göre Asc Sıralayan Sorgu";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 89);
            this.button2.TabIndex = 10;
            this.button2.Text = "Araç Markasına Göre Araç fiyatının toplamını veren sorgu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 89);
            this.button1.TabIndex = 9;
            this.button1.Text = "Araç Modeline Göre Descending Sıralama";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(221, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 322);
            this.dataGridView1.TabIndex = 8;
            // 
            // Raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Name = "Raporlar";
            this.Text = "Raporlar";
            this.Load += new System.EventHandler(this.Raporlar_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem polikliniklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}