using Boleteria.LogicaNegocio.Mensajes;
using Boleteria.LogicaNegocio.Servicios;
using Boleteria.Presentacion.Utilidades;

namespace Boleteria.Presentacion.Gestiones
{
    public partial class FrmVendedores : Form
    {
        private Form parentForm;
        private bool volverAlMain = false;
        private ServicioVendedor servicioVendedor;

        public FrmVendedores(Form parentForm)
        {
            this.parentForm = parentForm;
            servicioVendedor = new ServicioVendedor();

            InitializeComponent();
        }

        private void FrmVendedores_Load(object sender, EventArgs e)
        {
            AplicarEstilos();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (!volverAlMain)
            {
                Application.Exit();
            }
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            volverAlMain = true;
            parentForm.Show();
            Close();
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int idVendedor = int.Parse(idVendedorTextBox.Text);
                string identificacion = identificacionTextBox.Text;
                string nombre = nombreTextBox.Text;
                string apellido = apellidoTextBox.Text;
                DateTime fechaNacimiento = fechaNacimientoDateTimePicker.Value.Date;
                DateTime fechaIngreso = fechaIngresoDateTimePicker.Value.Date;

                servicioVendedor.RegistrarVendedor(
                    idVendedor,
                    identificacion,
                    nombre,
                    apellido,
                    fechaNacimiento,
                    fechaIngreso);

                MessageBox.Show(
                    MensajesExito.VendedorRegistrado,
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarFormulario();
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    MensajesError.IdFormatoInvalido,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            idVendedorTextBox.Clear();
            identificacionTextBox.Clear();
            nombreTextBox.Clear();
            apellidoTextBox.Clear();

            fechaNacimientoDateTimePicker.Value = DateTime.Today;
            fechaIngresoDateTimePicker.Value = DateTime.Today;

            idVendedorTextBox.Focus();
        }

        private void AplicarEstilos()
        {
            EstilosUI.AplicarEstiloFormulario(this);

            EstilosUI.AplicarEstiloTitulo(tituloLbl);
            EstilosUI.AplicarEstiloGroupBox(datosVendedorGroupBox);

            EstilosUI.AplicarEstiloLabel(idVendedorLbl);
            EstilosUI.AplicarEstiloLabel(identificacionLbl);
            EstilosUI.AplicarEstiloLabel(nombreLbl);
            EstilosUI.AplicarEstiloLabel(apellidoLbl);
            EstilosUI.AplicarEstiloLabel(fechaNacimientoLbl);
            EstilosUI.AplicarEstiloLabel(fechaIngresoLbl);

            EstilosUI.AplicarEstiloTextBox(idVendedorTextBox);
            EstilosUI.AplicarEstiloTextBox(identificacionTextBox);
            EstilosUI.AplicarEstiloTextBox(nombreTextBox);
            EstilosUI.AplicarEstiloTextBox(apellidoTextBox);

            EstilosUI.AplicarEstiloDateTimePicker(fechaNacimientoDateTimePicker);
            EstilosUI.AplicarEstiloDateTimePicker(fechaIngresoDateTimePicker);

            EstilosUI.AplicarEstiloBotonSecundario(volverBtn);
            EstilosUI.AplicarEstiloBotonPrimario(guardarBtn);
        }
    }
}