using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp53.Properties;
using System.Media;


namespace WindowsFormsApp53
{
    public partial class Form1 : Form
    {
        public Kart kart1;
        public Kart kart2;
        public Kart kart3;
        public Kart kart4;
        public Kart kart5;
        public Kart kart6;
        public Kart kart7;  
        public Kart kart8;
        public Kart kart9;
        public Kart kart10;
        public Kart kart11;  
        public Kart kart12;
        public Kart kart13;
        public Kart kart14;
        public Kart kart15;
        public Kart kart16;
        public Kart kart17;
        public Kart kart18;
        public Kart kart19;
        public Kart kart20;
        public Kart kart21;
        public Kart kart23;
        public Kart kart25;
        public Kart kart27;
        public Kart kart29;
        public Kart kart31;
        public Kart kart33;
        public Kart kart35;
        public Kart kart37;
        public Kart kart39;
        public Kart kart41;
        public Kart kart43;
        public Kart kart45;
        public Kart kart47;
        public Kart kart49;
        public Kart kart51;
        public Kart kart53;
        public Kart kart55;
        public Kart kart57;
        public Kart kart59;



        public static int kontrol = 0;
        public static int zincir = 0;
        public static int kart_sayisi=20;
        public static int havuzkartsayisi = 19;
     
        
        public void combo(int com)
        {
            zincir += com;
            kontrol += zincir;
            label_puan.Text=Convert.ToString(kontrol);
            label_combo.Text = Convert.ToString("+"+zincir);
            

        }

      

        public void kartsayisii(int ks)
        {
            kart_sayisi -= ks;
            label10.Text = Convert.ToString(kart_sayisi);
            label9.Text = Convert.ToString(20-kart_sayisi);
            if(kart_sayisi == 0)
            {
               timer1.Stop();
                Form8 form8= new Form8();
                form8.StartPosition = FormStartPosition.CenterScreen;
                form8.Show();
                
              
            }
            
        }
        public static int temizlenenkartsayısı = 20 - kart_sayisi;


        public void havuz()
        {
            havuzkartsayisi--;
            havuzkart.Text = Convert.ToString(havuzkartsayisi);    
            if(havuzkartsayisi == 0 && (pictureBox1.Visible==true||pictureBox10.Visible==true||pictureBox15.Visible==true||pictureBox20.Visible==true))
            {
                timer1.Stop();
                

            }

        }

        

      
        

        /*if (kart_sayisi != 0 && havuzkartsayisi == 0)
            {
               pictureBox79.Visible = true;


            }*/



    List<Kart> KartDestesi = new List<Kart>()
        {
            new Kart() {numara=1,adı="yesil1",resim="y1.jpg"},
            new Kart() {numara=1,adı="mavi1",resim="mavi1.jpg"},
            new Kart() {numara=1,adı="kirmizi1",resim="1.jpg"},
            new Kart() {numara=1,adı="mor1",resim="mor1.jpg"},

            new Kart() {numara=2,adı="yesil2",resim="y2.jpg"},
            new Kart() {numara=2,adı="mavi2",resim="mavi2.jpg"},
            new Kart() {numara=2,adı="kirmizi2",resim="2.jpg"},
            new Kart() {numara=2,adı="mor2",resim="mor2.jpg"},

            new Kart() {numara=3,adı="yesil3",resim="y3.jpg"},
            new Kart() {numara=3,adı="mavi3",resim="mavi3.jpg"},
            new Kart() {numara=3,adı="kirmizi3",resim="3.jpg"},
            new Kart() {numara=3,adı="mor3",resim="mor3.jpg"},

            new Kart() {numara=4,adı="yesil4",resim="y4.jpg"},
            new Kart() {numara=4,adı="mavi4",resim="mavi4.jpg"},
            new Kart() {numara=4,adı="kirmizi4",resim="4.jpg"},
            new Kart() {numara=4,adı="mor4",resim="mor4.jpg"},

            new Kart() {numara=5,adı="yesil5",resim="y5.jpg"},
            new Kart() {numara=5,adı="mavi5",resim="mavi5.jpg"},
            new Kart() {numara=5,adı="kirmizi5",resim="5.jpg"},
            new Kart() {numara=5,adı="mor5",resim="mor5.jpg"},

            new Kart() {numara=6,adı="yesil6",resim="y6.jpg"},
            new Kart() {numara=6,adı="mavi6",resim="mavi6.jpg"},
            new Kart() {numara=6,adı="kirmizi6",resim="6.jpg"},
            new Kart() {numara=6,adı="mor6",resim="mor6.jpg"},

            new Kart() {numara=7,adı="yesil7",resim="y7.jpg"},
            new Kart() {numara=7,adı="mavi7",resim="mavi7.jpg"},
            new Kart() {numara=7,adı="kirmizi7",resim="7.jpg"},
            new Kart() {numara=7,adı="mor7",resim="mor7.jpg"},

            new Kart() {numara=8,adı="yesil8",resim="y8.jpg"},
            new Kart() {numara=8,adı="mavi8",resim="mavi8.jpg"},
            new Kart() {numara=8,adı="kirmizi8",resim="8.jpg"},
            new Kart() {numara=8,adı="mor8",resim="mor8.jpg"},

            new Kart() {numara=9,adı="yesil9",resim="y9.jpg"},
            new Kart() {numara=9,adı="mavi9",resim="mavi9.jpg"},
            new Kart() {numara=9,adı="kirmizi9",resim="9.jpg"},
            new Kart() {numara=9,adı="mor9",resim="mor9.jpg"},

            new Kart() {numara=10,adı="yesil10",resim="y10.jpg"},
            new Kart() {numara=10,adı="mavi10",resim="mavi10.jpg"},
            new Kart() {numara=10,adı="kirmizi10",resim="10.jpg"},
            new Kart() {numara=10,adı="mor10",resim="mor10.jpg"},
        };
        public Form1()
        {
            InitializeComponent();
           
        }
       public static int dakika;
       public static int saniye;
        public void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            saniye++;

            
            
            if(saniye == 60)
            {
                saniye = 0;
                dakika++;
            }
            label1.Text = dakika.ToString()+":"+saniye.ToString();
            
            
        }

        




        Random r=new Random();

        private int KartKaristir()
        {
            int rastgelekart = r.Next(0, KartDestesi.Count);
            return rastgelekart;
        }

        List<int> kullanilankart = new List<int>()
        { };
        
        public void Form1_Load(object sender, EventArgs e)
        {

            timer1.Start();
            saniye = 0;
            dakika = 0;
            havuzkart.Text = "19";
            label_puan.Text = "0";
            label_combo.Text = "";
            label9.Text = "0";
            label10.Text = "20";
            kart_sayisi = 20;
            havuzkartsayisi = 19;
            kontrol = 0;
            zincir = 0;

            int rastgele = KartKaristir();
            kart1 = KartDestesi[rastgele];
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\" + kart1.resim);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            kart1 = KartDestesi[rastgele];
            kullanilankart.Add(rastgele);
         
            
            int rastgele2 = KartKaristir();
            kart2 = KartDestesi[rastgele2];           
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele2))
            {
                rastgele2 = KartKaristir();
            }
            rastgele2 = 1 * rastgele2;
            kart2 = KartDestesi[rastgele2];
            pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\" + kart2.resim);
            kullanilankart.Add(rastgele2);
 
            
            int rastgele3 = KartKaristir();
            kart3 = KartDestesi[rastgele3];            
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;            
            while (kullanilankart.Contains(rastgele3))
            {
                rastgele3 = KartKaristir();
            }
            rastgele3 = 1 * rastgele3;
            kart3 = KartDestesi[rastgele3];
            pictureBox3.Image = Image.FromFile(Application.StartupPath + "\\" + kart3.resim);
            kullanilankart.Add(rastgele3);
       

            int rastgele4 = KartKaristir();
            kart4 = KartDestesi[rastgele4];           
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele4))
            {
                rastgele4 = KartKaristir();
            }
            rastgele4 = 1 * rastgele4;
            kart4 = KartDestesi[rastgele4];
            pictureBox4.Image = Image.FromFile(Application.StartupPath + "\\" + kart4.resim);
            kullanilankart.Add(rastgele4);
      

            int rastgele5 = KartKaristir();
            kart5 = KartDestesi[rastgele5];          
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele5))
            {
                rastgele5 = KartKaristir();
            }
            rastgele5 = 1 * rastgele5;
            kart5 = KartDestesi[rastgele5];
            pictureBox5.Image = Image.FromFile(Application.StartupPath + "\\" + kart5.resim);
            kullanilankart.Add(rastgele5);
        


            int rastgele6 = KartKaristir();
            kart6 = KartDestesi[rastgele6];            
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele6))
            {
                rastgele6 = KartKaristir();
            }
            rastgele6 = 1 * rastgele6;
            kart6 = KartDestesi[rastgele6];
            pictureBox6.Image = Image.FromFile(Application.StartupPath + "\\" + kart6.resim);
            kullanilankart.Add(rastgele6);
            

            int rastgele7 = KartKaristir();
            kart7 = KartDestesi[rastgele7];
            pictureBox7.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele7))
            {
                rastgele7 = KartKaristir();
            }
            rastgele7 = 1 * rastgele7;
            kart7 = KartDestesi[rastgele7];
            pictureBox7.Image = Image.FromFile(Application.StartupPath + "\\" + kart7.resim);
            kullanilankart.Add(rastgele7);
            

            int rastgele8 = KartKaristir();
            kart8 = KartDestesi[rastgele8];
            pictureBox8.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele8))
            {
                rastgele8 = KartKaristir();
            }
            rastgele8 = 1 * rastgele8;
            kart8 = KartDestesi[rastgele8];
            pictureBox8.Image = Image.FromFile(Application.StartupPath + "\\" + kart8.resim);
            kullanilankart.Add(rastgele8);
            

            int rastgele9 = KartKaristir();
            kart9 = KartDestesi[rastgele9];
            pictureBox9.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele9))
            {
                rastgele9 = KartKaristir();
            }
            rastgele9 = 1 * rastgele9;
            kart9 = KartDestesi[rastgele9];
            pictureBox9.Image = Image.FromFile(Application.StartupPath + "\\" + kart9.resim);
            kullanilankart.Add(rastgele9);
            

            int rastgele10 = KartKaristir();
            kart10 = KartDestesi[rastgele10];
            pictureBox10.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele10))
            {
                rastgele10 = KartKaristir();
            }
            rastgele10 = 1 * rastgele10;
            kart10 = KartDestesi[rastgele10];
            pictureBox10.Image = Image.FromFile(Application.StartupPath + "\\" + kart10.resim);
            kullanilankart.Add(rastgele10);


           int rastgele11 = KartKaristir();
            kart11 = KartDestesi[rastgele11];
            pictureBox11.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele11))
            {
                rastgele11 = KartKaristir();
            }
            rastgele11 = 1 * rastgele11;
            kart11 = KartDestesi[rastgele11];
            pictureBox11.Image = Image.FromFile(Application.StartupPath + "\\" + kart11.resim);
            kullanilankart.Add(rastgele11);
            

            int rastgele12 = KartKaristir();
            kart12 = KartDestesi[rastgele12];
            pictureBox12.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele12))
            {
                rastgele12 = KartKaristir();
            }
            rastgele12 = 1 * rastgele12;
            kart12 = KartDestesi[rastgele12];
            pictureBox12.Image = Image.FromFile(Application.StartupPath + "\\" + kart12.resim);
            kullanilankart.Add(rastgele12);
            

            int rastgele13 = KartKaristir();
            kart13 = KartDestesi[rastgele13];
            pictureBox13.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele13))
            {
                rastgele13 = KartKaristir();
            }
            rastgele13 = 1 * rastgele13;
            kart13 = KartDestesi[rastgele13];
            pictureBox13.Image = Image.FromFile(Application.StartupPath + "\\" + kart13.resim);
            kullanilankart.Add(rastgele13);
           

            int rastgele14 = KartKaristir();
            kart14 = KartDestesi[rastgele14];
            pictureBox14.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele14))
            {
                rastgele14 = KartKaristir();
            }
            rastgele14 = 1 * rastgele14;
            kart14 = KartDestesi[rastgele14];
            pictureBox14.Image = Image.FromFile(Application.StartupPath + "\\" + kart14.resim);
            kullanilankart.Add(rastgele14);

            int rastgele15 = KartKaristir();
            kart15 = KartDestesi[rastgele15];
            pictureBox15.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele15))
            {
                rastgele15 = KartKaristir();
            }
            rastgele15 = 1 * rastgele15;
            kart15 = KartDestesi[rastgele15];
            pictureBox15.Image = Image.FromFile(Application.StartupPath + "\\" + kart15.resim);
            kullanilankart.Add(rastgele15);


            int rastgele16 = KartKaristir();
            kart16 = KartDestesi[rastgele16];
            pictureBox16.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele16))
            {
                rastgele16 = KartKaristir();
            }
            rastgele16 = 1 * rastgele16;
            kart16 = KartDestesi[rastgele16];
            pictureBox16.Image = Image.FromFile(Application.StartupPath + "\\" + kart16.resim);
            kullanilankart.Add(rastgele16);


            int rastgele17 = KartKaristir();
            kart17 = KartDestesi[rastgele17];
            while (kullanilankart.Contains(rastgele17))
            {
                rastgele17 = KartKaristir();
            }
            rastgele17 = 1 * rastgele17;
            kart17 = KartDestesi[rastgele17];
            pictureBox17.Image = Image.FromFile(Application.StartupPath + "\\" + kart17.resim);
            kullanilankart.Add(rastgele17);

            int rastgele18 = KartKaristir();
            kart18 = KartDestesi[rastgele18];
            pictureBox18.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele18))
            {
                rastgele18 = KartKaristir();
            }
            rastgele18 = 1 * rastgele18;
            kart18 = KartDestesi[rastgele18];
            pictureBox18.Image = Image.FromFile(Application.StartupPath + "\\" + kart18.resim);
            kullanilankart.Add(rastgele18);

            int rastgele19 = KartKaristir();
            kart19 = KartDestesi[rastgele19];
            pictureBox19.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele19))
            {
                rastgele19 = KartKaristir();
            }
            rastgele19 = 1 * rastgele19;
            kart19 = KartDestesi[rastgele19];
            pictureBox19.Image = Image.FromFile(Application.StartupPath + "\\" + kart19.resim);
            kullanilankart.Add(rastgele19);

            int rastgele20 = KartKaristir();
            kart20 = KartDestesi[rastgele20];
            pictureBox20.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele20))
            {
                rastgele20 = KartKaristir();
            }
            rastgele20 = 1 * rastgele20;
            kart20 = KartDestesi[rastgele20];
            pictureBox20.Image = Image.FromFile(Application.StartupPath + "\\" + kart20.resim);
            kullanilankart.Add(rastgele20);


            int rastgele21 = KartKaristir();
            kart21 = KartDestesi[rastgele21];
            pictureBox21.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele21))
            {
                rastgele21 = KartKaristir();
            }
            rastgele21 = 1 * rastgele21;
            kart21 = KartDestesi[rastgele21];
            pictureBox21.Image = Image.FromFile(Application.StartupPath + "\\" + kart21.resim);
            kullanilankart.Add(rastgele21);



            int rastgele22 = KartKaristir();
            kart23 = KartDestesi[rastgele22];
            pictureBox23.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele22))
            {
                rastgele22 = KartKaristir();
            }
            rastgele22 = 1 * rastgele22;
            kart23 = KartDestesi[rastgele22];
            pictureBox23.Image = Image.FromFile(Application.StartupPath + "\\" + kart23.resim);
            kullanilankart.Add(rastgele22);

            int rastgele23 = KartKaristir();
            kart25 = KartDestesi[rastgele23];
            pictureBox25.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele23))
            {
                rastgele23 = KartKaristir();
            }
            rastgele23 = 1 * rastgele23;
            kart25 = KartDestesi[rastgele23];
            pictureBox25.Image = Image.FromFile(Application.StartupPath + "\\" + kart25.resim);
            kullanilankart.Add(rastgele23);

            int rastgele24 = KartKaristir();
            kart27 = KartDestesi[rastgele24];
            pictureBox27.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele24))
            {
                rastgele24 = KartKaristir();
            }
            rastgele24 = 1 * rastgele24;
            kart27 = KartDestesi[rastgele24];
            pictureBox27.Image = Image.FromFile(Application.StartupPath + "\\" + kart27.resim);
            kullanilankart.Add(rastgele24);



            int rastgele25 = KartKaristir();
            kart29 = KartDestesi[rastgele25];
            pictureBox29.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele25))
            {
                rastgele25 = KartKaristir();
            }
            rastgele25 = 1 * rastgele25;
            kart29 = KartDestesi[rastgele25];
            pictureBox29.Image = Image.FromFile(Application.StartupPath + "\\" + kart29.resim);
            kullanilankart.Add(rastgele25);

            int rastgele26 = KartKaristir();
            kart31 = KartDestesi[rastgele26];
            pictureBox31.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele26))
            {
                rastgele26 = KartKaristir();
            }
            rastgele26 = 1 * rastgele26;
            kart31 = KartDestesi[rastgele26];
            pictureBox31.Image = Image.FromFile(Application.StartupPath + "\\" + kart31.resim);
            kullanilankart.Add(rastgele26);

            int rastgele27 = KartKaristir();
            kart33 = KartDestesi[rastgele27];
            pictureBox33.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele27))
            {
                rastgele27 = KartKaristir();
            }
            rastgele27 = 1 * rastgele27;
            kart33 = KartDestesi[rastgele27];
            pictureBox33.Image = Image.FromFile(Application.StartupPath + "\\" + kart33.resim);
            kullanilankart.Add(rastgele27);

            int rastgele28 = KartKaristir();
            kart35 = KartDestesi[rastgele28];
            pictureBox35.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele28))
            {
                rastgele28 = KartKaristir();
            }
            rastgele28 = 1 * rastgele28;
            kart35 = KartDestesi[rastgele28];
            pictureBox35.Image = Image.FromFile(Application.StartupPath + "\\" + kart35.resim);
            kullanilankart.Add(rastgele28);

            int rastgele29 = KartKaristir();
            kart37 = KartDestesi[rastgele29];
            pictureBox37.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele29))
            {
                rastgele29 = KartKaristir();
            }
            rastgele29 = 1 * rastgele29;
            kart37 = KartDestesi[rastgele29];
            pictureBox37.Image = Image.FromFile(Application.StartupPath + "\\" + kart37.resim);
            kullanilankart.Add(rastgele29);

            int rastgele30 = KartKaristir();
            kart39 = KartDestesi[rastgele30];
            pictureBox39.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele30))
            {
                rastgele30 = KartKaristir();
            }
            rastgele30 = 1 * rastgele30;
            kart39 = KartDestesi[rastgele30];
            pictureBox39.Image = Image.FromFile(Application.StartupPath + "\\" + kart39.resim);
            kullanilankart.Add(rastgele30);

            int rastgele31 = KartKaristir();
            kart41 = KartDestesi[rastgele31];
            pictureBox41.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele31))
            {
                rastgele31 = KartKaristir();
            }
            rastgele31 = 1 * rastgele31;
            kart41 = KartDestesi[rastgele31];
            pictureBox41.Image = Image.FromFile(Application.StartupPath + "\\" + kart41.resim);
            kullanilankart.Add(rastgele31);

            int rastgele32 = KartKaristir();
            kart43 = KartDestesi[rastgele32];
            pictureBox43.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele32))
            {
                rastgele32 = KartKaristir();
            }
            rastgele32 = 1 * rastgele32;
            kart43 = KartDestesi[rastgele32];
            pictureBox43.Image = Image.FromFile(Application.StartupPath + "\\" + kart43.resim);
            kullanilankart.Add(rastgele32);

            int rastgele33 = KartKaristir();
            kart45 = KartDestesi[rastgele33];
            pictureBox45.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele33))
            {
                rastgele33 = KartKaristir();
            }
            rastgele33 = 1 * rastgele33;
            kart45 = KartDestesi[rastgele33];
            pictureBox45.Image = Image.FromFile(Application.StartupPath + "\\" + kart45.resim);
            kullanilankart.Add(rastgele33);

            int rastgele34 = KartKaristir();
            kart47= KartDestesi[rastgele34];
            pictureBox47.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele34))
            {
                rastgele34 = KartKaristir();
            }
            rastgele34 = 1 * rastgele34;
            kart47 = KartDestesi[rastgele34];
            pictureBox47.Image = Image.FromFile(Application.StartupPath + "\\" + kart47.resim);
            kullanilankart.Add(rastgele34);

            int rastgele35 = KartKaristir();
            kart49 = KartDestesi[rastgele35];
            pictureBox49.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele35))
            {
                rastgele35 = KartKaristir();
            }
            rastgele35 = 1 * rastgele35;
            kart49 = KartDestesi[rastgele35];
            pictureBox49.Image = Image.FromFile(Application.StartupPath + "\\" + kart49.resim);
            kullanilankart.Add(rastgele35);

            int rastgele36 = KartKaristir();
            kart51 = KartDestesi[rastgele36];
            pictureBox51.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele36))
            {
                rastgele36 = KartKaristir();
            }
            rastgele36 = 1 * rastgele36;
            kart51 = KartDestesi[rastgele36];
            pictureBox51.Image = Image.FromFile(Application.StartupPath + "\\" + kart51.resim);
            kullanilankart.Add(rastgele36);

            int rastgele37 = KartKaristir();
            kart53 = KartDestesi[rastgele37];
            pictureBox53.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele37))
            {
                rastgele37 = KartKaristir();
            }
            rastgele37 = 1 * rastgele37;
            kart53 = KartDestesi[rastgele37];
            pictureBox53.Image = Image.FromFile(Application.StartupPath + "\\" + kart53.resim);
            kullanilankart.Add(rastgele37);

            int rastgele38 = KartKaristir();
            kart55 = KartDestesi[rastgele38];
            pictureBox55.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele38))
            {
                rastgele38 = KartKaristir();
            }
            rastgele38 = 1 * rastgele38;
            kart55 = KartDestesi[rastgele38];
            pictureBox55.Image = Image.FromFile(Application.StartupPath + "\\" + kart55.resim);
            kullanilankart.Add(rastgele38);

            int rastgele39 = KartKaristir();
            kart57 = KartDestesi[rastgele39];
            pictureBox57.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele39))
            {
                rastgele39 = KartKaristir();
            }
            rastgele39 = 1 * rastgele39;
            kart57 = KartDestesi[rastgele39];
            pictureBox57.Image = Image.FromFile(Application.StartupPath + "\\" + kart57.resim);
            kullanilankart.Add(rastgele39);

            int rastgele40 = KartKaristir();
            kart59 = KartDestesi[rastgele40];
            pictureBox59.SizeMode = PictureBoxSizeMode.AutoSize;
            while (kullanilankart.Contains(rastgele40))
            {
                rastgele40 = KartKaristir();
            }
            rastgele40 = 1 * rastgele40;
            kart59= KartDestesi[rastgele40];
            pictureBox59.Image = Image.FromFile(Application.StartupPath + "\\" + kart59.resim);
            kullanilankart.Add(rastgele40);

            

        }
       



        private void pictureBox23_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox22_Click_1(object sender, EventArgs e)
        {
            pictureBox59.Image = pictureBox21.Image;
            kart59.numara = kart21.numara;
            pictureBox22.Visible = false;
            pictureBox21.Visible = false;
            zincir = 0;
            label_combo.Text ="";
            havuz();
            SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\kart.wav";
            ses.SoundLocation = dizin;
            ses.Play();

            //liste=siyah kartlar görünmez olduğunda ekle liste
            //açık kartların değeriinin bir artı bir eksisini= (tıklanabilir listesi) konrol etme timerla
            //listenin içi 0 olduğunda finiş

        }

        private void pictureBox58_Click(object sender, EventArgs e)
        {
            pictureBox59.Image = pictureBox57.Image;
            kart59.numara = kart57.numara;
            pictureBox57.Visible = false;
            pictureBox58.Visible = false;
            zincir = 0;
            label_combo.Text = "";
            havuz();
            SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\kart.wav";
            ses.SoundLocation = dizin;
            ses.Play();

        }


        private void pictureBox56_Click_1(object sender, EventArgs e)
        {
            pictureBox59.Image = pictureBox55.Image;
            kart59.numara = kart55.numara;
            pictureBox56.Visible = false;
            pictureBox55.Visible = false;
            zincir = 0;
            label_combo.Text = "";
            havuz();
            SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\kart.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (kart1.numara + 1 == kart59.numara || kart1.numara - 1 == kart59.numara)
            {
                pictureBox59.Image = pictureBox1.Image;
                kart59.numara = kart1.numara;
                pictureBox1.Visible = false;
                combo(1);
                kartsayisii(1);
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\kart.wav";
                ses.SoundLocation = dizin;
                ses.Play();


            }



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (kart2.numara + 1 == kart59.numara || kart2.numara - 1 == kart59.numara)
            {
                pictureBox59.Image = pictureBox2.Image;
                kart59.numara = kart2.numara;
                pictureBox2.Visible = false;
                pictureBox60.Visible = false;
                combo(1);
                kartsayisii(1);
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\kart.wav";
                ses.SoundLocation = dizin;
                ses.Play();
            };


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (kart3.numara + 1 == kart59.numara || kart3.numara - 1 == kart59.numara)
            {
                pictureBox59.Image = pictureBox3.Image;
                kart59.numara = kart3.numara;
                pictureBox3.Visible = false;
                pictureBox61.Visible = false;
                combo(1);
                kartsayisii(1);
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\kart.wav";
                ses.SoundLocation = dizin;
                ses.Play();
            };

        }


        private void pictureBox54_Click(object sender, EventArgs e)
        {
            pictureBox59.Image = pictureBox53.Image;
            kart59.numara = kart53.numara;
            pictureBox54.Visible = false;
            pictureBox53.Visible = false;
            havuz();
            SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\kart.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (kart5.numara + 1 == kart59.numara || kart5.numara - 1 == kart59.numara)
            {

                pictureBox59.Image = pictureBox5.Image;
                kart59.numara = kart5.numara;
                pictureBox5.Visible = false;
                pictureBox63.Visible = false;
                combo(1);
                kartsayisii(1);
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\kart.wav";
                ses.SoundLocation = dizin;
                ses.Play();

            };
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (kart4.numara + 1 == kart59.numara || kart4.numara - 1 == kart59.numara)
            {
                pictureBox59.Image = pictureBox4.Image;
                kart59.numara = kart4.numara;
                pictureBox4.Visible = false;
                pictureBox62.Visible = false;
                combo(1);
                kartsayisii(1);
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\kart.wav";
                ses.SoundLocation = dizin;
                ses.Play();
            };


        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (kart6.numara + 1 == kart59.numara || kart6.numara - 1 == kart59.numara)
            {
                pictureBox59.Image = pictureBox6.Image;
                kart59.numara = kart6.numara;
                pictureBox6.Visible = false;
                pictureBox67.Visible = false;
                combo(1);
                kartsayisii(1);
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\kart.wav";
                ses.SoundLocation = dizin;
                ses.Play();

            };

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (kart7.numara + 1 == kart59.numara || kart7.numara - 1 == kart59.numara)
            {
                pictureBox59.Image = pictureBox7.Image;
                kart59.numara = kart7.numara;
                pictureBox7.Visible = false;
                pictureBox66.Visible = false;
                combo(1);
                kartsayisii(1);
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\kart.wav";
                ses.SoundLocation = dizin;
                ses.Play();
            };

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (kart8.numara + 1 == kart59.numara || kart8.numara - 1 == kart59.numara)
            {
                pictureBox59.Image = pictureBox8.Image;
                kart59.numara = kart8.numara;
                pictureBox8.Visible = false;
                pictureBox65.Visible = false;
                combo(1);
                kartsayisii(1);
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\kart.wav";
                ses.SoundLocation = dizin;
                ses.Play();
            };
  
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (kart9.numara + 1 == kart59.numara || kart9.numara - 1 == kart59.numara)
            {
                pictureBox59.Image = pictureBox9.Image;
                kart59.numara = kart9.numara;
                pictureBox9.Visible = false;
                pictureBox64.Visible = false;
                combo(1);
                kartsayisii(1);
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\kart.wav";
                ses.SoundLocation = dizin;
                ses.Play();
            };
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (kart10.numara + 1 == kart59.numara || kart10.numara - 1 == kart59.numara)
            {
                pictureBox59.Image = pictureBox10.Image;
                kart59.numara = kart10.numara;
                pictureBox10.Visible = false;
                combo(1);
                kartsayisii(1);
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\kart.wav";
                ses.SoundLocation = dizin;
                ses.Play();

            };
        }

        private void pictureBox52_Click_1(object sender, EventArgs e)
        {
            pictureBox59.Image = pictureBox51.Image;
            kart59.numara = kart51.numara;
            pictureBox52.Visible = false;
            pictureBox51.Visible = false;
            zincir = 0;
            label_combo.Text = "";
            havuz();
            SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\kart.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void pictureBox50_Click_1(object sender, EventArgs e)
        {
            pictureBox59.Image = pictureBox49.Image;
            kart59.numara = kart49.numara;
            pictureBox50.Visible = false;
            pictureBox49.Visible = false;
            zincir = 0;
            label_combo.Text = "";
            havuz();
            SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\kart.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void pictureBox48_Click_1(object sender, EventArgs e)
        {
            pictureBox59.Image = pictureBox47.Image;
            kart59.numara = kart47.numara;
            pictureBox48.Visible = false;
            pictureBox47.Visible = false;
            zincir = 0;
            label_combo.Text = "";
            havuz(); SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\kart.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void pictureBox46_Click_1(object sender, EventArgs e)
        {
            pictureBox59.Image = pictureBox45.Image;
            kart59.numara = kart45.numara;
            pictureBox46.Visible = false;
            pictureBox45.Visible = false;
            zincir = 0;
            label_combo.Text = "";
            havuz();
            SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\kart.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void pictureBox44_Click_1(object sender, EventArgs e)
        {
            pictureBox59.Image = pictureBox43.Image;
            kart59.numara = kart43.numara;
            pictureBox44.Visible = false;
            pictureBox43.Visible = false;
            zincir = 0;
            label_combo.Text = "";
            havuz();
            SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\kart.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void pictureBox42_Click_1(object sender, EventArgs e)
        {
            pictureBox59.Image = pictureBox41.Image;
            kart59.numara = kart41.numara;
            pictureBox42.Visible = false;
            pictureBox41.Visible = false;
            zincir = 0;
            label_combo.Text = "";
            havuz();
            SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\kart.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void pictureBox40_Click_1(object sender, EventArgs e)
        {
            pictureBox59.Image = pictureBox39.Image;
            kart59.numara = kart39.numara;
            pictureBox40.Visible = false;
            pictureBox39.Visible = false;
            zincir = 0;
            label_combo.Text = "";
            havuz();
            SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\kart.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void pictureBox38_Click_1(object sender, EventArgs e)
        {
            pictureBox59.Image = pictureBox37.Image;
            kart59.numara = kart37.numara;
            pictureBox38.Visible = false;
            pictureBox37.Visible = false;
            zincir = 0;
            label_combo.Text = "";
            havuz();
            SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\kart.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void pictureBox36_Click_1(object sender, EventArgs e)
        {
            pictureBox59.Image = pictureBox35.Image;
            kart59.numara = kart35.numara;
            pictureBox36.Visible = false;
            pictureBox35.Visible = false;
            zincir = 0;
            label_combo.Text = "";
            havuz();
            SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\kart.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void pictureBox34_Click_1(object sender, EventArgs e)
        {
            pictureBox59.Image = pictureBox33.Image;
            kart59.numara = kart33.numara;
            pictureBox34.Visible = false;
            pictureBox33.Visible = false;
            zincir = 0;
            label_combo.Text = "";
            havuz();
            SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\kart.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void pictureBox32_Click_1(object sender, EventArgs e)
        {
            pictureBox59.Image = pictureBox31.Image;
            kart59.numara = kart31.numara;
            pictureBox32.Visible = false;
            pictureBox31.Visible = false;
            zincir = 0;
            label_combo.Text = "";
            havuz();
            SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\kart.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void pictureBox30_Click_1(object sender, EventArgs e)
        {
            pictureBox59.Image = pictureBox29.Image;
            kart59.numara = kart29.numara;
            pictureBox30.Visible = false;
            pictureBox29.Visible = false;
            zincir = 0;
            label_combo.Text = "";
            havuz();
            SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\kart.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void pictureBox28_Click_1(object sender, EventArgs e)
        {
            pictureBox59.Image = pictureBox27.Image;
            kart59.numara = kart27.numara;
            pictureBox28.Visible = false;
            pictureBox27.Visible = false;
            zincir = 0;
            label_combo.Text = "";
            havuz();
            SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\kart.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void pictureBox26_Click_1(object sender, EventArgs e)
        {
            pictureBox59.Image = pictureBox25.Image;
            kart59.numara = kart25.numara;
            pictureBox26.Visible = false;
            pictureBox25.Visible = false;
            zincir = 0;
            label_combo.Text = "";
            havuz();
            SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\kart.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            pictureBox59.Image = pictureBox23.Image;
            kart59.numara = kart23.numara;
            pictureBox24.Visible = false;
            pictureBox23.Visible = false;
            zincir = 0;
            label_combo.Text = "";
            havuz();
            SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\kart.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }
       

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (kart11.numara + 1 == kart59.numara || kart11.numara - 1 == kart59.numara)
            {
                pictureBox59.Image = pictureBox11.Image;
                kart59.numara = kart11.numara;
                pictureBox11.Visible = false;
                pictureBox71.Visible = false;
                combo(1);
                kartsayisii(1);
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\kart.wav";
                ses.SoundLocation = dizin;
                ses.Play();

            };
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (kart12.numara + 1 == kart59.numara || kart12.numara - 1 == kart59.numara)
            {
                pictureBox59.Image = pictureBox12.Image;
                kart59.numara = kart12.numara;
                pictureBox12.Visible = false;
                pictureBox70.Visible = false;
                combo(1);
                kartsayisii(1);
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\kart.wav";
                ses.SoundLocation = dizin;
                ses.Play();

            };
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (kart13.numara + 1 == kart59.numara || kart13.numara - 1 == kart59.numara)
            {
                pictureBox59.Image = pictureBox13.Image;
                kart59.numara = kart13.numara;
                pictureBox13.Visible = false;
                pictureBox69.Visible = false;
                combo(1);
                kartsayisii(1);
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\kart.wav";
                ses.SoundLocation = dizin;
                ses.Play();

            };
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (kart14.numara + 1 == kart59.numara || kart14.numara - 1 == kart59.numara)
            {
                pictureBox59.Image = pictureBox14.Image;
                kart59.numara = kart14.numara;
                pictureBox14.Visible = false;
                pictureBox68.Visible = false;
                combo(1);
                kartsayisii(1);
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\kart.wav";
                ses.SoundLocation = dizin;
                ses.Play();
            };
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (kart15.numara + 1 == kart59.numara || kart15.numara - 1 == kart59.numara)
            {
                pictureBox59.Image = pictureBox15.Image;
                kart59.numara = kart15.numara;
                pictureBox15.Visible = false;
                combo(1);
                kartsayisii(1);
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\kart.wav";
                ses.SoundLocation = dizin;
                ses.Play();

            };
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (kart16.numara + 1 == kart59.numara || kart16.numara - 1 == kart59.numara)
            {
                pictureBox59.Image = pictureBox16.Image;
                kart59.numara = kart16.numara;
                pictureBox16.Visible = false;
                pictureBox75.Visible = false;
                combo(1);
                kartsayisii(1);
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\kart.wav";
                ses.SoundLocation = dizin;
                ses.Play();

            };
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            if (kart17.numara + 1 == kart59.numara || kart17.numara - 1 == kart59.numara)
            {
                pictureBox59.Image = pictureBox17.Image;
                kart59.numara = kart17.numara;
                pictureBox17.Visible = false;
                pictureBox74.Visible = false;
                combo(1);
                kartsayisii(1);
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\kart.wav";
                ses.SoundLocation = dizin;
                ses.Play();

            };
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            if (kart18.numara + 1 == kart59.numara || kart18.numara - 1 == kart59.numara)
            {
                pictureBox59.Image = pictureBox18.Image;
                kart59.numara = kart18.numara;
                pictureBox18.Visible = false;
                pictureBox73.Visible = false;
                combo(1);
                kartsayisii(1);
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\kart.wav";
                ses.SoundLocation = dizin;
                ses.Play();

            };
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            if (kart19.numara + 1 == kart59.numara || kart19.numara - 1 == kart59.numara)
            {
                pictureBox59.Image = pictureBox19.Image;
                kart59.numara = kart19.numara;
                pictureBox19.Visible = false;
                pictureBox72.Visible = false;
                combo(1);
                kartsayisii(1);
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\kart.wav";
                ses.SoundLocation = dizin;
                ses.Play();

            };
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            if (kart20.numara + 1 == kart59.numara || kart20.numara - 1 == kart59.numara)
            {
                pictureBox59.Image = pictureBox20.Image;
                kart59.numara = kart20.numara;
                pictureBox20.Visible = false;
                combo(1);
                kartsayisii(1);
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\kart.wav";
                ses.SoundLocation = dizin;
                ses.Play();


            };
        }

        private void pictureBox76_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void pictureBox77_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            dakika = 0;
            saniye = 0;
            
            Form1 form1=new Form1();
            form1.Show();
            this.Close();
            
            
            
            
        }

        private void havuzkart_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }



        /*private void label7_Click(object sender, EventArgs e)
        {

        }*/
    }

    }



public class Kart
{
    public int numara
    {
        get;
        set;
    }

    public string adı
    {
        get;
        set;
    }

    public string resim
    {
        get;
        set;
    }
}
