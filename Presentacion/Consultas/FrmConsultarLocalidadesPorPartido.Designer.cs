namespace Boleteria.Presentacion.Consultas
{
    partial class FrmConsultarLocalidadesPorPartido
    {
        private System.ComponentModel.IContainer components = null;

        private Button volverBtn;
        private DataGridView localidadesPorPartidoDataGridView;
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
            volverBtn = new Button();
            localidadesPorPartidoDataGridView = new DataGridView();
            buscarPorLbl = new Label();
            criterioComboBox = new ComboBox();
            valorBusquedaLbl = new Label();
            valorBusquedaTextBox = new TextBox();
            buscarBtn = new Button();
            limpiarFiltroBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)localidadesPorPartidoDataGridView).BeginInit();
            SuspendLayout();
            // 
            // volverBtn
            // 
            volverBtn.Location = new Point(312, 387);
            volverBtn.Name = "volverBtn";
            volverBtn.Size = new Size(172, 51);
            volverBtn.TabIndex = 7;
            volverBtn.Text = "Volver";
            volverBtn.UseVisualStyleBackColor = true;
            volverBtn.Click += volverBtn_Click;
            // 
            // localidadesPorPartidoDataGridView
            // 
            localidadesPorPartidoDataGridView.AllowUserToAddRows = false;
            localidadesPorPartidoDataGridView.AllowUserToDeleteRows = false;
            localidadesPorPartidoDataGridView.AllowUserToResizeColumns = false;
            localidadesPorPartidoDataGridView.AllowUserToResizeRows = false;
            localidadesPorPartidoDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            localidadesPorPartidoDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            localidadesPorPartidoDataGridView.Location = new Point(20, 95);
            localidadesPorPartidoDataGridView.MultiSelect = false;
            localidadesPorPartidoDataGridView.Name = "localidadesPorPartidoDataGridView";
            localidadesPorPartidoDataGridView.ReadOnly = true;
            localidadesPorPartidoDataGridView.RowHeadersVisible = false;
            localidadesPorPartidoDataGridView.RowHeadersWidth = 51;
            localidadesPorPartidoDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            localidadesPorPartidoDataGridView.Size = new Size(760, 265);
            localidadesPorPartidoDataGridView.TabIndex = 8;
            // 
            // buscarPorLbl
            // 
            buscarPorLbl.AutoSize = true;
            buscarPorLbl.Location = new Point(20, 35);
            buscarPorLbl.Name = "buscarPorLbl";
            buscarPorLbl.Size = new Size(79, 20);
            buscarPorLbl.TabIndex = 9;
            buscarPorLbl.Text = "Buscar por";
            // 
            // criterioComboBox
            // 
            criterioComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            criterioComboBox.FormattingEnabled = true;
            criterioComboBox.Location = new Point(106, 32);
            criterioComboBox.Name = "criterioComboBox";
            criterioComboBox.Size = new Size(190, 28);
            criterioComboBox.TabIndex = 10;
            // 
            // valorBusquedaLbl
            // 
            valorBusquedaLbl.AutoSize = true;
            valorBusquedaLbl.Location = new Point(320, 35);
            valorBusquedaLbl.Name = "valorBusquedaLbl";
            valorBusquedaLbl.Size = new Size(43, 20);
            valorBusquedaLbl.TabIndex = 11;
            valorBusquedaLbl.Text = "Valor";
            // 
            // valorBusquedaTextBox
            // 
            valorBusquedaTextBox.Location = new Point(369, 32);
            valorBusquedaTextBox.Name = "valorBusquedaTextBox";
            valorBusquedaTextBox.Size = new Size(195, 27);
            valorBusquedaTextBox.TabIndex = 12;
            // 
            // buscarBtn
            // 
            buscarBtn.Location = new Point(580, 30);
            buscarBtn.Name = "buscarBtn";
            buscarBtn.Size = new Size(85, 31);
            buscarBtn.TabIndex = 13;
            buscarBtn.Text = "Buscar";
            buscarBtn.UseVisualStyleBackColor = true;
            buscarBtn.Click += buscarBtn_Click;
            // 
            // limpiarFiltroBtn
            // 
            limpiarFiltroBtn.Location = new Point(671, 30);
            limpiarFiltroBtn.Name = "limpiarFiltroBtn";
            limpiarFiltroBtn.Size = new Size(109, 31);
            limpiarFiltroBtn.TabIndex = 14;
            limpiarFiltroBtn.Text = "Limpiar";
            limpiarFiltroBtn.UseVisualStyleBackColor = true;
            limpiarFiltroBtn.Click += limpiarFiltroBtn_Click;
            // 
            // FrmConsultarLocalidadesPorPartido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(limpiarFiltroBtn);
            Controls.Add(buscarBtn);
            Controls.Add(valorBusquedaTextBox);
            Controls.Add(valorBusquedaLbl);
            Controls.Add(criterioComboBox);
            Controls.Add(buscarPorLbl);
            Controls.Add(localidadesPorPartidoDataGridView);
            Controls.Add(volverBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmConsultarLocalidadesPorPartido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Localidades por Partido";
            Load += FrmConsultarLocalidadesPorPartido_Load;
            ((System.ComponentModel.ISupportInitialize)localidadesPorPartidoDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}