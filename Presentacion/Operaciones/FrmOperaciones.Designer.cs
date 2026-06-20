namespace Boleteria.Presentacion.Operaciones
{
    partial class FrmOperaciones
    {
        private System.ComponentModel.IContainer components = null;

        private Button localidadPorPartidoBtn;
        private Button ventaDeEntradasBtn;
        private Button volverBtn;

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
            localidadPorPartidoBtn = new Button();
            ventaDeEntradasBtn = new Button();
            volverBtn = new Button();
            SuspendLayout();
            // 
            // localidadPorPartidoBtn
            // 
            localidadPorPartidoBtn.Location = new Point(90, 85);
            localidadPorPartidoBtn.Name = "localidadPorPartidoBtn";
            localidadPorPartidoBtn.Size = new Size(250, 170);
            localidadPorPartidoBtn.TabIndex = 0;
            localidadPorPartidoBtn.Text = "Localidad\r\npor Partido";
            localidadPorPartidoBtn.UseVisualStyleBackColor = true;
            localidadPorPartidoBtn.Click += localidadPorPartidoBtn_Click;
            // 
            // ventaDeEntradasBtn
            // 
            ventaDeEntradasBtn.Location = new Point(460, 85);
            ventaDeEntradasBtn.Name = "ventaDeEntradasBtn";
            ventaDeEntradasBtn.Size = new Size(250, 170);
            ventaDeEntradasBtn.TabIndex = 1;
            ventaDeEntradasBtn.Text = "Venta de\r\nEntradas";
            ventaDeEntradasBtn.UseVisualStyleBackColor = true;
            ventaDeEntradasBtn.Click += ventaDeEntradasBtn_Click;
            // 
            // volverBtn
            // 
            volverBtn.Location = new Point(330, 340);
            volverBtn.Name = "volverBtn";
            volverBtn.Size = new Size(140, 48);
            volverBtn.TabIndex = 2;
            volverBtn.Text = "Volver";
            volverBtn.UseVisualStyleBackColor = true;
            volverBtn.Click += volverBtn_Click;
            // 
            // FrmOperaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(volverBtn);
            Controls.Add(ventaDeEntradasBtn);
            Controls.Add(localidadPorPartidoBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmOperaciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Operaciones";
            Load += FrmOperaciones_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}