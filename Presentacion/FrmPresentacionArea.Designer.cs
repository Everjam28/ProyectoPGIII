namespace Presentacion
{
    partial class FrmPresentacionArea
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.Dt_Listado = new System.Windows.Forms.DataGridView();
            this.bt_Nuevo = new System.Windows.Forms.Button();
            this.bt_Modificar = new System.Windows.Forms.Button();
            this.bt_Eliminar = new System.Windows.Forms.Button();
            this.bt_Cerrar = new System.Windows.Forms.Button();
            this.bt_Vis = new System.Windows.Forms.Button();
            this.lbll_area = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Listado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Ciudad: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(85, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(167, 67);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(326, 20);
            this.txt_nombre.TabIndex = 3;
            // 
            // Dt_Listado
            // 
            this.Dt_Listado.AllowUserToAddRows = false;
            this.Dt_Listado.AllowUserToDeleteRows = false;
            this.Dt_Listado.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Dt_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dt_Listado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3});
            this.Dt_Listado.Location = new System.Drawing.Point(89, 120);
            this.Dt_Listado.Name = "Dt_Listado";
            this.Dt_Listado.ReadOnly = true;
            this.Dt_Listado.Size = new System.Drawing.Size(476, 275);
            this.Dt_Listado.TabIndex = 5;
            // 
            // bt_Nuevo
            // 
            this.bt_Nuevo.BackColor = System.Drawing.Color.Teal;
            this.bt_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.bt_Nuevo.Location = new System.Drawing.Point(89, 405);
            this.bt_Nuevo.Name = "bt_Nuevo";
            this.bt_Nuevo.Size = new System.Drawing.Size(98, 32);
            this.bt_Nuevo.TabIndex = 7;
            this.bt_Nuevo.Text = "Nuevo";
            this.bt_Nuevo.UseVisualStyleBackColor = false;
            this.bt_Nuevo.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_Modificar
            // 
            this.bt_Modificar.BackColor = System.Drawing.Color.Teal;
            this.bt_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.bt_Modificar.Location = new System.Drawing.Point(216, 405);
            this.bt_Modificar.Name = "bt_Modificar";
            this.bt_Modificar.Size = new System.Drawing.Size(98, 32);
            this.bt_Modificar.TabIndex = 8;
            this.bt_Modificar.Text = "Modificar";
            this.bt_Modificar.UseVisualStyleBackColor = false;
            this.bt_Modificar.Click += new System.EventHandler(this.bt_Modificar_Click);
            // 
            // bt_Eliminar
            // 
            this.bt_Eliminar.BackColor = System.Drawing.Color.Teal;
            this.bt_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.bt_Eliminar.Location = new System.Drawing.Point(343, 406);
            this.bt_Eliminar.Name = "bt_Eliminar";
            this.bt_Eliminar.Size = new System.Drawing.Size(98, 31);
            this.bt_Eliminar.TabIndex = 9;
            this.bt_Eliminar.Text = "Eliminar";
            this.bt_Eliminar.UseVisualStyleBackColor = false;
            this.bt_Eliminar.Click += new System.EventHandler(this.bt_Eliminar_Click);
            // 
            // bt_Cerrar
            // 
            this.bt_Cerrar.BackColor = System.Drawing.Color.Teal;
            this.bt_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.bt_Cerrar.Location = new System.Drawing.Point(463, 405);
            this.bt_Cerrar.Name = "bt_Cerrar";
            this.bt_Cerrar.Size = new System.Drawing.Size(102, 29);
            this.bt_Cerrar.TabIndex = 10;
            this.bt_Cerrar.Text = "Cerrar";
            this.bt_Cerrar.UseVisualStyleBackColor = false;
            this.bt_Cerrar.Click += new System.EventHandler(this.bt_Cerrar_Click);
            // 
            // bt_Vis
            // 
            this.bt_Vis.BackColor = System.Drawing.Color.Teal;
            this.bt_Vis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Vis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Vis.Location = new System.Drawing.Point(532, 67);
            this.bt_Vis.Name = "bt_Vis";
            this.bt_Vis.Size = new System.Drawing.Size(102, 31);
            this.bt_Vis.TabIndex = 11;
            this.bt_Vis.UseVisualStyleBackColor = false;
            this.bt_Vis.Click += new System.EventHandler(this.bt_Vis_Click);
            // 
            // lbll_area
            // 
            this.lbll_area.AutoSize = true;
            this.lbll_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbll_area.ForeColor = System.Drawing.Color.Red;
            this.lbll_area.Location = new System.Drawing.Point(176, 35);
            this.lbll_area.Name = "lbll_area";
            this.lbll_area.Size = new System.Drawing.Size(28, 20);
            this.lbll_area.TabIndex = 12;
            this.lbll_area.Text = "ID";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre de Ciudad";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Id";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // FrmPresentacionArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.lbll_area);
            this.Controls.Add(this.bt_Vis);
            this.Controls.Add(this.bt_Cerrar);
            this.Controls.Add(this.bt_Eliminar);
            this.Controls.Add(this.bt_Modificar);
            this.Controls.Add(this.bt_Nuevo);
            this.Controls.Add(this.Dt_Listado);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPresentacionArea";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPresentacionArea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Listado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.DataGridView Dt_Listado;
        private System.Windows.Forms.Button bt_Nuevo;
        private System.Windows.Forms.Button bt_Modificar;
        private System.Windows.Forms.Button bt_Eliminar;
        private System.Windows.Forms.Button bt_Cerrar;
        private System.Windows.Forms.Button bt_Vis;
        private System.Windows.Forms.Label lbll_area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

