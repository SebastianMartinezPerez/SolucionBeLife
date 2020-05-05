using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF;

namespace Biblioteca
{
    public class Cliente
    {
        public string Rut { get; set; }
        public string NombreContacto { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public TipoEmpresa TipoEmpresa { get; set; }
        public int Telefono { get; set; }
        public Actividad Activi { get; set; }
        public string Mail { get; set; }

        public Cliente()
        {
            this.Init();
        }

        private void Init()
        {
            Rut = string.Empty;
            NombreContacto = string.Empty;
            RazonSocial = string.Empty;
            Direccion = string.Empty;
            Mail = string.Empty;
            Telefono = 0;
        }
    }
}
