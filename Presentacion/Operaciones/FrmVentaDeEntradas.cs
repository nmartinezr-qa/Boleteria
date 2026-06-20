using Boleteria.Entidades;
using Boleteria.LogicaNegocio.Mensajes;
using Boleteria.LogicaNegocio.Servicios;
using Boleteria.Presentacion.Utilidades;

namespace Boleteria.Presentacion.Operaciones
{
    public partial class FrmVentaDeEntradas : Form
    {
        private Form parentForm;
        private bool volverAlMain = false;

        private ServicioCliente servicioCliente;
        private ServicioVendedor servicioVendedor;
        private ServicioPartido servicioPartido;
        private ServicioLocalidadPorPartido servicioLocalidadPorPartido;
        private ServicioVenta servicioVenta;

        public FrmVentaDeEntradas(Form parentForm)
        {
            this.parentForm = parentForm;

            servicioCliente = new ServicioCliente();
            servicioVendedor = new ServicioVendedor();
            servicioPartido = new ServicioPartido();
            servicioLocalidadPorPartido = new ServicioLocalidadPorPartido();
            servicioVenta = new ServicioVenta();

            InitializeComponent();
        }

        private void FrmVentaDeEntradas_Load(object sender, EventArgs e)
        {
            AplicarEstilos();

            fechaVentaDateTimePicker.Value = DateTime.Today;

            CargarClientes();
            CargarVendedores();
            CargarPartidos();
            CargarLocalidadesPorPartidoSeleccionado();
            ActualizarDisponibilidadYTotal();
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
                Cliente cliente = ObtenerClienteSeleccionado();
                Vendedor vendedor = ObtenerVendedorSeleccionado();
                Partido partido = ObtenerPartidoSeleccionado();
                Localidad localidad = ObtenerLocalidadSeleccionada();

                int idVenta = int.Parse(idVentaTextBox.Text);
                int cantidad = int.Parse(cantidadTextBox.Text);
                DateTime fechaVenta = fechaVentaDateTimePicker.Value.Date;

                servicioVenta.RegistrarVenta(
                    idVenta,
                    cliente.Id,
                    vendedor.Id,
                    partido.IdPartido,
                    localidad.IdLocalidad,
                    cantidad,
                    fechaVenta);

                MessageBox.Show(
                    MensajesExito.VentaRegistrada,
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarFormulario();
                CargarLocalidadesPorPartidoSeleccionado();
                ActualizarDisponibilidadYTotal();
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    MensajesError.DatosDeVentaInvalidos,
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

        private void partidoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarLocalidadesPorPartidoSeleccionado();
            ActualizarDisponibilidadYTotal();
        }

        private void localidadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarDisponibilidadYTotal();
        }

        private void cantidadTextBox_TextChanged(object sender, EventArgs e)
        {
            ActualizarDisponibilidadYTotal();
        }

        private void CargarClientes()
        {
            clienteComboBox.DataSource = null;
            clienteComboBox.DataSource = servicioCliente.ObtenerClientes();
            clienteComboBox.DisplayMember = "Descripcion";
            clienteComboBox.ValueMember = "Id";
        }

        private void CargarVendedores()
        {
            vendedorComboBox.DataSource = null;
            vendedorComboBox.DataSource = servicioVendedor.ObtenerVendedores();
            vendedorComboBox.DisplayMember = "Descripcion";
            vendedorComboBox.ValueMember = "Id";
        }

        private void CargarPartidos()
        {
            partidoComboBox.DataSource = null;
            partidoComboBox.DataSource = servicioPartido.ObtenerPartidos();
            partidoComboBox.DisplayMember = "Descripcion";
            partidoComboBox.ValueMember = "IdPartido";
        }

        private void CargarLocalidadesPorPartidoSeleccionado()
        {
            Partido partido = partidoComboBox.SelectedItem as Partido;

            localidadComboBox.DataSource = null;

            if (partido == null)
            {
                return;
            }

            LocalidadPorPartido[] registros =
                servicioLocalidadPorPartido.ObtenerLocalidadesPorPartido();

            Localidad[] localidades =
                ObtenerLocalidadesDelPartido(registros, partido.IdPartido);

            localidadComboBox.DataSource = localidades;
            localidadComboBox.DisplayMember = "Descripcion";
            localidadComboBox.ValueMember = "IdLocalidad";
        }

        private Localidad[] ObtenerLocalidadesDelPartido(
            LocalidadPorPartido[] registros,
            int idPartido)
        {
            int coincidencias = 0;

            for (int i = 0; i < registros.Length; i++)
            {
                if (registros[i].Partido.IdPartido == idPartido)
                {
                    coincidencias++;
                }
            }

            Localidad[] localidades = new Localidad[coincidencias];
            int indice = 0;

            for (int i = 0; i < registros.Length; i++)
            {
                if (registros[i].Partido.IdPartido == idPartido)
                {
                    localidades[indice] = registros[i].Localidad;
                    indice++;
                }
            }

            return localidades;
        }

        private void ActualizarDisponibilidadYTotal()
        {
            disponibilidadTextBox.Clear();
            totalTextBox.Clear();

            Partido partido = partidoComboBox.SelectedItem as Partido;
            Localidad localidad = localidadComboBox.SelectedItem as Localidad;

            if (partido == null || localidad == null)
            {
                return;
            }

            LocalidadPorPartido registro =
                servicioLocalidadPorPartido.BuscarPorPartidoYLocalidad(
                    partido.IdPartido,
                    localidad.IdLocalidad);

            disponibilidadTextBox.Text = registro.CantidadDisponible.ToString();

            int cantidad;

            if (!int.TryParse(cantidadTextBox.Text, out cantidad))
            {
                return;
            }

            decimal total = servicioVenta.CalcularMontoTotal(
                cantidad,
                localidad.Precio);

            totalTextBox.Text = total.ToString();
        }

        private Cliente ObtenerClienteSeleccionado()
        {
            if (clienteComboBox.SelectedItem == null)
            {
                throw new Exception(MensajesError.ClienteNoSeleccionado);
            }

            return (Cliente)clienteComboBox.SelectedItem;
        }

        private Vendedor ObtenerVendedorSeleccionado()
        {
            if (vendedorComboBox.SelectedItem == null)
            {
                throw new Exception(MensajesError.VendedorNoSeleccionado);
            }

            return (Vendedor)vendedorComboBox.SelectedItem;
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
            idVentaTextBox.Clear();
            cantidadTextBox.Clear();
            disponibilidadTextBox.Clear();
            totalTextBox.Clear();

            fechaVentaDateTimePicker.Value = DateTime.Today;

            if (clienteComboBox.Items.Count > 0)
            {
                clienteComboBox.SelectedIndex = 0;
            }

            if (vendedorComboBox.Items.Count > 0)
            {
                vendedorComboBox.SelectedIndex = 0;
            }

            if (partidoComboBox.Items.Count > 0)
            {
                partidoComboBox.SelectedIndex = 0;
            }

            idVentaTextBox.Focus();
        }

        private void AplicarEstilos()
        {
            EstilosUI.AplicarEstiloFormulario(this);

            EstilosUI.AplicarEstiloTitulo(tituloLbl);
            EstilosUI.AplicarEstiloGroupBox(datosVentaGroupBox);

            EstilosUI.AplicarEstiloLabel(idVentaLbl);
            EstilosUI.AplicarEstiloLabel(clienteLbl);
            EstilosUI.AplicarEstiloLabel(vendedorLbl);
            EstilosUI.AplicarEstiloLabel(partidoLbl);
            EstilosUI.AplicarEstiloLabel(localidadLbl);
            EstilosUI.AplicarEstiloLabel(cantidadLbl);
            EstilosUI.AplicarEstiloLabel(disponibilidadLbl);
            EstilosUI.AplicarEstiloLabel(fechaVentaLbl);
            EstilosUI.AplicarEstiloLabel(totalLbl);
            EstilosUI.AplicarEstiloLabel(tipoVentaLbl);
            EstilosUI.AplicarEstiloLabel(tipoVentaValorLbl);

            EstilosUI.AplicarEstiloTextBox(idVentaTextBox);
            EstilosUI.AplicarEstiloTextBox(cantidadTextBox);
            EstilosUI.AplicarEstiloTextBox(disponibilidadTextBox);
            EstilosUI.AplicarEstiloTextBox(totalTextBox);

            EstilosUI.AplicarEstiloComboBox(clienteComboBox);
            EstilosUI.AplicarEstiloComboBox(vendedorComboBox);
            EstilosUI.AplicarEstiloComboBox(partidoComboBox);
            EstilosUI.AplicarEstiloComboBox(localidadComboBox);

            EstilosUI.AplicarEstiloDateTimePicker(fechaVentaDateTimePicker);

            EstilosUI.AplicarEstiloBotonSecundario(volverBtn);
            EstilosUI.AplicarEstiloBotonPrimario(guardarBtn);
        }
    }
}