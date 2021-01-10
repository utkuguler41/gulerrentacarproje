
namespace gulerrentacarproje1
{
    partial class frmAraçListele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboAraçlar = new System.Windows.Forms.ComboBox();
            this.btnResim = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Yiltxt = new System.Windows.Forms.TextBox();
            this.Yakıtcombo = new System.Windows.Forms.ComboBox();
            this.Ücrettxt = new System.Windows.Forms.TextBox();
            this.Kmtxt = new System.Windows.Forms.TextBox();
            this.Renktxt = new System.Windows.Forms.TextBox();
            this.Sericombo = new System.Windows.Forms.ComboBox();
            this.Markacombo = new System.Windows.Forms.ComboBox();
            this.Plakatxt = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(259, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(623, 283);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // comboAraçlar
            // 
            this.comboAraçlar.FormattingEnabled = true;
            this.comboAraçlar.Items.AddRange(new object[] {
            "Tüm Araçlar",
            "Boş Araçlar",
            "Dolu Araçlar"});
            this.comboAraçlar.Location = new System.Drawing.Point(761, 25);
            this.comboAraçlar.Name = "comboAraçlar";
            this.comboAraçlar.Size = new System.Drawing.Size(121, 21);
            this.comboAraçlar.TabIndex = 1;
            this.comboAraçlar.SelectedIndexChanged += new System.EventHandler(this.comboAraçlar_SelectedIndexChanged);
            // 
            // btnResim
            // 
            this.btnResim.BackColor = System.Drawing.Color.Maroon;
            this.btnResim.ForeColor = System.Drawing.Color.White;
            this.btnResim.Location = new System.Drawing.Point(288, 430);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(97, 25);
            this.btnResim.TabIndex = 29;
            this.btnResim.Text = "Resim Değiştir";
            this.btnResim.UseVisualStyleBackColor = false;
            this.btnResim.Click += new System.EventHandler(this.btnResim_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.BackColor = System.Drawing.Color.Maroon;
            this.btnİptal.ForeColor = System.Drawing.Color.White;
            this.btnİptal.Location = new System.Drawing.Point(131, 562);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(101, 33);
            this.btnİptal.TabIndex = 28;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = false;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.Maroon;
            this.btnGüncelle.ForeColor = System.Drawing.Color.White;
            this.btnGüncelle.Location = new System.Drawing.Point(12, 562);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(101, 33);
            this.btnGüncelle.TabIndex = 27;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Marka";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(14, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Kira Ücreti";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Yakıt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Km";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Renk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Model(Yıl)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Seri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Plaka";
            // 
            // Yiltxt
            // 
            this.Yiltxt.Location = new System.Drawing.Point(131, 156);
            this.Yiltxt.Name = "Yiltxt";
            this.Yiltxt.Size = new System.Drawing.Size(122, 20);
            this.Yiltxt.TabIndex = 18;
            // 
            // Yakıtcombo
            // 
            this.Yakıtcombo.FormattingEnabled = true;
            this.Yakıtcombo.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Benzin+Lpg"});
            this.Yakıtcombo.Location = new System.Drawing.Point(131, 284);
            this.Yakıtcombo.Name = "Yakıtcombo";
            this.Yakıtcombo.Size = new System.Drawing.Size(122, 21);
            this.Yakıtcombo.TabIndex = 17;
            // 
            // Ücrettxt
            // 
            this.Ücrettxt.Location = new System.Drawing.Point(131, 324);
            this.Ücrettxt.Name = "Ücrettxt";
            this.Ücrettxt.Size = new System.Drawing.Size(122, 20);
            this.Ücrettxt.TabIndex = 16;
            // 
            // Kmtxt
            // 
            this.Kmtxt.Location = new System.Drawing.Point(131, 243);
            this.Kmtxt.Name = "Kmtxt";
            this.Kmtxt.Size = new System.Drawing.Size(122, 20);
            this.Kmtxt.TabIndex = 15;
            // 
            // Renktxt
            // 
            this.Renktxt.Location = new System.Drawing.Point(131, 200);
            this.Renktxt.Name = "Renktxt";
            this.Renktxt.Size = new System.Drawing.Size(122, 20);
            this.Renktxt.TabIndex = 14;
            // 
            // Sericombo
            // 
            this.Sericombo.FormattingEnabled = true;
            this.Sericombo.Location = new System.Drawing.Point(131, 114);
            this.Sericombo.Name = "Sericombo";
            this.Sericombo.Size = new System.Drawing.Size(122, 21);
            this.Sericombo.TabIndex = 12;
            // 
            // Markacombo
            // 
            this.Markacombo.FormattingEnabled = true;
            this.Markacombo.Items.AddRange(new object[] {
            "Opel",
            "Renault",
            "Fiat",
            "Ford"});
            this.Markacombo.Location = new System.Drawing.Point(131, 74);
            this.Markacombo.Name = "Markacombo";
            this.Markacombo.Size = new System.Drawing.Size(122, 21);
            this.Markacombo.TabIndex = 13;
            this.Markacombo.SelectedIndexChanged += new System.EventHandler(this.Markacombo_SelectedIndexChanged);
            // 
            // Plakatxt
            // 
            this.Plakatxt.Location = new System.Drawing.Point(131, 26);
            this.Plakatxt.Name = "Plakatxt";
            this.Plakatxt.Size = new System.Drawing.Size(122, 20);
            this.Plakatxt.TabIndex = 11;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Maroon;
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(888, 61);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(63, 33);
            this.btnSil.TabIndex = 28;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(17, 362);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(252, 169);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAraçListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(954, 607);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnResim);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Yiltxt);
            this.Controls.Add(this.Yakıtcombo);
            this.Controls.Add(this.Ücrettxt);
            this.Controls.Add(this.Kmtxt);
            this.Controls.Add(this.Renktxt);
            this.Controls.Add(this.Sericombo);
            this.Controls.Add(this.Markacombo);
            this.Controls.Add(this.Plakatxt);
            this.Controls.Add(this.comboAraçlar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmAraçListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Listeleme Sayfası";
            this.Load += new System.EventHandler(this.frmAraçListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboAraçlar;
        private System.Windows.Forms.Button btnResim;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Yiltxt;
        private System.Windows.Forms.ComboBox Yakıtcombo;
        private System.Windows.Forms.TextBox Ücrettxt;
        private System.Windows.Forms.TextBox Kmtxt;
        private System.Windows.Forms.TextBox Renktxt;
        private System.Windows.Forms.ComboBox Sericombo;
        private System.Windows.Forms.ComboBox Markacombo;
        private System.Windows.Forms.TextBox Plakatxt;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}