using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos
{
    public class Facturacion
    {
        //Atributos
        private string producto;
        private decimal precio;
        private int cantidad;
        private decimal total;

        public string Producto { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }

        public Facturacion()
        {
        }

        //Constructores
        public Facturacion(string producto, decimal precio, int cantidad, decimal total)
        {
            Producto = producto;
            Cantidad = cantidad;
            Precio = precio;
            Total = total;
        }

        //Metodos
        public string DevolverDatos()
        {
            return "Producto" + producto + "Cantidad" + cantidad + "Precio" + Precio + "Total" + total;
        }

    }
}
