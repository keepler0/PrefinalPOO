using SegundoParcialPrestamos.Entidades.Enums;
using System.Runtime.CompilerServices;

namespace SegundoParcialPrestamos.Entidades
{
	public class PrestamoDolares : Prestamo
	{
		public PrestamoDolares()
		{
		}

		public PrestamoDolares(DateTime fechaInicio, decimal monto, decimal tasaInteres, Persona? persona, Plazo plazo) : base(fechaInicio, monto, tasaInteres, persona, plazo)
		{
		}
        
        public static Dictionary<Plazo, decimal> TasaPorPlazo
		{
			get
			{
				return new Dictionary<Plazo, decimal>
					{
						{Plazo.DoceMeses, 5m },
						{Plazo.VeintaYCuatroMeses,6m},
						{Plazo.TreintaYSeisMeses,7m},
						{Plazo.CuarentaYOchoMeses,8m}
					};
			}
		}
	}
}
