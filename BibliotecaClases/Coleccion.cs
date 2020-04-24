using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
   public class Coleccion

    {
        public List<Cliente> clientes = new List<Cliente>();
        public bool GuardarCliente(Cliente cliente)
        {
            this.clientes.Add(cliente);
            return true;
        }

    }
}
