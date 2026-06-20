namespace Boleteria.Presentacion.Gestiones
{
    partial class FrmClientes
    {
        private System.ComponentModel.IContainer components = null;

        private Button volverBtn;
        private Button guardarBtn;

        private TextBox idClienteTextBox;
        private TextBox identificacionTextBox;
        private TextBox nombreTextBox;
        private TextBox apellidoTextBox;

        private DateTimePicker fechaNacimientoDateTimePicker;
        private DateTimePicker fechaRegistroDateTimePicker;

        private CheckBox activoCheckBox;

        private Label tituloLbl;
        private Label idClienteLbl;
        private Label identificacionLbl;
        private Label nombreLbl;
        private Label apellidoLbl;
        private Label fechaNacimientoLbl;
        private Label fechaRegistroLbl;

        private GroupBox datosClienteGroupBox;

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
            idClienteTextBox = new TextBox();
            identificacionTextBox = new TextBox();
            nombreTextBox = new TextBox();
            apellidoTextBox = new TextBox();
            fechaNacimientoDateTimePicker = new DateTimePicker();
            fechaRegistroDateTimePicker = new DateTimePicker();
            activoCheckBox = new CheckBox();
            tituloLbl = new Label();
            idClienteLbl = new Label();
            identificacionLbl = new Label();
            nombreLbl = new Label();
            apellidoLbl = new Label();
            fechaNacimientoLbl = new Label();
            fechaRegistroLbl = new Label();
            datosClienteGroupBox = new GroupBox();
            datosClienteGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // tituloLbl
            // 
            tituloLbl.AutoSize = true;
            tituloLbl.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            tituloLbl.Location = new Point(286, 20);
            tituloLbl.Name = "tituloLbl";
            tituloLbl.Size = new Size(230, 37);
            tituloLbl.TabIndex = 0;
            tituloLbl.Text = "Registro Cliente";
            // 
            // datosClienteGroupBox
            // 
            datosClienteGroupBox.Controls.Add(idClienteLbl);
            datosClienteGroupBox.Controls.Add(idClienteTextBox);
            datosClienteGroupBox.Controls.Add(identificacionLbl);
            datosClienteGroupBox.Controls.Add(identificacionTextBox);
            datosClienteGroupBox.Controls.Add(nombreLbl);
            datosClienteGroupBox.Controls.Add(nombreTextBox);
            datosClienteGroupBox.Controls.Add(apellidoLbl);
            datosClienteGroupBox.Controls.Add(apellidoTextBox);
            datosClienteGroupBox.Controls.Add(fechaNacimientoLbl);
            datosClienteGroupBox.Controls.Add(fechaNacimientoDateTimePicker);
            datosClienteGroupBox.Controls.Add(fechaRegistroLbl);
            datosClienteGroupBox.Controls.Add(fechaRegistroDateTimePicker);
            datosClienteGroupBox.Controls.Add(activoCheckBox);
            datosClienteGroupBox.Location = new Point(130, 75);
            datosClienteGroupBox.Name = "datosClienteGroupBox";
            datosClienteGroupBox.Size = new Size(540, 285);
            datosClienteGroupBox.TabIndex = 1;
            datosClienteGroupBox.TabStop = false;
            datosClienteGroupBox.Text = "";
            // 
            // idClienteLbl
            // 
            idClienteLbl.AutoSize = true;
            idClienteLbl.Location = new Point(45, 35);
            idClienteLbl.Name = "idClienteLbl";
            idClienteLbl.Size = new Size(72, 20);
            idClienteLbl.TabIndex = 2;
            idClienteLbl.Text = "Id cliente";
            // 
            // idClienteTextBox
            // 
            idClienteTextBox.Location = new Point(210, 32);
            idClienteTextBox.Name = "idClienteTextBox";
            idClienteTextBox.Size = new Size(280, 27);
            idClienteTextBox.TabIndex = 1;
            // 
            // identificacionLbl
            // 
            identificacionLbl.AutoSize = true;
            identificacionLbl.Location = new Point(45, 70);
            identificacionLbl.Name = "identificacionLbl";
            identificacionLbl.Size = new Size(102, 20);
            identificacionLbl.TabIndex = 3;
            identificacionLbl.Text = "Identificación";
            // 
            // identificacionTextBox
            // 
            identificacionTextBox.Location = new Point(210, 67);
            identificacionTextBox.Name = "identificacionTextBox";
            identificacionTextBox.Size = new Size(280, 27);
            identificacionTextBox.TabIndex = 2;
            // 
            // nombreLbl
            // 
            nombreLbl.AutoSize = true;
            nombreLbl.Location = new Point(45, 105);
            nombreLbl.Name = "nombreLbl";
            nombreLbl.Size = new Size(64, 20);
            nombreLbl.TabIndex = 4;
            nombreLbl.Text = "Nombre";
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(210, 102);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(280, 27);
            nombreTextBox.TabIndex = 3;
            // 
            // apellidoLbl
            // 
            apellidoLbl.AutoSize = true;
            apellidoLbl.Location = new Point(45, 140);
            apellidoLbl.Name = "apellidoLbl";
            apellidoLbl.Size = new Size(66, 20);
            apellidoLbl.TabIndex = 5;
            apellidoLbl.Text = "Apellido";
            // 
            // apellidoTextBox
            // 
            apellidoTextBox.Location = new Point(210, 137);
            apellidoTextBox.Name = "apellidoTextBox";
            apellidoTextBox.Size = new Size(280, 27);
            apellidoTextBox.TabIndex = 4;
            // 
            // fechaNacimientoLbl
            // 
            fechaNacimientoLbl.AutoSize = true;
            fechaNacimientoLbl.Location = new Point(45, 175);
            fechaNacimientoLbl.Name = "fechaNacimientoLbl";
            fechaNacimientoLbl.Size = new Size(126, 20);
            fechaNacimientoLbl.TabIndex = 6;
            fechaNacimientoLbl.Text = "Fecha nacimiento";
            // 
            // fechaNacimientoDateTimePicker
            // 
            fechaNacimientoDateTimePicker.Location = new Point(210, 172);
            fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            fechaNacimientoDateTimePicker.Size = new Size(280, 27);
            fechaNacimientoDateTimePicker.TabIndex = 5;
            // 
            // fechaRegistroLbl
            // 
            fechaRegistroLbl.AutoSize = true;
            fechaRegistroLbl.Location = new Point(45, 210);
            fechaRegistroLbl.Name = "fechaRegistroLbl";
            fechaRegistroLbl.Size = new Size(104, 20);
            fechaRegistroLbl.TabIndex = 7;
            fechaRegistroLbl.Text = "Fecha registro";
            // 
            // fechaRegistroDateTimePicker
            // 
            fechaRegistroDateTimePicker.Location = new Point(210, 207);
            fechaRegistroDateTimePicker.Name = "fechaRegistroDateTimePicker";
            fechaRegistroDateTimePicker.Size = new Size(280, 27);
            fechaRegistroDateTimePicker.TabIndex = 6;
            // 
            // activoCheckBox
            // 
            activoCheckBox.AutoCheck = true;
            activoCheckBox.AutoSize = true;
            activoCheckBox.Checked = true;
            activoCheckBox.CheckState = CheckState.Checked;
            activoCheckBox.Location = new Point(210, 245);
            activoCheckBox.Name = "activoCheckBox";
            activoCheckBox.Size = new Size(73, 24);
            activoCheckBox.TabIndex = 7;
            activoCheckBox.Text = "Activo";
            activoCheckBox.UseVisualStyleBackColor = true;
            activoCheckBox.CheckedChanged += activoCheckBox_CheckedChanged;
            // 
            // volverBtn
            // 
            volverBtn.Location = new Point(255, 375);
            volverBtn.Name = "volverBtn";
            volverBtn.Size = new Size(140, 48);
            volverBtn.TabIndex = 8;
            volverBtn.Text = "Volver";
            volverBtn.UseVisualStyleBackColor = true;
            volverBtn.Click += volverBtn_Click;
            // 
            // guardarBtn
            // 
            guardarBtn.Location = new Point(425, 375);
            guardarBtn.Name = "guardarBtn";
            guardarBtn.Size = new Size(140, 48);
            guardarBtn.TabIndex = 9;
            guardarBtn.Text = "Guardar";
            guardarBtn.UseVisualStyleBackColor = true;
            guardarBtn.Click += guardarBtn_Click;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(guardarBtn);
            Controls.Add(volverBtn);
            Controls.Add(datosClienteGroupBox);
            Controls.Add(tituloLbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            Load += FrmClientes_Load;
            datosClienteGroupBox.ResumeLayout(false);
            datosClienteGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}