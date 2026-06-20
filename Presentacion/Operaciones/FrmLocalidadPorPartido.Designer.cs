namespace Boleteria.Presentacion.Operaciones
{
    partial class FrmLocalidadPorPartido
    {
        private System.ComponentModel.IContainer components = null;

        private ComboBox partidoComboBox;
        private ComboBox localidadComboBox;
        private TextBox cantidadDisponibleTextBox;

        private Label tituloLbl;
        private Label partidoLbl;
        private Label localidadLbl;
        private Label cantidadDisponibleLbl;

        private GroupBox datosLocalidadPorPartidoGroupBox;

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
            partidoComboBox = new ComboBox();
            localidadComboBox = new ComboBox();
            cantidadDisponibleTextBox = new TextBox();
            tituloLbl = new Label();
            partidoLbl = new Label();
            localidadLbl = new Label();
            cantidadDisponibleLbl = new Label();
            datosLocalidadPorPartidoGroupBox = new GroupBox();
            volverBtn = new Button();
            guardarBtn = new Button();
            datosLocalidadPorPartidoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // partidoComboBox
            // 
            partidoComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            partidoComboBox.FormattingEnabled = true;
            partidoComboBox.Location = new Point(217, 45);
            partidoComboBox.Name = "partidoComboBox";
            partidoComboBox.Size = new Size(288, 28);
            partidoComboBox.TabIndex = 1;
            // 
            // localidadComboBox
            // 
            localidadComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            localidadComboBox.FormattingEnabled = true;
            localidadComboBox.Location = new Point(217, 100);
            localidadComboBox.Name = "localidadComboBox";
            localidadComboBox.Size = new Size(288, 28);
            localidadComboBox.TabIndex = 2;
            // 
            // cantidadDisponibleTextBox
            // 
            cantidadDisponibleTextBox.Location = new Point(217, 155);
            cantidadDisponibleTextBox.Name = "cantidadDisponibleTextBox";
            cantidadDisponibleTextBox.Size = new Size(288, 27);
            cantidadDisponibleTextBox.TabIndex = 3;
            // 
            // tituloLbl
            // 
            tituloLbl.AutoSize = true;
            tituloLbl.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            tituloLbl.Location = new Point(220, 28);
            tituloLbl.Name = "tituloLbl";
            tituloLbl.Size = new Size(411, 37);
            tituloLbl.TabIndex = 0;
            tituloLbl.Text = "Registro Localidad por Partido";
            // 
            // partidoLbl
            // 
            partidoLbl.AutoSize = true;
            partidoLbl.Location = new Point(45, 48);
            partidoLbl.Name = "partidoLbl";
            partidoLbl.Size = new Size(56, 20);
            partidoLbl.TabIndex = 2;
            partidoLbl.Text = "Partido";
            // 
            // localidadLbl
            // 
            localidadLbl.AutoSize = true;
            localidadLbl.Location = new Point(45, 103);
            localidadLbl.Name = "localidadLbl";
            localidadLbl.Size = new Size(74, 20);
            localidadLbl.TabIndex = 3;
            localidadLbl.Text = "Localidad";
            // 
            // cantidadDisponibleLbl
            // 
            cantidadDisponibleLbl.AutoSize = true;
            cantidadDisponibleLbl.Location = new Point(45, 158);
            cantidadDisponibleLbl.Name = "cantidadDisponibleLbl";
            cantidadDisponibleLbl.Size = new Size(143, 20);
            cantidadDisponibleLbl.TabIndex = 4;
            cantidadDisponibleLbl.Text = "Cantidad disponible";
            // 
            // datosLocalidadPorPartidoGroupBox
            // 
            datosLocalidadPorPartidoGroupBox.Controls.Add(partidoLbl);
            datosLocalidadPorPartidoGroupBox.Controls.Add(partidoComboBox);
            datosLocalidadPorPartidoGroupBox.Controls.Add(localidadLbl);
            datosLocalidadPorPartidoGroupBox.Controls.Add(localidadComboBox);
            datosLocalidadPorPartidoGroupBox.Controls.Add(cantidadDisponibleLbl);
            datosLocalidadPorPartidoGroupBox.Controls.Add(cantidadDisponibleTextBox);
            datosLocalidadPorPartidoGroupBox.Location = new Point(125, 92);
            datosLocalidadPorPartidoGroupBox.Name = "datosLocalidadPorPartidoGroupBox";
            datosLocalidadPorPartidoGroupBox.Size = new Size(550, 220);
            datosLocalidadPorPartidoGroupBox.TabIndex = 1;
            datosLocalidadPorPartidoGroupBox.TabStop = false;
            // 
            // volverBtn
            // 
            volverBtn.Location = new Point(255, 360);
            volverBtn.Name = "volverBtn";
            volverBtn.Size = new Size(140, 48);
            volverBtn.TabIndex = 4;
            volverBtn.Text = "Volver";
            volverBtn.UseVisualStyleBackColor = true;
            volverBtn.Click += volverBtn_Click;
            // 
            // guardarBtn
            // 
            guardarBtn.Location = new Point(425, 360);
            guardarBtn.Name = "guardarBtn";
            guardarBtn.Size = new Size(140, 48);
            guardarBtn.TabIndex = 5;
            guardarBtn.Text = "Guardar";
            guardarBtn.UseVisualStyleBackColor = true;
            guardarBtn.Click += guardarBtn_Click;
            // 
            // FrmLocalidadPorPartido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(guardarBtn);
            Controls.Add(volverBtn);
            Controls.Add(datosLocalidadPorPartidoGroupBox);
            Controls.Add(tituloLbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmLocalidadPorPartido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Localidad por Partido";
            Load += FrmLocalidadPorPartido_Load;
            datosLocalidadPorPartidoGroupBox.ResumeLayout(false);
            datosLocalidadPorPartidoGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}