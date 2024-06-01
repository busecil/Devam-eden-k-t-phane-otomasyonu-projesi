namespace Kutuphane.Formlar
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnUyeEkle = new System.Windows.Forms.Button();
            this.btnEmanetKitap = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.btnKitapTur = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnUyeEkle);
            this.panel1.Controls.Add(this.btnEmanetKitap);
            this.panel1.Controls.Add(this.btnKitapEkle);
            this.panel1.Controls.Add(this.btnKitapTur);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 730);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.ImageKey = "(yok)";
            this.btnExit.ImageList = this.ımageList1;
            this.btnExit.Location = new System.Drawing.Point(27, 640);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 56);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "pngwing.com (2).png");
            this.ımageList1.Images.SetKeyName(1, "Kitap listele.png");
            this.ımageList1.Images.SetKeyName(2, "Kitap ekle.png");
            this.ımageList1.Images.SetKeyName(3, "Üye listeleme.png");
            this.ımageList1.Images.SetKeyName(4, "Üye ekleme.png");
            this.ımageList1.Images.SetKeyName(5, "Emanet kitaplar.png");
            this.ımageList1.Images.SetKeyName(6, "Kitap türleri.png");
            this.ımageList1.Images.SetKeyName(7, "ÇIKIŞ.png");
            this.ımageList1.Images.SetKeyName(8, "Bölümler.png");
            // 
            // btnUyeEkle
            // 
            this.btnUyeEkle.FlatAppearance.BorderSize = 0;
            this.btnUyeEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUyeEkle.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUyeEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUyeEkle.ImageKey = "Üye ekleme.png";
            this.btnUyeEkle.ImageList = this.ımageList1;
            this.btnUyeEkle.Location = new System.Drawing.Point(45, 9);
            this.btnUyeEkle.Margin = new System.Windows.Forms.Padding(1);
            this.btnUyeEkle.Name = "btnUyeEkle";
            this.btnUyeEkle.Size = new System.Drawing.Size(109, 143);
            this.btnUyeEkle.TabIndex = 0;
            this.btnUyeEkle.Text = "Üye İşlemleri";
            this.btnUyeEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUyeEkle.UseVisualStyleBackColor = true;
            this.btnUyeEkle.Click += new System.EventHandler(this.btnUyeEkle_Click);
            // 
            // btnEmanetKitap
            // 
            this.btnEmanetKitap.FlatAppearance.BorderSize = 0;
            this.btnEmanetKitap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmanetKitap.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmanetKitap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmanetKitap.ImageKey = "Emanet kitaplar.png";
            this.btnEmanetKitap.ImageList = this.ımageList1;
            this.btnEmanetKitap.Location = new System.Drawing.Point(27, 491);
            this.btnEmanetKitap.Name = "btnEmanetKitap";
            this.btnEmanetKitap.Size = new System.Drawing.Size(144, 95);
            this.btnEmanetKitap.TabIndex = 0;
            this.btnEmanetKitap.Text = "Emanet Kitaplar";
            this.btnEmanetKitap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEmanetKitap.UseVisualStyleBackColor = true;
            this.btnEmanetKitap.Click += new System.EventHandler(this.btnEmanetKitap_Click);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.FlatAppearance.BorderSize = 0;
            this.btnKitapEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapEkle.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKitapEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKitapEkle.ImageKey = "Kitap ekle.png";
            this.btnKitapEkle.ImageList = this.ımageList1;
            this.btnKitapEkle.Location = new System.Drawing.Point(32, 319);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(126, 128);
            this.btnKitapEkle.TabIndex = 0;
            this.btnKitapEkle.Text = "Kitap İşlemleri";
            this.btnKitapEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // btnKitapTur
            // 
            this.btnKitapTur.FlatAppearance.BorderSize = 0;
            this.btnKitapTur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapTur.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKitapTur.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKitapTur.ImageKey = "Kitap türleri.png";
            this.btnKitapTur.ImageList = this.ımageList1;
            this.btnKitapTur.Location = new System.Drawing.Point(45, 156);
            this.btnKitapTur.Name = "btnKitapTur";
            this.btnKitapTur.Size = new System.Drawing.Size(109, 106);
            this.btnKitapTur.TabIndex = 0;
            this.btnKitapTur.Text = "Kitap Türleri";
            this.btnKitapTur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKitapTur.UseVisualStyleBackColor = true;
            this.btnKitapTur.Click += new System.EventHandler(this.btnKitapTur_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kutuphane.Properties.Resources.Ekran_görüntüsü_2024_03_25_160046;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1103, 730);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUyeEkle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Button btnKitapTur;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEmanetKitap;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}