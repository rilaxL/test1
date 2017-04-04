using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAOOracle;
using DTO;

namespace Negocio
{
    public class ClienteBO
    {

        private static ClienteBO instance;
        public static ClienteBO getInstance
        {
            get {
                
                 if (instance == null)
                    instance = new ClienteBO();

                    return instance; 
                }

            set { instance = value; }
        }


        /*
            Negocio
        */

        public void spInsertarCliente(ClienteDTO clt)
        {
            ClienteOracle ora = new ClienteOracle();

            validarInsCliente(clt);
            ora.spInsertarCliente(clt);
        }

        /*
            Validaciones
         */

        private void validarInsCliente(ClienteDTO clt)
        {
            if (clt.nombre == "")
            {
                throw new Exception("Campo nombre es requerido");
            }

            if (clt.apellido == "")
            {
                throw new Exception("Campo apellido es requerido");
            }

            if (clt.edad == 0)
            {
                throw new Exception("Campo edad es requerido");
            }
        }


    
    }
}
