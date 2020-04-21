using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace PracticaORM
{
    public class Venta
    {
        int ventaID;
        DateTime fecha;
        int productoID;
        int clienteID;

        public int VentaID { get => ventaID; set => ventaID = value; }
        public int ProductoID { get => productoID; set => productoID = value; }
        public int ClienteID { get => clienteID; set => clienteID = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        public virtual Cliente ClienteNavigator { get; set; }
        public virtual Producto ProductoNavigator { get; set; }

    }
}
