using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaORM
{
    public class Producto
    {
         int productoID;
         string codigo;
         string marca;
         decimal precio;

        public int ProductoID { get => productoID; set => productoID = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Marca { get => marca; set => marca = value; }
        public decimal Precio { get => precio; set => precio = value; }
    }
   
}
