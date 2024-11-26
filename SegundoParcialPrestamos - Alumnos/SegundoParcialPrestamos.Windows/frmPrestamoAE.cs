using SegundoParcialPrestamos.Entidades;
using SegundoParcialPrestamos.Entidades.Enums;
using SegundoParcialPrestamos.Windows.Helpers;

namespace SegundoParcialPrestamos.Windows
{
	public partial class frmPrestamoAE : Form
	{
		private Prestamo? prestamo;
		private TipoPrestamo tipoPrestamo;
		private Plazo plazoSeleccionado=Plazo.DoceMeses;
		private Dictionary<Plazo, decimal> plazosTasas;
		public frmPrestamoAE()
		{
			InitializeComponent();
		}

		internal Prestamo? GetPrestamo() => prestamo;

		private void rbtDolares_CheckedChanged(object sender, EventArgs e)
		{
			tipoPrestamo = TipoPrestamo.Dolares;
			plazosTasas = PrestamoDolares.TasaPorPlazo!;
			cboPlazos.SelectedIndex = 0;
			MostrarTasaInteres();
		}
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			CombosHelper.CargarComboPlazos(ref cboPlazos);
			if (rbtDolares.Checked==true)
			{
				plazosTasas = PrestamoDolares.TasaPorPlazo;
			}
			else
			{
				plazosTasas = PrestamoPesos.TasaPorPlazo;

			}

		}
		private void MostrarTasaInteres()
		{
			txtTasa.Text = plazosTasas[plazoSeleccionado]!.ToString();
		}

		private void rbtPesos_CheckedChanged(object sender, EventArgs e)
		{
			tipoPrestamo = TipoPrestamo.Pesos;
			plazosTasas = PrestamoPesos.TasaPorPlazo!;
			cboPlazos.SelectedIndex = 0;
			MostrarTasaInteres();

		}

		private void btnValidar_Click(object sender, EventArgs e)
		{
			if (!Persona.ValidarDni(txtDni.Text))
			{
				errorProvider1.SetError(txtDni, "Error, dni no valido");
				txtDni.Clear();
			}
		}

		private void cboPlazos_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboPlazos.SelectedIndex > 0)
			{
				plazoSeleccionado = (Plazo)cboPlazos.SelectedItem!;
				MostrarTasaInteres();
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (Validar())
			{
				var p = new Persona();
				
				p.Dni=txtDni.Text;
				p.Nombres = txtNombres.Text;
				p.Apellido = txtApellido.Text;
				var tasaInteres = plazosTasas[plazoSeleccionado];
				var fecha = dtpFecha.Value;
				var monto=decimal.Parse(txtMonto.Text);
				if (rbtDolares.Checked==true)
				{

					prestamo=new PrestamoDolares(fecha, monto, tasaInteres, p, plazoSeleccionado);
				}
				else
				{
					prestamo = new PrestamoPesos(fecha, monto, tasaInteres, p, plazoSeleccionado);
				}
				DialogResult = DialogResult.OK;
			}
		}

		private bool Validar()
		{
			if (string.IsNullOrEmpty(txtNombres.Text))
			{
				errorProvider1.SetError(txtNombres, "Debe ingresar un nombre");
				return false;
			}
			if (string.IsNullOrEmpty(txtApellido.Text))
			{
				errorProvider1.SetError(txtApellido, "Debe ingresar un apellido");
				return false;
			}
			if (!decimal.TryParse(txtMonto.Text,out decimal valor))
			{
				errorProvider1.SetError(txtMonto, "Debe ingresar un valor numerico");
				return false;
			}
			if (cboPlazos.SelectedIndex==0)
			{
				errorProvider1.SetError(cboPlazos, "Debe ingresar seleccionar un plazo");
				return false;
			}
			return true;
		}
	}
}
