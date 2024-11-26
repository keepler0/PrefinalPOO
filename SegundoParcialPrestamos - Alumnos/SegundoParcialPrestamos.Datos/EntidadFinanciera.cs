using SegundoParcialPrestamos.Entidades;
using SegundoParcialPrestamos.Entidades.Enums;

namespace SegundoParcialPrestamos.Datos
{
	public class EntidadFinanciera
	{
		private string? nombre;
		private List<Prestamo> prestamos;
        private EntidadFinanciera()
        {
            prestamos=new List<Prestamo>();
        }
        public EntidadFinanciera(string? nombre):this()
		{
			this.nombre = nombre;
		}
		public (bool,string) AgregarPrestamo(Prestamo prestamo)
		{
			if (prestamo is null) return (false, "El prestamo tiene valor null, no es posible agregar");
			if (ExistePrestamo(prestamo)) return (false, "Ya existe un prestamo solicitado, no es posible agregar");
			prestamos.Add(prestamo);
			return (true, prestamo.ToString());
		}
		public bool ExistePrestamo(Prestamo prestamo)
		{
			if (prestamo is null) throw new Exception("Error: Prestamo con valor null");
			return prestamos.Any(p => p.ToString()==prestamo.ToString());
		}
		public int GetCantidad(TipoPrestamo? tipo)
		{
			switch (tipo)
			{
				case TipoPrestamo.Pesos:
					return prestamos.Where(p => p.GetType().Name == "PrestamoPesos").Count();
				case TipoPrestamo.Dolares:
					return prestamos.Where(p => p.GetType().Name == "PrestamoDolares").Count();
				case TipoPrestamo.Todos:
					return prestamos.Count();
				default:
					throw new Exception("Opcion no valida");
			}
		}
		public Prestamo? GetPrestamo(Guid numeroPrestamo)
		{
			return prestamos.SingleOrDefault(p => p.PrestamoNro==numeroPrestamo);
			
        }
		public List<Prestamo> GetPrestamos(TipoPrestamo? tipo)
		{
			switch (tipo)
			{
				case TipoPrestamo.Pesos:
					return prestamos.Where(p => p.GetType().Name == "PrestamoPesos").ToList();
				case TipoPrestamo.Dolares:
					return prestamos.Where(p => p.GetType().Name == "PrestamoDolares").ToList();
				case TipoPrestamo.Todos:
					return prestamos;
				default:
					throw new Exception("Opcion no valida");
			}
		}
	}
}
