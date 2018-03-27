using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        static int m = 19;
        static int c = 19;
        static int ca = 19;
        Moto[] mot = new Moto[m];
        Carro[] car = new Carro[c];
        Camión[] cam = new Camión[ca];
        int ContadorM = 0;
        int ContadorC = 0;
        int Contadorca = 0;

        public Form2()
        {
            InitializeComponent();
          

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

      
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Faltan ingresar un Nombre");
            }
            else if (textBox2.Text.Equals(""))
            {
                MessageBox.Show("Faltan ingresar la Placa");
            }
            else if (textBox3.Text.Equals(""))
            {
                MessageBox.Show("Faltan ingresar el Nit");
            }
            else 
            {
                if (checkBox1.Checked == true)//Opcion Moto
                {
                    mot[ContadorM] = new Moto(textBox2.Text,textBox1.Text,textBox3.Text);
                    ContadorM = ContadorM + 1;
                }
                else if (checkBox2.Checked == true)//Opcion Carro
                {
                    car[ContadorC] = new Carro(textBox2.Text, textBox1.Text, textBox2.Text);
                    ContadorC = ContadorC + 1;
                }
                else if (checkBox3.Checked == true)//Opcion Camion
                {
                    cam[ContadorC] = new Camión(textBox2.Text, textBox1.Text, textBox2.Text);
                    Contadorca = Contadorca + 1;
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = true;
            checkBox3.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < ContadorM; x++)
            {
                
                Console.WriteLine(mot[x].Placa);
            }
        }
    }
}
