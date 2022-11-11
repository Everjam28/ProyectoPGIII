using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace Presentacion
{
    public partial class FrmListaProfesionales : Form
    {
        S_Profesionales accion = new S_Profesionales();
        public FrmListaProfesionales()
        {
            InitializeComponent();
        }

        private void MensajeConfirmacion(string mensaje)
        {
            MessageBox.Show(mensaje, "MarketSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "MarketSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        public void AccionesTabla()
        {
            Dt_LP.Columns[0].Visible = false;
            Dt_LP.Columns[7].Visible = false;

            Dt_LP.Columns[1].HeaderText = "N° Cedula";
            Dt_LP.Columns[2].HeaderText = "Nombres";
            Dt_LP.Columns[3].HeaderText = "Apellidos";
            Dt_LP.Columns[4].HeaderText = "Direccion";
            Dt_LP.Columns[5].HeaderText = "Telefono";
            Dt_LP.Columns[6].HeaderText = "Correo";

        }

        public void MostrarRegistro()
        {
            
            Dt_LP.DataSource = accion.ListadoProsefional(txt_BuscarLP.Text);
            AccionesTabla();
        }

        public void BuscarRegistro()
        {
            Dt_LP.DataSource = accion.ListadoProsefional(txt_BuscarLP.Text);
        }

        private void Actualizar(object sender, FormClosedEventArgs e)
        {
            MostrarRegistro();
        }
        private void EliminarProfesional(int idprofesional)
        {
            //S_Ciudades accion = new S_Ciudades();
            if (accion.Eliminar(idprofesional))
            {
                MessageBox.Show("Registro eliminado exitosamente", "Eliminar");
            }
            else
                MessageBox.Show("Error al realizar esta operacion", "Eliminar");
        }
        private void FrmListaProfesionales_Load(object sender, EventArgs e)
        {
            MostrarRegistro();
        }

        private void btn_NuevoLP_Click(object sender, EventArgs e)
        {
            FrmProfesional nuevoR = new FrmProfesional();
            nuevoR.FormClosed += new FormClosedEventHandler(Actualizar);
            nuevoR.ShowDialog();
        }

        private void bt_EditarLP_Click(object sender, EventArgs e)
        {
            FrmProfesional editarR = new FrmProfesional();
            editarR.FormClosed += new FormClosedEventHandler(Actualizar);
            if (Dt_LP.SelectedRows.Count > 0)
            {
                Program.Evento = 1;
                editarR.txt_codigoP.Text = Dt_LP.CurrentRow.Cells[0].Value.ToString();
                editarR.txt_cedulaP.Text = Dt_LP.CurrentRow.Cells[1].Value.ToString();
                editarR.txt_NombresP.Text = Dt_LP.CurrentRow.Cells[2].Value.ToString();
                editarR.txt_apellidosP.Text = Dt_LP.CurrentRow.Cells[3].Value.ToString();
                editarR.txt_direccionP.Text = Dt_LP.CurrentRow.Cells[4].Value.ToString();
                editarR.txt_telefonoP.Text = Dt_LP.CurrentRow.Cells[5].Value.ToString();
                editarR.txt_correoP.Text = Dt_LP.CurrentRow.Cells[6].Value.ToString();
                editarR.Cb_CiudadP.SelectedValue = Dt_LP.CurrentRow.Cells[7].Value.ToString();
                editarR.ShowDialog();
            }
            else
            {
                MensajeError("Selecione la Fila a Editar");
            }


        }

        private void btn_EliminarLp_Click(object sender, EventArgs e)
        {
            try
            {


                string msg = "Esta seguro de eliminar el registro selecionado?";
                string titulo = "Eliminar";

                if (MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFila = Dt_LP.CurrentRow.Index;
                    int idprofesional = Convert.ToInt32(Dt_LP.Rows[indiceFila].Cells[0].Value.ToString());
                    EliminarProfesional(idprofesional);
                    MostrarRegistro();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al realizar esta operacion" + ex, "Modificar");

            }
        }

        private void txt_BuscarLP_TextChanged(object sender, EventArgs e)
        {
            BuscarRegistro();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {

        }
    }

}
