namespace IngilizcePerformanYonetimUygulamasi
{
    partial class TestEkleUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestEkleUC));
            this.eklenenSorular_flwpnl = new System.Windows.Forms.FlowLayoutPanel();
            this.sinavTuru_cmb = new System.Windows.Forms.ComboBox();
            this.olustur_btn = new ns1.BunifuThinButton2();
            this.soruEkle_btn = new ns1.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sinavIsim_txt = new ns1.BunifuMetroTextbox();
            this.sinavSure_txt = new ns1.BunifuMetroTextbox();
            this.konuSecme_cmb = new System.Windows.Forms.ComboBox();
            this.konularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingilizcePerformansVeritabaniDataSet = new IngilizcePerformanYonetimUygulamasi.IngilizcePerformansVeritabaniDataSet();
            this.sinavSube_cmb = new System.Windows.Forms.ComboBox();
            this.siniflarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.konularBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.konularTableAdapter = new IngilizcePerformanYonetimUygulamasi.IngilizcePerformansVeritabaniDataSetTableAdapters.KonularTableAdapter();
            this.siniflarTableAdapter = new IngilizcePerformanYonetimUygulamasi.IngilizcePerformansVeritabaniDataSetTableAdapters.SiniflarTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.konularBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingilizcePerformansVeritabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siniflarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.konularBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // eklenenSorular_flwpnl
            // 
            this.eklenenSorular_flwpnl.AutoScroll = true;
            this.eklenenSorular_flwpnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.eklenenSorular_flwpnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.eklenenSorular_flwpnl.Location = new System.Drawing.Point(0, 0);
            this.eklenenSorular_flwpnl.Name = "eklenenSorular_flwpnl";
            this.eklenenSorular_flwpnl.Size = new System.Drawing.Size(218, 435);
            this.eklenenSorular_flwpnl.TabIndex = 0;
            // 
            // sinavTuru_cmb
            // 
            this.sinavTuru_cmb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sinavTuru_cmb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.sinavTuru_cmb.DisplayMember = "Konu_Ismi";
            this.sinavTuru_cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sinavTuru_cmb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sinavTuru_cmb.FormattingEnabled = true;
            this.sinavTuru_cmb.Items.AddRange(new object[] {
            "Konu Tarama Testi",
            "Sınav"});
            this.sinavTuru_cmb.Location = new System.Drawing.Point(254, 25);
            this.sinavTuru_cmb.Name = "sinavTuru_cmb";
            this.sinavTuru_cmb.Size = new System.Drawing.Size(312, 25);
            this.sinavTuru_cmb.TabIndex = 10;
            this.sinavTuru_cmb.Text = "Test Türü Seçiniz";
            this.sinavTuru_cmb.ValueMember = "Id";
            this.sinavTuru_cmb.SelectedIndexChanged += new System.EventHandler(this.sinavTuru_cmb_SelectedIndexChanged);
            // 
            // olustur_btn
            // 
            this.olustur_btn.ActiveBorderThickness = 1;
            this.olustur_btn.ActiveCornerRadius = 20;
            this.olustur_btn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.olustur_btn.ActiveForecolor = System.Drawing.Color.White;
            this.olustur_btn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.olustur_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.olustur_btn.BackColor = System.Drawing.Color.DarkGray;
            this.olustur_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("olustur_btn.BackgroundImage")));
            this.olustur_btn.ButtonText = "Testi Oluştur";
            this.olustur_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.olustur_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olustur_btn.ForeColor = System.Drawing.Color.SeaGreen;
            this.olustur_btn.IdleBorderThickness = 1;
            this.olustur_btn.IdleCornerRadius = 20;
            this.olustur_btn.IdleFillColor = System.Drawing.Color.White;
            this.olustur_btn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.olustur_btn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.olustur_btn.Location = new System.Drawing.Point(423, 362);
            this.olustur_btn.Margin = new System.Windows.Forms.Padding(5);
            this.olustur_btn.Name = "olustur_btn";
            this.olustur_btn.Size = new System.Drawing.Size(153, 50);
            this.olustur_btn.TabIndex = 12;
            this.olustur_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.olustur_btn.Click += new System.EventHandler(this.olustur_btn_Click);
            // 
            // soruEkle_btn
            // 
            this.soruEkle_btn.ActiveBorderThickness = 1;
            this.soruEkle_btn.ActiveCornerRadius = 20;
            this.soruEkle_btn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.soruEkle_btn.ActiveForecolor = System.Drawing.Color.White;
            this.soruEkle_btn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.soruEkle_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.soruEkle_btn.Location = new System.Drawing.Point(244, 362);
            this.soruEkle_btn.Margin = new System.Windows.Forms.Padding(5);
            this.soruEkle_btn.Name = "soruEkle_btn";
            this.soruEkle_btn.Size = new System.Drawing.Size(153, 50);
            this.soruEkle_btn.TabIndex = 13;
            this.soruEkle_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.soruEkle_btn.Click += new System.EventHandler(this.soruEkle_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.sinavIsim_txt);
            this.panel1.Controls.Add(this.sinavSure_txt);
            this.panel1.Controls.Add(this.konuSecme_cmb);
            this.panel1.Controls.Add(this.sinavSube_cmb);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(219, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 286);
            this.panel1.TabIndex = 14;
            // 
            // sinavIsim_txt
            // 
            this.sinavIsim_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sinavIsim_txt.BorderColorFocused = System.Drawing.Color.Green;
            this.sinavIsim_txt.BorderColorIdle = System.Drawing.Color.Silver;
            this.sinavIsim_txt.BorderColorMouseHover = System.Drawing.Color.Green;
            this.sinavIsim_txt.BorderThickness = 3;
            this.sinavIsim_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sinavIsim_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.sinavIsim_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sinavIsim_txt.isPassword = false;
            this.sinavIsim_txt.Location = new System.Drawing.Point(35, 110);
            this.sinavIsim_txt.Margin = new System.Windows.Forms.Padding(4);
            this.sinavIsim_txt.Name = "sinavIsim_txt";
            this.sinavIsim_txt.Size = new System.Drawing.Size(313, 33);
            this.sinavIsim_txt.TabIndex = 23;
            this.sinavIsim_txt.Text = "Sınav İsmi Giriniz";
            this.sinavIsim_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sinavIsim_txt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sinavIsim_txt_MouseEnter);
            this.sinavIsim_txt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sinavIsim_txt_MouseLeave);
            // 
            // sinavSure_txt
            // 
            this.sinavSure_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sinavSure_txt.BorderColorFocused = System.Drawing.Color.Green;
            this.sinavSure_txt.BorderColorIdle = System.Drawing.Color.Silver;
            this.sinavSure_txt.BorderColorMouseHover = System.Drawing.Color.Green;
            this.sinavSure_txt.BorderThickness = 3;
            this.sinavSure_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sinavSure_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.sinavSure_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sinavSure_txt.isPassword = false;
            this.sinavSure_txt.Location = new System.Drawing.Point(35, 163);
            this.sinavSure_txt.Margin = new System.Windows.Forms.Padding(4);
            this.sinavSure_txt.Name = "sinavSure_txt";
            this.sinavSure_txt.Size = new System.Drawing.Size(313, 33);
            this.sinavSure_txt.TabIndex = 22;
            this.sinavSure_txt.Text = "Sınav Süresi Giriniz";
            this.sinavSure_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sinavSure_txt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sinavSure_txt_MouseEnter);
            this.sinavSure_txt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sinavSure_txt_MouseLeave);
            // 
            // konuSecme_cmb
            // 
            this.konuSecme_cmb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.konuSecme_cmb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.konuSecme_cmb.DataSource = this.konularBindingSource;
            this.konuSecme_cmb.DisplayMember = "Konu_Ismi";
            this.konuSecme_cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.konuSecme_cmb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.konuSecme_cmb.FormattingEnabled = true;
            this.konuSecme_cmb.Location = new System.Drawing.Point(36, 13);
            this.konuSecme_cmb.Name = "konuSecme_cmb";
            this.konuSecme_cmb.Size = new System.Drawing.Size(312, 25);
            this.konuSecme_cmb.TabIndex = 18;
            this.konuSecme_cmb.ValueMember = "Id";
            // 
            // konularBindingSource
            // 
            this.konularBindingSource.DataMember = "Konular";
            this.konularBindingSource.DataSource = this.ingilizcePerformansVeritabaniDataSet;
            // 
            // ingilizcePerformansVeritabaniDataSet
            // 
            this.ingilizcePerformansVeritabaniDataSet.DataSetName = "IngilizcePerformansVeritabaniDataSet";
            this.ingilizcePerformansVeritabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinavSube_cmb
            // 
            this.sinavSube_cmb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sinavSube_cmb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.sinavSube_cmb.DataSource = this.siniflarBindingSource;
            this.sinavSube_cmb.DisplayMember = "Sinif_TamIsim";
            this.sinavSube_cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sinavSube_cmb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sinavSube_cmb.FormattingEnabled = true;
            this.sinavSube_cmb.Location = new System.Drawing.Point(36, 62);
            this.sinavSube_cmb.Name = "sinavSube_cmb";
            this.sinavSube_cmb.Size = new System.Drawing.Size(312, 25);
            this.sinavSube_cmb.TabIndex = 14;
            this.sinavSube_cmb.ValueMember = "Id";
            // 
            // siniflarBindingSource
            // 
            this.siniflarBindingSource.DataMember = "Siniflar";
            this.siniflarBindingSource.DataSource = this.ingilizcePerformansVeritabaniDataSet;
            // 
            // konularBindingSource1
            // 
            this.konularBindingSource1.DataMember = "Konular";
            this.konularBindingSource1.DataSource = this.ingilizcePerformansVeritabaniDataSet;
            // 
            // konularTableAdapter
            // 
            this.konularTableAdapter.ClearBeforeFill = true;
            // 
            // siniflarTableAdapter
            // 
            this.siniflarTableAdapter.ClearBeforeFill = true;
            // 
            // TestEkleUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.soruEkle_btn);
            this.Controls.Add(this.olustur_btn);
            this.Controls.Add(this.sinavTuru_cmb);
            this.Controls.Add(this.eklenenSorular_flwpnl);
            this.Name = "TestEkleUC";
            this.Size = new System.Drawing.Size(606, 435);
            this.Load += new System.EventHandler(this.TestEkleUC_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.konularBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingilizcePerformansVeritabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siniflarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.konularBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public ns1.BunifuThinButton2 olustur_btn;
        public ns1.BunifuThinButton2 soruEkle_btn;
        public System.Windows.Forms.FlowLayoutPanel eklenenSorular_flwpnl;
        public System.Windows.Forms.ComboBox sinavTuru_cmb;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox sinavSube_cmb;
        public System.Windows.Forms.ComboBox konuSecme_cmb;
        private System.Windows.Forms.BindingSource konularBindingSource;
        private IngilizcePerformansVeritabaniDataSet ingilizcePerformansVeritabaniDataSet;
        private System.Windows.Forms.BindingSource konularBindingSource1;
        private IngilizcePerformansVeritabaniDataSetTableAdapters.KonularTableAdapter konularTableAdapter;
        private System.Windows.Forms.BindingSource siniflarBindingSource;
        private IngilizcePerformansVeritabaniDataSetTableAdapters.SiniflarTableAdapter siniflarTableAdapter;
        public ns1.BunifuMetroTextbox sinavIsim_txt;
        public ns1.BunifuMetroTextbox sinavSure_txt;
    }
}
