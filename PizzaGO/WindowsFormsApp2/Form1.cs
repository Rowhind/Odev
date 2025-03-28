﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int fiyat = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Enabled = false;
            label2.Enabled = false;
            label3.Enabled = false;
            SipraisPaneli.Enabled = true;
            SipraisPaneli.Visible = true;

            listBox1.Enabled = false;
            comboBox1.Enabled = false;
            groupBox1.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;

            
        }

        private void SalamBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SalamBox.Checked == true)
            {
                fiyat += 18;
                textBox2.Text = fiyat.ToString() + "TL";
            }
            else if (SalamBox.Checked == false)
            {
                fiyat -= 18;
                textBox2.Text = fiyat.ToString() + "TL";
            }
        }

        private void DanaBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DanaBox.Checked == true)
            {
                fiyat += 25;
                textBox2.Text = fiyat.ToString() + "TL";
            }
            else if (DanaBox.Checked == false)
            {
                fiyat -= 25;
                textBox2.Text = fiyat.ToString() + "TL";
            }
        }

        private void SosisBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SosisBox.Checked == true)
            {
                fiyat += 18;
                textBox2.Text = fiyat.ToString() + "TL";
            }
            else if (SosisBox.Checked == false)
            {
                fiyat -= 18;
                textBox2.Text = fiyat.ToString() + "TL";
            }
        }

        private void MisirBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MisirBox.Checked == true)
            {
                fiyat += 10;
                textBox2.Text = fiyat.ToString() + "TL";
            }
            else if (MisirBox.Checked == false)
            {
                fiyat -= 10;
                textBox2.Text = fiyat.ToString() + "TL";
            }
        }

        private void AncuezBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AncuezBox.Checked == true)
            {
                fiyat += 12;
                textBox2.Text = fiyat.ToString() + "TL";
            }
            else if (AncuezBox.Checked == false)
            {
                fiyat -= 12;
                textBox2.Text = fiyat.ToString() + "TL";
            }
        }

        private void ZeytinBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ZeytinBox.Checked == true)
            {
                fiyat += 8;
                textBox2.Text = fiyat.ToString() + "TL";
            }
            else if (ZeytinBox.Checked == false)
            {
                fiyat -= 8;
                textBox2.Text = fiyat.ToString() + "TL";
            }
        }

        private void PeynirBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PeynirBox.Checked == true)
            {
                fiyat += 5;
                textBox2.Text = fiyat.ToString() + "TL";
            }
            else if (PeynirBox.Checked == false)
            {
                fiyat -= 5;
                textBox2.Text = fiyat.ToString() + "TL";
            }
        }

        private void TonBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TonBox.Checked == true)
            {
                fiyat += 20;
                textBox2.Text = fiyat.ToString() + "TL";
            }
            else if (TonBox.Checked == false)
            {
                fiyat -= 20;
                textBox2.Text = fiyat.ToString() + "TL";
            }
        }

        private void MantarBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MantarBox.Checked == true)
            {
                fiyat += 15;
                textBox2.Text = fiyat.ToString() + "TL";
            }
            else if (MantarBox.Checked == false)
            {
                fiyat -= 15;
                textBox2.Text = fiyat.ToString() + "TL";
            }
        }

        private void SucukBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SucukBox.Checked == true)
            {
                fiyat += 18;
                textBox2.Text = fiyat.ToString() + "TL";
            }
            else if (SucukBox.Checked == false)
            {
                fiyat -= 18;
                textBox2.Text = fiyat.ToString() + "TL";
            }
        }
        bool tiklanmaInce = false;
        bool tiklanmaKalin = false;
        
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
           
        {
            
        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
            groupBox1.Enabled = true;
            if (radioButton1.Checked == true)
            {
                tiklanmaInce = true;

                if (tiklanmaKalin == true)
                {
                    fiyat -= 10;

                }
                else
                {
                    fiyat += 15;
                }
                
                textBox2.Text = fiyat.ToString();
                textBox2.Text += "TL";

            }
            else if (radioButton2.Checked == true)
            {
                tiklanmaKalin = true;
                if (tiklanmaInce == true)
                {
                    fiyat += 10;
                    
                }
                else
                {
                    fiyat += 25;
                }
                    textBox2.Text = fiyat.ToString();
                    textBox2.Text += "TL";
            }
        }
        bool kucukboy = false;
        bool ortaboy = false;
        bool buyukboy = false;
        bool doubleboy = false;
        bool extralarge = false;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (comboBox1.SelectedIndex == 0)
            {
                kucukboy = true;

                if (ortaboy == true)
                {
                    fiyat -= 20;

                }
                else if (buyukboy == true)
                {
                    fiyat -= 40;
                }
                else if (doubleboy == true)
                {
                    fiyat -= 70;
                }
                else if (extralarge == true)
                {
                    fiyat -= 110;
                }
                else
                {
                    fiyat += 90;
                }

                    ortaboy = false;
                buyukboy = false;
                doubleboy = false;
                extralarge = false;
            }
            else if (comboBox1.SelectedIndex == 1) 
            {
                ortaboy = true;

                if (kucukboy == true)
                {
                    fiyat += 20;

                }
                else if (buyukboy == true)
                {
                    fiyat -= 20;
                }
                else if (doubleboy == true)
                {
                    fiyat -= 50;
                }
                else if (extralarge == true)
                {
                    fiyat -= 90;
                }
                else
                {
                    fiyat += 110;
                }
                kucukboy = false;
                
                buyukboy = false;
                doubleboy = false;
                extralarge = false;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                buyukboy = true;

                if (kucukboy == true)
                {
                    fiyat += 40;

                }
                else if (ortaboy == true)
                {
                    fiyat += 20;
                }
                else if (doubleboy == true)
                {
                    fiyat -= 30;
                }
                else if (extralarge == true)
                {
                    fiyat -= 70;
                }
                else
                {
                    fiyat += 130;
                }
               
                
                kucukboy = false;
                ortaboy = false;
                
                doubleboy = false;
                extralarge = false;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                doubleboy = true;

                if (kucukboy == true)
                {
                    fiyat += 70;

                }
                else if (ortaboy == true)
                {
                    fiyat += 50;
                }
                else if (buyukboy == true)
                {
                    fiyat += 30;
                }
                else if (extralarge == true)
                {
                    fiyat -= 40;
                }
                else
                {
                    fiyat += 160;
                }
                
                
                kucukboy = false;
                ortaboy = false;
                buyukboy = false;
                
                extralarge = false;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                extralarge = true;

                if (kucukboy == true)
                {
                    fiyat += 110;

                }
                else if (ortaboy == true)
                {
                    fiyat += 90;
                }
                else if (buyukboy == true)
                {
                    fiyat += 70;
                }
                else if (doubleboy == true)
                {
                    fiyat += 40;
                }
                else
                {
                    fiyat += 200;
                }
                
                
                kucukboy = false;
                ortaboy = false;
                buyukboy = false;
                doubleboy = false;
                
            }


            textBox2.Text = fiyat.ToString() + "TL";

            radioButton1.Enabled = true;
            radioButton2.Enabled = true;

        }   
            
        private void textBox1_TextChanged(object sender, EventArgs e)
        {       
            /*
            try
            {
                fiyat = fiyat * Int32.Parse(textBox1.Text);

                textBox2.Text = fiyat.ToString();
                textBox2.Text += "TL";
            }
            catch
            {
                MessageBox.Show("Lütfen sadece sayı giriniz...");
            }
            */
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            

           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
        }
        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        int toplamfiyat = 0;
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            toplamfiyat = Convert.ToInt32(comboBox5.SelectedItem) * fiyat;

            lblToplam.Text = "Toplam : "+toplamfiyat.ToString() + "TL";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siparişiniz İptal Edilmiştir.");
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox3.Enabled = true;
            if(comboBox2.SelectedIndex == 0)
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Adana");
                comboBox3.Items.Add("Antalya");
                comboBox3.Items.Add("Burdur");
                comboBox3.Items.Add("Hatay");
                comboBox3.Items.Add("Isparta");
                comboBox3.Items.Add("İçel");
                comboBox3.Items.Add("Kahramanmaraş");
                comboBox3.Items.Add("Osmaniye");
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Elaziğ");
                comboBox3.Items.Add("Erzincan");
                comboBox3.Items.Add("Erzurum");
                comboBox3.Items.Add("Malatya");
                comboBox3.Items.Add("Tunceli");
                comboBox3.Items.Add("Kars");
                comboBox3.Items.Add("Iğdır");
                comboBox3.Items.Add("Ardahan");
                comboBox3.Items.Add("Van");
                comboBox3.Items.Add("Bingöl");
                comboBox3.Items.Add("Hakkari");
                comboBox3.Items.Add("Bitlis");
                comboBox3.Items.Add("Ağrı");
                comboBox3.Items.Add("Muş");
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("İzmir");
                comboBox3.Items.Add("Manisa");
                comboBox3.Items.Add("Aydın");
                comboBox3.Items.Add("Uşak");
                comboBox3.Items.Add("Kütahya");
                comboBox3.Items.Add("Afyon");
                comboBox3.Items.Add("Denizli");
                comboBox3.Items.Add("Muğla");
                comboBox3.Items.Add("Çanakkale");
                comboBox3.Items.Add("Balıkesir");
                comboBox3.Items.Add("Bursa");
                comboBox3.Items.Add("Bilecik");
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Gaziantep");
                comboBox3.Items.Add("Şanlıurfa");
                comboBox3.Items.Add("Diyarbakır");
                comboBox3.Items.Add("Mardin");
                comboBox3.Items.Add("Adıyaman");
                comboBox3.Items.Add("Batman");
                comboBox3.Items.Add("Siirt");
                comboBox3.Items.Add("Kilis");
            }
            else if (comboBox2.SelectedIndex == 4)
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Ankara");
                comboBox3.Items.Add("Konya");
                comboBox3.Items.Add("Eskişehir");
                comboBox3.Items.Add("Kayseri");
                comboBox3.Items.Add("Sivas");
                comboBox3.Items.Add("Aksaray");
                comboBox3.Items.Add("Kırıkkale");
                comboBox3.Items.Add("Kırşehir");
                comboBox3.Items.Add("Nevşehir");
                comboBox3.Items.Add("Niğde");
                comboBox3.Items.Add("Yozgat");
                comboBox3.Items.Add("Karaman");
            }
            else if (comboBox2.SelectedIndex == 5)
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("İstanbul");
                comboBox3.Items.Add("Kırklareli");
                comboBox3.Items.Add("Tekirdağ");
                comboBox3.Items.Add("Çanakkale");
                comboBox3.Items.Add("Balıkesir");
                comboBox3.Items.Add("Kocaeli");
                comboBox3.Items.Add("Sakarya");
                comboBox3.Items.Add("Bilecik");
                comboBox3.Items.Add("Yalova");
            }
            else if (comboBox2.SelectedIndex == 6)
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Artvin");
                comboBox3.Items.Add("Rize");
                comboBox3.Items.Add("Trabzon");
                comboBox3.Items.Add("Giresun");
                comboBox3.Items.Add("Ordu");
                comboBox3.Items.Add("Gümüşhane");
                comboBox3.Items.Add("Bayburt");
                comboBox3.Items.Add("Samsun");               
                comboBox3.Items.Add("Amasya");
                comboBox3.Items.Add("Tokat");
                comboBox3.Items.Add("Sinop");
                comboBox3.Items.Add("Çorum");
                comboBox3.Items.Add("Kastamonu");
                comboBox3.Items.Add("Bartın");
                comboBox3.Items.Add("Karabük");
                comboBox3.Items.Add("Zonguldak");
                comboBox3.Items.Add("Düzce");
                comboBox3.Items.Add("Bolu");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SipraisPaneli.Enabled = false;
            SipraisPaneli.Visible = false;

            listBox1.Enabled = true;
            comboBox1.Enabled = true;
            groupBox1.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            comboBox5.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if((comboBox5.Items == null)||(textBox3.Text == "")||(comboBox3.Items == null))
            {
                MessageBox.Show("Lütfen Size Gösterilen Alanları Tam Doldurunuz...");
            }
            else
            {
                MessageBox.Show(



                    "Siparişinz Alınmıştır"
                    + Environment.NewLine + Environment.NewLine + "ADRES : " + comboBox3.SelectedItem + "," + textBox3.Text
                    + Environment.NewLine + Environment.NewLine + "Sipariş içeriği" + comboBox1.SelectedItem + ", " + listBox1.SelectedItem + " Pizza"
                    + Environment.NewLine + Environment.NewLine + "Bizi Tercih Ettiğiniz İçin Teşekkürler..."
                    );


                this.Close();
            }
                
        }
    }
}
