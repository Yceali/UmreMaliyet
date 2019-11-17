namespace UmreMaliyet
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sabit Giderler";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Varsayılan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Paket Cinsi";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(194, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mekke Gece";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Medine Gece";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(194, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(194, 126);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(194, 155);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(193, 24);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Havayolu Şirketi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Şirket Karı";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(194, 186);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 12;
            this.textBox4.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(194, 215);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 13;
            this.textBox5.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Acente Karı";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 39);
            this.button2.TabIndex = 15;
            this.button2.Text = "Hesapla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(194, 319);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 16;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(194, 348);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "2\'li Oda";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "3\'lü Oda";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 377);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "4\'lü Oda";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(194, 377);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(309, 394);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 44);
            this.button3.TabIndex = 22;
            this.button3.Text = "Varsayılan Değerleri Düzenle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBox18);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.textBox15);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.textBox14);
            this.panel1.Controls.Add(this.textBox13);
            this.panel1.Controls.Add(this.textBox12);
            this.panel1.Controls.Add(this.textBox11);
            this.panel1.Controls.Add(this.textBox10);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Location = new System.Drawing.Point(75, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 350);
            this.panel1.TabIndex = 23;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(143, 273);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(100, 22);
            this.textBox18.TabIndex = 18;
            this.textBox18.TextChanged += new System.EventHandler(this.TextBox18_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(49, 273);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(51, 17);
            this.label25.TabIndex = 17;
            this.label25.Text = "Yemek";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(51, 304);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 30);
            this.button5.TabIndex = 16;
            this.button5.Text = "Varsayılan";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(152, 304);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 30);
            this.button4.TabIndex = 15;
            this.button4.Text = "Onayla";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(143, 244);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 22);
            this.textBox15.TabIndex = 14;
            this.textBox15.TextChanged += new System.EventHandler(this.TextBox15_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(48, 244);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 17);
            this.label18.TabIndex = 13;
            this.label18.Text = "Ofis";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(48, 215);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 17);
            this.label17.TabIndex = 12;
            this.label17.Text = "Free";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(48, 185);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 17);
            this.label16.TabIndex = 11;
            this.label16.Text = "Hediye";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(48, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 17);
            this.label15.TabIndex = 10;
            this.label15.Text = "Rehberlik";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(48, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 17);
            this.label14.TabIndex = 9;
            this.label14.Text = "Ulaşım";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(48, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 8;
            this.label13.Text = "Diyanet";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 17);
            this.label12.TabIndex = 7;
            this.label12.Text = "Vize";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(74, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 25);
            this.label11.TabIndex = 6;
            this.label11.Text = "Sabit Giderler";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(143, 215);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 22);
            this.textBox14.TabIndex = 5;
            this.textBox14.TextChanged += new System.EventHandler(this.TextBox14_TextChanged);
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(143, 185);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 22);
            this.textBox13.TabIndex = 4;
            this.textBox13.TextChanged += new System.EventHandler(this.TextBox13_TextChanged);
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(143, 156);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 22);
            this.textBox12.TabIndex = 3;
            this.textBox12.TextChanged += new System.EventHandler(this.TextBox12_TextChanged);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(143, 127);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 22);
            this.textBox11.TabIndex = 2;
            this.textBox11.TextChanged += new System.EventHandler(this.TextBox11_TextChanged);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(143, 98);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 22);
            this.textBox10.TabIndex = 1;
            this.textBox10.TextChanged += new System.EventHandler(this.TextBox10_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(143, 69);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 22);
            this.textBox9.TabIndex = 0;
            this.textBox9.TextChanged += new System.EventHandler(this.TextBox9_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 332);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.textBox20);
            this.panel2.Controls.Add(this.textBox19);
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.textBox17);
            this.panel2.Controls.Add(this.textBox16);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Location = new System.Drawing.Point(75, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 350);
            this.panel2.TabIndex = 17;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(76, 46);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(145, 17);
            this.label22.TabIndex = 6;
            this.label22.Text = "Yeni Paket Oluşturma";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(106, 255);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 29);
            this.button6.TabIndex = 5;
            this.button6.Text = "Onayla";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(166, 228);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(100, 22);
            this.textBox17.TabIndex = 4;
            this.textBox17.TextChanged += new System.EventHandler(this.TextBox17_TextChanged);
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(165, 89);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(100, 22);
            this.textBox16.TabIndex = 3;
            this.textBox16.TextChanged += new System.EventHandler(this.TextBox16_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label21.Location = new System.Drawing.Point(48, 287);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(206, 36);
            this.label21.TabIndex = 2;
            this.label21.Text = "Not: Otel gecelik fiyatlarını oda \r\nfiyatı ve riyal olarak giriniz.";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(25, 228);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(135, 17);
            this.label20.TabIndex = 1;
            this.label20.Text = "Medine Otel Gecelik";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(24, 92);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(128, 17);
            this.label19.TabIndex = 0;
            this.label19.Text = "Mekke Otel Double";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(12, 427);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(81, 13);
            this.label23.TabIndex = 25;
            this.label23.Text = "Pix-it Software®";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.Location = new System.Drawing.Point(108, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(220, 20);
            this.label24.TabIndex = 26;
            this.label24.Text = "Umre Maliyet Hesaplama";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(156, 243);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(178, 21);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "Yemek Ücretini Dahil Et";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(24, 124);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(119, 17);
            this.label26.TabIndex = 7;
            this.label26.Text = "Mekke Otel Triple";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(24, 156);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(118, 17);
            this.label27.TabIndex = 8;
            this.label27.Text = "Mekke Otel Quad";
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(165, 122);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(100, 22);
            this.textBox19.TabIndex = 9;
            this.textBox19.TextChanged += new System.EventHandler(this.TextBox19_TextChanged);
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(165, 157);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(100, 22);
            this.textBox20.TabIndex = 10;
            this.textBox20.TextChanged += new System.EventHandler(this.TextBox20_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(458, 449);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 500);
            this.MinimumSize = new System.Drawing.Size(480, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UMP v1.2.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
    }
}

