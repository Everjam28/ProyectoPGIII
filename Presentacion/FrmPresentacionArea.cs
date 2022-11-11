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
    public partial class FrmPresentacionArea : Form
    {

        private void MostrarCiudad()
        {
            S_Ciudades accion = new S_Ciudades();
            List<ciudades> listado = accion.Listado();
            Dt_Listado.Rows.Clear();

            foreach (ciudades obj in listado)
            {
                Dt_Listado.Rows.Add(obj.Descripcion, obj.IdCiudades);
            }

        }

               
         
        public void UbicarCiudad(int idciudad)
        {
            S_Ciudades accion = new S_Ciudades();
            ciudades obj = accion.BuscarId(idciudad);
            lbll_area.Visible = true;
            lbll_area.Text = obj.IdCiudades.ToString();
            txt_nombre.Text = obj.Descripcion;
            
        }


        private void EliminarCiudad(int idciudad)
        {
            S_Ciudades accion = new S_Ciudades();
            if (accion.Eliminar(idciudad))
            {
                MessageBox.Show("Registro eliminado exitosamente", "Eliminar");
            }
            else
                MessageBox.Show("Error al realizar esta operacion","Eliminar");
        }

        private void Limpiar()
        {
            lbll_area.Text = String.Empty;
            txt_nombre.Clear();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bt_Vis.Visible = true;
            bt_Vis.Text = "Registrar";
            txt_nombre.Focus();
        }

        private void bt_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                bt_Vis.Visible = true;
                bt_Vis.Text = "Actualizar";

                int indiceFila = Dt_Listado.CurrentRow.Index;
                int idciudad = Convert.ToInt32(Dt_Listado.Rows[indiceFila].Cells[1].Value.ToString());
                UbicarCiudad(idciudad);
                txt_nombre.SelectAll();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Realizar esta Actividad" + ex, "Modificar");
            }
        }

       private void RegistrarArea(ciudades obj)
        {
            S_Ciudades accion = new S_Ciudades();
            if (accion.Agregar(obj))
            {
                bt_Vis.Visible = false;
                lbll_area.Text = String.Empty;
                txt_nombre.Clear();
         
                MostrarCiudad();
            }
            else
            {
                MessageBox.Show("Error al realizar esta operacion", "Registrar");
                txt_nombre.SelectAll();
                
            }
        }

        private void ActualizarCiudad(ciudades obj)
        {
            S_Ciudades accion = new S_Ciudades();
            if (accion.Actualizar(obj))
            {
                MessageBox.Show("Actualizado Exitosamnete", "Actualizar");
                bt_Vis.Visible = false;
                Limpiar();
                MostrarCiudad();
            }
            else
            {
                MessageBox.Show("Error Al realizar esta operacion", "Actualizar");
                txt_nombre.SelectAll();txt_nombre.Focus();

            }
        }

       
        private void bt_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {


                string msg = "Esta seguro de eliminar el registro selecionado?";
                string titulo = "Eliminar";

                if (MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indiceFila = Dt_Listado.CurrentRow.Index;
                    int idciudad = Convert.ToInt32(Dt_Listado.Rows[indiceFila].Cells[1].Value.ToString());
                    EliminarCiudad(idciudad);
                    MostrarCiudad();
                }
            }catch(Exception ex){
                MessageBox.Show("Error Al realizar esta operacion" + ex, "Modificar");

            }
        }

        private void bt_Vis_Click(object sender, EventArgs e)
        {
            ciudades obj = new ciudades();
            obj.Descripcion = txt_nombre.Text;
            

            if (bt_Vis.Text.Equals("Registrar"))
                RegistrarArea(obj);
            else
            {
                obj.IdCiudades = Convert.ToInt32(lbll_area.Text);
                ActualizarCiudad(obj);
            }
        }

        public FrmPresentacionArea()
        {
            InitializeComponent();
        }

        private void FrmPresentacionArea_Load(object sender, EventArgs e)
        {
            MostrarCiudad();
            lbll_area.Visible = false;
            bt_Vis.Visible = false;
        }

        private void bt_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
