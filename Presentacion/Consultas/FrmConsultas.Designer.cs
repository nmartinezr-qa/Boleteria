namespace Boleteria.Presentacion.Consultas
{
    partial class FrmConsultas
    {
        private System.ComponentModel.IContainer components = null;

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
            consultarLocalidadesBtn = new Button();
            consultarPartidosBtn = new Button();
            consultarClientesBtn = new Button();
            consultarVendedoresBtn = new Button();
            consultarLocalidadesPorPartidoBtn = new Button();
            consultarVentasBtn = new Button();
            volverBtn = new Button();
            SuspendLayout();
            // 
            // consultarLocalidadesBtn
            // 
            consultarLocalidadesBtn.Location = new Point(40, 40);
            consultarLocalidadesBtn.Name = "consultarLocalidadesBtn";
            consultarLocalidadesBtn.Size = new Size(220, 140);
            consultarLocalidadesBtn.TabIndex = 0;
            consultarLocalidadesBtn.Text = "Localidades";
            consultarLocalidadesBtn.UseVisualStyleBackColor = true;
            consultarLocalidadesBtn.Click += consultarLocalidadesBtn_Click;
            // 
            // consultarPartidosBtn
            // 
            consultarPartidosBtn.Location = new Point(290, 40);
            consultarPartidosBtn.Name = "consultarPartidosBtn";
            consultarPartidosBtn.Size = new Size(220, 140);
            consultarPartidosBtn.TabIndex = 1;
            consultarPartidosBtn.Text = "Partidos";
            consultarPartidosBtn.UseVisualStyleBackColor = true;
            consultarPartidosBtn.Click += consultarPartidosBtn_Click;
            // 
            // consultarClientesBtn
            // 
            consultarClientesBtn.Location = new Point(540, 40);
            consultarClientesBtn.Name = "consultarClientesBtn";
            consultarClientesBtn.Size = new Size(220, 140);
            consultarClientesBtn.TabIndex = 2;
            consultarClientesBtn.Text = "Clientes";
            consultarClientesBtn.UseVisualStyleBackColor = true;
            consultarClientesBtn.Click += consultarClientesBtn_Click;
            // 
            // consultarVendedoresBtn
            // 
            consultarVendedoresBtn.Location = new Point(40, 210);
            consultarVendedoresBtn.Name = "consultarVendedoresBtn";
            consultarVendedoresBtn.Size = new Size(220, 140);
            consultarVendedoresBtn.TabIndex = 3;
            consultarVendedoresBtn.Text = "Vendedores";
            consultarVendedoresBtn.UseVisualStyleBackColor = true;
            consultarVendedoresBtn.Click += consultarVendedoresBtn_Click;
            // 
            // consultarLocalidadesPorPartidoBtn
            // 
            consultarLocalidadesPorPartidoBtn.Location = new Point(290, 210);
            consultarLocalidadesPorPartidoBtn.Name = "consultarLocalidadesPorPartidoBtn";
            consultarLocalidadesPorPartidoBtn.Size = new Size(220, 140);
            consultarLocalidadesPorPartidoBtn.TabIndex = 4;
            consultarLocalidadesPorPartidoBtn.Text = "Localidad por Partido";
            consultarLocalidadesPorPartidoBtn.UseVisualStyleBackColor = true;
            consultarLocalidadesPorPartidoBtn.Click += consultarLocalidadesPorPartidoBtn_Click;
            // 
            // consultarVentasBtn
            // 
            consultarVentasBtn.Location = new Point(540, 210);
            consultarVentasBtn.Name = "consultarVentasBtn";
            consultarVentasBtn.Size = new Size(220, 140);
            consultarVentasBtn.TabIndex = 5;
            consultarVentasBtn.Text = "Ventas";
            consultarVentasBtn.UseVisualStyleBackColor = true;
            consultarVentasBtn.Click += consultarVentasBtn_Click;
            // 
            // volverBtn
            // 
            volverBtn.Location = new Point(330, 385);
            volverBtn.Name = "volverBtn";
            volverBtn.Size = new Size(140, 48);
            volverBtn.TabIndex = 6;
            volverBtn.Text = "Volver";
            volverBtn.UseVisualStyleBackColor = true;
            volverBtn.Click += volverBtn_Click;
            // 
            // FrmConsultas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(volverBtn);
            Controls.Add(consultarVentasBtn);
            Controls.Add(consultarLocalidadesPorPartidoBtn);
            Controls.Add(consultarVendedoresBtn);
            Controls.Add(consultarClientesBtn);
            Controls.Add(consultarPartidosBtn);
            Controls.Add(consultarLocalidadesBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmConsultas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultas";
            Load += FrmConsultas_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button consultarLocalidadesBtn;
        private Button consultarPartidosBtn;
        private Button consultarClientesBtn;
        private Button consultarVendedoresBtn;
        private Button consultarLocalidadesPorPartidoBtn;
        private Button consultarVentasBtn;
        private Button volverBtn;
    }
}