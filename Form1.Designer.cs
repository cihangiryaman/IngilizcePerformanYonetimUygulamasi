namespace IngilizcePerformanYonetimUygulamasi
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
            this.components = new System.ComponentModel.Container();
            this.konularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingilizcePerformansVeritabaniDataSet = new IngilizcePerformanYonetimUygulamasi.IngilizcePerformansVeritabaniDataSet();
            this.konularTableAdapter = new IngilizcePerformanYonetimUygulamasi.IngilizcePerformansVeritabaniDataSetTableAdapters.KonularTableAdapter();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.konularBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingilizcePerformansVeritabaniDataSet)).BeginInit();
            this.SuspendLayout();
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
            // konularTableAdapter
            // 
            this.konularTableAdapter.ClearBeforeFill = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(51, 43);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(335, 224);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 363);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.konularBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingilizcePerformansVeritabaniDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private IngilizcePerformansVeritabaniDataSet ingilizcePerformansVeritabaniDataSet;
        private System.Windows.Forms.BindingSource konularBindingSource;
        private IngilizcePerformansVeritabaniDataSetTableAdapters.KonularTableAdapter konularTableAdapter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}