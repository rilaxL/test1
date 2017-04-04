using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using System.Data;

namespace Utilidades
{
    public class Conexion
    {

        private static OracleConnection _ora_connection;
        public static OracleConnection ora_connection
        {
            get {
                   return  new OracleConnection("User Id="+Constantes.USER_ID+"; Password="+Constantes.USER_PASSWORD+"; Data Source="+Constantes.DATA_SOURCE+"; Pooling=false;"); 
                }
            set { _ora_connection = value; }
        }
        
    }
}
