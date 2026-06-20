namespace Boleteria.Presentacion.Consultas
{
    partial class FrmConsultarClientes
    {
        private System.ComponentModel.IContainer components = null;

        private Button volverBtn;
        private Label buscarPorLbl;
        private ComboBox criterioComboBox;
        private Label valorBusquedaLbl;
        private TextBox valorBusquedaTextBox;
        private Button buscarBtn;
        private Button limpiarFiltroBtn;
        private Label tituloLbl;
        private GroupBox busquedaGroupBox;
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
            volverBtn = new Button();
            clientesDataGridView = new DataGridView();
            buscarPorLbl = new Label();
            criterioComboBox = new ComboBox();
            valorBusquedaLbl = new Label();
            valorBusquedaTextBox = new TextBox();
            buscarBtn = new Button();
            limpiarFiltroBtn = new Button();
            tituloLbl = new Label();
            busquedaGroupBox = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)clientesDataGridView).BeginInit();
            busquedaGroupBox.SuspendLayout();
            SuspendLayout();
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
            // clientesDataGridView
            // 
            clientesDataGridView.AllowUserToAddRows = false;
            clientesDataGridView.AllowUserToDeleteRows = false;
            clientesDataGridView.AllowUserToResizeColumns = false;
            clientesDataGridView.AllowUserToResizeRows = false;
            clientesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientesDataGridView.Location = new Point(25, 172);
            clientesDataGridView.MultiSelect = false;
            clientesDataGridView.Name = "clientesDataGridView";
            clientesDataGridView.ReadOnly = true;
            clientesDataGridView.RowHeadersVisible = false;
            clientesDataGridView.RowHeadersWidth = 51;
            clientesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            clientesDataGridView.Size = new Size(750, 185);
            clientesDataGridView.TabIndex = 2;
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
            // tituloLbl
            // 
            tituloLbl.AutoSize = true;
            tituloLbl.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            tituloLbl.Location = new Point(265, 15);
            tituloLbl.Name = "tituloLbl";
            tituloLbl.Size = new Size(238, 37);
            tituloLbl.TabIndex = 0;
            tituloLbl.Text = "Consulta Clientes";
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
            // FrmConsultarClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 460);
            Controls.Add(tituloLbl);
            Controls.Add(busquedaGroupBox);
            Controls.Add(clientesDataGridView);
            Controls.Add(volverBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmConsultarClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Clientes";
            Load += FrmConsultarClientes_Load;
            ((System.ComponentModel.ISupportInitialize)clientesDataGridView).EndInit();
            busquedaGroupBox.ResumeLayout(false);
            busquedaGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView clientesDataGridView;
    }
}