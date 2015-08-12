using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }





        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor, ingrese solo números.");
                textBox1.Text.Remove(textBox1.Text.Length - 1);



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float QNH;
            float TRL;


            QNH = Convert.ToInt32(textBox1.Text);
            QNH = int.Parse(textBox1.Text);


            if (QNH > 942.2 && QNH < 959.4)
            {
                TRL = 090;
                MessageBox.Show("El TRL(en todos los aeropuertos) es: FL" + TRL);
            }
            else if (QNH > 959.5 && QNH < 977.1)
            {
                TRL = 085;
                MessageBox.Show("El TRL(en todos los aeropuertos) es: FL" + TRL);
            }
            else if (QNH > 977.2 && QNH < 995.0)
            {
                TRL = 080;
                MessageBox.Show("El TRL(en todos los aeropuertos) es: FL" + TRL);
            }
            else if (QNH > 995.1 && QNH < 1013.2)
            {
                TRL = 075;
                MessageBox.Show("El TRL(en todos los aeropuertos) es: FL" + TRL);
            }
            else if (QNH > 1013.3 && QNH < 1031.6)
            {
                TRL = 070;
                MessageBox.Show("El TRL(en todos los aeropuertos) es: FL" + TRL);
            }
            else if (QNH > 1031.7 && QNH < 1050.3)
            {
                TRL = 065;
                MessageBox.Show("El TRL(en todos los aeropuertos) es: FL" + TRL);
            }
                

        }

        private void button2_Click(object sender, EventArgs e)
        {
            float QNH;
            float TRL;


            QNH = Convert.ToInt32(textBox1.Text);
            QNH = int.Parse(textBox1.Text);

            if (QNH > 942.2 && QNH < 959.4)
            {
                TRL = 160;
                MessageBox.Show("El TRL(en TMA Madrid) es: FL" + TRL);
            }
            else if (QNH > 959.5 && QNH < 977.1)
            {
                TRL = 155;
                MessageBox.Show("El TRL(en TMA Madrid) es: FL" + TRL);
            }
            else if (QNH > 977.2 && QNH < 995.0)
            {
                TRL = 150;
                MessageBox.Show("El TRL(en TMA Madrid) es: FL" + TRL);
            }
            else if (QNH > 995.1 && QNH < 1013.2)
            {
                TRL = 145;
                MessageBox.Show("El TRL(en TMA Madrid) es: FL" + TRL);
            }
            else if (QNH > 1013.3 && QNH < 1031.6)
            {
                TRL = 140;
                MessageBox.Show("El TRL(en TMA Madrid) es: FL" + TRL);
            }
            else if (QNH > 1031.7 && QNH < 1050.3)
            {
                TRL = 135;
                MessageBox.Show("El TRL(en TMA Madrid) es: FL" + TRL);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            float QNH;
            float TRL;


            QNH = Convert.ToInt32(textBox1.Text);
            QNH = int.Parse(textBox1.Text);

            if (QNH > 942.2 && QNH < 959.4)
            {
                TRL = 100;
                MessageBox.Show("El TRL(Granada) es: FL" + TRL);
            }
            else if (QNH > 959.5 && QNH < 977.1)
            {
                TRL = 095;
                MessageBox.Show("El TRL(Granada) es: FL" + TRL);
            }
            else if (QNH > 977.2 && QNH < 995.0)
            {
                TRL = 090;
                MessageBox.Show("El TRL(Granada) es: FL" + TRL);
            }
            else if (QNH > 995.1 && QNH < 1013.2)
            {
                TRL = 085;
                MessageBox.Show("El TRL(Granada) es: FL" + TRL);
            }
            else if (QNH > 1013.3 && QNH < 1031.6)
            {
                TRL = 080;
                MessageBox.Show("El TRL(Granada) es: FL" + TRL);
            }
            else if (QNH > 1031.7 && QNH < 1050.3)
            {
                TRL = 075;
                MessageBox.Show("El TRL(en Granada) es: FL" + TRL);
            }
        }

    }
}

        

