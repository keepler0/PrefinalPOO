using SegundoParcialPrestamos.Entidades.Enums;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace SegundoParcialPrestamos.Entidades
{
	public abstract class Prestamo
	{
		public Guid PrestamoNro { get; private set; }
		public DateTime FechaInicio { get; set; }
		public decimal Monto { get; set; }
		public decimal TasaInteres { get; set; }
        public Plazo Plazo { get; set; }
        public Persona? Persona { get; set; }

        public Prestamo()
		{
			PrestamoNro = Guid.NewGuid();
		}

		public Prestamo(DateTime fechaInicio, decimal monto,
						decimal tasaInteres, Persona? persona,
						Plazo plazo) : this()
		{
			FechaInicio = fechaInicio;
			Monto = monto;
			TasaInteres = tasaInteres;
			Persona = persona;
			Plazo = plazo;
		}
		public string CalcularCuotas()
		{
			var sb = new StringBuilder();
			int meses = GetPlazoMeses();
			var montoPorMes = Monto / meses;
            for (int i = 0; i < meses; i++)
            {
				sb.AppendLine($"mes {i + 1}={montoPorMes*TasaInteres}");
            }
			return sb.ToString();
        }
		public override string ToString()
		{
			int meses = GetPlazoMeses();
			var sb = new StringBuilder();
			var tipo = this.GetType().Name == "PrestamoPesos" ? "En pesos" : "En dolares";
			sb.AppendLine($"Tipo de prestamo: {tipo}");
			sb.AppendLine($"Fecha: {FechaInicio}");
			sb.AppendLine($"Monto: {Monto}");
			sb.AppendLine($"Tipo de prestamo: {tipo}");
			sb.AppendLine($"Taza de interes {TasaInteres}");
			sb.AppendLine($"Plazo: {meses} meses");
			return sb.ToString();
		}

		private int GetPlazoMeses()
		{
			int meses = 0;
			switch (Plazo)
			{
				case Plazo.DoceMeses:
					meses = (int)Plazo.DoceMeses;
					break;
				case Plazo.VeintaYCuatroMeses:
					meses = (int)Plazo.VeintaYCuatroMeses;
					break;
				case Plazo.TreintaYSeisMeses:
					meses = (int)Plazo.TreintaYSeisMeses;
					break;
				case Plazo.CuarentaYOchoMeses:
					meses = (int)Plazo.CuarentaYOchoMeses;
					break;
			}
			return meses;
		}
	}
}
