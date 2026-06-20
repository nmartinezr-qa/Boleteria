using Boleteria.Entidades;
using Boleteria.LogicaNegocio.Mensajes;
using Boleteria.LogicaNegocio.Servicios;
using Boleteria.Presentacion.Utilidades;

namespace Boleteria.Presentacion.Consultas
{
    public partial class FrmConsultarPartidos : Form
    {
        private Form parentForm;
        private bool volverAlMain = false;
        private ServicioPartido servicioPartido;

        public FrmConsultarPartidos(Form parentForm)
        {
            this.parentForm = parentForm;
            servicioPartido = new ServicioPartido();

            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (!volverAlMain)
            {
                Application.Exit();
            }
        }

        private void FrmConsultarPartidos_Load(object sender, EventArgs e)
        {
            ConfigurarCriteriosBusqueda();
            ConfigurarGrid();
            CargarTodosLosPartidos();
            AplicarEstilos();
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            volverAlMain = true;
            parentForm.Show();
            Close();
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                BuscarPartidos();
            }
            catch (FormatException)
            {
                MessageBox.Show(MensajesError.IdFormatoInvalido,
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
            CargarTodosLosPartidos();
        }

        private void ConfigurarCriteriosBusqueda()
        {
            criterioComboBox.Items.Clear();
            criterioComboBox.Items.Add("IdPartido");
            criterioComboBox.Items.Add("Rival");
            criterioComboBox.Items.Add("Activo");
            criterioComboBox.SelectedIndex = 0;
        }

        private void ConfigurarGrid()
        {
            partidosDataGridView.AutoGenerateColumns = false;
            partidosDataGridView.Columns.Clear();

            partidosDataGridView.Columns.Add("IdPartido", "Id Partido");
            partidosDataGridView.Columns["IdPartido"].DataPropertyName = "IdPartido";
       
            partidosDataGridView.Columns.Add("Rival", "Rival");
            partidosDataGridView.Columns["Rival"].DataPropertyName = "Rival";

            partidosDataGridView.Columns.Add("Fecha", "Fecha");
            partidosDataGridView.Columns["Fecha"].DataPropertyName = "Fecha";
            
            partidosDataGridView.Columns.Add("Hora", "Hora");
            partidosDataGridView.Columns["Hora"].DataPropertyName = "Hora";
            
            partidosDataGridView.Columns.Add("Activo", "Activo");
            partidosDataGridView.Columns["Activo"].DataPropertyName = "Activo";
          
        }

        private void CargarTodosLosPartidos()
        {
            Partido[] partidos = servicioPartido.ObtenerPartidos();

            partidosDataGridView.DataSource = null;
            partidosDataGridView.DataSource = partidos;
        }

        private void BuscarPartidos()
        {
            string criterio = criterioComboBox.Text;
            string valor = valorBusquedaTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(valor))
            {
                CargarTodosLosPartidos();
                return;
            }

            if (criterio == "IdPartido")
            {
                BuscarPorId(valor);
                return;
            }

            if (criterio == "Rival")
            {
                Partido[] partidos = servicioPartido.BuscarPartidosPorRival(valor);
                CargarPartidosEnGrid(partidos);
                return;
            }

            if (criterio == "Activo")
            {
                BuscarPorActivo(valor);
                return;
            }
        }

        private void BuscarPorId(string valor)
        {
            int idPartido = int.Parse(valor);

            Partido partido = servicioPartido.BuscarPartidoPorId(idPartido);

            Partido[] resultado = new Partido[1];
            resultado[0] = partido;

            CargarPartidosEnGrid(resultado);
        }

        private void BuscarPorActivo(string valor)
        {
            bool activo;

            if (valor.ToUpper() == "ACTIVO" || valor.ToUpper() == "TRUE" || valor == "1")
            {
                activo = true;
            }
            else if (valor.ToUpper() == "INACTIVO" || valor.ToUpper() == "FALSE" || valor == "0")
            {
                activo = false;
            }
            else
            {
                throw new Exception(MensajesError.ValorBusquedaActivoInvalido);
            }

            Partido[] partidos = servicioPartido.ObtenerPartidos();
            Partido[] resultado = FiltrarPorActivo(partidos, activo);

            CargarPartidosEnGrid(resultado);
        }

        private Partido[] FiltrarPorActivo(Partido[] partidos, bool activo)
        {
            int coincidencias = 0;

            for (int i = 0; i < partidos.Length; i++)
            {
                if (partidos[i].Activo == activo)
                {
                    coincidencias++;
                }
            }

            Partido[] resultado = new Partido[coincidencias];
            int indiceResultado = 0;

            for (int i = 0; i < partidos.Length; i++)
            {
                if (partidos[i].Activo == activo)
                {
                    resultado[indiceResultado] = partidos[i];
                    indiceResultado++;
                }
            }

            return resultado;
        }

        private void CargarPartidosEnGrid(Partido[] partidos)
        {
            partidosDataGridView.DataSource = null;
            partidosDataGridView.DataSource = partidos;
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

            EstilosUI.AplicarEstiloDataGridView(partidosDataGridView);
        }
    }
}