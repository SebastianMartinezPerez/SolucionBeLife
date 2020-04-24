using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClases;

   namespace Controlador { }
/*{
    public class ClientesColeccion
    {
        private List<Cliente> Clientes;
        public ClientesColeccion()
        {
            Clientes = new List<Cliente>();
        }
        public bool Agregar(Cliente cli)
        {
            if(existeCliente(cli.RutCliente)==false)
            {
                Clientes.Add(cli);
                return true;
            } return false;
                    }
  /*  private bool existeCliente(string rut)
        {
            foreach(Cliente item in Clientes)
            {
                if (item.RutCliente.Equals(rut))
                {
                    return true;
                }
                        }return false;

        }]

