using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BibliotecaClases
{
    public class Cliente
    {
        public string RutCliente { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Sexo sexo { get; set; }
        public EstadoCivil estadocivil { get; set; }

        public Cliente()
        {
           
        }

       
    }
}
