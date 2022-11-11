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
    public partial class FrmListadoClientes : Form
    {
        S_Clientes accion = new S_Clientes();
        public FrmListadoClientes()
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
            Dt_LC.Columns[0].Visible = false;
            Dt_LC.Columns[6].Visible = false;
            Dt_LC.Columns[7].Visible = false;

            Dt_LC.Columns[1].HeaderText = "CI O RUC";
            Dt_LC.Columns[2].HeaderText = "Razón Social";
            Dt_LC.Columns[4].HeaderText = "Direccion";
            Dt_LC.Columns[5].HeaderText = "Telefono";
            Dt_LC.Columns[6].HeaderText = "Correo";

        }

        public void MostrarRegistro()
        {

            Dt_LC.DataSource = accion.ListadoClientes(txt_BuscarLC.Text);
            AccionesTabla();
        }

        public void BuscarRegistro()
        {
            Dt_LC.DataSource = accion.ListadoClientes(txt_BuscarLC.Text);
        }
        private void EliminarCliente(int idcliente)
        {
            //S_Ciudades accion = new S_Ciudades();
            if (accion.Eliminar(idcliente))
            {
                MessageBox.Show("Registro eliminado exitosamente", "Eliminar");
            }
            else
                MessageBox.Show("Error al realizar esta operacion", "Eliminar");
        }

        private void Actualizar(object sender, FormClosedEventArgs e)
        {
            MostrarRegistro();
        }
        private void FrmListadoClientes_Load(object sender, EventArgs e)
        {
            MostrarRegistro();
        }

        private void btn_NuevoLC_Click(object sender, EventArgs e)
        {
            FrmClientes nuevoR = new FrmClientes();
            nuevoR.FormClosed += new FormClosedEventHandler(Actualizar);
            nuevoR.ShowDialog();
        }

        private void bt_EditarLC_Click(object sender, EventArgs e)
        {
            FrmClientes editarR = new FrmClientes();
            editarR.FormClosed += new FormClosedEventHandler(Actualizar);
            if (Dt_LC.SelectedRows.Count > 0)
            {
                Program.Evento = 1;
                editarR.txt_codigoC.Text = Dt_LC.CurrentRow.Cells[0].Value.ToString();
                editarR.txt_RUC.Text = Dt_LC.CurrentRow.Cells[1].Value.ToString();
                editarR.txt_RazonSocial.Text = Dt_LC.CurrentRow.Cells[2].Value.ToString();
                editarR.txt_direccionC.Text = Dt_LC.CurrentRow.Cells[3].Value.ToString();
                editarR.txt_telefonoC.Text = Dt_LC.CurrentRow.Cells[5].Value.ToString();
                editarR.txt_correoC.Text = Dt_LC.CurrentRow.Cells[6].Value.ToString();
                editarR.cbx_profesionalC.SelectedValue = Dt_LC.CurrentRow.Cells[7].Value.ToString();
                editarR.Cb_CiudadC.SelectedValue = Dt_LC.CurrentRow.Cells[7].Value.ToString();
                editarR.ShowDialog();
            }
            else
            {
                MensajeError("Selecione la Fila a Editar");
            }

        }

        private void btn_EliminarLC_Click(object sender, EventArgs e)
        {
            try
            {


                string msg = "Esta seguro de eliminar el registro selecionado?";
                string titulo = "Eliminar";

                if (MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFila = Dt_LC.CurrentRow.Index;
                    int idcliente = Convert.ToInt32(Dt_LC.Rows[indiceFila].Cells[0].Value.ToString());
                    EliminarCliente(idcliente);
                    MostrarRegistro();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al realizar esta operacion" + ex, "Modificar");

            }
        }

        private void txt_BuscarLC_TextChanged(object sender, EventArgs e)
        {
            BuscarRegistro();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
