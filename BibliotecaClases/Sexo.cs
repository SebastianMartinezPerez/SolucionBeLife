using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Sexo
    {
		private int _idSexo;
		private String _descripcion;

		public String Descripcion
		{
			get { return _descripcion; }
			set { _descripcion = value; }
		}
		public int IdSexo
		{
			get { return _idSexo; }
			set { _idSexo = value; }
		}

        public Sexo()
        {

        }
	}
}
