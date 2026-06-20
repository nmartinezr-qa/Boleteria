namespace Boleteria.Presentacion
{
    partial class Principal
    {
        private System.ComponentModel.IContainer components = null;

        private Label tituloLbl;
        private Label subtituloLbl;
        private GroupBox menuGroupBox;
        private Button gestionBtn;
        private Button operacionesBtn;
        private Button consultasBtn;

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
            subtituloLbl = new Label();
            menuGroupBox = new GroupBox();
            gestionBtn = new Button();
            operacionesBtn = new Button();
            consultasBtn = new Button();
            menuGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // tituloLbl
            // 
            tituloLbl.AutoSize = true;
            tituloLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            tituloLbl.Location = new Point(255, 30);
            tituloLbl.Name = "tituloLbl";
            tituloLbl.Size = new Size(306, 41);
            tituloLbl.TabIndex = 0;
            tituloLbl.Text = "Sistema de Boletería";
            // 
            // subtituloLbl
            // 
            subtituloLbl.AutoSize = true;
            subtituloLbl.Location = new Point(246, 75);
            subtituloLbl.Name = "subtituloLbl";
            subtituloLbl.Size = new Size(297, 20);
            subtituloLbl.TabIndex = 1;
            subtituloLbl.Text = "Seleccione el módulo al que desea ingresar";
            // 
            // menuGroupBox
            // 
            menuGroupBox.Controls.Add(gestionBtn);
            menuGroupBox.Controls.Add(operacionesBtn);
            menuGroupBox.Controls.Add(consultasBtn);
            menuGroupBox.Location = new Point(35, 125);
            menuGroupBox.Name = "menuGroupBox";
            menuGroupBox.Size = new Size(730, 230);
            menuGroupBox.TabIndex = 2;
            menuGroupBox.TabStop = false;
            // 
            // gestionBtn
            // 
            gestionBtn.Location = new Point(35, 45);
            gestionBtn.Name = "gestionBtn";
            gestionBtn.Size = new Size(210, 150);
            gestionBtn.TabIndex = 3;
            gestionBtn.Text = "Gestiones";
            gestionBtn.UseVisualStyleBackColor = true;
            gestionBtn.Click += gestionBtn_Click;
            // 
            // operacionesBtn
            // 
            operacionesBtn.Location = new Point(265, 45);
            operacionesBtn.Name = "operacionesBtn";
            operacionesBtn.Size = new Size(210, 150);
            operacionesBtn.TabIndex = 4;
            operacionesBtn.Text = "Operaciones";
            operacionesBtn.UseVisualStyleBackColor = true;
            operacionesBtn.Click += operacionesBtn_Click;
            // 
            // consultasBtn
            // 
            consultasBtn.Location = new Point(495, 45);
            consultasBtn.Name = "consultasBtn";
            consultasBtn.Size = new Size(210, 150);
            consultasBtn.TabIndex = 5;
            consultasBtn.Text = "Consultas";
            consultasBtn.UseVisualStyleBackColor = true;
            consultasBtn.Click += consultasBtn_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuGroupBox);
            Controls.Add(subtituloLbl);
            Controls.Add(tituloLbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Boletería";
            Load += Principal_Load;
            menuGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}