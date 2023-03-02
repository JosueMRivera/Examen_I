using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Productos;

namespace JosueRivera
{
    public partial class Segundo_Formulario : Form
    {
        public Segundo_Formulario()
        {
            InitializeComponent();
        }

        decimal TotalP = 0;
        Facturacion misProductos = null;
        List<Facturacion> listaproductos = new List<Facturacion>();

        private void button1_Click(object sender, EventArgs e)
        {
            string producto = productotxt.Text;
            int cantidad = Convert.ToInt32(cantidadtxt.Text);
            decimal precio = Convert.ToDecimal(preciotxt.Text);
            decimal totalDGV = 0;

            misProductos = new Facturacion();
            misProductos.Producto = producto;
            misProductos.Cantidad = cantidad;
            misProductos.Precio = precio;
            misProductos.Total = totalDGV;

            listaproductos.Add(misProductos);
            ProductosDGV.DataSource = null;
            ProductosDGV.DataSource = listaproductos;
            limpiarControles();
            productotxt.Focus();
        }

        private void limpiarControles()
        {
            productotxt.Clear();
            cantidadtxt.Clear();
            preciotxt.Clear();

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ProductosDGV.Rows)
            {
                int cantidad = Convert.ToInt32(row.Cells[1].Value);

                int precio = Convert.ToInt32(row.Cells[2].Value);

                row.Cells[3].Value = Convert.ToString(precio * cantidad);

                TotalP += Convert.ToDecimal(row.Cells[3].Value);

            }

            decimal totalD = await descuentoAsync(TotalP);
            decimal TotalF = TotalP - totalD;

            MessageBox.Show("Costo total: " + TotalP + "\nDescuento (15%): " + totalD + "\n\nTotal a Pagar: " + TotalF);
            TotalP = 0;

        }

        private async Task<decimal> descuentoAsync(decimal total)
        {

            decimal descuento = await Task.Run(() =>
            {
                return total * Convert.ToDecimal(0.15);
            });
            return descuento;
        }
    }
}
