namespace Boleteria.Presentacion.Gestiones
{
    partial class FrmPartidos
    {
        private System.ComponentModel.IContainer components = null;

        private Button volverBtn;
        private TextBox idPartidoTextBox;
        private Label idPartidoLbl;
        private Label rivalLbl;
        private TextBox rivalTextBox;
        private TextBox horaTextBox;
        private Label horaLbl;
        private DateTimePicker fechaDateTimePicker;
        private Label fechaLbl;
        private CheckBox activoCheckBox;
        private Button guardarBtn;
        private Label tituloLbl;
        private GroupBox datosPartidoGroupBox;

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
            idPartidoTextBox = new TextBox();
            idPartidoLbl = new Label();
            rivalLbl = new Label();
            rivalTextBox = new TextBox();
            horaTextBox = new TextBox();
            horaLbl = new Label();
            fechaDateTimePicker = new DateTimePicker();
            fechaLbl = new Label();
            activoCheckBox = new CheckBox();
            guardarBtn = new Button();
            tituloLbl = new Label();
            datosPartidoGroupBox = new GroupBox();
            datosPartidoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // tituloLbl
            // 
            tituloLbl.AutoSize = true;
            tituloLbl.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            tituloLbl.Location = new Point(285, 28);
            tituloLbl.Name = "tituloLbl";
            tituloLbl.Size = new Size(230, 37);
            tituloLbl.TabIndex = 0;
            tituloLbl.Text = "Registro Partido";
            // 
            // datosPartidoGroupBox
            // 
            datosPartidoGroupBox.Controls.Add(idPartidoLbl);
            datosPartidoGroupBox.Controls.Add(idPartidoTextBox);
            datosPartidoGroupBox.Controls.Add(rivalLbl);
            datosPartidoGroupBox.Controls.Add(rivalTextBox);
            datosPartidoGroupBox.Controls.Add(fechaLbl);
            datosPartidoGroupBox.Controls.Add(fechaDateTimePicker);
            datosPartidoGroupBox.Controls.Add(horaLbl);
            datosPartidoGroupBox.Controls.Add(horaTextBox);
            datosPartidoGroupBox.Controls.Add(activoCheckBox);
            datosPartidoGroupBox.Location = new Point(150, 88);
            datosPartidoGroupBox.Name = "datosPartidoGroupBox";
            datosPartidoGroupBox.Size = new Size(500, 240);
            datosPartidoGroupBox.TabIndex = 1;
            datosPartidoGroupBox.TabStop = false;
            datosPartidoGroupBox.Text = "";
            // 
            // idPartidoLbl
            // 
            idPartidoLbl.AutoSize = true;
            idPartidoLbl.Location = new Point(45, 42);
            idPartidoLbl.Name = "idPartidoLbl";
            idPartidoLbl.Size = new Size(75, 20);
            idPartidoLbl.TabIndex = 2;
            idPartidoLbl.Text = "Id partido";
            // 
            // idPartidoTextBox
            // 
            idPartidoTextBox.Location = new Point(185, 39);
            idPartidoTextBox.Name = "idPartidoTextBox";
            idPartidoTextBox.Size = new Size(260, 27);
            idPartidoTextBox.TabIndex = 1;
            // 
            // rivalLbl
            // 
            rivalLbl.AutoSize = true;
            rivalLbl.Location = new Point(45, 82);
            rivalLbl.Name = "rivalLbl";
            rivalLbl.Size = new Size(41, 20);
            rivalLbl.TabIndex = 3;
            rivalLbl.Text = "Rival";
            // 
            // rivalTextBox
            // 
            rivalTextBox.Location = new Point(185, 79);
            rivalTextBox.Name = "rivalTextBox";
            rivalTextBox.Size = new Size(260, 27);
            rivalTextBox.TabIndex = 2;
            // 
            // fechaLbl
            // 
            fechaLbl.AutoSize = true;
            fechaLbl.Location = new Point(45, 122);
            fechaLbl.Name = "fechaLbl";
            fechaLbl.Size = new Size(47, 20);
            fechaLbl.TabIndex = 4;
            fechaLbl.Text = "Fecha";
            // 
            // fechaDateTimePicker
            // 
            fechaDateTimePicker.Location = new Point(185, 119);
            fechaDateTimePicker.Name = "fechaDateTimePicker";
            fechaDateTimePicker.Size = new Size(260, 27);
            fechaDateTimePicker.TabIndex = 3;
            // 
            // horaLbl
            // 
            horaLbl.AutoSize = true;
            horaLbl.Location = new Point(45, 162);
            horaLbl.Name = "horaLbl";
            horaLbl.Size = new Size(42, 20);
            horaLbl.TabIndex = 5;
            horaLbl.Text = "Hora";
            // 
            // horaTextBox
            // 
            horaTextBox.Location = new Point(185, 159);
            horaTextBox.Name = "horaTextBox";
            horaTextBox.Size = new Size(260, 27);
            horaTextBox.TabIndex = 4;
            // 
            // activoCheckBox
            // 
            activoCheckBox.AutoCheck = true;
            activoCheckBox.AutoSize = true;
            activoCheckBox.Checked = true;
            activoCheckBox.CheckState = CheckState.Checked;
            activoCheckBox.Location = new Point(185, 199);
            activoCheckBox.Name = "activoCheckBox";
            activoCheckBox.Size = new Size(73, 24);
            activoCheckBox.TabIndex = 5;
            activoCheckBox.Text = "Activo";
            activoCheckBox.UseVisualStyleBackColor = true;
            activoCheckBox.CheckedChanged += activoCheckBox_CheckedChanged;
            // 
            // volverBtn
            // 
            volverBtn.Location = new Point(255, 365);
            volverBtn.Name = "volverBtn";
            volverBtn.Size = new Size(140, 48);
            volverBtn.TabIndex = 6;
            volverBtn.Text = "Volver";
            volverBtn.UseVisualStyleBackColor = true;
            volverBtn.Click += volverBtn_Click;
            // 
            // guardarBtn
            // 
            guardarBtn.Location = new Point(425, 365);
            guardarBtn.Name = "guardarBtn";
            guardarBtn.Size = new Size(140, 48);
            guardarBtn.TabIndex = 7;
            guardarBtn.Text = "Guardar";
            guardarBtn.UseVisualStyleBackColor = true;
            guardarBtn.Click += guardarBtn_Click;
            // 
            // FrmPartidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(guardarBtn);
            Controls.Add(volverBtn);
            Controls.Add(datosPartidoGroupBox);
            Controls.Add(tituloLbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmPartidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Partidos";
            Load += FrmPartidos_Load;
            datosPartidoGroupBox.ResumeLayout(false);
            datosPartidoGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}