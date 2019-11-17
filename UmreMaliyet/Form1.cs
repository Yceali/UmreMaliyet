using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UmreMaliyet
{
    public partial class Form1 : Form
    {
        float dolar_riyal = 3.75f;
        float visa;
        float religious;
        float transport;
        float guide;
        float gift;
        float free;
        float office;
        float totalexpanses;
        string[] packageType = {"1.Şişe Aziziye Bölgesi","2.Ribaş-Mahbes Bölgesi","3. Yürüme Mesafeli Bölge","4.3 Yıldız Pket (600-800 mt.)",
        "5.Anjum Otelli Paket","6.4 Yıldızlı Yürüme","7.5 Yıldızlı Yürüme","8.5 Yıldızlı Lüks", "9. Yeni Paket Oluştur"};
        float[] pacOnePrice = { 35, 115 };
        float[] pacTwoPrice = { 50, 115 };
        float[] pacThreePrice = { 130, 115 };
        float[] pacFourPrice = { 160, 250 };
        float[] pacFivePrice = { 300,325,370, 175 };
        float[] pacSixPrice = { 350, 450 };
        float[] pacSevenPrice = { 650, 750 };
        float[] pacEightPrice = { 750, 850 };
        float[] pacNinePrice = { 0, 0,0,0 };
        string[] airlines = { "THY", "SAHY", "ATLAS", "ONUR" };
        float[] airlinePrices = { 330.00f, 280.00f, 330.00f, 330.00f };
        float airlinePrice;

        float mekkeGece;
        float medineGece;

        float food;

        float companyProfit;
        float agencyProfit;

        float doubleRoom;
        float tripleRoom;
        float quadRoom;

        public Form1()
        {
            InitializeComponent();
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            SetDefaults();
            totalexpanses = visa + religious + transport + guide + gift + free + office;
            textBox1.Text = totalexpanses.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            comboBox1.Items.AddRange(packageType);
            comboBox2.Items.AddRange(airlines);
            panel1.Visible = false;
            panel2.Visible = false;
            SetDefaults();
        }

        private void SetDefaults()
        {
            visa = 26.67f;
            religious = 65.00f;
            transport = 14.67f;
            guide = 8.80f;
            gift = 20.00f;
            free = 0.00f;
            office = 30.00f;
            food = 4.54f;
            textBox9.Text = visa.ToString();
            textBox10.Text = religious.ToString();
            textBox11.Text = transport.ToString();
            textBox12.Text = guide.ToString();
            textBox13.Text = gift.ToString();
            textBox14.Text = free.ToString();
            textBox15.Text = office.ToString();
            textBox18.Text = food.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == packageType[0] && checkBox1.Checked)
            {
                doubleRoom = totalexpanses + (pacOnePrice[0]*mekkeGece/dolar_riyal/2) + (pacOnePrice[1]*medineGece/dolar_riyal/2) + airlinePrice + companyProfit + agencyProfit + ((medineGece+mekkeGece+1)*food);
                textBox6.Text = doubleRoom.ToString();
                tripleRoom = totalexpanses + (pacOnePrice[0] * mekkeGece / dolar_riyal / 3) + (pacOnePrice[1] * medineGece / dolar_riyal / 3) + airlinePrice + companyProfit + agencyProfit + ((medineGece + mekkeGece + 1) * food);
                textBox7.Text = tripleRoom.ToString();
                quadRoom = totalexpanses + (pacOnePrice[0] * mekkeGece / dolar_riyal / 4) + (pacOnePrice[1] * medineGece / dolar_riyal / 4) + airlinePrice + companyProfit + agencyProfit + ((medineGece + mekkeGece + 1) * food);
                textBox8.Text = quadRoom.ToString();
            }
            else if(comboBox1.Text == packageType[0])
            {
                doubleRoom = totalexpanses + (pacOnePrice[0] * mekkeGece / dolar_riyal / 2) + (pacOnePrice[1] * medineGece / dolar_riyal / 2) + airlinePrice + companyProfit + agencyProfit;
                textBox6.Text = doubleRoom.ToString();
                tripleRoom = totalexpanses + (pacOnePrice[0] * mekkeGece / dolar_riyal / 3) + (pacOnePrice[1] * medineGece / dolar_riyal / 3) + airlinePrice + companyProfit + agencyProfit;
                textBox7.Text = tripleRoom.ToString();
                quadRoom = totalexpanses + (pacOnePrice[0] * mekkeGece / dolar_riyal / 4) + (pacOnePrice[1] * medineGece / dolar_riyal / 4) + airlinePrice + companyProfit + agencyProfit;
                textBox8.Text = quadRoom.ToString();
            }

            if (comboBox1.Text == packageType[1] && checkBox1.Checked)
            {
                doubleRoom = totalexpanses + (pacTwoPrice[0] * mekkeGece / dolar_riyal / 2) + (pacTwoPrice[1] * medineGece / dolar_riyal / 2) + airlinePrice + companyProfit + agencyProfit + ((medineGece + mekkeGece + 1) * food);
                textBox6.Text = doubleRoom.ToString();
                tripleRoom = totalexpanses + (pacTwoPrice[0] * mekkeGece / dolar_riyal / 3) + (pacTwoPrice[1] * medineGece / dolar_riyal / 3) + airlinePrice + companyProfit + agencyProfit + ((medineGece + mekkeGece + 1) * food);
                textBox7.Text = tripleRoom.ToString();
                quadRoom = totalexpanses + (pacTwoPrice[0] * mekkeGece / dolar_riyal / 4) + (pacTwoPrice[1] * medineGece / dolar_riyal / 4) + airlinePrice + companyProfit + agencyProfit + ((medineGece + mekkeGece + 1) * food);
                textBox8.Text = quadRoom.ToString();
            }
            else if (comboBox1.Text == packageType[1])
            {
                doubleRoom = totalexpanses + (pacTwoPrice[0] * mekkeGece / dolar_riyal / 2) + (pacTwoPrice[1] * medineGece / dolar_riyal / 2) + airlinePrice + companyProfit + agencyProfit;
                textBox6.Text = doubleRoom.ToString();
                tripleRoom = totalexpanses + (pacTwoPrice[0] * mekkeGece / dolar_riyal / 3) + (pacTwoPrice[1] * medineGece / dolar_riyal / 3) + airlinePrice + companyProfit + agencyProfit;
                textBox7.Text = tripleRoom.ToString();
                quadRoom = totalexpanses + (pacTwoPrice[0] * mekkeGece / dolar_riyal / 4) + (pacTwoPrice[1] * medineGece / dolar_riyal / 4) + airlinePrice + companyProfit + agencyProfit;
                textBox8.Text = quadRoom.ToString();
            }

            if (comboBox1.Text == packageType[2] && checkBox1.Checked)
            {
                doubleRoom = totalexpanses + (pacThreePrice[0] * mekkeGece / dolar_riyal / 2) + (pacThreePrice[1] * medineGece / dolar_riyal / 2) + airlinePrice + companyProfit + agencyProfit + ((medineGece + mekkeGece + 1) * food);
                textBox6.Text = doubleRoom.ToString();
                tripleRoom = totalexpanses + (pacThreePrice[0] * mekkeGece / dolar_riyal / 3) + (pacThreePrice[1] * medineGece / dolar_riyal / 3) + airlinePrice + companyProfit + agencyProfit + ((medineGece + mekkeGece + 1) * food);
                textBox7.Text = tripleRoom.ToString();
                quadRoom = totalexpanses + (pacThreePrice[0] * mekkeGece / dolar_riyal / 4) + (pacThreePrice[1] * medineGece / dolar_riyal / 4) + airlinePrice + companyProfit + agencyProfit + ((medineGece + mekkeGece + 1) * food);
                textBox8.Text = quadRoom.ToString();
            }
            else if (comboBox1.Text == packageType[2])
            {
                doubleRoom = totalexpanses + (pacThreePrice[0] * mekkeGece / dolar_riyal / 2) + (pacThreePrice[1] * medineGece / dolar_riyal / 2) + airlinePrice + companyProfit + agencyProfit;
                textBox6.Text = doubleRoom.ToString();
                tripleRoom = totalexpanses + (pacThreePrice[0] * mekkeGece / dolar_riyal / 3) + (pacThreePrice[1] * medineGece / dolar_riyal / 3) + airlinePrice + companyProfit + agencyProfit;
                textBox7.Text = tripleRoom.ToString();
                quadRoom = totalexpanses + (pacThreePrice[0] * mekkeGece / dolar_riyal / 4) + (pacThreePrice[1] * medineGece / dolar_riyal / 4) + airlinePrice + companyProfit + agencyProfit;
                textBox8.Text = quadRoom.ToString();
            }

            if (comboBox1.Text == packageType[3] && checkBox1.Checked)
            {
                doubleRoom = totalexpanses + (pacFourPrice[0] * mekkeGece / dolar_riyal / 2) + (pacFourPrice[1] * medineGece / dolar_riyal / 2) + airlinePrice + companyProfit + agencyProfit + ((medineGece + mekkeGece + 1) * food);
                textBox6.Text = doubleRoom.ToString();
                tripleRoom = totalexpanses + (pacFourPrice[0] * mekkeGece / dolar_riyal / 3) + (pacFourPrice[1] * medineGece / dolar_riyal / 3) + airlinePrice + companyProfit + agencyProfit + ((medineGece + mekkeGece + 1) * food);
                textBox7.Text = tripleRoom.ToString();
                quadRoom = totalexpanses + (pacFourPrice[0] * mekkeGece / dolar_riyal / 4) + (pacFourPrice[1] * medineGece / dolar_riyal / 4) + airlinePrice + companyProfit + agencyProfit + ((medineGece + mekkeGece + 1) * food);
                textBox8.Text = quadRoom.ToString();
            }
            else if (comboBox1.Text == packageType[3])
            {
                doubleRoom = totalexpanses + (pacFourPrice[0] * mekkeGece / dolar_riyal / 2) + (pacFourPrice[1] * medineGece / dolar_riyal / 2) + airlinePrice + companyProfit + agencyProfit;
                textBox6.Text = doubleRoom.ToString();
                tripleRoom = totalexpanses + (pacFourPrice[0] * mekkeGece / dolar_riyal / 3) + (pacFourPrice[1] * medineGece / dolar_riyal / 3) + airlinePrice + companyProfit + agencyProfit;
                textBox7.Text = tripleRoom.ToString();
                quadRoom = totalexpanses + (pacFourPrice[0] * mekkeGece / dolar_riyal / 4) + (pacFourPrice[1] * medineGece / dolar_riyal / 4) + airlinePrice + companyProfit + agencyProfit;
                textBox8.Text = quadRoom.ToString();
            }

            if (comboBox1.Text == packageType[4] && checkBox1.Checked)
            {
                doubleRoom = totalexpanses + (pacFivePrice[0] * mekkeGece / dolar_riyal / 2) + (pacFivePrice[3] * medineGece / dolar_riyal / 2) + airlinePrice + companyProfit + agencyProfit + ((medineGece + mekkeGece + 1) * food);
                textBox6.Text = doubleRoom.ToString();
                tripleRoom = totalexpanses + (pacFivePrice[1] * mekkeGece / dolar_riyal / 3) + (pacFivePrice[3] * medineGece / dolar_riyal / 3) + airlinePrice + companyProfit + agencyProfit + ((medineGece + mekkeGece + 1) * food);
                textBox7.Text = tripleRoom.ToString();
                quadRoom = totalexpanses + (pacFivePrice[2] * mekkeGece / dolar_riyal / 4) + (pacFivePrice[3] * medineGece / dolar_riyal / 4) + airlinePrice + companyProfit + agencyProfit + ((medineGece + mekkeGece + 1) * food);
                textBox8.Text = quadRoom.ToString();
            }
            else if(comboBox1.Text == packageType[4])
            {
                doubleRoom = totalexpanses + (pacFivePrice[0] * mekkeGece / dolar_riyal / 2) + (pacFivePrice[3] * medineGece / dolar_riyal / 2) + airlinePrice + companyProfit + agencyProfit;
                textBox6.Text = doubleRoom.ToString();
                tripleRoom = totalexpanses + (pacFivePrice[1] * mekkeGece / dolar_riyal / 3) + (pacFivePrice[3] * medineGece / dolar_riyal / 3) + airlinePrice + companyProfit + agencyProfit;
                textBox7.Text = tripleRoom.ToString();
                quadRoom = totalexpanses + (pacFivePrice[2] * mekkeGece / dolar_riyal / 4) + (pacFivePrice[3] * medineGece / dolar_riyal / 4) + airlinePrice + companyProfit + agencyProfit;
                textBox8.Text = quadRoom.ToString();
            }

            if (comboBox1.Text == packageType[5] && checkBox1.Checked)
            {
                doubleRoom = totalexpanses + (pacSixPrice[0] * mekkeGece / dolar_riyal / 2) + (pacSixPrice[1] * medineGece / dolar_riyal / 2) + airlinePrice + companyProfit + agencyProfit + ((medineGece + mekkeGece + 1) * food);
                textBox6.Text = doubleRoom.ToString();
                tripleRoom = totalexpanses + (pacSixPrice[0] * mekkeGece / dolar_riyal / 3) + (pacSixPrice[1] * medineGece / dolar_riyal / 3) + airlinePrice + companyProfit + agencyProfit + ((medineGece + mekkeGece + 1) * food);
                textBox7.Text = tripleRoom.ToString();
                quadRoom = totalexpanses + (pacSixPrice[0] * mekkeGece / dolar_riyal / 4) + (pacSixPrice[1] * medineGece / dolar_riyal / 4) + airlinePrice + companyProfit + agencyProfit + ((medineGece + mekkeGece + 1) * food);
                textBox8.Text = quadRoom.ToString();
            }
            else if (comboBox1.Text == packageType[5])
            {
                doubleRoom = totalexpanses + (pacSixPrice[0] * mekkeGece / dolar_riyal / 2) + (pacSixPrice[1] * medineGece / dolar_riyal / 2) + airlinePrice + companyProfit + agencyProfit;
                textBox6.Text = doubleRoom.ToString();
                tripleRoom = totalexpanses + (pacSixPrice[0] * mekkeGece / dolar_riyal / 3) + (pacSixPrice[1] * medineGece / dolar_riyal / 3) + airlinePrice + companyProfit + agencyProfit;
                textBox7.Text = tripleRoom.ToString();
                quadRoom = totalexpanses + (pacSixPrice[0] * mekkeGece / dolar_riyal / 4) + (pacSixPrice[1] * medineGece / dolar_riyal / 4) + airlinePrice + companyProfit + agencyProfit;
                textBox8.Text = quadRoom.ToString();
            }

            if (comboBox1.Text == packageType[6] && checkBox1.Checked)
            {
                doubleRoom = totalexpanses + (pacSevenPrice[0] * mekkeGece / dolar_riyal / 2) + (pacSevenPrice[1] * medineGece / dolar_riyal / 2) + airlinePrice + companyProfit + agencyProfit + ((medineGece + mekkeGece + 1) * food);
                textBox6.Text = doubleRoom.ToString();
                tripleRoom = totalexpanses + (pacSevenPrice[0] * mekkeGece / dolar_riyal / 3) + (pacSevenPrice[1] * medineGece / dolar_riyal / 3) + airlinePrice + companyProfit + agencyProfit + ((medineGece + mekkeGece + 1) * food);
                textBox7.Text = tripleRoom.ToString();
                quadRoom = totalexpanses + (pacSevenPrice[0] * mekkeGece / dolar_riyal / 4) + (pacSevenPrice[1] * medineGece / dolar_riyal / 4) + airlinePrice + companyProfit + agencyProfit + ((medineGece + mekkeGece + 1) * food);
                textBox8.Text = quadRoom.ToString();
            }
            else if (comboBox1.Text == packageType[6])
            {
                doubleRoom = totalexpanses + (pacSevenPrice[0] * mekkeGece / dolar_riyal / 2) + (pacSevenPrice[1] * medineGece / dolar_riyal / 2) + airlinePrice + companyProfit + agencyProfit;
                textBox6.Text = doubleRoom.ToString();
                tripleRoom = totalexpanses + (pacSevenPrice[0] * mekkeGece / dolar_riyal / 3) + (pacSevenPrice[1] * medineGece / dolar_riyal / 3) + airlinePrice + companyProfit + agencyProfit;
                textBox7.Text = tripleRoom.ToString();
                quadRoom = totalexpanses + (pacSevenPrice[0] * mekkeGece / dolar_riyal / 4) + (pacSevenPrice[1] * medineGece / dolar_riyal / 4) + airlinePrice + companyProfit + agencyProfit;
                textBox8.Text = quadRoom.ToString();
            }

            if (comboBox1.Text == packageType[7] && checkBox1.Checked)
            {
                doubleRoom = totalexpanses + (pacEightPrice[0] * mekkeGece / dolar_riyal / 2) + (pacEightPrice[1] * medineGece / dolar_riyal / 2) + airlinePrice + companyProfit + agencyProfit + ((medineGece + mekkeGece + 1) * food);
                textBox6.Text = doubleRoom.ToString();
                tripleRoom = totalexpanses + (pacEightPrice[0] * mekkeGece / dolar_riyal / 3) + (pacEightPrice[1] * medineGece / dolar_riyal / 3) + airlinePrice + companyProfit + agencyProfit + ((medineGece + mekkeGece + 1) * food);
                textBox7.Text = tripleRoom.ToString();
                quadRoom = totalexpanses + (pacEightPrice[0] * mekkeGece / dolar_riyal / 4) + (pacEightPrice[1] * medineGece / dolar_riyal / 4) + airlinePrice + companyProfit + agencyProfit + ((medineGece + mekkeGece + 1) * food);
                textBox8.Text = quadRoom.ToString();
            }
            else if (comboBox1.Text == packageType[7])
            {
                doubleRoom = totalexpanses + (pacEightPrice[0] * mekkeGece / dolar_riyal / 2) + (pacEightPrice[1] * medineGece / dolar_riyal / 2) + airlinePrice + companyProfit + agencyProfit;
                textBox6.Text = doubleRoom.ToString();
                tripleRoom = totalexpanses + (pacEightPrice[0] * mekkeGece / dolar_riyal / 3) + (pacEightPrice[1] * medineGece / dolar_riyal / 3) + airlinePrice + companyProfit + agencyProfit;
                textBox7.Text = tripleRoom.ToString();
                quadRoom = totalexpanses + (pacEightPrice[0] * mekkeGece / dolar_riyal / 4) + (pacEightPrice[1] * medineGece / dolar_riyal / 4) + airlinePrice + companyProfit + agencyProfit;
                textBox8.Text = quadRoom.ToString();
            }

            if (comboBox1.Text == packageType[8] && checkBox1.Checked)
            {
                doubleRoom = totalexpanses + (pacNinePrice[0] * mekkeGece / dolar_riyal / 2) + (pacNinePrice[3] * medineGece / dolar_riyal / 2) + airlinePrice + companyProfit + agencyProfit + ((medineGece + mekkeGece + 1) * food);
                textBox6.Text = doubleRoom.ToString();
                tripleRoom = totalexpanses + (pacNinePrice[1] * mekkeGece / dolar_riyal / 3) + (pacNinePrice[3] * medineGece / dolar_riyal / 3) + airlinePrice + companyProfit + agencyProfit + ((medineGece + mekkeGece + 1) * food);
                textBox7.Text = tripleRoom.ToString();
                quadRoom = totalexpanses + (pacNinePrice[2] * mekkeGece / dolar_riyal / 4) + (pacNinePrice[3] * medineGece / dolar_riyal / 4) + airlinePrice + companyProfit + agencyProfit + ((medineGece + mekkeGece + 1) * food);
                textBox8.Text = quadRoom.ToString();
            }
            else if (comboBox1.Text == packageType[8])
            {
                doubleRoom = totalexpanses + (pacNinePrice[0] * mekkeGece / dolar_riyal / 2) + (pacNinePrice[3] * medineGece / dolar_riyal / 2) + airlinePrice + companyProfit + agencyProfit;
                textBox6.Text = doubleRoom.ToString();
                tripleRoom = totalexpanses + (pacNinePrice[1] * mekkeGece / dolar_riyal / 3) + (pacNinePrice[3] * medineGece / dolar_riyal / 3) + airlinePrice + companyProfit + agencyProfit;
                textBox7.Text = tripleRoom.ToString();
                quadRoom = totalexpanses + (pacNinePrice[2] * mekkeGece / dolar_riyal / 4) + (pacNinePrice[3] * medineGece / dolar_riyal / 4) + airlinePrice + companyProfit + agencyProfit;
                textBox8.Text = quadRoom.ToString();
            }

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if(float.TryParse(textBox2.Text,out mekkeGece))
            {
                mekkeGece = float.Parse(textBox2.Text);
            }
            else if (textBox2.Text == String.Empty)
            {
                textBox2.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Sadece Sayı Girin.");
                textBox2.Text = "";
            }
           
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBox3.Text, out medineGece))
            {
                medineGece = float.Parse(textBox3.Text);
            }
            else if (textBox3.Text == String.Empty)
            {
                textBox3.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Sadece Sayı Girin.");
                textBox3.Text = "";
            }
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBox4.Text, out companyProfit))
            {
                companyProfit = float.Parse(textBox4.Text);
            }
            else if (textBox4.Text == String.Empty)
            {
                textBox4.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Sadece Sayı Girin.");
                textBox4.Text = "";
            }
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBox5.Text, out agencyProfit))
            {
                agencyProfit = float.Parse(textBox5.Text);
            }
            else if (textBox5.Text == String.Empty)
            {
                textBox5.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Sadece Sayı Girin.");
                textBox5.Text = "";
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBox1.Text, out totalexpanses))
            {
                totalexpanses = float.Parse(textBox1.Text);
            }
            else if (textBox1.Text == String.Empty)
            {
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Sadece Sayı Girin.");
                textBox1.Text = "";
            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.Text == airlines[0])
            {
                airlinePrice = airlinePrices[0];
            }
            else if (comboBox2.Text == airlines[1])
            {
                airlinePrice = airlinePrices[1];
            }
            else if (comboBox2.Text == airlines[2])
            {
                airlinePrice = airlinePrices[2];
            }
            else if (comboBox2.Text == airlines[3])
            {
                airlinePrice = airlinePrices[3];
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            totalexpanses = visa + religious + transport + guide + gift + free + office;
            textBox1.Text = totalexpanses.ToString();
        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBox9.Text, out visa))
            {
                visa = float.Parse(textBox9.Text);
            }
            else if (textBox9.Text == String.Empty)
            {
                textBox9.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Sadece Sayı Girin.");
                textBox9.Text = "";
            }
        }

        private void TextBox10_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBox10.Text, out religious))
            {
                religious = float.Parse(textBox10.Text);
            }
            else if (textBox10.Text == String.Empty)
            {
                textBox10.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Sadece Sayı Girin.");
                textBox10.Text = "";
            }
        }

        private void TextBox11_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBox11.Text, out transport))
            {
                transport = float.Parse(textBox11.Text);
            }
            else if (textBox11.Text == String.Empty)
            {
                textBox11.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Sadece Sayı Girin.");
                textBox11.Text = "";
            }
        }

        private void TextBox12_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBox12.Text, out guide))
            {
                guide = float.Parse(textBox12.Text);
            }
            else if (textBox12.Text == String.Empty)
            {
                textBox12.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Sadece Sayı Girin.");
                textBox12.Text = "";
            }
        }

        private void TextBox13_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBox13.Text, out gift))
            {
                gift = float.Parse(textBox13.Text);
            }
            else if (textBox13.Text == String.Empty)
            {
                textBox13.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Sadece Sayı Girin.");
                textBox13.Text = "";
            }
        }

        private void TextBox14_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBox14.Text, out free))
            {
                free = float.Parse(textBox14.Text);
            }
            else if (textBox14.Text == String.Empty)
            {
                textBox14.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Sadece Sayı Girin.");
                textBox14.Text = "";
            }
        }

        private void TextBox15_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBox15.Text, out office))
            {
                office = float.Parse(textBox15.Text);
            }
            else if (textBox15.Text == String.Empty)
            {
                textBox15.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Sadece Sayı Girin.");
                textBox15.Text = "";
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void TextBox16_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBox16.Text, out pacNinePrice[0]))
            {
                pacNinePrice[0] = float.Parse(textBox16.Text);
            }
            else if (textBox16.Text == String.Empty)
            {
                textBox16.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Sadece Sayı Girin.");
                textBox16.Text = "";
            }
        }

        private void TextBox17_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBox17.Text, out pacNinePrice[3]))
            {
                pacNinePrice[3] = float.Parse(textBox17.Text);
            }
            else if (textBox17.Text == String.Empty)
            {
                textBox17.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Sadece Sayı Girin.");
                textBox17.Text = "";
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == packageType[8])
            {
                panel2.Visible = true;
            }
        }

        private void TextBox18_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBox18.Text, out food))
            {
                food = float.Parse(textBox18.Text);
            }
            else if (textBox18.Text == String.Empty)
            {
                textBox18.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Sadece Sayı Girin.");
                textBox18.Text = "";
            }
        }

        private void Label19_Click(object sender, EventArgs e)
        {

        }

        private void TextBox19_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBox19.Text, out pacNinePrice[1]))
            {
                pacNinePrice[1] = float.Parse(textBox19.Text);
            }
            else if (textBox19.Text == String.Empty)
            {
                textBox19.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Sadece Sayı Girin.");
                textBox19.Text = "";
            }
        }

        private void TextBox20_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBox20.Text, out pacNinePrice[2]))
            {
                pacNinePrice[2] = float.Parse(textBox20.Text);
            }
            else if (textBox20.Text == String.Empty)
            {
                textBox20.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Sadece Sayı Girin.");
                textBox20.Text = "";
            }
        }
    }
}
