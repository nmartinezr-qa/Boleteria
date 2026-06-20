namespace Boleteria.Presentacion.Consultas
{
    partial class FrmConsultarVentas
    {
        private System.ComponentModel.IContainer components = null;

        private Button volverBtn;
        private DataGridView ventasDataGridView;
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
            ventasDataGridView = new DataGridView();
            buscarPorLbl = new Label();
            criterioComboBox = new ComboBox();
            valorBusquedaLbl = new Label();
            valorBusquedaTextBox = new TextBox();
            buscarBtn = new Button();
            limpiarFiltroBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)ventasDataGridView).BeginInit();
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
            // ventasDataGridView
            // 
            ventasDataGridView.AllowUserToAddRows = false;
            ventasDataGridView.AllowUserToDeleteRows = false;
            ventasDataGridView.AllowUserToResizeColumns = false;
            ventasDataGridView.AllowUserToResizeRows = false;
            ventasDataGridView.ScrollBars = ScrollBars.Both;
            ventasDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            ventasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ventasDataGridView.Location = new Point(15, 95);
            ventasDataGridView.MultiSelect = false;
            ventasDataGridView.Name = "ventasDataGridView";
            ventasDataGridView.ReadOnly = true;
            ventasDataGridView.RowHeadersVisible = false;
            ventasDataGridView.RowHeadersWidth = 51;
            ventasDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ventasDataGridView.Size = new Size(770, 265);
            ventasDataGridView.TabIndex = 8;
            // 
            // buscarPorLbl
            // 
            buscarPorLbl.AutoSize = true;
            buscarPorLbl.Location = new Point(15, 35);
            buscarPorLbl.Name = "buscarPorLbl";
            buscarPorLbl.Size = new Size(80, 20);
            buscarPorLbl.TabIndex = 9;
            buscarPorLbl.Text = "Buscar por";
            // 
            // criterioComboBox
            // 
            criterioComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            criterioComboBox.FormattingEnabled = true;
            criterioComboBox.Location = new Point(101, 32);
            criterioComboBox.Name = "criterioComboBox";
            criterioComboBox.Size = new Size(195, 28);
            criterioComboBox.TabIndex = 10;
            // 
            // valorBusquedaLbl
            // 
            valorBusquedaLbl.AutoSize = true;
            valorBusquedaLbl.Location = new Point(315, 35);
            valorBusquedaLbl.Name = "valorBusquedaLbl";
            valorBusquedaLbl.Size = new Size(43, 20);
            valorBusquedaLbl.TabIndex = 11;
            valorBusquedaLbl.Text = "Valor";
            // 
            // valorBusquedaTextBox
            // 
            valorBusquedaTextBox.Location = new Point(364, 32);
            valorBusquedaTextBox.Name = "valorBusquedaTextBox";
            valorBusquedaTextBox.Size = new Size(200, 27);
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
            limpiarFiltroBtn.Size = new Size(114, 31);
            limpiarFiltroBtn.TabIndex = 14;
            limpiarFiltroBtn.Text = "Limpiar";
            limpiarFiltroBtn.UseVisualStyleBackColor = true;
            limpiarFiltroBtn.Click += limpiarFiltroBtn_Click;
            // 
            // FrmConsultarVentas
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
            Controls.Add(ventasDataGridView);
            Controls.Add(volverBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmConsultarVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Ventas";
            Load += FrmConsultarVentas_Load;
            ((System.ComponentModel.ISupportInitialize)ventasDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}