using Boleteria.Presentacion.Utilidades;

namespace Boleteria.Presentacion.Consultas
{
    public partial class FrmConsultas : Form
    {
        private Form mainForm;
        private bool volverAlMain = false;
        private bool abrirFormularioHijo = false;

        public FrmConsultas(Form mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void FrmConsultas_Load(object sender, EventArgs e)
        {
            AplicarEstilos();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (!volverAlMain && !abrirFormularioHijo)
            {
                Application.Exit();
            }
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            volverAlMain = true;
            mainForm.Show();
            Close();
        }

        private void consultarLocalidadesBtn_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmConsultarLocalidades(this));
        }

        private void consultarPartidosBtn_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmConsultarPartidos(this));
        }

        private void consultarClientesBtn_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmConsultarClientes(this));
        }

        private void consultarVendedoresBtn_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmConsultarVendedores(this));
        }

        private void consultarLocalidadesPorPartidoBtn_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmConsultarLocalidadesPorPartido(this));
        }

        private void consultarVentasBtn_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmConsultarVentas(this));
        }

        private void AbrirFormularioHijo(Form formularioHijo)
        {
            abrirFormularioHijo = true;
            Hide();
            formularioHijo.Show();
        }

        public void MostrarFormulario()
        {
            abrirFormularioHijo = false;
            volverAlMain = false;
            Show();
        }

        private void AplicarEstilos()
        {
            EstilosUI.AplicarEstiloFormulario(this);

            EstilosUI.AplicarEstiloBotonCard(
                consultarLocalidadesBtn,
                Properties.Resources.localidades);

            EstilosUI.AplicarEstiloBotonCard(
                consultarPartidosBtn,
                Properties.Resources.partido);

            EstilosUI.AplicarEstiloBotonCard(
                consultarClientesBtn,
                Properties.Resources.clientes);

            EstilosUI.AplicarEstiloBotonCard(
                consultarVendedoresBtn,
                Properties.Resources.vendedores);

            EstilosUI.AplicarEstiloBotonCard(
                consultarLocalidadesPorPartidoBtn,
                Properties.Resources.localidadPorPartido);

            EstilosUI.AplicarEstiloBotonCard(
                consultarVentasBtn,
                Properties.Resources.ventas);

            EstilosUI.AplicarEstiloBotonSecundario(volverBtn);
        }
    }
}