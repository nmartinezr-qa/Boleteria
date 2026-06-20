namespace Boleteria.Presentacion.Operaciones
{
    partial class FrmVentaDeEntradas
    {
        private System.ComponentModel.IContainer components = null;

        private ComboBox clienteComboBox;
        private ComboBox vendedorComboBox;
        private ComboBox partidoComboBox;
        private ComboBox localidadComboBox;

        private TextBox idVentaTextBox;
        private TextBox cantidadTextBox;
        private TextBox disponibilidadTextBox;
        private TextBox totalTextBox;

        private DateTimePicker fechaVentaDateTimePicker;

        private Label tituloLbl;
        private Label idVentaLbl;
        private Label clienteLbl;
        private Label vendedorLbl;
        private Label partidoLbl;
        private Label localidadLbl;
        private Label cantidadLbl;
        private Label disponibilidadLbl;
        private Label fechaVentaLbl;
        private Label totalLbl;
        private Label tipoVentaLbl;
        private Label tipoVentaValorLbl;

        private GroupBox datosVentaGroupBox;

        private Button volverBtn;
        private Button guardarBtn;

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
            clienteComboBox = new ComboBox();
            vendedorComboBox = new ComboBox();
            partidoComboBox = new ComboBox();
            localidadComboBox = new ComboBox();
            idVentaTextBox = new TextBox();
            cantidadTextBox = new TextBox();
            disponibilidadTextBox = new TextBox();
            totalTextBox = new TextBox();
            fechaVentaDateTimePicker = new DateTimePicker();
            tituloLbl = new Label();
            idVentaLbl = new Label();
            clienteLbl = new Label();
            vendedorLbl = new Label();
            partidoLbl = new Label();
            localidadLbl = new Label();
            cantidadLbl = new Label();
            disponibilidadLbl = new Label();
            fechaVentaLbl = new Label();
            totalLbl = new Label();
            tipoVentaLbl = new Label();
            tipoVentaValorLbl = new Label();
            datosVentaGroupBox = new GroupBox();
            volverBtn = new Button();
            guardarBtn = new Button();
            datosVentaGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // clienteComboBox
            // 
            clienteComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            clienteComboBox.Location = new Point(220, 62);
            clienteComboBox.Name = "clienteComboBox";
            clienteComboBox.Size = new Size(320, 28);
            clienteComboBox.TabIndex = 2;
            // 
            // vendedorComboBox
            // 
            vendedorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            vendedorComboBox.Location = new Point(220, 99);
            vendedorComboBox.Name = "vendedorComboBox";
            vendedorComboBox.Size = new Size(320, 28);
            vendedorComboBox.TabIndex = 3;
            // 
            // partidoComboBox
            // 
            partidoComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            partidoComboBox.Location = new Point(220, 133);
            partidoComboBox.Name = "partidoComboBox";
            partidoComboBox.Size = new Size(320, 28);
            partidoComboBox.TabIndex = 4;
            partidoComboBox.SelectedIndexChanged += partidoComboBox_SelectedIndexChanged;
            // 
            // localidadComboBox
            // 
            localidadComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            localidadComboBox.Location = new Point(220, 167);
            localidadComboBox.Name = "localidadComboBox";
            localidadComboBox.Size = new Size(320, 28);
            localidadComboBox.TabIndex = 5;
            localidadComboBox.SelectedIndexChanged += localidadComboBox_SelectedIndexChanged;
            // 
            // idVentaTextBox
            // 
            idVentaTextBox.Location = new Point(220, 29);
            idVentaTextBox.Name = "idVentaTextBox";
            idVentaTextBox.Size = new Size(320, 27);
            idVentaTextBox.TabIndex = 1;
            // 
            // cantidadTextBox
            // 
            cantidadTextBox.Location = new Point(220, 206);
            cantidadTextBox.Name = "cantidadTextBox";
            cantidadTextBox.Size = new Size(320, 27);
            cantidadTextBox.TabIndex = 6;
            cantidadTextBox.TextChanged += cantidadTextBox_TextChanged;
            // 
            // disponibilidadTextBox
            // 
            disponibilidadTextBox.Location = new Point(220, 240);
            disponibilidadTextBox.Name = "disponibilidadTextBox";
            disponibilidadTextBox.ReadOnly = true;
            disponibilidadTextBox.Size = new Size(320, 27);
            disponibilidadTextBox.TabIndex = 7;
            // 
            // totalTextBox
            // 
            totalTextBox.Enabled = false;
            totalTextBox.Location = new Point(220, 308);
            totalTextBox.Name = "totalTextBox";
            totalTextBox.ReadOnly = true;
            totalTextBox.Size = new Size(320, 27);
            totalTextBox.TabIndex = 9;
            // 
            // fechaVentaDateTimePicker
            // 
            fechaVentaDateTimePicker.Location = new Point(220, 271);
            fechaVentaDateTimePicker.Name = "fechaVentaDateTimePicker";
            fechaVentaDateTimePicker.Size = new Size(320, 27);
            fechaVentaDateTimePicker.TabIndex = 8;
            // 
            // tituloLbl
            // 
            tituloLbl.AutoSize = true;
            tituloLbl.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            tituloLbl.Location = new Point(270, 12);
            tituloLbl.Name = "tituloLbl";
            tituloLbl.Size = new Size(247, 37);
            tituloLbl.TabIndex = 0;
            tituloLbl.Text = "Venta de Entradas";
            // 
            // idVentaLbl
            // 
            idVentaLbl.AutoSize = true;
            idVentaLbl.Location = new Point(45, 32);
            idVentaLbl.Name = "idVentaLbl";
            idVentaLbl.Size = new Size(62, 20);
            idVentaLbl.TabIndex = 2;
            idVentaLbl.Text = "Id venta";
            // 
            // clienteLbl
            // 
            clienteLbl.AutoSize = true;
            clienteLbl.Location = new Point(45, 67);
            clienteLbl.Name = "clienteLbl";
            clienteLbl.Size = new Size(55, 20);
            clienteLbl.TabIndex = 3;
            clienteLbl.Text = "Cliente";
            // 
            // vendedorLbl
            // 
            vendedorLbl.AutoSize = true;
            vendedorLbl.Location = new Point(45, 107);
            vendedorLbl.Name = "vendedorLbl";
            vendedorLbl.Size = new Size(73, 20);
            vendedorLbl.TabIndex = 4;
            vendedorLbl.Text = "Vendedor";
            // 
            // partidoLbl
            // 
            partidoLbl.AutoSize = true;
            partidoLbl.Location = new Point(45, 141);
            partidoLbl.Name = "partidoLbl";
            partidoLbl.Size = new Size(56, 20);
            partidoLbl.TabIndex = 5;
            partidoLbl.Text = "Partido";
            // 
            // localidadLbl
            // 
            localidadLbl.AutoSize = true;
            localidadLbl.Location = new Point(45, 175);
            localidadLbl.Name = "localidadLbl";
            localidadLbl.Size = new Size(74, 20);
            localidadLbl.TabIndex = 6;
            localidadLbl.Text = "Localidad";
            // 
            // cantidadLbl
            // 
            cantidadLbl.AutoSize = true;
            cantidadLbl.Location = new Point(45, 213);
            cantidadLbl.Name = "cantidadLbl";
            cantidadLbl.Size = new Size(69, 20);
            cantidadLbl.TabIndex = 7;
            cantidadLbl.Text = "Cantidad";
            // 
            // disponibilidadLbl
            // 
            disponibilidadLbl.AutoSize = true;
            disponibilidadLbl.Location = new Point(45, 247);
            disponibilidadLbl.Name = "disponibilidadLbl";
            disponibilidadLbl.Size = new Size(107, 20);
            disponibilidadLbl.TabIndex = 8;
            disponibilidadLbl.Text = "Disponibilidad";
            // 
            // fechaVentaLbl
            // 
            fechaVentaLbl.AutoSize = true;
            fechaVentaLbl.Location = new Point(45, 278);
            fechaVentaLbl.Name = "fechaVentaLbl";
            fechaVentaLbl.Size = new Size(87, 20);
            fechaVentaLbl.TabIndex = 9;
            fechaVentaLbl.Text = "Fecha venta";
            // 
            // totalLbl
            // 
            totalLbl.AutoSize = true;
            totalLbl.Location = new Point(45, 315);
            totalLbl.Name = "totalLbl";
            totalLbl.Size = new Size(42, 20);
            totalLbl.TabIndex = 10;
            totalLbl.Text = "Total";
            // 
            // tipoVentaLbl
            // 
            tipoVentaLbl.AutoSize = true;
            tipoVentaLbl.Location = new Point(45, 347);
            tipoVentaLbl.Name = "tipoVentaLbl";
            tipoVentaLbl.Size = new Size(100, 20);
            tipoVentaLbl.TabIndex = 11;
            tipoVentaLbl.Text = "Tipo de venta";
            // 
            // tipoVentaValorLbl
            // 
            tipoVentaValorLbl.AutoSize = true;
            tipoVentaValorLbl.Location = new Point(220, 347);
            tipoVentaValorLbl.Name = "tipoVentaValorLbl";
            tipoVentaValorLbl.Size = new Size(69, 20);
            tipoVentaValorLbl.TabIndex = 12;
            tipoVentaValorLbl.Text = "Boletería";
            // 
            // datosVentaGroupBox
            // 
            datosVentaGroupBox.Controls.Add(idVentaLbl);
            datosVentaGroupBox.Controls.Add(idVentaTextBox);
            datosVentaGroupBox.Controls.Add(clienteLbl);
            datosVentaGroupBox.Controls.Add(clienteComboBox);
            datosVentaGroupBox.Controls.Add(vendedorLbl);
            datosVentaGroupBox.Controls.Add(vendedorComboBox);
            datosVentaGroupBox.Controls.Add(partidoLbl);
            datosVentaGroupBox.Controls.Add(partidoComboBox);
            datosVentaGroupBox.Controls.Add(localidadLbl);
            datosVentaGroupBox.Controls.Add(localidadComboBox);
            datosVentaGroupBox.Controls.Add(cantidadLbl);
            datosVentaGroupBox.Controls.Add(cantidadTextBox);
            datosVentaGroupBox.Controls.Add(disponibilidadLbl);
            datosVentaGroupBox.Controls.Add(disponibilidadTextBox);
            datosVentaGroupBox.Controls.Add(fechaVentaLbl);
            datosVentaGroupBox.Controls.Add(fechaVentaDateTimePicker);
            datosVentaGroupBox.Controls.Add(totalLbl);
            datosVentaGroupBox.Controls.Add(totalTextBox);
            datosVentaGroupBox.Controls.Add(tipoVentaLbl);
            datosVentaGroupBox.Controls.Add(tipoVentaValorLbl);
            datosVentaGroupBox.Location = new Point(105, 58);
            datosVentaGroupBox.Name = "datosVentaGroupBox";
            datosVentaGroupBox.Size = new Size(587, 381);
            datosVentaGroupBox.TabIndex = 1;
            datosVentaGroupBox.TabStop = false;
            // 
            // volverBtn
            // 
            volverBtn.Location = new Point(254, 460);
            volverBtn.Name = "volverBtn";
            volverBtn.Size = new Size(140, 48);
            volverBtn.TabIndex = 10;
            volverBtn.Text = "Volver";
            volverBtn.UseVisualStyleBackColor = true;
            volverBtn.Click += volverBtn_Click;
            // 
            // guardarBtn
            // 
            guardarBtn.Location = new Point(414, 460);
            guardarBtn.Name = "guardarBtn";
            guardarBtn.Size = new Size(140, 48);
            guardarBtn.TabIndex = 11;
            guardarBtn.Text = "Guardar";
            guardarBtn.UseVisualStyleBackColor = true;
            guardarBtn.Click += guardarBtn_Click;
            // 
            // FrmVentaDeEntradas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 520);
            Controls.Add(guardarBtn);
            Controls.Add(volverBtn);
            Controls.Add(datosVentaGroupBox);
            Controls.Add(tituloLbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmVentaDeEntradas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Venta de Entradas";
            Load += FrmVentaDeEntradas_Load;
            datosVentaGroupBox.ResumeLayout(false);
            datosVentaGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}