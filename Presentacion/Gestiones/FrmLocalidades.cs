using Boleteria.LogicaNegocio.Mensajes;
using Boleteria.LogicaNegocio.Servicios;
using Boleteria.Presentacion.Utilidades;

namespace Boleteria.Presentacion.Gestiones
{
    public partial class FrmLocalidades : Form
    {
        private Form parentForm;
        private bool volverAlMain = false;
        private ServicioLocalidad servicioLocalidad;

        public FrmLocalidades(Form parentForm)
        {
            this.parentForm = parentForm;
            servicioLocalidad = new ServicioLocalidad();

            InitializeComponent();
        }

        private void FrmLocalidades_Load(object sender, EventArgs e)
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
                int idLocalidad = int.Parse(idLocalidadTextBox.Text);
                string nombreLocalidad = nombreLocalidadTextBox.Text;
                decimal precio = decimal.Parse(precioTextBox.Text);

                servicioLocalidad.RegistrarLocalidad(
                    idLocalidad,
                    nombreLocalidad,
                    precio);

                MessageBox.Show(
                    MensajesExito.LocalidadRegistrada,
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarFormulario();
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    MensajesError.DatosInvalidos,
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
            idLocalidadTextBox.Clear();
            nombreLocalidadTextBox.Clear();
            precioTextBox.Clear();

            idLocalidadTextBox.Focus();
        }

        private void AplicarEstilos()
        {
            EstilosUI.AplicarEstiloFormulario(this);

            EstilosUI.AplicarEstiloTitulo(tituloLbl);
            EstilosUI.AplicarEstiloGroupBox(datosLocalidadGroupBox);

            EstilosUI.AplicarEstiloLabel(idLocalidadLbl);
            EstilosUI.AplicarEstiloLabel(nombreLocalidadLbl);
            EstilosUI.AplicarEstiloLabel(precioLbl);

            EstilosUI.AplicarEstiloTextBox(idLocalidadTextBox);
            EstilosUI.AplicarEstiloTextBox(nombreLocalidadTextBox);
            EstilosUI.AplicarEstiloTextBox(precioTextBox);

            EstilosUI.AplicarEstiloBotonSecundario(volverBtn);
            EstilosUI.AplicarEstiloBotonPrimario(guardarBtn);
        }
    }
}