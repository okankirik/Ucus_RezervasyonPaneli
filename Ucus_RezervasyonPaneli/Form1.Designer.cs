namespace Ucus_RezervasyonPaneli
{
    partial class UcusRezervasyonPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcusRezervasyonPaneli));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxSaat = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxNereye = new System.Windows.Forms.ComboBox();
            this.comboBoxNereden = new System.Windows.Forms.ComboBox();
            this.dtPickerTarih = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.maskedTxtBoxTelefonNo = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtBoxTCNo = new System.Windows.Forms.MaskedTextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.lblMarka = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxSaat);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.comboBoxNereye);
            this.groupBox1.Controls.Add(this.comboBoxNereden);
            this.groupBox1.Controls.Add(this.dtPickerTarih);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // comboBoxSaat
            // 
            this.comboBoxSaat.FormattingEnabled = true;
            this.comboBoxSaat.Items.AddRange(new object[] {
            "00:15",
            "00:30",
            "00:45",
            "01:00",
            "01:15",
            "01:30",
            "01:45",
            "02:00",
            "02:15",
            "02:30",
            "02:45",
            "03:00",
            "03:15",
            "03:30",
            "03:45",
            "04:00",
            "04:15",
            "04:30",
            "04:45"});
            this.comboBoxSaat.Location = new System.Drawing.Point(85, 112);
            this.comboBoxSaat.Name = "comboBoxSaat";
            this.comboBoxSaat.Size = new System.Drawing.Size(157, 21);
            this.comboBoxSaat.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(252, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "label9";
            this.label9.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "<>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxNereye
            // 
            this.comboBoxNereye.FormattingEnabled = true;
            this.comboBoxNereye.Items.AddRange(new object[] {
            "Ankara",
            "İstanbul",
            "İzmir",
            "Diyarbakır",
            "Sinop",
            "Van ",
            "Hakkari",
            "Çorum",
            "Hatay"});
            this.comboBoxNereye.Location = new System.Drawing.Point(85, 55);
            this.comboBoxNereye.Name = "comboBoxNereye";
            this.comboBoxNereye.Size = new System.Drawing.Size(157, 21);
            this.comboBoxNereye.TabIndex = 3;
            // 
            // comboBoxNereden
            // 
            this.comboBoxNereden.FormattingEnabled = true;
            this.comboBoxNereden.Items.AddRange(new object[] {
            "Ankara",
            "İstanbul",
            "İzmir",
            "Diyarbakır",
            "Sinop",
            "Van ",
            "Hakkari",
            "Çorum",
            "Hatay"});
            this.comboBoxNereden.Location = new System.Drawing.Point(85, 23);
            this.comboBoxNereden.Name = "comboBoxNereden";
            this.comboBoxNereden.Size = new System.Drawing.Size(157, 21);
            this.comboBoxNereden.TabIndex = 3;
            // 
            // dtPickerTarih
            // 
            this.dtPickerTarih.Location = new System.Drawing.Point(85, 83);
            this.dtPickerTarih.Name = "dtPickerTarih";
            this.dtPickerTarih.Size = new System.Drawing.Size(157, 20);
            this.dtPickerTarih.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(34, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Saat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(31, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tarih:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(17, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nereye:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nereden:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKaydet);
            this.groupBox2.Controls.Add(this.maskedTxtBoxTelefonNo);
            this.groupBox2.Controls.Add(this.maskedTxtBoxTCNo);
            this.groupBox2.Controls.Add(this.txtAdSoyad);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(333, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 143);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(180, 109);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedTxtBoxTelefonNo
            // 
            this.maskedTxtBoxTelefonNo.Location = new System.Drawing.Point(98, 83);
            this.maskedTxtBoxTelefonNo.Mask = "(999) 000-0000";
            this.maskedTxtBoxTelefonNo.Name = "maskedTxtBoxTelefonNo";
            this.maskedTxtBoxTelefonNo.Size = new System.Drawing.Size(157, 20);
            this.maskedTxtBoxTelefonNo.TabIndex = 2;
            // 
            // maskedTxtBoxTCNo
            // 
            this.maskedTxtBoxTCNo.Location = new System.Drawing.Point(98, 57);
            this.maskedTxtBoxTCNo.Mask = "00000000000";
            this.maskedTxtBoxTCNo.Name = "maskedTxtBoxTCNo";
            this.maskedTxtBoxTCNo.Size = new System.Drawing.Size(157, 20);
            this.maskedTxtBoxTCNo.TabIndex = 2;
            this.maskedTxtBoxTCNo.ValidatingType = typeof(int);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(98, 27);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(157, 20);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(31, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(60, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "TC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad Soyad:";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(26, 284);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(911, 147);
            this.listBox.TabIndex = 1;
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Font = new System.Drawing.Font("Segoe Script", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMarka.Location = new System.Drawing.Point(11, 29);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(595, 89);
            this.lblMarka.TabIndex = 2;
            this.lblMarka.Text = "Martı Hava Yolları";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(626, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // UcusRezervasyonPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 444);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UcusRezervasyonPaneli";
            this.Text = "Uçuş Rezervasyon Paneli";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxNereye;
        private System.Windows.Forms.ComboBox comboBoxNereden;
        private System.Windows.Forms.DateTimePicker dtPickerTarih;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxTelefonNo;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxTCNo;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxSaat;
    }
}

