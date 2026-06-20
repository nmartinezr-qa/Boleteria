using Boleteria.Entidades;
using Boleteria.LogicaNegocio.Mensajes;
using Boleteria.LogicaNegocio.Servicios;
using Boleteria.Presentacion.Utilidades;

namespace Boleteria.Presentacion.Operaciones
{
    public partial class FrmLocalidadPorPartido : Form
    {
        private Form parentForm;
        private bool volverAlMain = false;

        private ServicioPartido servicioPartido;
        private ServicioLocalidad servicioLocalidad;
        private ServicioLocalidadPorPartido servicioLocalidadPorPartido;

        public FrmLocalidadPorPartido(Form parentForm)
        {
            this.parentForm = parentForm;

            servicioPartido = new ServicioPartido();
            servicioLocalidad = new ServicioLocalidad();
            servicioLocalidadPorPartido = new ServicioLocalidadPorPartido();

            InitializeComponent();
        }

        private void FrmLocalidadPorPartido_Load(object sender, EventArgs e)
        {
            AplicarEstilos();
            CargarPartidos();
            CargarLocalidades();
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

            if (parentForm is FrmOperaciones operaciones)
            {
                operaciones.MostrarFormulario();
            }
            else
            {
                parentForm.Show();
            }

            Close();
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Partido partido = ObtenerPartidoSeleccionado();
                Localidad localidad = ObtenerLocalidadSeleccionada();
                int cantidadDisponible = int.Parse(cantidadDisponibleTextBox.Text);

                servicioLocalidadPorPartido.RegistrarLocalidadPorPartido(
                    partido.IdPartido,
                    localidad.IdLocalidad,
                    cantidadDisponible);

                MessageBox.Show(
                    MensajesExito.LocalidadPorPartidoRegistrada,
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarFormulario();
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    MensajesError.CantidadDisponibleInvalida,
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

        private void CargarPartidos()
        {
            Partido[] partidos = servicioPartido.ObtenerPartidos();

            partidoComboBox.DataSource = null;
            partidoComboBox.DataSource = partidos;
            partidoComboBox.DisplayMember = "Descripcion";
            partidoComboBox.ValueMember = "IdPartido";

            if (partidos.Length > 0)
            {
                partidoComboBox.SelectedIndex = 0;
            }
        }

        private void CargarLocalidades()
        {
            Localidad[] localidades = servicioLocalidad.ObtenerLocalidades();

            localidadComboBox.DataSource = null;
            localidadComboBox.DataSource = localidades;
            localidadComboBox.DisplayMember = "Descripcion";
            localidadComboBox.ValueMember = "IdLocalidad";

            if (localidades.Length > 0)
            {
                localidadComboBox.SelectedIndex = 0;
            }
        }

        private Partido ObtenerPartidoSeleccionado()
        {
            if (partidoComboBox.SelectedItem == null)
            {
                throw new Exception(MensajesError.PartidoNoSeleccionado);
            }

            return (Partido)partidoComboBox.SelectedItem;
        }

        private Localidad ObtenerLocalidadSeleccionada()
        {
            if (localidadComboBox.SelectedItem == null)
            {
                throw new Exception(MensajesError.LocalidadNoSeleccionada);
            }

            return (Localidad)localidadComboBox.SelectedItem;
        }

        private void LimpiarFormulario()
        {
            cantidadDisponibleTextBox.Clear();

            if (partidoComboBox.Items.Count > 0)
            {
                partidoComboBox.SelectedIndex = 0;
            }

            if (localidadComboBox.Items.Count > 0)
            {
                localidadComboBox.SelectedIndex = 0;
            }

            cantidadDisponibleTextBox.Focus();
        }

        private void AplicarEstilos()
        {
            EstilosUI.AplicarEstiloFormulario(this);

            EstilosUI.AplicarEstiloTitulo(tituloLbl);
            EstilosUI.AplicarEstiloGroupBox(datosLocalidadPorPartidoGroupBox);

            EstilosUI.AplicarEstiloLabel(partidoLbl);
            EstilosUI.AplicarEstiloLabel(localidadLbl);
            EstilosUI.AplicarEstiloLabel(cantidadDisponibleLbl);

            EstilosUI.AplicarEstiloComboBox(partidoComboBox);
            EstilosUI.AplicarEstiloComboBox(localidadComboBox);

            EstilosUI.AplicarEstiloTextBox(cantidadDisponibleTextBox);

            EstilosUI.AplicarEstiloBotonSecundario(volverBtn);
            EstilosUI.AplicarEstiloBotonPrimario(guardarBtn);
        }
    }
}