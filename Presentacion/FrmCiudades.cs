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
    public partial class FrmCiudades : Form
    {

        private void MostrarCiudades()
        {
            S_Ciudades accion = new S_Ciudades();
            List<ciudades> listado = accion.Listado();
            Dt_ListadoC.Rows.Clear();

            foreach (ciudades obj in listado)
            {
                Dt_ListadoC.Rows.Add(obj.Descripcion, obj.IdCiudades);
            }


        }

        public void UbicarCiudad(int idciudad)
        {
            S_Ciudades accion = new S_Ciudades();
            ciudades obj = accion.BuscarId(idciudad);
            lbl_Id.Visible = true;
            lbl_Id.Text = obj.IdCiudades.ToString();
            txtDescripC.Text = obj.Descripcion;
        }


        private void RegistrarCiudad(ciudades obj)
        {
            S_Ciudades accion = new S_Ciudades();
            if (accion.Agregar(obj))
            {
                btn_GuardarC.Visible = false;
                lbl_Id.Text = String.Empty;
                txtDescripC.Clear();

                MostrarCiudades();
            }
            else
            {
                MessageBox.Show("Error al realizar esta operacion", "Registrar");
                txtDescripC.SelectAll();

            }
        }

       


        private void ActualizarCiudad(ciudades obj)
        {
            S_Ciudades accion = new S_Ciudades();
            if (accion.Actualizar(obj))
            {
                MessageBox.Show("Actualizado Exitosamnete", "Actualizar");
                btn_GuardarC.Visible = false;
                Limpiar();
                MostrarCiudades();
            }
            else
            {
                MessageBox.Show("Error Al realizar esta operacion", "Actualizar");
                txtDescripC.SelectAll(); txtDescripC.Focus();

            }
        }


        private void Eliminar(int idciudad)
        {
            S_Ciudades accion = new S_Ciudades();
            if (accion.Eliminar(idciudad))
            {
                MessageBox.Show("Registro eliminado exitosamente", "Eliminar");
            }
            else
                MessageBox.Show("Error al realizar esta operacion", "Eliminar");
        }

        private void Limpiar()
        {
            lbl_Id.Text = String.Empty;
            txtDescripC.Clear();
        }

        

       
        private void btn_GuardarC_Click(object sender, EventArgs e)
        {
            ciudades obj = new ciudades();
            obj.Descripcion = txtDescripC.Text;


            if (btn_GuardarC.Text.Equals("Registrar"))
                RegistrarCiudad(obj);
            else
            {
                obj.IdCiudades = Convert.ToInt32(lbl_Id.Text);
                ActualizarCiudad(obj);
            }
        }

      
        private void btn_NuevoC_Click(object sender, EventArgs e)
        {
            btn_GuardarC.Visible = true;
            btn_GuardarC.Text = " Registrar";
            txtDescripC.Focus();
        }

        private void btn_EditarC_Click(object sender, EventArgs e)
        {
            try
            {
                btn_GuardarC.Visible = true;
                btn_GuardarC.Text = "Actualizar";

                int indiceFila = Dt_ListadoC.CurrentRow.Index;
                int idciudad = Convert.ToInt32(Dt_ListadoC.Rows[indiceFila].Cells[1].Value.ToString());
                UbicarCiudad(idciudad);
                txtDescripC.SelectAll();
            }catch(Exception ex)
            {
                MessageBox.Show("Error al realizar esta Actividad" + ex, "Modificar");
            }
        }

        public FrmCiudades()
        {
            InitializeComponent();
        }

        private void FrmCiudades_Load(object sender, EventArgs e)
        {
            MostrarCiudades();
            lbl_Id.Visible = false;
            btn_GuardarC.Visible = false;
        }

        private void btn_EliminarC_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = "Esta seguro de eliminar el registro selecionado?";
                string titulo = "Eliminar";

                if (MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFila = Dt_ListadoC.CurrentRow.Index;
                    int idciudad = Convert.ToInt32(Dt_ListadoC.Rows[indiceFila].Cells[1].Value.ToString());
                    Eliminar(idciudad);
                    MostrarCiudades();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al realizar esta operacion" + ex, "Modificar");

            }
        }
    }
}
