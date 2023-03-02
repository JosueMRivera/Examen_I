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
    public partial class Primer_Formulario : Form
    {
        public Primer_Formulario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            //Fecha y Tiempo
            DateTime fecha = fechatxt.Value;
            string nuevafecha;
            string periodotiempo = periodotiempoCB.Text;
            int tiempo = Convert.ToInt32(periodotiempotxt.Text);

            //Capital y Tasa
            decimal capital = Convert.ToDecimal(cantidadtx.Text);
            decimal tasa = Convert.ToDecimal(tasatxt.Text);
            decimal interesperiodo;
            decimal capitalperiodo;
            decimal total;

            //Funciones
            decimal interestotal = interes(capital, tasa);
            decimal capitaltotal = Capital(capital, tiempo);


            if (periodotiempo == "Diario")
            {
                for (int i = 1; i <= tiempo; i++)
                {
                    nuevafecha = fecha.AddDays(i - 1).ToString("d");
                    interesperiodo = interestotal * i;
                    capitalperiodo = (int)(capitaltotal * i);
                    total = interesperiodo + capitalperiodo;
                    dataGridView1.Rows.Add(nuevafecha, interesperiodo, capitalperiodo, total);
                }
            }
            if (periodotiempo == "Mensual")
            {
                for (int i = 1; i <= tiempo; i++)
                {
                    nuevafecha = fecha.AddMonths(i - 1).ToString("MMMM");
                    interesperiodo = interestotal * (i);
                    capitalperiodo = (int)(capitaltotal * i);
                    total = interesperiodo + capitalperiodo;
                    dataGridView1.Rows.Add(nuevafecha, interesperiodo, capitalperiodo, total);
                }
            }
            if (periodotiempo == "Anual")
            {
                for (int i = 1; i <= tiempo; i++)
                {
                    nuevafecha = fecha.AddYears(i - 1).ToString("yyyy");
                    interesperiodo = interestotal * i;
                    capitalperiodo = (int)(capitaltotal * i);
                    total = interesperiodo + capitalperiodo;
                    dataGridView1.Rows.Add(nuevafecha, interesperiodo, capitalperiodo, total);
                }
            }
            cantidadtx.Focus();

        }

        private decimal interes(decimal capital, decimal tasa)
        {
            decimal Interes = capital * (tasa / 100);
            return Interes;
        }

        private decimal Capital(decimal capital, decimal tiempo)
        {
            decimal capitalt = capital / tiempo;
            return capitalt;
        }

    }
}
