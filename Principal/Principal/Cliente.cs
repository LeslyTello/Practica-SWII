using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    class Cliente
    {
        int idCliente;
        String nombre, apellido, cedula, direccion;

        public Cliente(String nombre, String apellido, String direccion)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
        }
    }
}
