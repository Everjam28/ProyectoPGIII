namespace Presentacion
{
    partial class FrmCiudades
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
            this.label1 = new System.Windows.Forms.Label();
            this.Dt_ListadoC = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripC = new System.Windows.Forms.TextBox();
            this.btn_EliminarC = new System.Windows.Forms.Button();
            this.btn_EditarC = new System.Windows.Forms.Button();
            this.btn_GuardarC = new System.Windows.Forms.Button();
            this.btn_NuevoC = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_ListadoC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado De Ciudades";
            // 
            // Dt_ListadoC
            // 
            this.Dt_ListadoC.AllowUserToAddRows = false;
            this.Dt_ListadoC.AllowUserToDeleteRows = false;
            this.Dt_ListadoC.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Dt_ListadoC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dt_ListadoC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1});
            this.Dt_ListadoC.Location = new System.Drawing.Point(26, 48);
            this.Dt_ListadoC.Name = "Dt_ListadoC";
            this.Dt_ListadoC.ReadOnly = true;
            this.Dt_ListadoC.Size = new System.Drawing.Size(460, 238);
            this.Dt_ListadoC.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(530, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Codigo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(492, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripcion:";
            // 
            // txtDescripC
            // 
            this.txtDescripC.Location = new System.Drawing.Point(606, 130);
            this.txtDescripC.Multiline = true;
            this.txtDescripC.Name = "txtDescripC";
            this.txtDescripC.Size = new System.Drawing.Size(162, 72);
            this.txtDescripC.TabIndex = 6;
            // 
            // btn_EliminarC
            // 
            this.btn_EliminarC.BackColor = System.Drawing.Color.Teal;
            this.btn_EliminarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarC.ForeColor = System.Drawing.Color.Black;
            this.btn_EliminarC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EliminarC.Location = new System.Drawing.Point(385, 301);
            this.btn_EliminarC.Name = "btn_EliminarC";
            this.btn_EliminarC.Size = new System.Drawing.Size(103, 33);
            this.btn_EliminarC.TabIndex = 10;
            this.btn_EliminarC.Text = "  Eliminar";
            this.btn_EliminarC.UseVisualStyleBackColor = false;
            this.btn_EliminarC.Click += new System.EventHandler(this.btn_EliminarC_Click);
            // 
            // btn_EditarC
            // 
            this.btn_EditarC.BackColor = System.Drawing.Color.Teal;
            this.btn_EditarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditarC.ForeColor = System.Drawing.Color.Black;
            this.btn_EditarC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EditarC.Location = new System.Drawing.Point(267, 301);
            this.btn_EditarC.Name = "btn_EditarC";
            this.btn_EditarC.Size = new System.Drawing.Size(96, 33);
            this.btn_EditarC.TabIndex = 9;
            this.btn_EditarC.Text = "  Editar";
            this.btn_EditarC.UseVisualStyleBackColor = false;
            this.btn_EditarC.Click += new System.EventHandler(this.btn_EditarC_Click);
            // 
            // btn_GuardarC
            // 
            this.btn_GuardarC.BackColor = System.Drawing.Color.Teal;
            this.btn_GuardarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuardarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuardarC.ForeColor = System.Drawing.Color.Black;
            this.btn_GuardarC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GuardarC.Location = new System.Drawing.Point(26, 301);
            this.btn_GuardarC.Name = "btn_GuardarC";
            this.btn_GuardarC.Size = new System.Drawing.Size(107, 33);
            this.btn_GuardarC.TabIndex = 8;
            this.btn_GuardarC.UseVisualStyleBackColor = false;
            this.btn_GuardarC.Click += new System.EventHandler(this.btn_GuardarC_Click);
            // 
            // btn_NuevoC
            // 
            this.btn_NuevoC.BackColor = System.Drawing.Color.Teal;
            this.btn_NuevoC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NuevoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevoC.ForeColor = System.Drawing.Color.Black;
            this.btn_NuevoC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NuevoC.Location = new System.Drawing.Point(149, 301);
            this.btn_NuevoC.Name = "btn_NuevoC";
            this.btn_NuevoC.Size = new System.Drawing.Size(103, 33);
            this.btn_NuevoC.TabIndex = 7;
            this.btn_NuevoC.Text = "  Nuevo";
            this.btn_NuevoC.UseVisualStyleBackColor = false;
            this.btn_NuevoC.Click += new System.EventHandler(this.btn_NuevoC_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(775, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.lbl_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.ForeColor = System.Drawing.Color.Black;
            this.lbl_Id.Location = new System.Drawing.Point(602, 73);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(25, 20);
            this.lbl_Id.TabIndex = 11;
            this.lbl_Id.Text = "Id";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre Ciudad";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id Ciudad";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // FrmCiudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.btn_EliminarC);
            this.Controls.Add(this.btn_EditarC);
            this.Controls.Add(this.btn_GuardarC);
            this.Controls.Add(this.btn_NuevoC);
            this.Controls.Add(this.txtDescripC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dt_ListadoC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCiudades";
            this.Text = "Listado Clientes";
            this.Load += new System.EventHandler(this.FrmCiudades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dt_ListadoC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dt_ListadoC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripC;
        private System.Windows.Forms.Button btn_NuevoC;
        private System.Windows.Forms.Button btn_GuardarC;
        private System.Windows.Forms.Button btn_EditarC;
        private System.Windows.Forms.Button btn_EliminarC;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}