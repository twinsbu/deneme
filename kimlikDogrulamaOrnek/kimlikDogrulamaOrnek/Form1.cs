using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kimlikDogrulamaOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 frm2 = new Form2();
        //Form1 formuna Form2yi tanıtıyoruz.
        Form3 formUc = new Form3();
        //Form1'e Form3 form ekranını tanıtıyoruz.
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tc, sifre;
            tc = textBox1.Text;
            sifre = textBox2.Text;
            if (tc=="12345678910" && sifre=="123")
            {
                MessageBox.Show("GİRİŞ BAŞARILI :)");
                frm2.Show();//Form2 ekranını aç.
                this.Hide();//Bu formu gizle.
            }
            else
            {
                MessageBox.Show("GİRİŞ BAŞARISIZ :(");
                formUc.Show();//Form3 adlı formu aç.

            }
        }
    }
}
