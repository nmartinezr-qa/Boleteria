using Boleteria.Entidades;
using Boleteria.LogicaNegocio.Mensajes;
using Boleteria.LogicaNegocio.Servicios;
using Boleteria.Presentacion.Utilidades;

namespace Boleteria.Presentacion.Consultas
{
    public partial class FrmConsultarVentas : Form
    {
        private Form parentForm;
        private bool volverAlMain = false;
        private ServicioVenta servicioVenta;

        public FrmConsultarVentas(Form parentForm)
        {
            this.parentForm = parentForm;
            servicioVenta = new ServicioVenta();

            InitializeComponent();
        }

        private void FrmConsultarVentas_Load(object sender, EventArgs e)
        {
            ConfigurarCriteriosBusqueda();
            ConfigurarGrid();
            CargarTodasLasVentas();
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
            EstilosUI.AplicarEstiloDataGridView(ventasDataGridView);
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
                BuscarVentas();
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
            CargarTodasLasVentas();
        }

        private void ConfigurarCriteriosBusqueda()
        {
            criterioComboBox.Items.Clear();
            criterioComboBox.Items.Add("IdVenta");
            criterioComboBox.Items.Add("IdCliente");
            criterioComboBox.Items.Add("Cliente");
            criterioComboBox.Items.Add("IdVendedor");
            criterioComboBox.Items.Add("Vendedor");
            criterioComboBox.Items.Add("IdPartido");
            criterioComboBox.Items.Add("Rival");
            criterioComboBox.Items.Add("IdLocalidad");
            criterioComboBox.Items.Add("Localidad");
            criterioComboBox.SelectedIndex = 0;
        }

        private void ConfigurarGrid()
        {
            ventasDataGridView.AutoGenerateColumns = false;
            ventasDataGridView.Columns.Clear();

            ventasDataGridView.Columns.Add("IdVenta", "Id Venta");
            ventasDataGridView.Columns["IdVenta"].DataPropertyName = "IdVenta";
            ventasDataGridView.Columns["IdVenta"].Width = 120;

            ventasDataGridView.Columns.Add("IdCliente", "Id Cliente");
            ventasDataGridView.Columns["IdCliente"].DataPropertyName = "IdCliente";
            ventasDataGridView.Columns["IdCliente"].Width = 120;

            ventasDataGridView.Columns.Add("Cliente", "Cliente");
            ventasDataGridView.Columns["Cliente"].DataPropertyName = "Cliente";
            ventasDataGridView.Columns["Cliente"].Width = 130;

            ventasDataGridView.Columns.Add("IdVendedor", "Id Vendedor");
            ventasDataGridView.Columns["IdVendedor"].DataPropertyName = "IdVendedor";
            ventasDataGridView.Columns["IdVendedor"].Width = 140;

            ventasDataGridView.Columns.Add("Vendedor", "Vendedor");
            ventasDataGridView.Columns["Vendedor"].DataPropertyName = "Vendedor";
            ventasDataGridView.Columns["Vendedor"].Width = 140;

            ventasDataGridView.Columns.Add("IdPartido", "Id Partido");
            ventasDataGridView.Columns["IdPartido"].DataPropertyName = "IdPartido";
            ventasDataGridView.Columns["IdPartido"].Width = 130;

            ventasDataGridView.Columns.Add("Rival", "Rival");
            ventasDataGridView.Columns["Rival"].DataPropertyName = "Rival";
            ventasDataGridView.Columns["Rival"].Width = 120;

            ventasDataGridView.Columns.Add("IdLocalidad", "Id Localidad");
            ventasDataGridView.Columns["IdLocalidad"].DataPropertyName = "IdLocalidad";
            ventasDataGridView.Columns["IdLocalidad"].Width = 140;

            ventasDataGridView.Columns.Add("Localidad", "Localidad");
            ventasDataGridView.Columns["Localidad"].DataPropertyName = "Localidad";
            ventasDataGridView.Columns["Localidad"].Width = 110;

            ventasDataGridView.Columns.Add("Cantidad", "Cantidad");
            ventasDataGridView.Columns["Cantidad"].DataPropertyName = "Cantidad";
            ventasDataGridView.Columns["Cantidad"].Width = 100;

            ventasDataGridView.Columns.Add("FechaVenta", "Fecha Venta");
            ventasDataGridView.Columns["FechaVenta"].DataPropertyName = "FechaVenta";
            ventasDataGridView.Columns["FechaVenta"].Width = 140;

            ventasDataGridView.Columns.Add("Total", "Total");
            ventasDataGridView.Columns["Total"].DataPropertyName = "Total";
            ventasDataGridView.Columns["Total"].Width = 80;
        }

        private void CargarTodasLasVentas()
        {
            Venta[] ventas = servicioVenta.ObtenerVentas();
            CargarVentasEnGrid(ventas);
        }

        private void BuscarVentas()
        {
            string criterio = criterioComboBox.Text;
            string valor = valorBusquedaTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(valor))
            {
                CargarTodasLasVentas();
                return;
            }

            Venta[] ventas = servicioVenta.ObtenerVentas();
            Venta[] resultado = FiltrarVentas(ventas, criterio, valor);

            CargarVentasEnGrid(resultado);
        }

        private Venta[] FiltrarVentas(Venta[] ventas, string criterio, string valor)
        {
            int coincidencias = ContarCoincidencias(ventas, criterio, valor);
            Venta[] resultado = new Venta[coincidencias];

            int indiceResultado = 0;

            for (int i = 0; i < ventas.Length; i++)
            {
                if (Coincide(ventas[i], criterio, valor))
                {
                    resultado[indiceResultado] = ventas[i];
                    indiceResultado++;
                }
            }

            return resultado;
        }

        private int ContarCoincidencias(Venta[] ventas, string criterio, string valor)
        {
            int coincidencias = 0;

            for (int i = 0; i < ventas.Length; i++)
            {
                if (Coincide(ventas[i], criterio, valor))
                {
                    coincidencias++;
                }
            }

            return coincidencias;
        }

        private bool Coincide(Venta venta, string criterio, string valor)
        {
            if (criterio == "IdVenta")
            {
                return venta.IdVenta == int.Parse(valor);
            }

            if (criterio == "IdCliente")
            {
                return venta.Cliente.Id == int.Parse(valor);
            }

            if (criterio == "Cliente")
            {
                string nombreCliente = venta.Cliente.Nombre + " " + venta.Cliente.Apellido;
                return nombreCliente.ToUpper().Contains(valor.ToUpper());
            }

            if (criterio == "IdVendedor")
            {
                return venta.Vendedor.Id == int.Parse(valor);
            }

            if (criterio == "Vendedor")
            {
                string nombreVendedor = venta.Vendedor.Nombre + " " + venta.Vendedor.Apellido;
                return nombreVendedor.ToUpper().Contains(valor.ToUpper());
            }

            if (criterio == "IdPartido")
            {
                return venta.Partido.IdPartido == int.Parse(valor);
            }

            if (criterio == "Rival")
            {
                return venta.Partido.Rival.ToUpper().Contains(valor.ToUpper());
            }

            if (criterio == "IdLocalidad")
            {
                return venta.Localidad.IdLocalidad == int.Parse(valor);
            }

            if (criterio == "Localidad")
            {
                return venta.Localidad.NombreLocalidad.ToUpper().Contains(valor.ToUpper());
            }

            return false;
        }

        private void CargarVentasEnGrid(Venta[] ventas)
        {
            ventasDataGridView.Rows.Clear();

            for (int i = 0; i < ventas.Length; i++)
            {
                ventasDataGridView.Rows.Add(
                    ventas[i].IdVenta,
                    ventas[i].Cliente.Id,
                    ventas[i].Cliente.Nombre + " " + ventas[i].Cliente.Apellido,
                    ventas[i].Vendedor.Id,
                    ventas[i].Vendedor.Nombre + " " + ventas[i].Vendedor.Apellido,
                    ventas[i].Partido.IdPartido,
                    ventas[i].Partido.Rival,
                    ventas[i].Localidad.IdLocalidad,
                    ventas[i].Localidad.NombreLocalidad,
                    ventas[i].Cantidad,
                    ventas[i].FechaVenta.ToShortDateString(),
                    ventas[i].Total);
            }
        }
    }
}