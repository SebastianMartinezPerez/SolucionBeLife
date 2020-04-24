using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
	public class Cliente
	{
		private String _rutCliente;
		private String _nombres;
		private String _apellidos;
		private DateTime _fechaNacimiento;
		public Sexo sexo { get; set; }
		public EstadoCivil estadoCivil { get; set; }


		public DateTime FechaNacimiento
		{
			get { return _fechaNacimiento; }
			set { _fechaNacimiento = value; }
		}
		public String Apellidos
		{
			get { return _apellidos; }
			set
			{
				if (_apellidos == "")
				{
					throw new Exception("no debe estar vacio");

				}
				else
					_apellidos = value;
			}
		}
		public String Nombres
		{
			get { return _nombres; }
			set
			{
				if (_nombres == "")
				{
					throw new Exception("no debe estar vacio");
				}
				else
				{
					_nombres = value;
				}
			}
		} 
		
		public String RutCliente
		{
			get { return _rutCliente; }
			set
			{
				if (_rutCliente == "")
				{
					throw new Exception("no debe estar vacio");
				}
				else
				{
					_rutCliente = value;
				}

			}
		}
		public Cliente()
		{

		}



	}


}
