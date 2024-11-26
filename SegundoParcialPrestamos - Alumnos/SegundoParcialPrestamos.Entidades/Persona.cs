using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SegundoParcialPrestamos.Entidades
{
	public class Persona
	{
		private string? _apellido=null!;
		private string? _nombres=null!;
		private string? _dni;

		public string? Dni
		{
			get { return _dni; }
			set 
			{
				if (value is not null)
				{
					_dni = value;
				}
				else
				{
					throw new Exception("Error: DNI con valor null");
				}
			}
		}


		public string? Nombres
		{
			get { return _nombres; }
			set { _nombres = string.IsNullOrEmpty(value)?
				 throw new Exception("Error: valor Nombres fue NULL o vacio"):value; }
		}

		public string? Apellido
		{
			get { return _apellido; }
			set { _apellido = string.IsNullOrEmpty(value) ?
					throw new Exception("Error: valor Apellido fue NULL o vacio"):value; }
		}
		public override string ToString()
		{
			return $"{Nombres} {Apellido}";
		}
		public static bool ValidarDni(string dni) => Regex.IsMatch(dni!, @"^\d{8}$");
		public static bool operator ==(Persona p, Persona p1)=>p.Dni==p1.Dni;
		public static bool operator !=(Persona p, Persona p1) => !(p == p1);
	}
}
