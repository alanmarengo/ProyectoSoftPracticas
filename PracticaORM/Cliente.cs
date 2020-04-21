using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaORM
{
    public class Cliente
    {

        int clienteID;
        string dni;
        string nombre;
        string apellido;
        string direccion;
        string telefono;

        public int ClienteID { get => ClienteID; set => ClienteID = value; }
        public string Dni { get => Dni; set => Dni = value; }
        public string Nombre { get => Nombre; set => Nombre = value; }
        public string Apellido { get => Apellido; set => Apellido = value; }
        public string Direccion { get => Direccion; set => Direccion = value; }
        public string Telefono { get => Telefono; set => Telefono = value; }


    }
}
