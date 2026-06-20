using Boleteria.LogicaNegocio.Mensajes;
using Boleteria.LogicaNegocio.Servicios;
using Boleteria.Presentacion.Utilidades;

namespace Boleteria.Presentacion.Gestiones
{
    public partial class FrmPartidos : Form
    {
        private Form parentForm;
        private bool volverAlMain = false;
        private ServicioPartido servicioPartido;

        public FrmPartidos(Form parentForm)
        {
            InitializeComponent();

            this.parentForm = parentForm;
            servicioPartido = new ServicioPartido();
        }

        private void FrmPartidos_Load(object sender, EventArgs e)
        {
            activoCheckBox.Checked = true;
            activoCheckBox.Text = "Activo";

            AplicarEstilos();
        }

        private void AplicarEstilos()
        {
            EstilosUI.AplicarEstiloFormulario(this);

            EstilosUI.AplicarEstiloTitulo(tituloLbl);
            EstilosUI.AplicarEstiloGroupBox(datosPartidoGroupBox);

            EstilosUI.AplicarEstiloLabel(idPartidoLbl);
            EstilosUI.AplicarEstiloLabel(rivalLbl);
            EstilosUI.AplicarEstiloLabel(fechaLbl);
            EstilosUI.AplicarEstiloLabel(horaLbl);

            EstilosUI.AplicarEstiloTextBox(idPartidoTextBox);
            EstilosUI.AplicarEstiloTextBox(rivalTextBox);
            EstilosUI.AplicarEstiloTextBox(horaTextBox);

            EstilosUI.AplicarEstiloDateTimePicker(fechaDateTimePicker);

            EstilosUI.AplicarEstiloBotonSecundario(volverBtn);
            EstilosUI.AplicarEstiloBotonPrimario(guardarBtn);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (!volverAlMain)
            {
                Application.Exit();
            }
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int idPartido = int.Parse(idPartidoTextBox.Text);
                string rival = rivalTextBox.Text;
                DateTime fecha = fechaDateTimePicker.Value.Date;
                string hora = horaTextBox.Text;
                bool activo = activoCheckBox.Checked;

                servicioPartido.RegistrarPartido(
                    idPartido,
                    rival,
                    fecha,
                    hora,
                    activo);

                MessageBox.Show(
                    MensajesExito.PartidoRegistrado,
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarCampos();
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
            activoCheckBox.Text = activoCheckBox.Checked
                ? "Activo"
                : "Inactivo";
        }
        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            volverAlMain = true;
            parentForm.Show();
            Close();
        }

        private void LimpiarCampos()
        {
            idPartidoTextBox.Clear();
            rivalTextBox.Clear();
            horaTextBox.Clear();
            fechaDateTimePicker.Value = DateTime.Today;
            activoCheckBox.Checked = true;
            idPartidoTextBox.Focus();
        }

        private void guardarBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                int idPartido = int.Parse(idPartidoTextBox.Text);
                string rival = rivalTextBox.Text;
                DateTime fecha = fechaDateTimePicker.Value.Date;
                string hora = horaTextBox.Text;
                bool activo = activoCheckBox.Checked;

                servicioPartido.RegistrarPartido(
                    idPartido,
                    rival,
                    fecha,
                    hora,
                    activo);

                MessageBox.Show(
                    MensajesExito.PartidoRegistrado,
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarCampos();
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

    }
}