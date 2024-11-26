using SegundoParcialPrestamos.Datos;
using SegundoParcialPrestamos.Entidades;
using SegundoParcialPrestamos.Entidades.Enums;
using SegundoParcialPrestamos.Windows.Helpers;

namespace SegundoParcialPrestamos.Windows
{
	public partial class frmPrestamos : Form
	{
		private EntidadFinanciera entidad = new EntidadFinanciera("Banco Provincia");
		private TipoPrestamo? tipo = TipoPrestamo.Todos;
		private List<Prestamo>? lista;
		private int cantidad = 0;
		public frmPrestamos()
		{
			InitializeComponent();
		}

		private void frmPrestamos_Load(object sender, EventArgs e)
		{
			Recargar();
		}

		private void Recargar()
		{
			lista = entidad.GetPrestamos(tipo);
			cantidad = entidad.GetCantidad(tipo);
			GridHelper.MostrarDatosEnGrilla(lista, dgvDatos);
		}

		private void tsbNuevo_Click(object sender, EventArgs e)
		{
			var frm=new frmPrestamoAE();
			var dr=frm.ShowDialog();
			if (dr == DialogResult.Cancel) return;
			try
			{
				var nuevoPrestamo = frm.GetPrestamo();
				var valores = entidad.AgregarPrestamo(nuevoPrestamo!);
				if (valores.Item1)
				{
					MessageBox.Show(valores.Item2);
					Recargar();
				}
				else
				{
					MessageBox.Show(valores.Item2);
				}
				
			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}
