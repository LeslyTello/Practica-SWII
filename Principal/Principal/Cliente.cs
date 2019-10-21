using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    class Cliente
    {

        String nombre1, nombre2, apellido1, apellido2;


        public Cliente(String nombre, String nombre2, String apellido, String apellido2)
        {
            this.nombre1 = nombre;
            this.nombre2 = nombre2;
            this.apellido1 = apellido;
            this.apellido2 = apellido2;
        }



        public void insertarCliente(Cliente c)
        {


            string[] registro = { c.nombre1, c.nombre2, c.apellido1, c.apellido2 };
            System.IO.File.WriteAllLines(@"D:\registroCliente.txt", registro);


        }
    }
}
