namespace Presentacion
{
    partial class FrmListaProfesionales
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
            this.Dt_LP = new System.Windows.Forms.DataGridView();
            this.btn_NuevoLP = new System.Windows.Forms.Button();
            this.txt_BuscarLP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_EditarLP = new System.Windows.Forms.Button();
            this.btn_EliminarLp = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_LP)).BeginInit();
            this.SuspendLayout();
            // 
            // Dt_LP
            // 
            this.Dt_LP.AllowUserToAddRows = false;
            this.Dt_LP.AllowUserToDeleteRows = false;
            this.Dt_LP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dt_LP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dt_LP.Location = new System.Drawing.Point(50, 80);
            this.Dt_LP.Name = "Dt_LP";
            this.Dt_LP.ReadOnly = true;
            this.Dt_LP.Size = new System.Drawing.Size(414, 280);
            this.Dt_LP.TabIndex = 0;
            // 
            // btn_NuevoLP
            // 
            this.btn_NuevoLP.Location = new System.Drawing.Point(491, 80);
            this.btn_NuevoLP.Name = "btn_NuevoLP";
            this.btn_NuevoLP.Size = new System.Drawing.Size(75, 23);
            this.btn_NuevoLP.TabIndex = 1;
            this.btn_NuevoLP.Text = "Nuevo";
            this.btn_NuevoLP.UseVisualStyleBackColor = true;
            this.btn_NuevoLP.Click += new System.EventHandler(this.btn_NuevoLP_Click);
            // 
            // txt_BuscarLP
            // 
            this.txt_BuscarLP.Location = new System.Drawing.Point(50, 54);
            this.txt_BuscarLP.Name = "txt_BuscarLP";
            this.txt_BuscarLP.Size = new System.Drawing.Size(223, 20);
            this.txt_BuscarLP.TabIndex = 2;
            this.txt_BuscarLP.TextChanged += new System.EventHandler(this.txt_BuscarLP_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(46, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista De Profesionales";
            // 
            // bt_EditarLP
            // 
            this.bt_EditarLP.Location = new System.Drawing.Point(491, 127);
            this.bt_EditarLP.Name = "bt_EditarLP";
            this.bt_EditarLP.Size = new System.Drawing.Size(75, 23);
            this.bt_EditarLP.TabIndex = 4;
            this.bt_EditarLP.Text = "Editar";
            this.bt_EditarLP.UseVisualStyleBackColor = true;
            this.bt_EditarLP.Click += new System.EventHandler(this.bt_EditarLP_Click);
            // 
            // btn_EliminarLp
            // 
            this.btn_EliminarLp.Location = new System.Drawing.Point(491, 174);
            this.btn_EliminarLp.Name = "btn_EliminarLp";
            this.btn_EliminarLp.Size = new System.Drawing.Size(75, 23);
            this.btn_EliminarLp.TabIndex = 5;
            this.btn_EliminarLp.Text = "Eliminar";
            this.btn_EliminarLp.UseVisualStyleBackColor = true;
            this.btn_EliminarLp.Click += new System.EventHandler(this.btn_EliminarLp_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Cerrar.Image = global::Presentacion.Properties.Resources.circulo_cruzado;
            this.btn_Cerrar.Location = new System.Drawing.Point(774, 1);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(24, 24);
            this.btn_Cerrar.TabIndex = 6;
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // FrmListaProfesionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_EliminarLp);
            this.Controls.Add(this.bt_EditarLP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_BuscarLP);
            this.Controls.Add(this.btn_NuevoLP);
            this.Controls.Add(this.Dt_LP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListaProfesionales";
            this.Text = "FrmListaProfesionales";
            this.Load += new System.EventHandler(this.FrmListaProfesionales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dt_LP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dt_LP;
        private System.Windows.Forms.Button btn_NuevoLP;
        private System.Windows.Forms.TextBox txt_BuscarLP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_EditarLP;
        private System.Windows.Forms.Button btn_EliminarLp;
        private System.Windows.Forms.Button btn_Cerrar;
    }
}