using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocio;
using DTO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            ClienteDTO c = new ClienteDTO();

            try
            {
                c.nombre = "danilo";
                c.apellido = "caro";
                c.edad = 0;

                ClienteBO.getInstance.spInsertarCliente(c);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
