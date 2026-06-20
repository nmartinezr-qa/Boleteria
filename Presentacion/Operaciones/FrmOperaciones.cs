using Boleteria.Presentacion.Utilidades;

namespace Boleteria.Presentacion.Operaciones
{
    public partial class FrmOperaciones : Form
    {
        private Form mainForm;
        private bool volverAlMain = false;
        private bool abrirFormularioHijo = false;

        public FrmOperaciones(Form mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void FrmOperaciones_Load(object sender, EventArgs e)
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

        private void localidadPorPartidoBtn_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmLocalidadPorPartido(this));
        }

        private void ventaDeEntradasBtn_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmVentaDeEntradas(this));
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
                localidadPorPartidoBtn,
                Properties.Resources.localidadPorPartido);

            EstilosUI.AplicarEstiloBotonCard(
                ventaDeEntradasBtn,
                Properties.Resources.ventas);

            EstilosUI.AplicarEstiloBotonSecundario(volverBtn);
        }
    }
}