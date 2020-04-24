using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClases;

namespace BibliotecaClases
{
    public class Contrato : Tarifador
    {
		private string _numero;
		private DateTime _fechaCreacion;
		private DateTime _fechaTermino;
		private string _rutCliente;
        public Plan planContrato { get; set; }
        private DateTime _fechaIniciVigencia;
		private DateTime _fechaFinVigencia;
		private bool _vigente;
		private bool _declaracionSalud;
		private float _primaAnual;
		private float _primaMensual;
		private string _observaciones;
        public Cliente clienteContrato { get; set; }

        public string Observaciones
		{
			get { return _observaciones; }
			set {
                if (value.Trim().Length > 0)
                {
                    _observaciones = value;
                }
                else
                {
                    throw new Exception("Campo obligatorio");
                }
                 }
		}
		public float PrimaMensual
		{
			get { return _primaMensual; }
			set { _primaMensual = value; }
		}
		public float PrimaAnual
		{
			get { return _primaAnual; }
			set { _primaAnual = value; }
		}
		public bool DeclaracionSalud
		{
			get { return _declaracionSalud; }
			set { _declaracionSalud = value; }
		}
		public bool Vigente
		{
			get { return _vigente; }
			set { _vigente = value; }
		}
		public DateTime FechaFinVigencia

		{
			get { return _fechaFinVigencia; }
			set { _fechaFinVigencia = value; }
		}
		public DateTime FechaInicioVigencia
		{
			get { return _fechaIniciVigencia; }
			set {
                DateTime fi = DateTime.Now.Date;
                DateTime ft = DateTime.Now.AddDays(30);
                if (value >= fi && value <= ft) {
                    _fechaIniciVigencia = value;
                }
                else {
                    throw new Exception("Fecha incorrecta.");
                }
            }
		}
		public string RutCliente
		{
			get { return _rutCliente; }
			set {
				if (_rutCliente=="")
				{
					throw new Exception("no debe estar vacio");
				}
				else
				{
					_rutCliente = value;
				}
			}
			
		}
		public DateTime FechaTermino
		{
			get { return _fechaTermino; }
			set { _fechaTermino = value; }
		}
		public DateTime FechaCreacion
		{
			get { return _fechaCreacion; }
			set { _fechaCreacion = value; }
		}
		public string Numero
		{
			get { return _numero; }
			set { _numero = value; }
		}

        public Contrato()
        {

        }

        public double CalcularPrimaAnual()
        {
            this.clienteTarifador = clienteContrato;
            double pba = this.CalcularPrima();
            pba += planContrato.PrimaBase;
            return pba;
        }
	}
}
