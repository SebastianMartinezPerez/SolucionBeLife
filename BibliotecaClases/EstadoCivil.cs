using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class EstadoCivil
    {
		private int _idEstadoCivil;
		private String _descripcion;


		public String Descripcion
		{
			get { return _descripcion; }
			set { _descripcion = value; }
		}
		public int idEstadoCivil
		{
			get { return _idEstadoCivil; }
			set { _idEstadoCivil = value; }
		}

        public EstadoCivil()
        {

        }
	}
}
