using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruNo = 0, dogru = 0, yanlis=0;
        public string cevap;

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.SelectedItem.ToString();
            serialPort1.Open();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            cevap = textBox1.Text.ToLower();
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    textBox1.Enabled = false;
                    switch (soruNo)
                    {
                        case 1:
                            if (cevap == "akdeniz")
                            {
                                serialPort1.Write("1");
                                button1.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                serialPort1.Write("0");
                                button1.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();
                            }
                            textBox1.Text = "";
                            break;
                        case 2:
                            if (cevap == "bursa")
                            {
                                serialPort1.Write("1");
                                button2.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                serialPort1.Write("0");
                                button2.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();
                            }
                            textBox1.Text = "";
                            break;
                        case 3:
                            if (cevap == "cuma")
                            {
                                serialPort1.Write("1");
                                button3.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                serialPort1.Write("0");
                                button3.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();
                            }
                            textBox1.Text = "";
                            break;
                        case 4:
                            if (cevap == "diyarbakır")
                            {
                                serialPort1.Write("1");
                                button4.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                serialPort1.Write("0");
                                button4.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();
                            }
                            textBox1.Text = "";
                            break;
                        case 5:
                            if (cevap == "eski")
                            {
                                serialPort1.Write("1");
                                button5.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                serialPort1.Write("0");
                                button5.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();
                            }
                            textBox1.Text = "";
                            break;
                        case 6:
                            if (cevap == "ferman")
                            {
                                serialPort1.Write("1");
                                button6.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                serialPort1.Write("0");
                                button6.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();
                            }
                            textBox1.Text = "";
                            break;
                        case 7:
                            if (cevap == "güneş")
                            {
                                serialPort1.Write("1");
                                button7.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                serialPort1.Write("0");
                                button7.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();
                            }
                            textBox1.Text = "";
                            break;
                        case 8:
                            if (cevap == "halı")
                            {
                                serialPort1.Write("1");
                                button8.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                serialPort1.Write("0");
                                button8.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();
                            }
                            textBox1.Text = "";
                            break;
                        case 9:
                            if (cevap == "ısparta")
                            {
                                serialPort1.Write("1");
                                button9.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                serialPort1.Write("0");
                                button9.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();
                            }
                            textBox1.Text = "";
                            break;
                        case 10:
                            if (cevap == "içel")
                            {
                                serialPort1.Write("1");
                                button10.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                serialPort1.Write("0");
                                button10.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();
                            }
                            textBox1.Text = "";
                            break;
                        case 11:
                            if (cevap == "jandarma")
                            {
                                serialPort1.Write("1");
                                button11.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                serialPort1.Write("0");
                                button11.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();
                            }
                            textBox1.Text = "";
                            break;
                        case 12:
                            if (cevap == "kayısı")
                            {
                                serialPort1.Write("1");
                                button12.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                serialPort1.Write("0");
                                button12.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();
                            }
                            textBox1.Text = "";
                            break;
                        case 13:
                            if (cevap == "lale")
                            {
                                serialPort1.Write("1");
                                button13.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                serialPort1.Write("0");
                                button13.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();
                            }
                            textBox1.Text = "";
                            break;
                        case 14:
                            if (cevap == "mart")
                            {
                                serialPort1.Write("1");
                                button14.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                serialPort1.Write("0");
                                button14.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();
                            }
                            textBox1.Text = "";
                            break;
                        case 15:
                            if (cevap == "ney")
                            {
                                serialPort1.Write("1");
                                button15.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                serialPort1.Write("0");
                                button15.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();
                            }
                            textBox1.Text = "";
                            break;
                        case 16:
                            if (cevap == "ozan")
                            {
                                serialPort1.Write("1");
                                button16.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                serialPort1.Write("0");
                                button16.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();
                            }
                            textBox1.Text = "";
                            break;
                        case 17:
                            if (cevap == "pırasa")
                            {
                                serialPort1.Write("1");
                                button17.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                serialPort1.Write("0");
                                button17.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();
                            }
                            textBox1.Text = "";
                            break;
                        case 18:
                            if (cevap == "ramazan")
                            {
                                serialPort1.Write("1");
                                button18.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                serialPort1.Write("0");
                                button18.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();
                            }
                            textBox1.Text = "";
                            break;
                        case 19:
                            if (cevap == "snake")
                            {
                                serialPort1.Write("1");
                                button19.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                serialPort1.Write("0");
                                button19.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();
                            }
                            textBox1.Text = "";
                            break;
                        case 20:
                            if (cevap == "tarkan")
                            {
                                serialPort1.Write("1");
                                button20.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                serialPort1.Write("0");
                                button20.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();
                            }
                            textBox1.Text = "";
                            break;
                        case 21:
                            if (cevap == "umut")
                            {
                                serialPort1.Write("1");
                                button21.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                serialPort1.Write("0");
                                button21.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();
                            }
                            textBox1.Text = "";
                            break;
                        case 22:
                            if (cevap == "van")
                            {
                                serialPort1.Write("1");
                                button22.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                serialPort1.Write("0");
                                button22.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();
                            }
                            textBox1.Text = "";
                            break;
                        case 23:
                            if (cevap == "yıldırım")
                            {
                                serialPort1.Write("1");
                                button23.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                serialPort1.Write("0");
                                button23.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();
                            }
                            textBox1.Text = "";
                            break;
                        case 24:
                            if (cevap == "zeytin")
                            {
                                serialPort1.Write("1");
                                button24.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                serialPort1.Write("0");
                                button24.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();
                            }
                            textBox1.Text = "";
                            break;
                    }
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("Doğru portu seçtiğinizden emin olunuz!" + "\n" + exception,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error); }

            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (comboBox1.Text=="")
            {
                MessageBox.Show("Başlamak için sol alt köşeden port seçimi yapınız","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                linkLabel1.Text = "Sonraki";
                soruNo++;
                textBox1.Enabled = true;

                if (soruNo == 1)
                {
                    button25.Text = button1.Text;
                    richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi?";
                    button1.BackColor = Color.Yellow;
                }
                if (soruNo == 2)
                {
                    button25.Text = button2.Text;
                    richTextBox1.Text = "Yeşilliği ünlü Marmara ilimiz?";
                    button2.BackColor = Color.Yellow;
                }
                if (soruNo == 3)
                {
                    button25.Text = button3.Text;
                    richTextBox1.Text = "Müslümanlarn kutsal günü";
                    button3.BackColor = Color.Yellow;
                }
                if (soruNo == 4)
                {
                    button25.Text = button4.Text;
                    richTextBox1.Text = "Karpuzuyla ünlü ilimiz?";
                    button4.BackColor = Color.Yellow;
                }
                if (soruNo == 5)
                {
                    button25.Text = button5.Text;
                    richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı?";
                    button5.BackColor = Color.Yellow;
                }
                if (soruNo == 6)
                {
                    button25.Text = button6.Text;
                    richTextBox1.Text = "Padişahın emirlerinin yazılı hali?";
                    button6.BackColor = Color.Yellow;
                }
                if (soruNo == 7)
                {
                    button25.Text = button7.Text;
                    richTextBox1.Text = "Dünyanın ısı kaynağı?";
                    button7.BackColor = Color.Yellow;
                }
                if (soruNo == 8)
                {
                    button25.Text = button8.Text;
                    richTextBox1.Text = "Öğrencilerin kötü karne getirdiğinde bakıştığı nesne?";
                    button8.BackColor = Color.Yellow;
                }
                if (soruNo == 9)
                {
                    button25.Text = button9.Text;
                    richTextBox1.Text = "Gülü ile ünlü ilimiz";
                    button9.BackColor = Color.Yellow;
                }
                if (soruNo == 10)
                {
                    button25.Text = button10.Text;
                    richTextBox1.Text = "Mersin ilimizin diğer adı?";
                    button10.BackColor = Color.Yellow;
                }
                if (soruNo == 11)
                {
                    button25.Text = button11.Text;
                    richTextBox1.Text = "Askeri bir topluluk?";
                    button11.BackColor = Color.Yellow;
                }
                if (soruNo == 12)
                {
                    button25.Text = button12.Text;
                    richTextBox1.Text = "Malatya ilimizin meşhur meyvesi?";
                    button12.BackColor = Color.Yellow;
                }
                if (soruNo == 13)
                {
                    button25.Text = button13.Text;
                    richTextBox1.Text = "Her yıl bahar aylarında düzenlenen çiçek festivali?";
                    button13.BackColor = Color.Yellow;
                }
                if (soruNo == 14)
                {
                    button25.Text = button14.Text;
                    richTextBox1.Text = "Yılın üçüncü ayı?";
                    button14.BackColor = Color.Yellow;
                }
                if (soruNo == 15)
                {
                    button25.Text = button15.Text;
                    richTextBox1.Text = "Üflemeli bir müzik aleti?";
                    button15.BackColor = Color.Yellow;
                }
                if (soruNo == 16)
                {
                    button25.Text = button16.Text;
                    richTextBox1.Text = "Halk şairi?";
                    button16.BackColor = Color.Yellow;
                }
                if (soruNo == 17)
                {
                    button25.Text = button17.Text;
                    richTextBox1.Text = "Çocukların pek sevmediği pirinç, havuç gibi sebzeler ileyapılan yemek?";
                    button17.BackColor = Color.Yellow;
                }
                if (soruNo == 18)
                {
                    button25.Text = button18.Text;
                    richTextBox1.Text = "11 ayın sultanı?";
                    button18.BackColor = Color.Yellow;
                }
                if (soruNo == 19)
                {
                    button25.Text = button19.Text;
                    richTextBox1.Text = "İngilizcede yılan?";
                    button19.BackColor = Color.Yellow;
                }
                if (soruNo == 20)
                {
                    button25.Text = button20.Text;
                    richTextBox1.Text = "Türkiye'nin megastarı?";
                    button20.BackColor = Color.Yellow;
                }
                if (soruNo == 21)
                {
                    button25.Text = button21.Text;
                    richTextBox1.Text = "Ümit kelimesinin eş anlamlısı?";
                    button21.BackColor = Color.Yellow;
                }
                if (soruNo == 22)
                {
                    button25.Text = button22.Text;
                    richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz?";
                    button22.BackColor = Color.Yellow;
                }
                if (soruNo == 23)
                {
                    button25.Text = button23.Text;
                    richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı?";
                    button23.BackColor = Color.Yellow;
                }
                if (soruNo == 24)
                {
                    button25.Text = button24.Text;
                    richTextBox1.Text = "Daha çok Ege bölgesinde bulunan ve yağı da yapılan bir kahvaltı besini?";
                    button24.BackColor = Color.Yellow;
                }
                if (soruNo == 25)
                {
                    MessageBox.Show("Oyun Tamamlandı \n Dogru:" + label2.Text + "\n Yanlış: " + label4.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
