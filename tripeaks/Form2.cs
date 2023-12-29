using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace WindowsFormsApp53
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            
            SoundPlayer ses=new SoundPlayer();
            string dizin = Application.StartupPath + "\\müzik.wav";
                ses.SoundLocation = dizin;
            ses.Play();

        }
      



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1=new Form1();
            form1.Show();
            this.Hide();
            SoundPlayer ses = new SoundPlayer();
            ses.Stop();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form3 form3=new Form3();
            form3.Show();
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form7 form7=new Form7();
            form7.Show();
            this.Hide();
        }

       

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
            SoundPlayer ses = new SoundPlayer();
            ses.Stop();
            pictureBox5.Visible = false;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\müzik.wav";
            ses.SoundLocation = dizin;
            ses.Play();
            pictureBox5.Visible = true;
            
            
        }
    }
}
