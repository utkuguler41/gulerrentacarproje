
namespace gulerrentacarproje1
{
    partial class frmAraçKayıt
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
            this.Markacombo = new System.Windows.Forms.ComboBox();
            this.Sericombo = new System.Windows.Forms.ComboBox();
            this.Renktxt = new System.Windows.Forms.TextBox();
            this.Kmtxt = new System.Windows.Forms.TextBox();
            this.Ücrettxt = new System.Windows.Forms.TextBox();
            this.Yakıtcombo = new System.Windows.Forms.ComboBox();
            this.Yiltxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Plakatxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnResim = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Markacombo
            // 
            this.Markacombo.FormattingEnabled = true;
            this.Markacombo.Items.AddRange(new object[] {
            "Opel",
            "Renault",
            "Fiat",
            "Ford"});
            this.Markacombo.Location = new System.Drawing.Point(129, 68);
            this.Markacombo.Name = "Markacombo";
            this.Markacombo.Size = new System.Drawing.Size(122, 21);
            this.Markacombo.TabIndex = 1;
            this.Markacombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Sericombo
            // 
            this.Sericombo.FormattingEnabled = true;
            this.Sericombo.Location = new System.Drawing.Point(129, 108);
            this.Sericombo.Name = "Sericombo";
            this.Sericombo.Size = new System.Drawing.Size(122, 21);
            this.Sericombo.TabIndex = 1;
            // 
            // Renktxt
            // 
            this.Renktxt.Location = new System.Drawing.Point(129, 194);
            this.Renktxt.Name = "Renktxt";
            this.Renktxt.Size = new System.Drawing.Size(122, 20);
            this.Renktxt.TabIndex = 2;
            // 
            // Kmtxt
            // 
            this.Kmtxt.Location = new System.Drawing.Point(129, 237);
            this.Kmtxt.Name = "Kmtxt";
            this.Kmtxt.Size = new System.Drawing.Size(122, 20);
            this.Kmtxt.TabIndex = 2;
            // 
            // Ücrettxt
            // 
            this.Ücrettxt.Location = new System.Drawing.Point(129, 318);
            this.Ücrettxt.Name = "Ücrettxt";
            this.Ücrettxt.Size = new System.Drawing.Size(122, 20);
            this.Ücrettxt.TabIndex = 2;
            // 
            // Yakıtcombo
            // 
            this.Yakıtcombo.FormattingEnabled = true;
            this.Yakıtcombo.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Benzin+Lpg"});
            this.Yakıtcombo.Location = new System.Drawing.Point(129, 278);
            this.Yakıtcombo.Name = "Yakıtcombo";
            this.Yakıtcombo.Size = new System.Drawing.Size(122, 21);
            this.Yakıtcombo.TabIndex = 3;
            // 
            // Yiltxt
            // 
            this.Yiltxt.Location = new System.Drawing.Point(129, 150);
            this.Yiltxt.Name = "Yiltxt";
            this.Yiltxt.Size = new System.Drawing.Size(122, 20);
            this.Yiltxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Model(Yıl)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Renk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Km";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Yakıt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Kira Ücreti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Marka";
            // 
            // Plakatxt
            // 
            this.Plakatxt.Location = new System.Drawing.Point(129, 20);
            this.Plakatxt.Name = "Plakatxt";
            this.Plakatxt.Size = new System.Drawing.Size(122, 20);
            this.Plakatxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Plaka";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(15, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Kayıt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(150, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 33);
            this.button2.TabIndex = 9;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnResim
            // 
            this.btnResim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnResim.ForeColor = System.Drawing.Color.White;
            this.btnResim.Location = new System.Drawing.Point(500, 194);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(101, 33);
            this.btnResim.TabIndex = 9;
            this.btnResim.Text = "Resim Ekle";
            this.btnResim.UseVisualStyleBackColor = false;
            this.btnResim.Click += new System.EventHandler(this.btnResim_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(449, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAraçKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnResim);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            this.Name = "frmAraçKayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Kayıt Sayfası";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Markacombo;
        private System.Windows.Forms.ComboBox Sericombo;
        private System.Windows.Forms.TextBox Renktxt;
        private System.Windows.Forms.TextBox Kmtxt;
        private System.Windows.Forms.TextBox Ücrettxt;
        private System.Windows.Forms.ComboBox Yakıtcombo;
        private System.Windows.Forms.TextBox Yiltxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Plakatxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnResim;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}