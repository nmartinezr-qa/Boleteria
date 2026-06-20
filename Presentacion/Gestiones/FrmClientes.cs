using Boleteria.LogicaNegocio.Mensajes;
using Boleteria.LogicaNegocio.Servicios;
using Boleteria.Presentacion.Utilidades;

namespace Boleteria.Presentacion.Gestiones
{
    public partial class FrmClientes : Form
    {
        private Form parentForm;
        private bool volverAlMain = false;
        private ServicioCliente servicioCliente;

        public FrmClientes(Form parentForm)
        {
            this.parentForm = parentForm;
            servicioCliente = new ServicioCliente();

            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            activoCheckBox.Checked = true;
            activoCheckBox.Text = "Activo";

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
                int idCliente = int.Parse(idClienteTextBox.Text);
                string identificacion = identificacionTextBox.Text;
                string nombre = nombreTextBox.Text;
                string apellido = apellidoTextBox.Text;
                DateTime fechaNacimiento = fechaNacimientoDateTimePicker.Value.Date;
                DateTime fechaRegistro = fechaRegistroDateTimePicker.Value.Date;
                bool activo = activoCheckBox.Checked;

                servicioCliente.RegistrarCliente(
                    idCliente,
                    identificacion,
                    nombre,
                    apellido,
                    fechaNacimiento,
                    fechaRegistro,
                    activo);

                MessageBox.Show(
                    MensajesExito.ClienteRegistrado,
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

        private void activoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            activoCheckBox.Text = activoCheckBox.Checked ? "Activo" : "Inactivo";
        }

        private void LimpiarFormulario()
        {
            idClienteTextBox.Clear();
            identificacionTextBox.Clear();
            nombreTextBox.Clear();
            apellidoTextBox.Clear();

            fechaNacimientoDateTimePicker.Value = DateTime.Today;
            fechaRegistroDateTimePicker.Value = DateTime.Today;

            activoCheckBox.Checked = true;
            idClienteTextBox.Focus();
        }

        private void AplicarEstilos()
        {
            EstilosUI.AplicarEstiloFormulario(this);

            EstilosUI.AplicarEstiloTitulo(tituloLbl);
            EstilosUI.AplicarEstiloGroupBox(datosClienteGroupBox);

            EstilosUI.AplicarEstiloLabel(idClienteLbl);
            EstilosUI.AplicarEstiloLabel(identificacionLbl);
            EstilosUI.AplicarEstiloLabel(nombreLbl);
            EstilosUI.AplicarEstiloLabel(apellidoLbl);
            EstilosUI.AplicarEstiloLabel(fechaNacimientoLbl);
            EstilosUI.AplicarEstiloLabel(fechaRegistroLbl);

            EstilosUI.AplicarEstiloTextBox(idClienteTextBox);
            EstilosUI.AplicarEstiloTextBox(identificacionTextBox);
            EstilosUI.AplicarEstiloTextBox(nombreTextBox);
            EstilosUI.AplicarEstiloTextBox(apellidoTextBox);

            EstilosUI.AplicarEstiloDateTimePicker(fechaNacimientoDateTimePicker);
            EstilosUI.AplicarEstiloDateTimePicker(fechaRegistroDateTimePicker);

            EstilosUI.AplicarEstiloBotonSecundario(volverBtn);
            EstilosUI.AplicarEstiloBotonPrimario(guardarBtn);
        }
    }
}