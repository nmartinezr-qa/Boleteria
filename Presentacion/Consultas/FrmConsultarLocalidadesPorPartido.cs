using Boleteria.Entidades;
using Boleteria.LogicaNegocio.Mensajes;
using Boleteria.LogicaNegocio.Servicios;
using Boleteria.Presentacion.Utilidades;

namespace Boleteria.Presentacion.Consultas
{
    public partial class FrmConsultarLocalidadesPorPartido : Form
    {
        private Form parentForm;
        private bool volverAlMain = false;
        private ServicioLocalidadPorPartido servicioLocalidadPorPartido;

        public FrmConsultarLocalidadesPorPartido(Form parentForm)
        {
            this.parentForm = parentForm;
            servicioLocalidadPorPartido = new ServicioLocalidadPorPartido();

            InitializeComponent();
        }

        private void FrmConsultarLocalidadesPorPartido_Load(object sender, EventArgs e)
        {
            ConfigurarCriteriosBusqueda();
            ConfigurarGrid();
            CargarTodasLasLocalidadesPorPartido();
            AplicarEstilos();
        }

        private void AplicarEstilos()
        {
            EstilosUI.AplicarEstiloFormulario(this);
            EstilosUI.AplicarEstiloLabel(buscarPorLbl);
            EstilosUI.AplicarEstiloLabel(valorBusquedaLbl);
            EstilosUI.AplicarEstiloComboBox(criterioComboBox);
            EstilosUI.AplicarEstiloTextBox(valorBusquedaTextBox);
            EstilosUI.AplicarEstiloBotonPrimario(buscarBtn);
            EstilosUI.AplicarEstiloBotonSecundario(limpiarFiltroBtn);
            EstilosUI.AplicarEstiloBotonSecundario(volverBtn);
            EstilosUI.AplicarEstiloDataGridView(localidadesPorPartidoDataGridView);
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
                BuscarLocalidadesPorPartido();
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
            CargarTodasLasLocalidadesPorPartido();
        }

        private void ConfigurarCriteriosBusqueda()
        {
            criterioComboBox.Items.Clear();
            criterioComboBox.Items.Add("IdPartido");
            criterioComboBox.Items.Add("Rival");
            criterioComboBox.Items.Add("IdLocalidad");
            criterioComboBox.Items.Add("NombreLocalidad");
            criterioComboBox.SelectedIndex = 0;
        }

        private void ConfigurarGrid()
        {
            localidadesPorPartidoDataGridView.AutoGenerateColumns = false;
            localidadesPorPartidoDataGridView.Columns.Clear();

            localidadesPorPartidoDataGridView.Columns.Add("IdPartido", "Id Partido");
            localidadesPorPartidoDataGridView.Columns["IdPartido"].DataPropertyName = "IdPartido";

            localidadesPorPartidoDataGridView.Columns.Add("Rival", "Rival");
            localidadesPorPartidoDataGridView.Columns["Rival"].DataPropertyName = "Rival";

            localidadesPorPartidoDataGridView.Columns.Add("IdLocalidad", "Id Localidad");
            localidadesPorPartidoDataGridView.Columns["IdLocalidad"].DataPropertyName = "IdLocalidad";
            localidadesPorPartidoDataGridView.Columns["IdLocalidad"].MinimumWidth = 150;

            localidadesPorPartidoDataGridView.Columns.Add("NombreLocalidad", "Localidad");
            localidadesPorPartidoDataGridView.Columns["NombreLocalidad"].DataPropertyName = "NombreLocalidad";

            localidadesPorPartidoDataGridView.Columns.Add("Precio", "Precio");
            localidadesPorPartidoDataGridView.Columns["Precio"].DataPropertyName = "Precio";

            localidadesPorPartidoDataGridView.Columns.Add("CantidadDisponible", "Disponible");
            localidadesPorPartidoDataGridView.Columns["CantidadDisponible"].DataPropertyName = "CantidadDisponible";
        }

        private void CargarTodasLasLocalidadesPorPartido()
        {
            LocalidadPorPartido[] registros =
                servicioLocalidadPorPartido.ObtenerLocalidadesPorPartido();

            CargarLocalidadesPorPartidoEnGrid(registros);
        }

        private void BuscarLocalidadesPorPartido()
        {
            string criterio = criterioComboBox.Text;
            string valor = valorBusquedaTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(valor))
            {
                CargarTodasLasLocalidadesPorPartido();
                return;
            }

            LocalidadPorPartido[] registros =
                servicioLocalidadPorPartido.ObtenerLocalidadesPorPartido();

            LocalidadPorPartido[] resultado =
                FiltrarLocalidadesPorPartido(registros, criterio, valor);

            CargarLocalidadesPorPartidoEnGrid(resultado);
        }

        private LocalidadPorPartido[] FiltrarLocalidadesPorPartido(
            LocalidadPorPartido[] registros,
            string criterio,
            string valor)
        {
            int coincidencias = ContarCoincidencias(registros, criterio, valor);
            LocalidadPorPartido[] resultado = new LocalidadPorPartido[coincidencias];

            int indiceResultado = 0;

            for (int i = 0; i < registros.Length; i++)
            {
                if (Coincide(registros[i], criterio, valor))
                {
                    resultado[indiceResultado] = registros[i];
                    indiceResultado++;
                }
            }

            return resultado;
        }

        private int ContarCoincidencias(
            LocalidadPorPartido[] registros,
            string criterio,
            string valor)
        {
            int coincidencias = 0;

            for (int i = 0; i < registros.Length; i++)
            {
                if (Coincide(registros[i], criterio, valor))
                {
                    coincidencias++;
                }
            }

            return coincidencias;
        }

        private bool Coincide(LocalidadPorPartido registro, string criterio, string valor)
        {
            if (criterio == "IdPartido")
            {
                return registro.Partido.IdPartido == int.Parse(valor);
            }

            if (criterio == "Rival")
            {
                return registro.Partido.Rival.ToUpper().Contains(valor.ToUpper());
            }

            if (criterio == "IdLocalidad")
            {
                return registro.Localidad.IdLocalidad == int.Parse(valor);
            }

            if (criterio == "NombreLocalidad")
            {
                return registro.Localidad.NombreLocalidad.ToUpper().Contains(valor.ToUpper());
            }

            return false;
        }

        private void CargarLocalidadesPorPartidoEnGrid(LocalidadPorPartido[] registros)
        {
            localidadesPorPartidoDataGridView.Rows.Clear();

            for (int i = 0; i < registros.Length; i++)
            {
                localidadesPorPartidoDataGridView.Rows.Add(
                    registros[i].Partido.IdPartido,
                    registros[i].Partido.Rival,
                    registros[i].Localidad.IdLocalidad,
                    registros[i].Localidad.NombreLocalidad,
                    registros[i].Localidad.Precio,
                    registros[i].CantidadDisponible);
            }
        }
    }
}