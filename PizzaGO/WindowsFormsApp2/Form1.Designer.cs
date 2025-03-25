namespace WindowsFormsApp2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PeynirBox = new System.Windows.Forms.CheckBox();
            this.ZeytinBox = new System.Windows.Forms.CheckBox();
            this.TonBox = new System.Windows.Forms.CheckBox();
            this.AncuezBox = new System.Windows.Forms.CheckBox();
            this.MantarBox = new System.Windows.Forms.CheckBox();
            this.MisirBox = new System.Windows.Forms.CheckBox();
            this.SucukBox = new System.Windows.Forms.CheckBox();
            this.SosisBox = new System.Windows.Forms.CheckBox();
            this.SalamBox = new System.Windows.Forms.CheckBox();
            this.DanaBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SipraisPaneli = new System.Windows.Forms.Panel();
            this.lblToplam = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SipraisPaneli.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(-1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "PİZZAGO SİPARİŞ EKRANI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ebat :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Küçük Boy Menü",
            "Orta Boy Menü",
            "Büyük Boy Menü",
            "Extra Büyük Boy Menü",
            "Double Menü"});
            this.comboBox1.Location = new System.Drawing.Point(92, 200);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(271, 26);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Items.AddRange(new object[] {
            "American Hot",
            "Callypso",
            "Turkish",
            "Pizza İtaliano",
            "Etravaganzza"});
            this.listBox1.Location = new System.Drawing.Point(92, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(271, 94);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.Location = new System.Drawing.Point(61, 248);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(143, 22);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "İnce Kenar (15TL)";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2.Location = new System.Drawing.Point(228, 248);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(148, 22);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "Kalın Kenar (25TL)";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PeynirBox);
            this.groupBox1.Controls.Add(this.ZeytinBox);
            this.groupBox1.Controls.Add(this.TonBox);
            this.groupBox1.Controls.Add(this.AncuezBox);
            this.groupBox1.Controls.Add(this.MantarBox);
            this.groupBox1.Controls.Add(this.MisirBox);
            this.groupBox1.Controls.Add(this.SucukBox);
            this.groupBox1.Controls.Add(this.SosisBox);
            this.groupBox1.Controls.Add(this.SalamBox);
            this.groupBox1.Controls.Add(this.DanaBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(79, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 180);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Malzemeler";
            // 
            // PeynirBox
            // 
            this.PeynirBox.AutoSize = true;
            this.PeynirBox.Location = new System.Drawing.Point(149, 141);
            this.PeynirBox.Name = "PeynirBox";
            this.PeynirBox.Size = new System.Drawing.Size(68, 22);
            this.PeynirBox.TabIndex = 0;
            this.PeynirBox.Text = "Peynir";
            this.PeynirBox.UseVisualStyleBackColor = true;
            this.PeynirBox.CheckedChanged += new System.EventHandler(this.PeynirBox_CheckedChanged);
            // 
            // ZeytinBox
            // 
            this.ZeytinBox.AutoSize = true;
            this.ZeytinBox.Location = new System.Drawing.Point(15, 141);
            this.ZeytinBox.Name = "ZeytinBox";
            this.ZeytinBox.Size = new System.Drawing.Size(66, 22);
            this.ZeytinBox.TabIndex = 0;
            this.ZeytinBox.Text = "Zeytin";
            this.ZeytinBox.UseVisualStyleBackColor = true;
            this.ZeytinBox.CheckedChanged += new System.EventHandler(this.ZeytinBox_CheckedChanged);
            // 
            // TonBox
            // 
            this.TonBox.AutoSize = true;
            this.TonBox.Location = new System.Drawing.Point(149, 113);
            this.TonBox.Name = "TonBox";
            this.TonBox.Size = new System.Drawing.Size(92, 22);
            this.TonBox.TabIndex = 0;
            this.TonBox.Text = "Ton Balığı";
            this.TonBox.UseVisualStyleBackColor = true;
            this.TonBox.CheckedChanged += new System.EventHandler(this.TonBox_CheckedChanged);
            // 
            // AncuezBox
            // 
            this.AncuezBox.AutoSize = true;
            this.AncuezBox.Location = new System.Drawing.Point(15, 113);
            this.AncuezBox.Name = "AncuezBox";
            this.AncuezBox.Size = new System.Drawing.Size(76, 22);
            this.AncuezBox.TabIndex = 0;
            this.AncuezBox.Text = "Ançuez";
            this.AncuezBox.UseVisualStyleBackColor = true;
            this.AncuezBox.CheckedChanged += new System.EventHandler(this.AncuezBox_CheckedChanged);
            // 
            // MantarBox
            // 
            this.MantarBox.AutoSize = true;
            this.MantarBox.Location = new System.Drawing.Point(149, 85);
            this.MantarBox.Name = "MantarBox";
            this.MantarBox.Size = new System.Drawing.Size(73, 22);
            this.MantarBox.TabIndex = 0;
            this.MantarBox.Text = "Mantar";
            this.MantarBox.UseVisualStyleBackColor = true;
            this.MantarBox.CheckedChanged += new System.EventHandler(this.MantarBox_CheckedChanged);
            // 
            // MisirBox
            // 
            this.MisirBox.AutoSize = true;
            this.MisirBox.Location = new System.Drawing.Point(15, 85);
            this.MisirBox.Name = "MisirBox";
            this.MisirBox.Size = new System.Drawing.Size(59, 22);
            this.MisirBox.TabIndex = 0;
            this.MisirBox.Text = "Mısır";
            this.MisirBox.UseVisualStyleBackColor = true;
            this.MisirBox.CheckedChanged += new System.EventHandler(this.MisirBox_CheckedChanged);
            // 
            // SucukBox
            // 
            this.SucukBox.AutoSize = true;
            this.SucukBox.Location = new System.Drawing.Point(149, 57);
            this.SucukBox.Name = "SucukBox";
            this.SucukBox.Size = new System.Drawing.Size(69, 22);
            this.SucukBox.TabIndex = 0;
            this.SucukBox.Text = "Sucuk";
            this.SucukBox.UseVisualStyleBackColor = true;
            this.SucukBox.CheckedChanged += new System.EventHandler(this.SucukBox_CheckedChanged);
            // 
            // SosisBox
            // 
            this.SosisBox.AutoSize = true;
            this.SosisBox.Location = new System.Drawing.Point(15, 57);
            this.SosisBox.Name = "SosisBox";
            this.SosisBox.Size = new System.Drawing.Size(65, 22);
            this.SosisBox.TabIndex = 0;
            this.SosisBox.Text = "Sosis";
            this.SosisBox.UseVisualStyleBackColor = true;
            this.SosisBox.CheckedChanged += new System.EventHandler(this.SosisBox_CheckedChanged);
            // 
            // SalamBox
            // 
            this.SalamBox.AutoSize = true;
            this.SalamBox.Location = new System.Drawing.Point(149, 29);
            this.SalamBox.Name = "SalamBox";
            this.SalamBox.Size = new System.Drawing.Size(69, 22);
            this.SalamBox.TabIndex = 0;
            this.SalamBox.Text = "Salam";
            this.SalamBox.UseVisualStyleBackColor = true;
            this.SalamBox.CheckedChanged += new System.EventHandler(this.SalamBox_CheckedChanged);
            // 
            // DanaBox
            // 
            this.DanaBox.AutoSize = true;
            this.DanaBox.Location = new System.Drawing.Point(16, 29);
            this.DanaBox.Name = "DanaBox";
            this.DanaBox.Size = new System.Drawing.Size(120, 22);
            this.DanaBox.TabIndex = 0;
            this.DanaBox.Text = "Dana Jambon";
            this.DanaBox.UseVisualStyleBackColor = true;
            this.DanaBox.CheckedChanged += new System.EventHandler(this.DanaBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(242, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fiyat :";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(295, 490);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(68, 24);
            this.textBox2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(30, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Kapat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(139, 486);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "Sipariş Ver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 67);
            this.label5.TabIndex = 10;
            this.label5.Text = "PİZZA ÇEŞİDİ :";
            // 
            // SipraisPaneli
            // 
            this.SipraisPaneli.Controls.Add(this.lblToplam);
            this.SipraisPaneli.Controls.Add(this.label10);
            this.SipraisPaneli.Controls.Add(this.button5);
            this.SipraisPaneli.Controls.Add(this.button4);
            this.SipraisPaneli.Controls.Add(this.comboBox5);
            this.SipraisPaneli.Controls.Add(this.button3);
            this.SipraisPaneli.Controls.Add(this.textBox3);
            this.SipraisPaneli.Controls.Add(this.label9);
            this.SipraisPaneli.Controls.Add(this.label7);
            this.SipraisPaneli.Controls.Add(this.comboBox3);
            this.SipraisPaneli.Controls.Add(this.comboBox2);
            this.SipraisPaneli.Controls.Add(this.label6);
            this.SipraisPaneli.Controls.Add(this.label3);
            this.SipraisPaneli.Enabled = false;
            this.SipraisPaneli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SipraisPaneli.Location = new System.Drawing.Point(47, 78);
            this.SipraisPaneli.Name = "SipraisPaneli";
            this.SipraisPaneli.Size = new System.Drawing.Size(316, 415);
            this.SipraisPaneli.TabIndex = 11;
            this.SipraisPaneli.Visible = false;
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(172, 286);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(112, 20);
            this.lblToplam.TabIndex = 17;
            this.lblToplam.Text = "Toplam : 0TL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Adet :";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(3, 363);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 49);
            this.button5.TabIndex = 15;
            this.button5.Text = "Geriye Dön";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(116, 363);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 49);
            this.button4.TabIndex = 15;
            this.button4.Text = "Siparişi İptal Et";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox5.Location = new System.Drawing.Point(110, 283);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(52, 28);
            this.comboBox5.TabIndex = 14;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(226, 363);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 49);
            this.button3.TabIndex = 13;
            this.button3.Text = "Siparişi Tamamla";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(110, 216);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(174, 26);
            this.textBox3.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Adres :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "İL";
            // 
            // comboBox3
            // 
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(110, 159);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(174, 28);
            this.comboBox3.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Akdeniz Bölgesi",
            "Doğu Anadolu Bölgesi",
            "Ege Bölgesi",
            "Güneydoğu Anadolu Bölgesi",
            "İç Anadolu Bölgesi",
            "Marmara Bölgesi",
            "Karadeniz Bölgesi"});
            this.comboBox2.Location = new System.Drawing.Point(110, 99);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(174, 28);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "BÖLGE";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 77);
            this.label3.TabIndex = 2;
            this.label3.Text = "PİZZAGO SİPARİŞ EKRANI";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 543);
            this.ControlBox = false;
            this.Controls.Add(this.SipraisPaneli);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PİZZAGO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SipraisPaneli.ResumeLayout(false);
            this.SipraisPaneli.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox PeynirBox;
        private System.Windows.Forms.CheckBox ZeytinBox;
        private System.Windows.Forms.CheckBox TonBox;
        private System.Windows.Forms.CheckBox AncuezBox;
        private System.Windows.Forms.CheckBox MantarBox;
        private System.Windows.Forms.CheckBox MisirBox;
        private System.Windows.Forms.CheckBox SucukBox;
        private System.Windows.Forms.CheckBox SosisBox;
        private System.Windows.Forms.CheckBox SalamBox;
        private System.Windows.Forms.CheckBox DanaBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel SipraisPaneli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button5;
    }
}

