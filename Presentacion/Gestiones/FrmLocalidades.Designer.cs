namespace Boleteria.Presentacion.Gestiones
{
    partial class FrmLocalidades
    {
        private System.ComponentModel.IContainer components = null;

        private Button volverBtn;
        private Button guardarBtn;
        private TextBox idLocalidadTextBox;
        private TextBox nombreLocalidadTextBox;
        private TextBox precioTextBox;
        private Label tituloLbl;
        private Label idLocalidadLbl;
        private Label nombreLocalidadLbl;
        private Label precioLbl;
        private GroupBox datosLocalidadGroupBox;

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
            idLocalidadTextBox = new TextBox();
            nombreLocalidadTextBox = new TextBox();
            precioTextBox = new TextBox();
            tituloLbl = new Label();
            idLocalidadLbl = new Label();
            nombreLocalidadLbl = new Label();
            precioLbl = new Label();
            datosLocalidadGroupBox = new GroupBox();
            datosLocalidadGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // tituloLbl
            // 
            tituloLbl.AutoSize = true;
            tituloLbl.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            tituloLbl.Location = new Point(282, 28);
            tituloLbl.Name = "tituloLbl";
            tituloLbl.Size = new Size(257, 37);
            tituloLbl.TabIndex = 0;
            tituloLbl.Text = "Registro Localidad";
            // 
            // datosLocalidadGroupBox
            // 
            datosLocalidadGroupBox.Controls.Add(precioLbl);
            datosLocalidadGroupBox.Controls.Add(nombreLocalidadLbl);
            datosLocalidadGroupBox.Controls.Add(idLocalidadLbl);
            datosLocalidadGroupBox.Controls.Add(precioTextBox);
            datosLocalidadGroupBox.Controls.Add(nombreLocalidadTextBox);
            datosLocalidadGroupBox.Controls.Add(idLocalidadTextBox);
            datosLocalidadGroupBox.Location = new Point(150, 92);
            datosLocalidadGroupBox.Name = "datosLocalidadGroupBox";
            datosLocalidadGroupBox.Size = new Size(500, 215);
            datosLocalidadGroupBox.TabIndex = 1;
            datosLocalidadGroupBox.TabStop = false;
            datosLocalidadGroupBox.Text = "";
            // 
            // idLocalidadLbl
            // 
            idLocalidadLbl.AutoSize = true;
            idLocalidadLbl.Location = new Point(45, 47);
            idLocalidadLbl.Name = "idLocalidadLbl";
            idLocalidadLbl.Size = new Size(87, 20);
            idLocalidadLbl.TabIndex = 2;
            idLocalidadLbl.Text = "Id localidad";
            // 
            // idLocalidadTextBox
            // 
            idLocalidadTextBox.Location = new Point(185, 44);
            idLocalidadTextBox.Name = "idLocalidadTextBox";
            idLocalidadTextBox.Size = new Size(260, 27);
            idLocalidadTextBox.TabIndex = 1;
            // 
            // nombreLocalidadLbl
            // 
            nombreLocalidadLbl.AutoSize = true;
            nombreLocalidadLbl.Location = new Point(45, 96);
            nombreLocalidadLbl.Name = "nombreLocalidadLbl";
            nombreLocalidadLbl.Size = new Size(64, 20);
            nombreLocalidadLbl.TabIndex = 4;
            nombreLocalidadLbl.Text = "Nombre";
            // 
            // nombreLocalidadTextBox
            // 
            nombreLocalidadTextBox.Location = new Point(185, 93);
            nombreLocalidadTextBox.Name = "nombreLocalidadTextBox";
            nombreLocalidadTextBox.Size = new Size(260, 27);
            nombreLocalidadTextBox.TabIndex = 2;
            // 
            // precioLbl
            // 
            precioLbl.AutoSize = true;
            precioLbl.Location = new Point(45, 145);
            precioLbl.Name = "precioLbl";
            precioLbl.Size = new Size(50, 20);
            precioLbl.TabIndex = 6;
            precioLbl.Text = "Precio";
            // 
            // precioTextBox
            // 
            precioTextBox.Location = new Point(185, 142);
            precioTextBox.Name = "precioTextBox";
            precioTextBox.Size = new Size(260, 27);
            precioTextBox.TabIndex = 3;
            // 
            // volverBtn
            // 
            volverBtn.Location = new Point(255, 350);
            volverBtn.Name = "volverBtn";
            volverBtn.Size = new Size(140, 48);
            volverBtn.TabIndex = 4;
            volverBtn.Text = "Volver";
            volverBtn.UseVisualStyleBackColor = true;
            volverBtn.Click += volverBtn_Click;
            // 
            // guardarBtn
            // 
            guardarBtn.Location = new Point(425, 350);
            guardarBtn.Name = "guardarBtn";
            guardarBtn.Size = new Size(140, 48);
            guardarBtn.TabIndex = 5;
            guardarBtn.Text = "Guardar";
            guardarBtn.UseVisualStyleBackColor = true;
            guardarBtn.Click += guardarBtn_Click;
            // 
            // FrmLocalidades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(guardarBtn);
            Controls.Add(volverBtn);
            Controls.Add(datosLocalidadGroupBox);
            Controls.Add(tituloLbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmLocalidades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Localidades";
            Load += FrmLocalidades_Load;
            datosLocalidadGroupBox.ResumeLayout(false);
            datosLocalidadGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}