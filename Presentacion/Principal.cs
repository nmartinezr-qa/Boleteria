using Boleteria.Presentacion.Consultas;
using Boleteria.Presentacion.Gestiones;
using Boleteria.Presentacion.Operaciones;
using Boleteria.Presentacion.Utilidades;

namespace Boleteria.Presentacion
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            AplicarEstilos();
        }

        private void gestionBtn_Click(object sender, EventArgs e)
        {
            FrmGestiones frmGestiones = new FrmGestiones(this);
            Hide();
            frmGestiones.Show();
        }

        private void operacionesBtn_Click(object sender, EventArgs e)
        {
            FrmOperaciones frmOperaciones = new FrmOperaciones(this);
            Hide();
            frmOperaciones.Show();
        }

        private void consultasBtn_Click(object sender, EventArgs e)
        {
            FrmConsultas frmConsultas = new FrmConsultas(this);
            Hide();
            frmConsultas.Show();
        }

        private void AplicarEstilos()
        {
            EstilosUI.AplicarEstiloBotonCard(
    gestionBtn,
    Properties.Resources.gestiones);

            EstilosUI.AplicarEstiloBotonCard(
                operacionesBtn,
                Properties.Resources.operaciones);

            EstilosUI.AplicarEstiloBotonCard(
                consultasBtn,
                Properties.Resources.consultas);
        }
    }
}