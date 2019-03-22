namespace DBFirst_FaturaIslemlerii
{
    partial class FormSiparisSecenekleri
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
            this.siparişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişGösterVeyaDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtAra = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // siparişToolStripMenuItem
            // 
            this.siparişToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişGösterVeyaDüzenleToolStripMenuItem,
            this.siparişEkleToolStripMenuItem});
            this.siparişToolStripMenuItem.Name = "siparişToolStripMenuItem";
            this.siparişToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.siparişToolStripMenuItem.Text = "Sipariş";
            // 
            // siparişGösterVeyaDüzenleToolStripMenuItem
            // 
            this.siparişGösterVeyaDüzenleToolStripMenuItem.Name = "siparişGösterVeyaDüzenleToolStripMenuItem";
            this.siparişGösterVeyaDüzenleToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.siparişGösterVeyaDüzenleToolStripMenuItem.Text = "Sipariş Göster veya Düzenle";
            this.siparişGösterVeyaDüzenleToolStripMenuItem.Click += new System.EventHandler(this.siparişGösterVeyaDüzenleToolStripMenuItem_Click);
            // 
            // siparişEkleToolStripMenuItem
            // 
            this.siparişEkleToolStripMenuItem.Name = "siparişEkleToolStripMenuItem";
            this.siparişEkleToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.siparişEkleToolStripMenuItem.Text = "Sipariş Ekle";
            this.siparişEkleToolStripMenuItem.Click += new System.EventHandler(this.siparişEkleToolStripMenuItem_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.txtOrderID);
            this.panel.Controls.Add(this.txtAra);
            this.panel.Location = new System.Drawing.Point(81, 68);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(520, 189);
            this.panel.TabIndex = 1;
            this.panel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "OrderID";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(165, 78);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(100, 20);
            this.txtOrderID.TabIndex = 1;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(295, 76);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(75, 23);
            this.txtAra.TabIndex = 0;
            this.txtAra.Text = "Ara";
            this.txtAra.UseVisualStyleBackColor = true;
            this.txtAra.Click += new System.EventHandler(this.txtAra_Click);
            // 
            // FormSiparisSecenekleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormSiparisSecenekleri";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormSiparisSecenekleri_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişGösterVeyaDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişEkleToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Button txtAra;
    }
}

