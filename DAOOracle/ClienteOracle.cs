using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilidades;
using DAO;
using DTO;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;


namespace DAOOracle
{
    public class ClienteOracle 
    {

        public void spInsertarCliente(ClienteDTO clt)
        {
            string dataSource = "User Id=bodega; Password=system; Data Source=localhost:1521/XE; Pooling=false;";
            OracleConnection con = null;
            OracleCommand query = null;

            try
            {
                con = new OracleConnection(dataSource);
                con.Open();

                query = new OracleCommand("PKG_CLIENTE.SP_CARGAR_CLIENTES", con);
                query.CommandType = System.Data.CommandType.StoredProcedure;

                query.Parameters.Add(":p_nombre", clt.nombre);
                query.Parameters.Add(":p_apellido", clt.apellido);
                query.Parameters.Add(":p_edad", clt.edad);

                query.ExecuteNonQuery();
                Console.WriteLine("OK");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
         
        }
    }
}
