namespace Boleteria.Presentacion.Consultas
{
    partial class FrmConsultarLocalidades
    {
        private System.ComponentModel.IContainer components = null;

        private Label tituloLbl;
        private GroupBox busquedaGroupBox;

        private Button volverBtn;
        private DataGridView localidadesDataGridView;

        private Label buscarPorLbl;
        private ComboBox criterioComboBox;

        private Label valorBusquedaLbl;
        private TextBox valorBusquedaTextBox;

        private Button buscarBtn;
        private Button limpiarFiltroBtn;

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
            localidadesDataGridView = new DataGridView();
            volverBtn = new Button();
            busquedaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)localidadesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // tituloLbl
            // 
            tituloLbl.AutoSize = true;
            tituloLbl.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            tituloLbl.Location = new Point(245, 15);
            tituloLbl.Name = "tituloLbl";
            tituloLbl.Size = new Size(287, 37);
            tituloLbl.TabIndex = 0;
            tituloLbl.Text = "Consulta Localidades";
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
            criterioComboBox.Location = new Point(110, 34);
            criterioComboBox.Name = "criterioComboBox";
            criterioComboBox.Size = new Size(160, 28);
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
            // localidadesDataGridView
            // 
            localidadesDataGridView.AllowUserToAddRows = false;
            localidadesDataGridView.AllowUserToDeleteRows = false;
            localidadesDataGridView.AllowUserToResizeColumns = false;
            localidadesDataGridView.AllowUserToResizeRows = false;
            localidadesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            localidadesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            localidadesDataGridView.EnableHeadersVisualStyles = false;
            localidadesDataGridView.Location = new Point(38, 176);
            localidadesDataGridView.MultiSelect = false;
            localidadesDataGridView.Name = "localidadesDataGridView";
            localidadesDataGridView.ReadOnly = true;
            localidadesDataGridView.RowHeadersVisible = false;
            localidadesDataGridView.RowHeadersWidth = 51;
            localidadesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            localidadesDataGridView.Size = new Size(750, 210);
            localidadesDataGridView.TabIndex = 6;
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
            // FrmConsultarLocalidades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 460);
            Controls.Add(volverBtn);
            Controls.Add(localidadesDataGridView);
            Controls.Add(busquedaGroupBox);
            Controls.Add(tituloLbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmConsultarLocalidades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Localidades";
            Load += FrmConsultarLocalidades_Load;
            busquedaGroupBox.ResumeLayout(false);
            busquedaGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)localidadesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}