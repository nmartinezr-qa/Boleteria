namespace Boleteria.Presentacion.Consultas
{
    partial class FrmConsultarVendedores
    {
        private System.ComponentModel.IContainer components = null;

        private Label tituloLbl;
        private GroupBox busquedaGroupBox;

        private Button volverBtn;
        private DataGridView vendedoresDataGridView;

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
            volverBtn = new Button();
            vendedoresDataGridView = new DataGridView();
            busquedaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)vendedoresDataGridView).BeginInit();
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
            tituloLbl.Text = "Consulta Vendedores";
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
            criterioComboBox.Location = new Point(115, 34);
            criterioComboBox.Name = "criterioComboBox";
            criterioComboBox.Size = new Size(146, 28);
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
            // vendedoresDataGridView
            // 
            vendedoresDataGridView.AllowUserToAddRows = false;
            vendedoresDataGridView.AllowUserToDeleteRows = false;
            vendedoresDataGridView.AllowUserToResizeColumns = false;
            vendedoresDataGridView.AllowUserToResizeRows = false;
            vendedoresDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            vendedoresDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vendedoresDataGridView.Location = new Point(25, 165);
            vendedoresDataGridView.MultiSelect = false;
            vendedoresDataGridView.Name = "vendedoresDataGridView";
            vendedoresDataGridView.ReadOnly = true;
            vendedoresDataGridView.RowHeadersVisible = false;
            vendedoresDataGridView.RowHeadersWidth = 51;
            vendedoresDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            vendedoresDataGridView.Size = new Size(750, 210);
            vendedoresDataGridView.TabIndex = 6;
            // 
            // FrmConsultarVendedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 460);
            Controls.Add(volverBtn);
            Controls.Add(vendedoresDataGridView);
            Controls.Add(busquedaGroupBox);
            Controls.Add(tituloLbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmConsultarVendedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Vendedores";
            Load += FrmConsultarVendedores_Load;
            busquedaGroupBox.ResumeLayout(false);
            busquedaGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)vendedoresDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}