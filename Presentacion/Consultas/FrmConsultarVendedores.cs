using Boleteria.Entidades;
using Boleteria.LogicaNegocio.Mensajes;
using Boleteria.LogicaNegocio.Servicios;
using Boleteria.Presentacion.Utilidades;

namespace Boleteria.Presentacion.Consultas
{
    public partial class FrmConsultarVendedores : Form
    {
        private Form parentForm;
        private bool volverAlMain = false;
        private ServicioVendedor servicioVendedor;

        public FrmConsultarVendedores(Form parentForm)
        {
            this.parentForm = parentForm;
            servicioVendedor = new ServicioVendedor();

            InitializeComponent();
        }

        private void FrmConsultarVendedores_Load(object sender, EventArgs e)
        {
            AplicarEstilos();

            ConfigurarCriteriosBusqueda();
            ConfigurarGrid();
            CargarTodosLosVendedores();
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
                BuscarVendedores();
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

            CargarTodosLosVendedores();
        }

        private void ConfigurarCriteriosBusqueda()
        {
            criterioComboBox.Items.Clear();

            criterioComboBox.Items.Add("IdVendedor");
            criterioComboBox.Items.Add("Identificacion");
            criterioComboBox.Items.Add("Nombre");
            criterioComboBox.Items.Add("Apellido");

            criterioComboBox.SelectedIndex = 0;
        }

        private void ConfigurarGrid()
        {
            vendedoresDataGridView.AutoGenerateColumns = false;
            vendedoresDataGridView.Columns.Clear();

            vendedoresDataGridView.Columns.Add("Id", "Id Vendedor");
            vendedoresDataGridView.Columns["Id"].DataPropertyName = "Id";
            vendedoresDataGridView.Columns["Id"].MinimumWidth = 160;

            vendedoresDataGridView.Columns.Add("Identificacion", "Identificación");
            vendedoresDataGridView.Columns["Identificacion"].DataPropertyName = "Identificacion";
            vendedoresDataGridView.Columns["Identificacion"].MinimumWidth = 150;

            vendedoresDataGridView.Columns.Add("Nombre", "Nombre");
            vendedoresDataGridView.Columns["Nombre"].DataPropertyName = "Nombre";
            vendedoresDataGridView.Columns["Nombre"].MinimumWidth = 150;

            vendedoresDataGridView.Columns.Add("Apellido", "Apellido");
            vendedoresDataGridView.Columns["Apellido"].DataPropertyName = "Apellido";
            vendedoresDataGridView.Columns["Apellido"].MinimumWidth = 150;

            vendedoresDataGridView.Columns.Add("FechaNacimiento", "Fecha Nacimiento");
            vendedoresDataGridView.Columns["FechaNacimiento"].DataPropertyName = "FechaNacimiento";
            vendedoresDataGridView.Columns["FechaNacimiento"].MinimumWidth = 180;

            vendedoresDataGridView.Columns.Add("FechaIngreso", "Fecha Ingreso");
            vendedoresDataGridView.Columns["FechaIngreso"].DataPropertyName = "FechaIngreso";
            vendedoresDataGridView.Columns["FechaIngreso"].MinimumWidth = 170;
        }

        private void CargarTodosLosVendedores()
        {
            Vendedor[] vendedores = servicioVendedor.ObtenerVendedores();

            CargarVendedoresEnGrid(vendedores);
        }

        private void BuscarVendedores()
        {
            string criterio = criterioComboBox.Text;
            string valor = valorBusquedaTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(valor))
            {
                CargarTodosLosVendedores();
                return;
            }

            if (criterio == "IdVendedor")
            {
                BuscarPorId(valor);
                return;
            }

            if (criterio == "Identificacion")
            {
                BuscarPorIdentificacion(valor);
                return;
            }

            if (criterio == "Nombre")
            {
                Vendedor[] vendedores =
                    servicioVendedor.BuscarVendedoresPorNombre(valor);

                CargarVendedoresEnGrid(vendedores);
                return;
            }

            if (criterio == "Apellido")
            {
                BuscarPorApellido(valor);
            }
        }

        private void BuscarPorId(string valor)
        {
            int idVendedor = int.Parse(valor);

            Vendedor vendedor =
                servicioVendedor.BuscarVendedorPorId(idVendedor);

            Vendedor[] resultado = new Vendedor[1];
            resultado[0] = vendedor;

            CargarVendedoresEnGrid(resultado);
        }

        private void BuscarPorIdentificacion(string valor)
        {
            Vendedor vendedor =
                servicioVendedor.BuscarVendedorPorIdentificacion(valor);

            Vendedor[] resultado = new Vendedor[1];
            resultado[0] = vendedor;

            CargarVendedoresEnGrid(resultado);
        }

        private void BuscarPorApellido(string valor)
        {
            Vendedor[] vendedores =
                servicioVendedor.ObtenerVendedores();

            int coincidencias = 0;

            for (int i = 0; i < vendedores.Length; i++)
            {
                if (vendedores[i].Apellido.ToUpper().Contains(valor.ToUpper()))
                {
                    coincidencias++;
                }
            }

            Vendedor[] resultado = new Vendedor[coincidencias];
            int indiceResultado = 0;

            for (int i = 0; i < vendedores.Length; i++)
            {
                if (vendedores[i].Apellido.ToUpper().Contains(valor.ToUpper()))
                {
                    resultado[indiceResultado] = vendedores[i];
                    indiceResultado++;
                }
            }

            CargarVendedoresEnGrid(resultado);
        }

        private void CargarVendedoresEnGrid(Vendedor[] vendedores)
        {
            vendedoresDataGridView.DataSource = null;
            vendedoresDataGridView.DataSource = vendedores;
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

            EstilosUI.AplicarEstiloDataGridView(vendedoresDataGridView);
        }
    }
}