namespace Boleteria.Presentacion.Gestiones
{
    partial class FrmVendedores
    {
        private System.ComponentModel.IContainer components = null;

        private Button volverBtn;
        private Button guardarBtn;

        private TextBox idVendedorTextBox;
        private TextBox identificacionTextBox;
        private TextBox nombreTextBox;
        private TextBox apellidoTextBox;

        private DateTimePicker fechaNacimientoDateTimePicker;
        private DateTimePicker fechaIngresoDateTimePicker;

        private Label tituloLbl;
        private Label idVendedorLbl;
        private Label identificacionLbl;
        private Label nombreLbl;
        private Label apellidoLbl;
        private Label fechaNacimientoLbl;
        private Label fechaIngresoLbl;

        private GroupBox datosVendedorGroupBox;

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
            guardarBtn = new Button();
            idVendedorTextBox = new TextBox();
            identificacionTextBox = new TextBox();
            nombreTextBox = new TextBox();
            apellidoTextBox = new TextBox();
            fechaNacimientoDateTimePicker = new DateTimePicker();
            fechaIngresoDateTimePicker = new DateTimePicker();
            tituloLbl = new Label();
            idVendedorLbl = new Label();
            identificacionLbl = new Label();
            nombreLbl = new Label();
            apellidoLbl = new Label();
            fechaNacimientoLbl = new Label();
            fechaIngresoLbl = new Label();
            datosVendedorGroupBox = new GroupBox();
            datosVendedorGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // tituloLbl
            // 
            tituloLbl.AutoSize = true;
            tituloLbl.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            tituloLbl.Location = new Point(275, 22);
            tituloLbl.Name = "tituloLbl";
            tituloLbl.Size = new Size(254, 37);
            tituloLbl.TabIndex = 0;
            tituloLbl.Text = "Registro Vendedor";
            // 
            // datosVendedorGroupBox
            // 
            datosVendedorGroupBox.Controls.Add(idVendedorLbl);
            datosVendedorGroupBox.Controls.Add(idVendedorTextBox);
            datosVendedorGroupBox.Controls.Add(identificacionLbl);
            datosVendedorGroupBox.Controls.Add(identificacionTextBox);
            datosVendedorGroupBox.Controls.Add(nombreLbl);
            datosVendedorGroupBox.Controls.Add(nombreTextBox);
            datosVendedorGroupBox.Controls.Add(apellidoLbl);
            datosVendedorGroupBox.Controls.Add(apellidoTextBox);
            datosVendedorGroupBox.Controls.Add(fechaNacimientoLbl);
            datosVendedorGroupBox.Controls.Add(fechaNacimientoDateTimePicker);
            datosVendedorGroupBox.Controls.Add(fechaIngresoLbl);
            datosVendedorGroupBox.Controls.Add(fechaIngresoDateTimePicker);
            datosVendedorGroupBox.Location = new Point(130, 85);
            datosVendedorGroupBox.Name = "datosVendedorGroupBox";
            datosVendedorGroupBox.Size = new Size(540, 255);
            datosVendedorGroupBox.TabIndex = 1;
            datosVendedorGroupBox.TabStop = false;
            datosVendedorGroupBox.Text = "";
            // 
            // idVendedorLbl
            // 
            idVendedorLbl.AutoSize = true;
            idVendedorLbl.Location = new Point(45, 35);
            idVendedorLbl.Name = "idVendedorLbl";
            idVendedorLbl.Size = new Size(86, 20);
            idVendedorLbl.TabIndex = 2;
            idVendedorLbl.Text = "Id vendedor";
            // 
            // idVendedorTextBox
            // 
            idVendedorTextBox.Location = new Point(210, 32);
            idVendedorTextBox.Name = "idVendedorTextBox";
            idVendedorTextBox.Size = new Size(280, 27);
            idVendedorTextBox.TabIndex = 1;
            // 
            // identificacionLbl
            // 
            identificacionLbl.AutoSize = true;
            identificacionLbl.Location = new Point(45, 72);
            identificacionLbl.Name = "identificacionLbl";
            identificacionLbl.Size = new Size(102, 20);
            identificacionLbl.TabIndex = 3;
            identificacionLbl.Text = "Identificación";
            // 
            // identificacionTextBox
            // 
            identificacionTextBox.Location = new Point(210, 69);
            identificacionTextBox.Name = "identificacionTextBox";
            identificacionTextBox.Size = new Size(280, 27);
            identificacionTextBox.TabIndex = 2;
            // 
            // nombreLbl
            // 
            nombreLbl.AutoSize = true;
            nombreLbl.Location = new Point(45, 109);
            nombreLbl.Name = "nombreLbl";
            nombreLbl.Size = new Size(64, 20);
            nombreLbl.TabIndex = 4;
            nombreLbl.Text = "Nombre";
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(210, 106);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(280, 27);
            nombreTextBox.TabIndex = 3;
            // 
            // apellidoLbl
            // 
            apellidoLbl.AutoSize = true;
            apellidoLbl.Location = new Point(45, 146);
            apellidoLbl.Name = "apellidoLbl";
            apellidoLbl.Size = new Size(66, 20);
            apellidoLbl.TabIndex = 5;
            apellidoLbl.Text = "Apellido";
            // 
            // apellidoTextBox
            // 
            apellidoTextBox.Location = new Point(210, 143);
            apellidoTextBox.Name = "apellidoTextBox";
            apellidoTextBox.Size = new Size(280, 27);
            apellidoTextBox.TabIndex = 4;
            // 
            // fechaNacimientoLbl
            // 
            fechaNacimientoLbl.AutoSize = true;
            fechaNacimientoLbl.Location = new Point(45, 183);
            fechaNacimientoLbl.Name = "fechaNacimientoLbl";
            fechaNacimientoLbl.Size = new Size(126, 20);
            fechaNacimientoLbl.TabIndex = 6;
            fechaNacimientoLbl.Text = "Fecha nacimiento";
            // 
            // fechaNacimientoDateTimePicker
            // 
            fechaNacimientoDateTimePicker.Location = new Point(210, 180);
            fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            fechaNacimientoDateTimePicker.Size = new Size(280, 27);
            fechaNacimientoDateTimePicker.TabIndex = 5;
            // 
            // fechaIngresoLbl
            // 
            fechaIngresoLbl.AutoSize = true;
            fechaIngresoLbl.Location = new Point(45, 220);
            fechaIngresoLbl.Name = "fechaIngresoLbl";
            fechaIngresoLbl.Size = new Size(99, 20);
            fechaIngresoLbl.TabIndex = 7;
            fechaIngresoLbl.Text = "Fecha ingreso";
            // 
            // fechaIngresoDateTimePicker
            // 
            fechaIngresoDateTimePicker.Location = new Point(210, 217);
            fechaIngresoDateTimePicker.Name = "fechaIngresoDateTimePicker";
            fechaIngresoDateTimePicker.Size = new Size(280, 27);
            fechaIngresoDateTimePicker.TabIndex = 6;
            // 
            // volverBtn
            // 
            volverBtn.Location = new Point(255, 365);
            volverBtn.Name = "volverBtn";
            volverBtn.Size = new Size(140, 48);
            volverBtn.TabIndex = 7;
            volverBtn.Text = "Volver";
            volverBtn.UseVisualStyleBackColor = true;
            volverBtn.Click += volverBtn_Click;
            // 
            // guardarBtn
            // 
            guardarBtn.Location = new Point(425, 365);
            guardarBtn.Name = "guardarBtn";
            guardarBtn.Size = new Size(140, 48);
            guardarBtn.TabIndex = 8;
            guardarBtn.Text = "Guardar";
            guardarBtn.UseVisualStyleBackColor = true;
            guardarBtn.Click += guardarBtn_Click;
            // 
            // FrmVendedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(guardarBtn);
            Controls.Add(volverBtn);
            Controls.Add(datosVendedorGroupBox);
            Controls.Add(tituloLbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmVendedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vendedores";
            Load += FrmVendedores_Load;
            datosVendedorGroupBox.ResumeLayout(false);
            datosVendedorGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}