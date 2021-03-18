namespace IngilizcePerformanYonetimUygulamasi
{
    partial class EklenenSoruUC
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
            this.konu_lbl = new System.Windows.Forms.Label();
            this.soruSirasi_lbl = new System.Windows.Forms.Label();
            this.ozellikler_btn = new System.Windows.Forms.Button();
            this.sil_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // konu_lbl
            // 
            this.konu_lbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.konu_lbl.ForeColor = System.Drawing.Color.LightGray;
            this.konu_lbl.Location = new System.Drawing.Point(12, 37);
            this.konu_lbl.Name = "konu_lbl";
            this.konu_lbl.Size = new System.Drawing.Size(174, 49);
            this.konu_lbl.TabIndex = 5;
            this.konu_lbl.Text = "label2";
            // 
            // soruSirasi_lbl
            // 
            this.soruSirasi_lbl.AutoSize = true;
            this.soruSirasi_lbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soruSirasi_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.soruSirasi_lbl.Location = new System.Drawing.Point(12, 7);
            this.soruSirasi_lbl.Name = "soruSirasi_lbl";
            this.soruSirasi_lbl.Size = new System.Drawing.Size(52, 18);
            this.soruSirasi_lbl.TabIndex = 4;
            this.soruSirasi_lbl.Text = "1.Soru";
            // 
            // ozellikler_btn
            // 
            this.ozellikler_btn.BackColor = System.Drawing.Color.Teal;
            this.ozellikler_btn.BackgroundImage = global::IngilizcePerformanYonetimUygulamasi.Properties.Resources.details_24px;
            this.ozellikler_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ozellikler_btn.FlatAppearance.BorderSize = 0;
            this.ozellikler_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ozellikler_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ozellikler_btn.ForeColor = System.Drawing.Color.Wheat;
            this.ozellikler_btn.Location = new System.Drawing.Point(145, 3);
            this.ozellikler_btn.Name = "ozellikler_btn";
            this.ozellikler_btn.Size = new System.Drawing.Size(23, 23);
            this.ozellikler_btn.TabIndex = 7;
            this.ozellikler_btn.UseVisualStyleBackColor = false;
            this.ozellikler_btn.Visible = false;
            // 
            // sil_btn
            // 
            this.sil_btn.BackColor = System.Drawing.Color.Teal;
            this.sil_btn.BackgroundImage = global::IngilizcePerformanYonetimUygulamasi.Properties.Resources.delete_32px;
            this.sil_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sil_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.sil_btn.FlatAppearance.BorderSize = 0;
            this.sil_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sil_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.sil_btn.Location = new System.Drawing.Point(174, 3);
            this.sil_btn.Name = "sil_btn";
            this.sil_btn.Size = new System.Drawing.Size(23, 23);
            this.sil_btn.TabIndex = 6;
            this.sil_btn.UseVisualStyleBackColor = false;
            this.sil_btn.Visible = false;
            // 
            // EklenenSoruUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.ozellikler_btn);
            this.Controls.Add(this.sil_btn);
            this.Controls.Add(this.konu_lbl);
            this.Controls.Add(this.soruSirasi_lbl);
            this.DoubleBuffered = true;
            this.Name = "EklenenSoruUC";
            this.Size = new System.Drawing.Size(200, 97);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button ozellikler_btn;
        public System.Windows.Forms.Button sil_btn;
        public System.Windows.Forms.Label konu_lbl;
        public System.Windows.Forms.Label soruSirasi_lbl;
    }
}
