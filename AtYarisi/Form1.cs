using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //global alana 3 adet değişken tanımladık.
        int birinciatsolauzaklık, ikinciatsolauzaklık, ucuncuatsolauzaklık;
        Random rastgele = new Random();

        private void btnstart_Click(object sender, EventArgs e)
        {
            timer.Enabled = true; //butona tıklandığında timer aktif olsun.

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int birinciatingenisligi = pcrbox1.Width;
            int ikinciatingenisligi = pcrbox2.Width;
            int ucuncuatingenisligi = pcrbox3.Width;

            int bitisuzakligi = lblfinish.Left;

            pcrbox1.Left = pcrbox1.Left + rastgele.Next(5, 15);
            pcrbox2.Left = pcrbox2.Left + rastgele.Next(5, 15);
            pcrbox3.Left = pcrbox3.Left + rastgele.Next(5, 15);

            if (pcrbox1.Left > pcrbox2.Left+ 5 && pcrbox2.Left > pcrbox3.Left + 5)
            {
                lblanlik.Text = "1 numaralı at yarışı önde götürüyor.";
            }
            if (pcrbox2.Left > pcrbox1.Left + 5 && pcrbox1.Left > pcrbox3.Left + 5)
            {
                lblanlik.Text = "2 numaralı at yarışı önde götürüyor.";
            }
            if (pcrbox3.Left > pcrbox2.Left + 5 && pcrbox2.Left > pcrbox1.Left + 5)
            {
                lblanlik.Text = "3 numaralı at yarışı önde götürüyor.";
            }

            if (birinciatingenisligi+pcrbox1.Left>=bitisuzakligi)
            {
                timer.Enabled = false; //at bitişe geldiği anda timer dursun.
                MessageBox.Show( "1 numaralı at yarışı kazandı.");
            }
            if (ikinciatingenisligi+pcrbox2.Left>=bitisuzakligi)
            {
                timer.Enabled = false;
                MessageBox.Show("2 numaralı at yarışı kazandı.");
            }
            if (ucuncuatingenisligi+pcrbox3.Left>=bitisuzakligi)
            {
                timer.Enabled = false;
                MessageBox.Show("3 numaralı at yarışı kazandı.");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsolauzaklık = pcrbox1.Left;
            ikinciatsolauzaklık = pcrbox2.Left;
            ucuncuatsolauzaklık = pcrbox3.Left;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
