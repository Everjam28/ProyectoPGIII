namespace Presentacion
{
    partial class FrmListadoClientes
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
            this.btn_EliminarLC = new System.Windows.Forms.Button();
            this.bt_EditarLC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_BuscarLC = new System.Windows.Forms.TextBox();
            this.btn_NuevoLC = new System.Windows.Forms.Button();
            this.Dt_LC = new System.Windows.Forms.DataGridView();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_LC)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_EliminarLC
            // 
            this.btn_EliminarLC.Location = new System.Drawing.Point(505, 163);
            this.btn_EliminarLC.Name = "btn_EliminarLC";
            this.btn_EliminarLC.Size = new System.Drawing.Size(99, 23);
            this.btn_EliminarLC.TabIndex = 11;
            this.btn_EliminarLC.Text = "Eliminar";
            this.btn_EliminarLC.UseVisualStyleBackColor = true;
            this.btn_EliminarLC.Click += new System.EventHandler(this.btn_EliminarLC_Click);
            // 
            // bt_EditarLC
            // 
            this.bt_EditarLC.Location = new System.Drawing.Point(505, 116);
            this.bt_EditarLC.Name = "bt_EditarLC";
            this.bt_EditarLC.Size = new System.Drawing.Size(99, 23);
            this.bt_EditarLC.TabIndex = 10;
            this.bt_EditarLC.Text = "Editar";
            this.bt_EditarLC.UseVisualStyleBackColor = true;
            this.bt_EditarLC.Click += new System.EventHandler(this.bt_EditarLC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lista De Clientes";
            // 
            // txt_BuscarLC
            // 
            this.txt_BuscarLC.Location = new System.Drawing.Point(27, 45);
            this.txt_BuscarLC.Name = "txt_BuscarLC";
            this.txt_BuscarLC.Size = new System.Drawing.Size(223, 20);
            this.txt_BuscarLC.TabIndex = 8;
            this.txt_BuscarLC.TextChanged += new System.EventHandler(this.txt_BuscarLC_TextChanged);
            // 
            // btn_NuevoLC
            // 
            this.btn_NuevoLC.Location = new System.Drawing.Point(505, 69);
            this.btn_NuevoLC.Name = "btn_NuevoLC";
            this.btn_NuevoLC.Size = new System.Drawing.Size(99, 23);
            this.btn_NuevoLC.TabIndex = 7;
            this.btn_NuevoLC.Text = "Nuevo";
            this.btn_NuevoLC.UseVisualStyleBackColor = true;
            this.btn_NuevoLC.Click += new System.EventHandler(this.btn_NuevoLC_Click);
            // 
            // Dt_LC
            // 
            this.Dt_LC.AllowUserToAddRows = false;
            this.Dt_LC.AllowUserToDeleteRows = false;
            this.Dt_LC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dt_LC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dt_LC.Location = new System.Drawing.Point(27, 69);
            this.Dt_LC.Name = "Dt_LC";
            this.Dt_LC.ReadOnly = true;
            this.Dt_LC.Size = new System.Drawing.Size(453, 201);
            this.Dt_LC.TabIndex = 6;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Cerrar.Image = global::Presentacion.Properties.Resources.circulo_cruzado;
            this.btn_Cerrar.Location = new System.Drawing.Point(633, 0);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(24, 24);
            this.btn_Cerrar.TabIndex = 12;
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // FrmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(659, 295);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_EliminarLC);
            this.Controls.Add(this.bt_EditarLC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_BuscarLC);
            this.Controls.Add(this.btn_NuevoLC);
            this.Controls.Add(this.Dt_LC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListadoClientes";
            this.Text = "FrmListadoClientes";
            this.Load += new System.EventHandler(this.FrmListadoClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dt_LC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_EliminarLC;
        private System.Windows.Forms.Button bt_EditarLC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_BuscarLC;
        private System.Windows.Forms.Button btn_NuevoLC;
        private System.Windows.Forms.DataGridView Dt_LC;
        private System.Windows.Forms.Button btn_Cerrar;
    }
}