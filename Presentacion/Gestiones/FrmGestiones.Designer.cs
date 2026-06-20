namespace Boleteria.Presentacion.Gestiones
{
    partial class FrmGestiones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            localidadesBtn = new Button();
            partidosBtn = new Button();
            clientesBtn = new Button();
            vendedoresBtn = new Button();
            volverBtn = new Button();
            SuspendLayout();
            // 
            // localidadesBtn
            // 
            localidadesBtn.Location = new Point(114, 58);
            localidadesBtn.Name = "localidadesBtn";
            localidadesBtn.Size = new Size(242, 145);
            localidadesBtn.TabIndex = 0;
            localidadesBtn.Text = "Localidades";
            localidadesBtn.UseVisualStyleBackColor = true;
            localidadesBtn.Click += localidadesBtn_Click;
            // 
            // partidosBtn
            // 
            partidosBtn.Location = new Point(398, 58);
            partidosBtn.Name = "partidosBtn";
            partidosBtn.Size = new Size(242, 145);
            partidosBtn.TabIndex = 1;
            partidosBtn.Text = "Partidos";
            partidosBtn.UseVisualStyleBackColor = true;
            partidosBtn.Click += partidosBtn_Click;
            // 
            // clientesBtn
            // 
            clientesBtn.Location = new Point(114, 209);
            clientesBtn.Name = "clientesBtn";
            clientesBtn.Size = new Size(242, 145);
            clientesBtn.TabIndex = 2;
            clientesBtn.Text = "Clientes";
            clientesBtn.UseVisualStyleBackColor = true;
            clientesBtn.Click += clientesBtn_Click;
            // 
            // vendedoresBtn
            // 
            vendedoresBtn.Location = new Point(398, 209);
            vendedoresBtn.Name = "vendedoresBtn";
            vendedoresBtn.Size = new Size(242, 145);
            vendedoresBtn.TabIndex = 3;
            vendedoresBtn.Text = "Vendedores";
            vendedoresBtn.UseVisualStyleBackColor = true;
            vendedoresBtn.Click += vendedoresBtn_Click;
            // 
            // volverBtn
            // 
            volverBtn.Location = new Point(295, 387);
            volverBtn.Name = "volverBtn";
            volverBtn.Size = new Size(172, 51);
            volverBtn.TabIndex = 4;
            volverBtn.Text = "Volver";
            volverBtn.UseVisualStyleBackColor = true;
            volverBtn.Click += volverBtn_Click;
            // 
            // FrmGestiones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(volverBtn);
            Controls.Add(vendedoresBtn);
            Controls.Add(clientesBtn);
            Controls.Add(partidosBtn);
            Controls.Add(localidadesBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmGestiones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestiones";
            Load += Gestiones_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button localidadesBtn;
        private Button partidosBtn;
        private Button clientesBtn;
        private Button vendedoresBtn;
        private Button volverBtn;
    }
}