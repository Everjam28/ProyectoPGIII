namespace Presentacion
{
    partial class FrmMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.panel_Principal = new System.Windows.Forms.Panel();
            this.panel_Inferior = new System.Windows.Forms.Panel();
            this.panel_Contenedor = new System.Windows.Forms.Panel();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.btn_Ciudades = new System.Windows.Forms.Button();
            this.btn_Profesionales = new System.Windows.Forms.Button();
            this.btn_Clientes = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.btn_EditarPerfil = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lb_Correo = new System.Windows.Forms.Label();
            this.lb_Usuario = new System.Windows.Forms.Label();
            this.lb_Posicion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelTitule = new System.Windows.Forms.Panel();
            this.btn_restaurar = new System.Windows.Forms.Button();
            this.btn_Maximizar = new System.Windows.Forms.Button();
            this.btn_Minimizar = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_Principal.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            this.PanelTitule.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Principal
            // 
            this.panel_Principal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_Principal.Controls.Add(this.panel_Inferior);
            this.panel_Principal.Controls.Add(this.panel_Contenedor);
            this.panel_Principal.Controls.Add(this.PanelMenu);
            this.panel_Principal.Controls.Add(this.PanelTitule);
            this.panel_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Principal.Location = new System.Drawing.Point(0, 0);
            this.panel_Principal.Name = "panel_Principal";
            this.panel_Principal.Size = new System.Drawing.Size(960, 480);
            this.panel_Principal.TabIndex = 0;
            // 
            // panel_Inferior
            // 
            this.panel_Inferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel_Inferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Inferior.Location = new System.Drawing.Point(217, 380);
            this.panel_Inferior.Name = "panel_Inferior";
            this.panel_Inferior.Size = new System.Drawing.Size(743, 100);
            this.panel_Inferior.TabIndex = 5;
            // 
            // panel_Contenedor
            // 
            this.panel_Contenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel_Contenedor.Location = new System.Drawing.Point(223, 55);
            this.panel_Contenedor.Name = "panel_Contenedor";
            this.panel_Contenedor.Size = new System.Drawing.Size(725, 318);
            this.panel_Contenedor.TabIndex = 4;
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PanelMenu.Controls.Add(this.btn_Ciudades);
            this.PanelMenu.Controls.Add(this.btn_Profesionales);
            this.PanelMenu.Controls.Add(this.btn_Clientes);
            this.PanelMenu.Controls.Add(this.PanelLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(217, 480);
            this.PanelMenu.TabIndex = 3;
            // 
            // btn_Ciudades
            // 
            this.btn_Ciudades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Ciudades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Ciudades.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ciudades.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ciudades.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Ciudades.Image = global::Presentacion.Properties.Resources.paisaje_urbano;
            this.btn_Ciudades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Ciudades.Location = new System.Drawing.Point(3, 299);
            this.btn_Ciudades.Name = "btn_Ciudades";
            this.btn_Ciudades.Size = new System.Drawing.Size(214, 63);
            this.btn_Ciudades.TabIndex = 3;
            this.btn_Ciudades.Text = "Ciudades";
            this.btn_Ciudades.UseVisualStyleBackColor = false;
            this.btn_Ciudades.Click += new System.EventHandler(this.btn_Ciudades_Click);
            // 
            // btn_Profesionales
            // 
            this.btn_Profesionales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Profesionales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Profesionales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Profesionales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Profesionales.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Profesionales.Image = global::Presentacion.Properties.Resources.curriculum;
            this.btn_Profesionales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Profesionales.Location = new System.Drawing.Point(3, 239);
            this.btn_Profesionales.Name = "btn_Profesionales";
            this.btn_Profesionales.Size = new System.Drawing.Size(214, 63);
            this.btn_Profesionales.TabIndex = 2;
            this.btn_Profesionales.Text = "     Profesionales";
            this.btn_Profesionales.UseVisualStyleBackColor = false;
            this.btn_Profesionales.Click += new System.EventHandler(this.btn_Profesionales_Click);
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Clientes.Image = global::Presentacion.Properties.Resources.objetivo;
            this.btn_Clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Clientes.Location = new System.Drawing.Point(3, 179);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(214, 63);
            this.btn_Clientes.TabIndex = 1;
            this.btn_Clientes.Text = "Clientes";
            this.btn_Clientes.UseVisualStyleBackColor = false;
            this.btn_Clientes.Click += new System.EventHandler(this.btn_Clientes_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackColor = System.Drawing.Color.Black;
            this.PanelLogo.Controls.Add(this.btn_EditarPerfil);
            this.PanelLogo.Controls.Add(this.lb_Correo);
            this.PanelLogo.Controls.Add(this.lb_Usuario);
            this.PanelLogo.Controls.Add(this.lb_Posicion);
            this.PanelLogo.Controls.Add(this.button1);
            this.PanelLogo.Controls.Add(this.bunifuSeparator1);
            this.PanelLogo.Controls.Add(this.label1);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(217, 176);
            this.PanelLogo.TabIndex = 0;
            // 
            // btn_EditarPerfil
            // 
            this.btn_EditarPerfil.ActiveBorderThickness = 1;
            this.btn_EditarPerfil.ActiveCornerRadius = 20;
            this.btn_EditarPerfil.ActiveFillColor = System.Drawing.Color.Black;
            this.btn_EditarPerfil.ActiveForecolor = System.Drawing.Color.Black;
            this.btn_EditarPerfil.ActiveLineColor = System.Drawing.Color.Black;
            this.btn_EditarPerfil.BackColor = System.Drawing.Color.Black;
            this.btn_EditarPerfil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EditarPerfil.BackgroundImage")));
            this.btn_EditarPerfil.ButtonText = "Editar Perfil";
            this.btn_EditarPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EditarPerfil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditarPerfil.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_EditarPerfil.IdleBorderThickness = 1;
            this.btn_EditarPerfil.IdleCornerRadius = 20;
            this.btn_EditarPerfil.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_EditarPerfil.IdleForecolor = System.Drawing.Color.Transparent;
            this.btn_EditarPerfil.IdleLineColor = System.Drawing.Color.Teal;
            this.btn_EditarPerfil.Location = new System.Drawing.Point(8, 130);
            this.btn_EditarPerfil.Margin = new System.Windows.Forms.Padding(5);
            this.btn_EditarPerfil.Name = "btn_EditarPerfil";
            this.btn_EditarPerfil.Size = new System.Drawing.Size(198, 41);
            this.btn_EditarPerfil.TabIndex = 8;
            this.btn_EditarPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Correo
            // 
            this.lb_Correo.AutoSize = true;
            this.lb_Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lb_Correo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_Correo.Location = new System.Drawing.Point(76, 106);
            this.lb_Correo.Name = "lb_Correo";
            this.lb_Correo.Size = new System.Drawing.Size(44, 13);
            this.lb_Correo.TabIndex = 7;
            this.lb_Correo.Text = "Correo";
            // 
            // lb_Usuario
            // 
            this.lb_Usuario.AutoSize = true;
            this.lb_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lb_Usuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_Usuario.Location = new System.Drawing.Point(76, 79);
            this.lb_Usuario.Name = "lb_Usuario";
            this.lb_Usuario.Size = new System.Drawing.Size(50, 13);
            this.lb_Usuario.TabIndex = 6;
            this.lb_Usuario.Text = "Usuario";
            // 
            // lb_Posicion
            // 
            this.lb_Posicion.AutoSize = true;
            this.lb_Posicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lb_Posicion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_Posicion.Location = new System.Drawing.Point(76, 52);
            this.lb_Posicion.Name = "lb_Posicion";
            this.lb_Posicion.Size = new System.Drawing.Size(55, 13);
            this.lb_Posicion.TabIndex = 5;
            this.lb_Posicion.Text = "Posición";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Image = global::Presentacion.Properties.Resources.cara_feliz__2_;
            this.button1.Location = new System.Drawing.Point(3, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(3, 41);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(159, 16);
            this.bunifuSeparator1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "MarketSystem";
            // 
            // PanelTitule
            // 
            this.PanelTitule.BackColor = System.Drawing.Color.Teal;
            this.PanelTitule.Controls.Add(this.btn_restaurar);
            this.PanelTitule.Controls.Add(this.btn_Maximizar);
            this.PanelTitule.Controls.Add(this.btn_Minimizar);
            this.PanelTitule.Controls.Add(this.btn_Cerrar);
            this.PanelTitule.Controls.Add(this.label2);
            this.PanelTitule.Location = new System.Drawing.Point(215, 0);
            this.PanelTitule.Name = "PanelTitule";
            this.PanelTitule.Size = new System.Drawing.Size(745, 49);
            this.PanelTitule.TabIndex = 2;
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_restaurar.BackColor = System.Drawing.Color.Transparent;
            this.btn_restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_restaurar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_restaurar.Image = global::Presentacion.Properties.Resources.minimizar2;
            this.btn_restaurar.Location = new System.Drawing.Point(688, 3);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(24, 24);
            this.btn_restaurar.TabIndex = 4;
            this.btn_restaurar.UseVisualStyleBackColor = false;
            this.btn_restaurar.Visible = false;
            this.btn_restaurar.Click += new System.EventHandler(this.btn_restaurar_Click);
            // 
            // btn_Maximizar
            // 
            this.btn_Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Maximizar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Maximizar.Image = global::Presentacion.Properties.Resources.maximizar;
            this.btn_Maximizar.Location = new System.Drawing.Point(688, 3);
            this.btn_Maximizar.Name = "btn_Maximizar";
            this.btn_Maximizar.Size = new System.Drawing.Size(24, 24);
            this.btn_Maximizar.TabIndex = 3;
            this.btn_Maximizar.UseVisualStyleBackColor = false;
            this.btn_Maximizar.Click += new System.EventHandler(this.btn_Maximizar_Click);
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Minimizar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Minimizar.Image = global::Presentacion.Properties.Resources.minimizar;
            this.btn_Minimizar.Location = new System.Drawing.Point(658, 3);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(24, 24);
            this.btn_Minimizar.TabIndex = 2;
            this.btn_Minimizar.UseVisualStyleBackColor = false;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Cerrar.Image = global::Presentacion.Properties.Resources.circulo_cruzado;
            this.btn_Cerrar.Location = new System.Drawing.Point(718, 3);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(24, 24);
            this.btn_Cerrar.TabIndex = 1;
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "HOME";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PanelTitule;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this.panel_Contenedor;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 480);
            this.Controls.Add(this.panel_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(960, 480);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.panel_Principal.ResumeLayout(false);
            this.PanelMenu.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            this.PanelLogo.PerformLayout();
            this.PanelTitule.ResumeLayout(false);
            this.PanelTitule.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Principal;
        private System.Windows.Forms.Panel PanelTitule;
        private System.Windows.Forms.Button btn_Maximizar;
        private System.Windows.Forms.Button btn_Minimizar;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Button btn_Ciudades;
        private System.Windows.Forms.Button btn_Profesionales;
        private System.Windows.Forms.Button btn_Clientes;
        private System.Windows.Forms.Panel PanelLogo;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_EditarPerfil;
        private System.Windows.Forms.Label lb_Correo;
        private System.Windows.Forms.Label lb_Usuario;
        private System.Windows.Forms.Label lb_Posicion;
        private System.Windows.Forms.Button button1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Contenedor;
        private System.Windows.Forms.Panel panel_Inferior;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Button btn_restaurar;
    }
}