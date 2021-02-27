namespace IngilizcePerformanYonetimUygulamasi
{
    partial class TesteSoruEklemeFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TesteSoruEklemeFrm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.close_btn = new System.Windows.Forms.ToolStripButton();
            this.maximize_btn = new System.Windows.Forms.ToolStripButton();
            this.minimize_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.konuSecme_cmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listelenenSorular_flwpnl = new System.Windows.Forms.FlowLayoutPanel();
            this.sorgulamaCümlesi_lbl = new System.Windows.Forms.Label();
            this.sorgulamaControlleri_pnl = new System.Windows.Forms.Panel();
            this.secenekler_flwpnl = new System.Windows.Forms.FlowLayoutPanel();
            this.soruIcerik_txt = new System.Windows.Forms.TextBox();
            this.soruEkle_btn = new ns1.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSayaci_tmr = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.close_btn,
            this.maximize_btn,
            this.minimize_btn,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(743, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // close_btn
            // 
            this.close_btn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.close_btn.Image = global::IngilizcePerformanYonetimUygulamasi.Properties.Resources.icons8_close_window_48px;
            this.close_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(23, 22);
            this.close_btn.Text = "toolStripButton1";
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // maximize_btn
            // 
            this.maximize_btn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.maximize_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.maximize_btn.Image = global::IngilizcePerformanYonetimUygulamasi.Properties.Resources.maximize_window_30px;
            this.maximize_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.maximize_btn.Name = "maximize_btn";
            this.maximize_btn.Size = new System.Drawing.Size(23, 22);
            this.maximize_btn.Text = "toolStripButton2";
            this.maximize_btn.Click += new System.EventHandler(this.maximize_btn_Click);
            // 
            // minimize_btn
            // 
            this.minimize_btn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.minimize_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.minimize_btn.Image = global::IngilizcePerformanYonetimUygulamasi.Properties.Resources.minimize_window_30px1;
            this.minimize_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(23, 22);
            this.minimize_btn.Text = "toolStripButton3";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // konuSecme_cmb
            // 
            this.konuSecme_cmb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.konuSecme_cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.konuSecme_cmb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.konuSecme_cmb.FormattingEnabled = true;
            this.konuSecme_cmb.Items.AddRange(new object[] {
            "Konuya göre",
            "İsme göre",
            "Sınıfa göre"});
            this.konuSecme_cmb.Location = new System.Drawing.Point(140, 52);
            this.konuSecme_cmb.Name = "konuSecme_cmb";
            this.konuSecme_cmb.Size = new System.Drawing.Size(224, 25);
            this.konuSecme_cmb.TabIndex = 20;
            this.konuSecme_cmb.SelectedIndexChanged += new System.EventHandler(this.konuSecme_cmb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Listeleme Türü :";
            // 
            // listelenenSorular_flwpnl
            // 
            this.listelenenSorular_flwpnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listelenenSorular_flwpnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.listelenenSorular_flwpnl.Location = new System.Drawing.Point(34, 97);
            this.listelenenSorular_flwpnl.Name = "listelenenSorular_flwpnl";
            this.listelenenSorular_flwpnl.Size = new System.Drawing.Size(202, 328);
            this.listelenenSorular_flwpnl.TabIndex = 23;
            this.listelenenSorular_flwpnl.Visible = false;
            // 
            // sorgulamaCümlesi_lbl
            // 
            this.sorgulamaCümlesi_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sorgulamaCümlesi_lbl.AutoSize = true;
            this.sorgulamaCümlesi_lbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorgulamaCümlesi_lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.sorgulamaCümlesi_lbl.Location = new System.Drawing.Point(396, 55);
            this.sorgulamaCümlesi_lbl.Name = "sorgulamaCümlesi_lbl";
            this.sorgulamaCümlesi_lbl.Size = new System.Drawing.Size(51, 17);
            this.sorgulamaCümlesi_lbl.TabIndex = 24;
            this.sorgulamaCümlesi_lbl.Text = "*label2";
            this.sorgulamaCümlesi_lbl.Visible = false;
            // 
            // sorgulamaControlleri_pnl
            // 
            this.sorgulamaControlleri_pnl.Location = new System.Drawing.Point(468, 46);
            this.sorgulamaControlleri_pnl.Name = "sorgulamaControlleri_pnl";
            this.sorgulamaControlleri_pnl.Size = new System.Drawing.Size(245, 37);
            this.sorgulamaControlleri_pnl.TabIndex = 25;
            // 
            // secenekler_flwpnl
            // 
            this.secenekler_flwpnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.secenekler_flwpnl.AutoScroll = true;
            this.secenekler_flwpnl.Location = new System.Drawing.Point(253, 284);
            this.secenekler_flwpnl.Name = "secenekler_flwpnl";
            this.secenekler_flwpnl.Size = new System.Drawing.Size(458, 84);
            this.secenekler_flwpnl.TabIndex = 29;
            this.secenekler_flwpnl.Visible = false;
            // 
            // soruIcerik_txt
            // 
            this.soruIcerik_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.soruIcerik_txt.BackColor = System.Drawing.Color.DarkGray;
            this.soruIcerik_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.soruIcerik_txt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soruIcerik_txt.Location = new System.Drawing.Point(253, 97);
            this.soruIcerik_txt.Multiline = true;
            this.soruIcerik_txt.Name = "soruIcerik_txt";
            this.soruIcerik_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.soruIcerik_txt.Size = new System.Drawing.Size(460, 181);
            this.soruIcerik_txt.TabIndex = 28;
            this.soruIcerik_txt.Visible = false;
            // 
            // soruEkle_btn
            // 
            this.soruEkle_btn.ActiveBorderThickness = 1;
            this.soruEkle_btn.ActiveCornerRadius = 20;
            this.soruEkle_btn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.soruEkle_btn.ActiveForecolor = System.Drawing.Color.White;
            this.soruEkle_btn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.soruEkle_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.soruEkle_btn.BackColor = System.Drawing.Color.DarkGray;
            this.soruEkle_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("soruEkle_btn.BackgroundImage")));
            this.soruEkle_btn.ButtonText = "Soru Ekle";
            this.soruEkle_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.soruEkle_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soruEkle_btn.ForeColor = System.Drawing.Color.SeaGreen;
            this.soruEkle_btn.IdleBorderThickness = 1;
            this.soruEkle_btn.IdleCornerRadius = 20;
            this.soruEkle_btn.IdleFillColor = System.Drawing.Color.White;
            this.soruEkle_btn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.soruEkle_btn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.soruEkle_btn.Location = new System.Drawing.Point(558, 375);
            this.soruEkle_btn.Margin = new System.Windows.Forms.Padding(5);
            this.soruEkle_btn.Name = "soruEkle_btn";
            this.soruEkle_btn.Size = new System.Drawing.Size(153, 50);
            this.soruEkle_btn.TabIndex = 27;
            this.soruEkle_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.soruEkle_btn.Click += new System.EventHandler(this.soruEkle_btn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(250, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "bu soru zaten eklendi";
            this.label2.Visible = false;
            // 
            // TesteSoruEklemeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(743, 448);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.secenekler_flwpnl);
            this.Controls.Add(this.soruIcerik_txt);
            this.Controls.Add(this.soruEkle_btn);
            this.Controls.Add(this.sorgulamaControlleri_pnl);
            this.Controls.Add(this.sorgulamaCümlesi_lbl);
            this.Controls.Add(this.listelenenSorular_flwpnl);
            this.Controls.Add(this.konuSecme_cmb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TesteSoruEklemeFrm";
            this.Text = "TesteSoruEklemeFrm";
            this.Load += new System.EventHandler(this.TesteSoruEklemeFrm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton close_btn;
        public System.Windows.Forms.ToolStripButton maximize_btn;
        public System.Windows.Forms.ToolStripButton minimize_btn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        public System.Windows.Forms.ComboBox konuSecme_cmb;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel listelenenSorular_flwpnl;
        private System.Windows.Forms.Label sorgulamaCümlesi_lbl;
        private System.Windows.Forms.Panel sorgulamaControlleri_pnl;
        private System.Windows.Forms.FlowLayoutPanel secenekler_flwpnl;
        private System.Windows.Forms.TextBox soruIcerik_txt;
        public ns1.BunifuThinButton2 soruEkle_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer labelSayaci_tmr;
    }
}