using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JosueRivera
{
    public partial class Tercer_Formulario : Form
    {
        public Tercer_Formulario()
        {
            InitializeComponent();
        }

        private string nombre;
        private string apellido;

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;
            listBox1.Items.Clear();
            numerosde1al100(num);
        }

        private void numerosde1al100(int numero)
        {

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    nombre = "Josue";
                    apellido = "Rivera";
                    listBox1.Items.Add(nombre + " " + apellido);
                }
                else if (i % 3 == 0)
                {
                    nombre = "Josue";
                    listBox1.Items.Add(nombre);
                }
                else if (i % 5 == 0)
                {
                    apellido = "Rivera";
                    listBox1.Items.Add(apellido);
                }
                else
                {
                    listBox1.Items.Add(i);
                }


            }

        }

    }
}
