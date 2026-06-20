using Boleteria.Entidades;
using Boleteria.LogicaNegocio.Mensajes;
using Boleteria.LogicaNegocio.Servicios;
using Boleteria.Presentacion.Utilidades;

namespace Boleteria.Presentacion.Consultas
{
    public partial class FrmConsultarLocalidades : Form
    {
        private Form parentForm;
        private bool volverAlMain = false;
        private ServicioLocalidad servicioLocalidad;

        public FrmConsultarLocalidades(Form parentForm)
        {
            this.parentForm = parentForm;
            servicioLocalidad = new ServicioLocalidad();

            InitializeComponent();
        }

        private void FrmConsultarLocalidades_Load(object sender, EventArgs e)
        {
            AplicarEstilos();

            ConfigurarCriteriosBusqueda();
            ConfigurarGrid();
            CargarTodasLasLocalidades();
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

            if (parentForm is FrmConsultas consultas)
            {
                consultas.MostrarFormulario();
            }
            else
            {
                parentForm.Show();
            }

            Close();
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                BuscarLocalidades();
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

        private void limpiarFiltroBtn_Click(object sender, EventArgs e)
        {
            valorBusquedaTextBox.Clear();
            criterioComboBox.SelectedIndex = 0;

            CargarTodasLasLocalidades();
        }

        private void ConfigurarCriteriosBusqueda()
        {
            criterioComboBox.Items.Clear();

            criterioComboBox.Items.Add("IdLocalidad");
            criterioComboBox.Items.Add("NombreLocalidad");

            criterioComboBox.SelectedIndex = 0;
        }

        private void ConfigurarGrid()
        {
            localidadesDataGridView.AutoGenerateColumns = false;
            localidadesDataGridView.Columns.Clear();

            localidadesDataGridView.Columns.Add("IdLocalidad", "Id Localidad");
            localidadesDataGridView.Columns["IdLocalidad"].DataPropertyName = "IdLocalidad";
            localidadesDataGridView.Columns["IdLocalidad"].Width = 120;

            localidadesDataGridView.Columns.Add("NombreLocalidad", "Nombre");
            localidadesDataGridView.Columns["NombreLocalidad"].DataPropertyName = "NombreLocalidad";
            localidadesDataGridView.Columns["NombreLocalidad"].Width = 350;

            localidadesDataGridView.Columns.Add("Precio", "Precio");
            localidadesDataGridView.Columns["Precio"].DataPropertyName = "Precio";
            localidadesDataGridView.Columns["Precio"].Width = 150;
        }

        private void CargarTodasLasLocalidades()
        {
            Localidad[] localidades =
                servicioLocalidad.ObtenerLocalidades();

            CargarLocalidadesEnGrid(localidades);
        }

        private void BuscarLocalidades()
        {
            string criterio = criterioComboBox.Text;
            string valor = valorBusquedaTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(valor))
            {
                CargarTodasLasLocalidades();
                return;
            }

            if (criterio == "IdLocalidad")
            {
                BuscarPorId(valor);
                return;
            }

            if (criterio == "NombreLocalidad")
            {
                Localidad[] localidades =
                    servicioLocalidad.BuscarLocalidadesPorNombre(valor);

                CargarLocalidadesEnGrid(localidades);
            }
        }

        private void BuscarPorId(string valor)
        {
            int idLocalidad = int.Parse(valor);

            Localidad localidad =
                servicioLocalidad.BuscarLocalidadPorId(idLocalidad);

            Localidad[] resultado = new Localidad[1];
            resultado[0] = localidad;

            CargarLocalidadesEnGrid(resultado);
        }

        private void CargarLocalidadesEnGrid(Localidad[] localidades)
        {
            localidadesDataGridView.DataSource = null;
            localidadesDataGridView.DataSource = localidades;
        }

        private void AplicarEstilos()
        {
            EstilosUI.AplicarEstiloFormulario(this);

            EstilosUI.AplicarEstiloTitulo(tituloLbl);

            EstilosUI.AplicarEstiloGroupBox(busquedaGroupBox);

            EstilosUI.AplicarEstiloLabel(buscarPorLbl);
            EstilosUI.AplicarEstiloLabel(valorBusquedaLbl);

            EstilosUI.AplicarEstiloComboBox(criterioComboBox);
            EstilosUI.AplicarEstiloTextBox(valorBusquedaTextBox);

            EstilosUI.AplicarEstiloBotonPrimario(buscarBtn);
            EstilosUI.AplicarEstiloBotonSecundario(limpiarFiltroBtn);
            EstilosUI.AplicarEstiloBotonSecundario(volverBtn);

            EstilosUI.AplicarEstiloDataGridView(localidadesDataGridView);
        }
    }
}