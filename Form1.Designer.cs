namespace WindowsFormsApp3
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
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtucret = new System.Windows.Forms.TextBox();
            this.lblad = new System.Windows.Forms.Label();
            this.lbldogum = new System.Windows.Forms.Label();
            this.lblcinsiyet = new System.Windows.Forms.Label();
            this.lblucret = new System.Windows.Forms.Label();
            this.cmbcinsiyet = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClmnAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnDyili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnCinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnUcret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clmnindirimli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnYas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.lbltoplam = new System.Windows.Forms.Label();
            this.dateDogumTarihi = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(126, 12);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(100, 20);
            this.txtAdi.TabIndex = 0;
            // 
            // txtucret
            // 
            this.txtucret.Location = new System.Drawing.Point(357, 61);
            this.txtucret.Name = "txtucret";
            this.txtucret.Size = new System.Drawing.Size(100, 20);
            this.txtucret.TabIndex = 1;
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Location = new System.Drawing.Point(23, 19);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(22, 13);
            this.lblad.TabIndex = 4;
            this.lblad.Text = "Adı";
            // 
            // lbldogum
            // 
            this.lbldogum.AutoSize = true;
            this.lbldogum.Location = new System.Drawing.Point(23, 64);
            this.lbldogum.Name = "lbldogum";
            this.lbldogum.Size = new System.Drawing.Size(57, 13);
            this.lbldogum.TabIndex = 5;
            this.lbldogum.Text = "Doğum Yılı";
            // 
            // lblcinsiyet
            // 
            this.lblcinsiyet.AutoSize = true;
            this.lblcinsiyet.Location = new System.Drawing.Point(275, 19);
            this.lblcinsiyet.Name = "lblcinsiyet";
            this.lblcinsiyet.Size = new System.Drawing.Size(45, 13);
            this.lblcinsiyet.TabIndex = 6;
            this.lblcinsiyet.Text = "Cinsiyeti";
            this.lblcinsiyet.Click += new System.EventHandler(this.lblcinsiyet_Click);
            // 
            // lblucret
            // 
            this.lblucret.AutoSize = true;
            this.lblucret.Location = new System.Drawing.Point(275, 64);
            this.lblucret.Name = "lblucret";
            this.lblucret.Size = new System.Drawing.Size(33, 13);
            this.lblucret.TabIndex = 7;
            this.lblucret.Text = "Ücret";
            // 
            // cmbcinsiyet
            // 
            this.cmbcinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcinsiyet.FormattingEnabled = true;
            this.cmbcinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbcinsiyet.Location = new System.Drawing.Point(357, 16);
            this.cmbcinsiyet.Name = "cmbcinsiyet";
            this.cmbcinsiyet.Size = new System.Drawing.Size(121, 21);
            this.cmbcinsiyet.TabIndex = 8;
            this.cmbcinsiyet.SelectedIndexChanged += new System.EventHandler(this.cmbcinsiyet_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmnAdi,
            this.ClmnDyili,
            this.ClmnCinsiyet,
            this.ClmnUcret,
            this.Clmnindirimli,
            this.ClmnYas});
            this.dataGridView1.Location = new System.Drawing.Point(26, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(788, 200);
            this.dataGridView1.TabIndex = 9;
            // 
            // ClmnAdi
            // 
            this.ClmnAdi.HeaderText = "Adı";
            this.ClmnAdi.Name = "ClmnAdi";
            // 
            // ClmnDyili
            // 
            this.ClmnDyili.HeaderText = "Doğum Yılı";
            this.ClmnDyili.Name = "ClmnDyili";
            this.ClmnDyili.Width = 50;
            // 
            // ClmnCinsiyet
            // 
            this.ClmnCinsiyet.HeaderText = "Cinsiyet";
            this.ClmnCinsiyet.Name = "ClmnCinsiyet";
            // 
            // ClmnUcret
            // 
            this.ClmnUcret.HeaderText = "Ücret";
            this.ClmnUcret.Name = "ClmnUcret";
            // 
            // Clmnindirimli
            // 
            this.Clmnindirimli.HeaderText = "İndirimli Ücret";
            this.Clmnindirimli.Name = "Clmnindirimli";
            // 
            // ClmnYas
            // 
            this.ClmnYas.HeaderText = "Yaşı";
            this.ClmnYas.Name = "ClmnYas";
            this.ClmnYas.Width = 50;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(560, 54);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 10;
            this.btnekle.Text = "Hasta Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnhesapla
            // 
            this.btnhesapla.Location = new System.Drawing.Point(560, 19);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(75, 23);
            this.btnhesapla.TabIndex = 11;
            this.btnhesapla.Text = "Hesapla";
            this.btnhesapla.UseVisualStyleBackColor = true;
            // 
            // lbltoplam
            // 
            this.lbltoplam.AutoSize = true;
            this.lbltoplam.Location = new System.Drawing.Point(541, 83);
            this.lbltoplam.Name = "lbltoplam";
            this.lbltoplam.Size = new System.Drawing.Size(0, 13);
            this.lbltoplam.TabIndex = 12;
            // 
            // dateDogumTarihi
            // 
            this.dateDogumTarihi.CalendarTitleBackColor = System.Drawing.Color.Aqua;
            this.dateDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDogumTarihi.Location = new System.Drawing.Point(121, 61);
            this.dateDogumTarihi.MaxDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dateDogumTarihi.Name = "dateDogumTarihi";
            this.dateDogumTarihi.Size = new System.Drawing.Size(105, 20);
            this.dateDogumTarihi.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 338);
            this.Controls.Add(this.dateDogumTarihi);
            this.Controls.Add(this.lbltoplam);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbcinsiyet);
            this.Controls.Add(this.lblucret);
            this.Controls.Add(this.lblcinsiyet);
            this.Controls.Add(this.lbldogum);
            this.Controls.Add(this.lblad);
            this.Controls.Add(this.txtucret);
            this.Controls.Add(this.txtAdi);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtucret;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Label lbldogum;
        private System.Windows.Forms.Label lblcinsiyet;
        private System.Windows.Forms.Label lblucret;
        private System.Windows.Forms.ComboBox cmbcinsiyet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnDyili;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnCinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnUcret;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clmnindirimli;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnYas;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.Label lbltoplam;
        private System.Windows.Forms.DateTimePicker dateDogumTarihi;
    }
}

