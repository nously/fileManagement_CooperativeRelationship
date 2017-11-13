namespace FileManagement_CoopRel
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.luarNegeri = new MetroFramework.Controls.MetroTile();
            this.dalamNegeri = new MetroFramework.Controls.MetroTile();
            this.welcomePanel = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.listTahunPanel = new MetroFramework.Controls.MetroPanel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.daftarTahun = new System.Windows.Forms.FlowLayoutPanel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.daftarTahunPanelLabel = new MetroFramework.Controls.MetroLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.welcomePanel.SuspendLayout();
            this.listTahunPanel.SuspendLayout();
            this.daftarTahun.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Controls.Add(this.luarNegeri);
            this.metroPanel1.Controls.Add(this.dalamNegeri);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(178, 525);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.Black;
            this.metroPanel2.BackgroundImage = global::FileManagement_CoopRel.Properties.Resources.flat10;
            this.metroPanel2.Controls.Add(this.label3);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(178, 59);
            this.metroPanel2.TabIndex = 5;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // luarNegeri
            // 
            this.luarNegeri.ActiveControl = null;
            this.luarNegeri.Location = new System.Drawing.Point(3, 116);
            this.luarNegeri.Name = "luarNegeri";
            this.luarNegeri.Size = new System.Drawing.Size(172, 45);
            this.luarNegeri.TabIndex = 4;
            this.luarNegeri.Text = "Kerjasama Luar Negeri";
            this.luarNegeri.UseSelectable = true;
            this.luarNegeri.Click += new System.EventHandler(this.luarNegeri_Click);
            // 
            // dalamNegeri
            // 
            this.dalamNegeri.ActiveControl = null;
            this.dalamNegeri.Location = new System.Drawing.Point(3, 65);
            this.dalamNegeri.Name = "dalamNegeri";
            this.dalamNegeri.Size = new System.Drawing.Size(172, 45);
            this.dalamNegeri.TabIndex = 3;
            this.dalamNegeri.Text = "Kerjasama Dalam Negeri";
            this.dalamNegeri.UseSelectable = true;
            this.dalamNegeri.Click += new System.EventHandler(this.dalamNegeri_Click);
            // 
            // welcomePanel
            // 
            this.welcomePanel.Controls.Add(this.metroLabel1);
            this.welcomePanel.Controls.Add(this.label4);
            this.welcomePanel.HorizontalScrollbarBarColor = true;
            this.welcomePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.welcomePanel.HorizontalScrollbarSize = 10;
            this.welcomePanel.Location = new System.Drawing.Point(201, 59);
            this.welcomePanel.Name = "welcomePanel";
            this.welcomePanel.Size = new System.Drawing.Size(637, 445);
            this.welcomePanel.TabIndex = 2;
            this.welcomePanel.VerticalScrollbarBarColor = true;
            this.welcomePanel.VerticalScrollbarHighlightOnWheel = false;
            this.welcomePanel.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(196, 159);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(251, 50);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Pilih Salah Satu Jenis Kerjasama\r\nPada Panel Sebelah Kiri";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Source Sans Pro", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(529, 34);
            this.label4.TabIndex = 2;
            this.label4.Text = "Selamat Datang di Manajemen File Kerjasama";
            // 
            // listTahunPanel
            // 
            this.listTahunPanel.Controls.Add(this.metroButton1);
            this.listTahunPanel.Controls.Add(this.daftarTahun);
            this.listTahunPanel.Controls.Add(this.daftarTahunPanelLabel);
            this.listTahunPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.listTahunPanel.HorizontalScrollbarBarColor = true;
            this.listTahunPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.listTahunPanel.HorizontalScrollbarSize = 10;
            this.listTahunPanel.Location = new System.Drawing.Point(218, 0);
            this.listTahunPanel.Name = "listTahunPanel";
            this.listTahunPanel.Padding = new System.Windows.Forms.Padding(5);
            this.listTahunPanel.Size = new System.Drawing.Size(637, 525);
            this.listTahunPanel.TabIndex = 1;
            this.listTahunPanel.VerticalScrollbarBarColor = true;
            this.listTahunPanel.VerticalScrollbarHighlightOnWheel = false;
            this.listTahunPanel.VerticalScrollbarSize = 10;
            this.listTahunPanel.Visible = false;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(495, 16);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(95, 32);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Tambah Tahun";
            this.metroButton1.UseSelectable = true;
            // 
            // daftarTahun
            // 
            this.daftarTahun.AutoScroll = true;
            this.daftarTahun.Controls.Add(this.metroTile1);
            this.daftarTahun.Controls.Add(this.metroTile2);
            this.daftarTahun.Controls.Add(this.metroTile3);
            this.daftarTahun.Controls.Add(this.metroTile4);
            this.daftarTahun.Location = new System.Drawing.Point(3, 57);
            this.daftarTahun.Name = "daftarTahun";
            this.daftarTahun.Padding = new System.Windows.Forms.Padding(5);
            this.daftarTahun.Size = new System.Drawing.Size(631, 385);
            this.daftarTahun.TabIndex = 3;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(8, 8);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(286, 50);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(300, 8);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(286, 50);
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "metroTile2";
            this.metroTile2.UseSelectable = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(8, 64);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(286, 50);
            this.metroTile3.TabIndex = 2;
            this.metroTile3.Text = "metroTile3";
            this.metroTile3.UseSelectable = true;
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(300, 64);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(286, 50);
            this.metroTile4.TabIndex = 3;
            this.metroTile4.Text = "metroTile4";
            this.metroTile4.UseSelectable = true;
            // 
            // daftarTahunPanelLabel
            // 
            this.daftarTahunPanelLabel.AutoSize = true;
            this.daftarTahunPanelLabel.Location = new System.Drawing.Point(11, 22);
            this.daftarTahunPanelLabel.Name = "daftarTahunPanelLabel";
            this.daftarTahunPanelLabel.Size = new System.Drawing.Size(146, 19);
            this.daftarTahunPanelLabel.TabIndex = 2;
            this.daftarTahunPanelLabel.Text = "Daftar Tahun Kerjasama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(55, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Menu";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(855, 525);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.listTahunPanel);
            this.Controls.Add(this.welcomePanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Manajemen File Kerjasama";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.welcomePanel.ResumeLayout(false);
            this.welcomePanel.PerformLayout();
            this.listTahunPanel.ResumeLayout(false);
            this.listTahunPanel.PerformLayout();
            this.daftarTahun.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile dalamNegeri;
        private MetroFramework.Controls.MetroTile luarNegeri;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel listTahunPanel;
        private MetroFramework.Controls.MetroLabel daftarTahunPanelLabel;
        private MetroFramework.Controls.MetroPanel welcomePanel;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.FlowLayoutPanel daftarTahun;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Label label3;
    }
}

