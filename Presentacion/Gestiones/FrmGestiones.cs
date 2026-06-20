using Boleteria.Presentacion.Gestiones;
using Boleteria.Presentacion.Utilidades;

namespace Boleteria.Presentacion.Gestiones
{
    public partial class FrmGestiones : Form
    {
        private Form mainForm;
        private bool volverAlMain = false;
        private bool abrirFormularioHijo = false;

        public FrmGestiones(Form mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void Gestiones_Load(object sender, EventArgs e)
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

        private void localidadesBtn_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmLocalidades(this));
        }

        private void partidosBtn_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmPartidos(this));
        }

        private void clientesBtn_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmClientes(this));
        }

        private void vendedoresBtn_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmVendedores(this));
        }

        private void AbrirFormularioHijo(Form formularioHijo)
        {
            abrirFormularioHijo = true;
            formularioHijo.Show();
            Hide();
           
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
                localidadesBtn,
                Properties.Resources.localidades);

            EstilosUI.AplicarEstiloBotonCard(
                partidosBtn,
                Properties.Resources.partido);

            EstilosUI.AplicarEstiloBotonCard(
                clientesBtn,
                Properties.Resources.clientes);

            EstilosUI.AplicarEstiloBotonCard(
                vendedoresBtn,
                Properties.Resources.vendedores);

            EstilosUI.AplicarEstiloBotonSecundario(volverBtn);
        }

    }
}