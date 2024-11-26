using SegundoParcialPrestamos.Entidades.Enums;

namespace SegundoParcialPrestamos.Entidades
{
	public class PrestamoPesos : Prestamo
	{
        public PrestamoPesos()
		{
		}

		public PrestamoPesos(DateTime fechaInicio, decimal monto, decimal tasaInteres, Persona? persona, Plazo plazo) : 
						base(fechaInicio, monto, tasaInteres, persona, plazo)
		{
		}

		public static Dictionary<Plazo, decimal> TasaPorPlazo
		{
			get
			{
				return new Dictionary<Plazo, decimal>
				{
					{Plazo.DoceMeses,25m },
					{Plazo.VeintaYCuatroMeses,30m },
					{Plazo.TreintaYSeisMeses,35m },
					{Plazo.CuarentaYOchoMeses,40m }
				};
			}
		}
	}
}
