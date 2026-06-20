using Boleteria.Entidades;
using Boleteria.LogicaNegocio.Mensajes;
using Boleteria.LogicaNegocio.Servicios;
using Boleteria.Presentacion.Utilidades;

namespace Boleteria.Presentacion.Consultas
{
    public partial class FrmConsultarClientes : Form
    {
        private Form parentForm;
        private bool volverAlMain = false;
        private ServicioCliente servicioCliente;

        public FrmConsultarClientes(Form parentForm)
        {
            this.parentForm = parentForm;
            servicioCliente = new ServicioCliente();

            InitializeComponent();
        }

        private void FrmConsultarClientes_Load(object sender, EventArgs e)
        {
            ConfigurarCriteriosBusqueda();
            ConfigurarGrid();
            CargarTodosLosClientes();
            AplicarEstilos();
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

            EstilosUI.AplicarEstiloDataGridView(clientesDataGridView);
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
                BuscarClientes();
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
            CargarTodosLosClientes();
        }

        private void ConfigurarCriteriosBusqueda()
        {
            criterioComboBox.Items.Clear();
            criterioComboBox.Items.Add("IdCliente");
            criterioComboBox.Items.Add("Identificacion");
            criterioComboBox.Items.Add("Nombre");
            criterioComboBox.Items.Add("Apellido");
            criterioComboBox.Items.Add("Activo");
            criterioComboBox.SelectedIndex = 0;
        }

        private void ConfigurarGrid()
        {
            clientesDataGridView.AutoGenerateColumns = false;
            clientesDataGridView.Columns.Clear();

            clientesDataGridView.Columns.Add("Id", "Id Cliente");
            clientesDataGridView.Columns["Id"].DataPropertyName = "Id";

            clientesDataGridView.Columns.Add("Identificacion", "Identificación");
            clientesDataGridView.Columns["Identificacion"].DataPropertyName = "Identificacion";

            clientesDataGridView.Columns.Add("Nombre", "Nombre");
            clientesDataGridView.Columns["Nombre"].DataPropertyName = "Nombre";

            clientesDataGridView.Columns.Add("Apellido", "Apellido");
            clientesDataGridView.Columns["Apellido"].DataPropertyName = "Apellido";

            clientesDataGridView.Columns.Add("FechaNacimiento", "Fecha Nacimiento");
            clientesDataGridView.Columns["FechaNacimiento"].DataPropertyName = "FechaNacimiento";
            clientesDataGridView.Columns["FechaNacimiento"].MinimumWidth = 180;

            clientesDataGridView.Columns.Add("FechaRegistro", "Fecha Registro");
            clientesDataGridView.Columns["FechaRegistro"].DataPropertyName = "FechaRegistro";
            clientesDataGridView.Columns["FechaRegistro"].MinimumWidth = 180;

            clientesDataGridView.Columns.Add("Activo", "Activo");
            clientesDataGridView.Columns["Activo"].DataPropertyName = "Activo";
        }

        private void CargarTodosLosClientes()
        {
            Cliente[] clientes = servicioCliente.ObtenerClientes();
            CargarClientesEnGrid(clientes);
        }

        private void BuscarClientes()
        {
            string criterio = criterioComboBox.Text;
            string valor = valorBusquedaTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(valor))
            {
                CargarTodosLosClientes();
                return;
            }

            if (criterio == "IdCliente")
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
                Cliente[] clientes = servicioCliente.BuscarClientesPorNombre(valor);
                CargarClientesEnGrid(clientes);
                return;
            }

            if (criterio == "Apellido")
            {
                BuscarPorApellido(valor);
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
            int idCliente = int.Parse(valor);

            Cliente cliente = servicioCliente.BuscarClientePorId(idCliente);

            Cliente[] resultado = new Cliente[1];
            resultado[0] = cliente;

            CargarClientesEnGrid(resultado);
        }

        private void BuscarPorIdentificacion(string valor)
        {
            Cliente cliente = servicioCliente.BuscarClientePorIdentificacion(valor);

            Cliente[] resultado = new Cliente[1];
            resultado[0] = cliente;

            CargarClientesEnGrid(resultado);
        }

        private void BuscarPorApellido(string valor)
        {
            Cliente[] clientes = servicioCliente.ObtenerClientes();

            int coincidencias = 0;

            for (int i = 0; i < clientes.Length; i++)
            {
                if (clientes[i].Apellido.ToUpper().Contains(valor.ToUpper()))
                {
                    coincidencias++;
                }
            }

            Cliente[] resultado = new Cliente[coincidencias];
            int indiceResultado = 0;

            for (int i = 0; i < clientes.Length; i++)
            {
                if (clientes[i].Apellido.ToUpper().Contains(valor.ToUpper()))
                {
                    resultado[indiceResultado] = clientes[i];
                    indiceResultado++;
                }
            }

            CargarClientesEnGrid(resultado);
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

            Cliente[] clientes = servicioCliente.ObtenerClientes();

            int coincidencias = 0;

            for (int i = 0; i < clientes.Length; i++)
            {
                if (clientes[i].Activo == activo)
                {
                    coincidencias++;
                }
            }

            Cliente[] resultado = new Cliente[coincidencias];
            int indiceResultado = 0;

            for (int i = 0; i < clientes.Length; i++)
            {
                if (clientes[i].Activo == activo)
                {
                    resultado[indiceResultado] = clientes[i];
                    indiceResultado++;
                }
            }

            CargarClientesEnGrid(resultado);
        }

        private void CargarClientesEnGrid(Cliente[] clientes)
        {
            clientesDataGridView.DataSource = null;
            clientesDataGridView.DataSource = clientes;
        }
    }
}