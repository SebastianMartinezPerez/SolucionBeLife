using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Plan
    {
		private string _idPlan;
		private string _nombre;
		private float _primaBase;
		private string _polizaActual;


		public string PolizaActual
		{
			get { return _polizaActual; }
			set { _polizaActual = value; }
		}
		public float PrimaBase
		{
			get { return _primaBase; }
			set { _primaBase = value; }
		}
		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}
		public string IdPlan		
		{
			get { return _idPlan; }
			set { _idPlan = value; }
		}

        public Plan()
        {

        }
	}
}
