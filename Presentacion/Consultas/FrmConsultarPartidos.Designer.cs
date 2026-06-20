namespace Boleteria.Presentacion.Consultas
{
    partial class FrmConsultarPartidos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tituloLbl = new Label();
            busquedaGroupBox = new GroupBox();
            buscarPorLbl = new Label();
            criterioComboBox = new ComboBox();
            valorBusquedaLbl = new Label();
            valorBusquedaTextBox = new TextBox();
            buscarBtn = new Button();
            limpiarFiltroBtn = new Button();
            volverBtn = new Button();
            partidosDataGridView = new DataGridView();
            busquedaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)partidosDataGridView).BeginInit();
            SuspendLayout();
            // 
            // tituloLbl
            // 
            tituloLbl.AutoSize = true;
            tituloLbl.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            tituloLbl.Location = new Point(270, 15);
            tituloLbl.Name = "tituloLbl";
            tituloLbl.Size = new Size(244, 37);
            tituloLbl.TabIndex = 0;
            tituloLbl.Text = "Consulta Partidos";
            // 
            // busquedaGroupBox
            // 
            busquedaGroupBox.Controls.Add(buscarPorLbl);
            busquedaGroupBox.Controls.Add(criterioComboBox);
            busquedaGroupBox.Controls.Add(valorBusquedaLbl);
            busquedaGroupBox.Controls.Add(valorBusquedaTextBox);
            busquedaGroupBox.Controls.Add(buscarBtn);
            busquedaGroupBox.Controls.Add(limpiarFiltroBtn);
            busquedaGroupBox.Location = new Point(25, 65);
            busquedaGroupBox.Name = "busquedaGroupBox";
            busquedaGroupBox.Size = new Size(750, 85);
            busquedaGroupBox.TabIndex = 1;
            busquedaGroupBox.TabStop = false;
            // 
            // buscarPorLbl
            // 
            buscarPorLbl.AutoSize = true;
            buscarPorLbl.Location = new Point(15, 37);
            buscarPorLbl.Name = "buscarPorLbl";
            buscarPorLbl.Size = new Size(79, 20);
            buscarPorLbl.TabIndex = 0;
            buscarPorLbl.Text = "Buscar por";
            // 
            // criterioComboBox
            // 
            criterioComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            criterioComboBox.FormattingEnabled = true;
            criterioComboBox.Location = new Point(114, 34);
            criterioComboBox.Name = "criterioComboBox";
            criterioComboBox.Size = new Size(147, 28);
            criterioComboBox.TabIndex = 1;
            // 
            // valorBusquedaLbl
            // 
            valorBusquedaLbl.AutoSize = true;
            valorBusquedaLbl.Location = new Point(285, 37);
            valorBusquedaLbl.Name = "valorBusquedaLbl";
            valorBusquedaLbl.Size = new Size(43, 20);
            valorBusquedaLbl.TabIndex = 2;
            valorBusquedaLbl.Text = "Valor";
            // 
            // valorBusquedaTextBox
            // 
            valorBusquedaTextBox.Location = new Point(334, 34);
            valorBusquedaTextBox.Name = "valorBusquedaTextBox";
            valorBusquedaTextBox.Size = new Size(180, 27);
            valorBusquedaTextBox.TabIndex = 3;
            // 
            // buscarBtn
            // 
            buscarBtn.Location = new Point(535, 31);
            buscarBtn.Name = "buscarBtn";
            buscarBtn.Size = new Size(90, 33);
            buscarBtn.TabIndex = 4;
            buscarBtn.Text = "Buscar";
            buscarBtn.UseVisualStyleBackColor = true;
            buscarBtn.Click += buscarBtn_Click;
            // 
            // limpiarFiltroBtn
            // 
            limpiarFiltroBtn.Location = new Point(635, 31);
            limpiarFiltroBtn.Name = "limpiarFiltroBtn";
            limpiarFiltroBtn.Size = new Size(95, 33);
            limpiarFiltroBtn.TabIndex = 5;
            limpiarFiltroBtn.Text = "Limpiar";
            limpiarFiltroBtn.UseVisualStyleBackColor = true;
            limpiarFiltroBtn.Click += limpiarFiltroBtn_Click;
            // 
            // volverBtn
            // 
            volverBtn.Location = new Point(330, 392);
            volverBtn.Name = "volverBtn";
            volverBtn.Size = new Size(140, 48);
            volverBtn.TabIndex = 7;
            volverBtn.Text = "Volver";
            volverBtn.UseVisualStyleBackColor = true;
            volverBtn.Click += volverBtn_Click;
            // 
            // partidosDataGridView
            // 
            partidosDataGridView.AllowUserToAddRows = false;
            partidosDataGridView.AllowUserToDeleteRows = false;
            partidosDataGridView.AllowUserToResizeColumns = false;
            partidosDataGridView.AllowUserToResizeRows = false;
            partidosDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            partidosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            partidosDataGridView.Location = new Point(25, 165);
            partidosDataGridView.MultiSelect = false;
            partidosDataGridView.Name = "partidosDataGridView";
            partidosDataGridView.ReadOnly = true;
            partidosDataGridView.RowHeadersVisible = false;
            partidosDataGridView.RowHeadersWidth = 51;
            partidosDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            partidosDataGridView.Size = new Size(750, 210);
            partidosDataGridView.TabIndex = 8;
            // 
            // FrmConsultarPartidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 460);
            Controls.Add(volverBtn);
            Controls.Add(partidosDataGridView);
            Controls.Add(busquedaGroupBox);
            Controls.Add(tituloLbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmConsultarPartidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Partidos";
            Load += FrmConsultarPartidos_Load;
            busquedaGroupBox.ResumeLayout(false);
            busquedaGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)partidosDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button volverBtn;
        private DataGridView partidosDataGridView;
        private Label buscarPorLbl;
        private ComboBox criterioComboBox;
        private Label valorBusquedaLbl;
        private TextBox valorBusquedaTextBox;
        private Button buscarBtn;
        private Button limpiarFiltroBtn;
        private Label tituloLbl;
        private GroupBox busquedaGroupBox;
    }
}