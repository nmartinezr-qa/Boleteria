using System.Drawing;
using System.Windows.Forms;

namespace Boleteria.Presentacion.Utilidades
{
    public static class EstilosUI
    {
        public static readonly Color Fondo =
            Color.FromArgb(245, 247, 250);

        public static readonly Color Verde =
            Color.FromArgb(25, 135, 84);

        public static readonly Color Azul =
            Color.FromArgb(13, 110, 253);

        public static readonly Color Gris =
            Color.FromArgb(108, 117, 125);

        public static readonly Color Amarillo =
            Color.FromArgb(255, 193, 7);

        public static readonly Color TextoOscuro =
            Color.FromArgb(33, 37, 41);

        public static readonly Color Etiqueta =
            Color.FromArgb(73, 80, 87);

        public static void AplicarEstiloFormulario(Form formulario)
        {
            formulario.BackColor = Fondo;
        }

        public static void AplicarEstiloTitulo(Label titulo)
        {
            titulo.Font = new Font(
                "Segoe UI Semibold",
                18F,
                FontStyle.Regular);

            titulo.ForeColor = TextoOscuro;
        }
        public static void AplicarEstiloBotonMenu(Button boton)
        {
            boton.BackColor = Color.White;

            boton.ForeColor =
                Color.FromArgb(33, 37, 41);

            boton.FlatStyle = FlatStyle.Flat;

            boton.FlatAppearance.BorderColor =
                Color.FromArgb(222, 226, 230);

            boton.FlatAppearance.BorderSize = 1;

            boton.Font = new Font(
                "Segoe UI Semibold",
                12F,
                FontStyle.Regular);

            boton.Cursor = Cursors.Hand;

            AplicarHover(boton);
        }

        public static void AplicarEstiloBotonCard(
     Button boton,
     Image icono)
        {
            boton.BackColor = Color.White;

            boton.ForeColor =
                Color.FromArgb(33, 37, 41);

            boton.FlatStyle = FlatStyle.Flat;

            boton.FlatAppearance.BorderColor =
                Color.FromArgb(222, 226, 230);

            boton.FlatAppearance.BorderSize = 1;

            boton.Font = new Font(
                "Segoe UI Semibold",
                12F,
                FontStyle.Regular);

            boton.Cursor = Cursors.Hand;

            boton.Image = icono;

            boton.TextImageRelation =
                TextImageRelation.ImageAboveText;

            boton.Image = new Bitmap(icono, new Size(64, 64));
            boton.TextAlign =
                ContentAlignment.BottomCenter;
        
            AplicarHoverCard(boton);
        }

        private static void AplicarHoverCard(Button boton)
        {
            Color colorNormal = Color.White;
            Color colorHover = Color.FromArgb(230, 244, 234);
            Color colorClick = Color.FromArgb(233, 236, 239);

            boton.MouseEnter += (s, e) =>
            {
                boton.BackColor = colorHover;
            };

            boton.MouseLeave += (s, e) =>
            {
                boton.BackColor = colorNormal;
            };

            boton.MouseDown += (s, e) =>
            {
                boton.BackColor = colorClick;
            };

            boton.MouseUp += (s, e) =>
            {
                boton.BackColor = colorHover;
            };
        }

        private static void AplicarHover(Button boton)
        {
            Color colorNormal = Color.White;
            Color colorHover = Color.FromArgb(248, 249, 250);

            boton.MouseEnter += (s, e) =>
            {
                boton.BackColor = colorHover;
            };

            boton.MouseLeave += (s, e) =>
            {
                boton.BackColor = colorNormal;
            };
        }

        public static void AplicarEstiloLabel(Label label)
        {
            label.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Regular);

            label.ForeColor = Etiqueta;
        }

        public static void AplicarEstiloTextBox(TextBox textBox)
        {
            textBox.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Regular);

            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.BackColor = Color.White;
        }

        public static void AplicarEstiloComboBox(ComboBox comboBox)
        {
            comboBox.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Regular);

            comboBox.BackColor = Color.White;
        }

        public static void AplicarEstiloDateTimePicker(
            DateTimePicker dateTimePicker)
        {
            dateTimePicker.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Regular);
        }

        public static void AplicarEstiloGroupBox(GroupBox groupBox)
        {
            groupBox.Font = new Font(
                "Segoe UI Semibold",
                10F,
                FontStyle.Regular);

            groupBox.ForeColor =
                Color.FromArgb(52, 58, 64);
        }

        public static void AplicarEstiloBotonPrimario(Button boton)
        {
            boton.BackColor = Verde;
            boton.ForeColor = Color.White;

            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;

            boton.Font = new Font(
                "Segoe UI Semibold",
                10F,
                FontStyle.Regular);
        }

        public static void AplicarEstiloBotonSecundario(Button boton)
        {
            boton.BackColor = Gris;
            boton.ForeColor = Color.White;

            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;

            boton.Font = new Font(
                "Segoe UI Semibold",
                10F,
                FontStyle.Regular);
        }

        public static void AplicarEstiloBotonBusqueda(Button boton)
        {
            boton.BackColor = Azul;
            boton.ForeColor = Color.White;

            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;

            boton.Font = new Font(
                "Segoe UI Semibold",
                10F,
                FontStyle.Regular);
        }

        public static void AplicarEstiloBotonLimpiar(Button boton)
        {
            boton.BackColor = Amarillo;
            boton.ForeColor = Color.Black;

            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;

            boton.Font = new Font(
                "Segoe UI Semibold",
                10F,
                FontStyle.Regular);
        }

        public static void AplicarEstiloDataGridView(DataGridView dataGridView)
        {
            dataGridView.EnableHeadersVisualStyles = false;

            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.FixedSingle;

            dataGridView.RowHeadersVisible = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AllowUserToResizeColumns = false;

            dataGridView.ReadOnly = true;
            dataGridView.MultiSelect = false;

            dataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridView.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(52, 58, 64);

            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                Color.FromArgb(52, 58, 64);

            dataGridView.ColumnHeadersDefaultCellStyle.SelectionForeColor =
                Color.White;

            dataGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(
                    "Segoe UI Semibold",
                    10F,
                    FontStyle.Regular);

            dataGridView.RowTemplate.Height = 28;

            dataGridView.DefaultCellStyle.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Regular);

            dataGridView.DefaultCellStyle.BackColor = Color.White;
            dataGridView.DefaultCellStyle.ForeColor = Color.FromArgb(33, 37, 41);

            dataGridView.DefaultCellStyle.SelectionBackColor =
                Color.White;

            dataGridView.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(33, 37, 41);

            dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor =
                Color.White;

            dataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(33, 37, 41);

            dataGridView.ClearSelection();
        }
    }
}