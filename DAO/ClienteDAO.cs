using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;

namespace DAO
{
    public interface ClienteDAO
    {
        void spInsertarCliente(ClienteDTO clt);
    }
}
