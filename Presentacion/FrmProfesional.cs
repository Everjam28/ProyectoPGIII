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
    public partial class FrmProfesional : Form
    {
        S_Profesionales accion = new S_Profesionales();
        S_Ciudades accion2 = new S_Ciudades();

       
        public FrmProfesional()
        {
            InitializeComponent();
            LLenarCombo();
        }


        private void MensajeConfirmacion(string mensaje)
        {
            MessageBox.Show(mensaje, "MarketSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "MarketSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LimpiarText()
        {
            txt_codigoP.Text = "";
            txt_cedulaP.Text = "";
            txt_NombresP.Text = "";
            txt_apellidosP.Text = "";
            txt_direccionP.Text = "";
            txt_telefonoP.Text = "";
            txt_correoP.Text = "";
            txt_codigoP.Focus();
        }

        private void LLenarCombo()
        {
            Cb_CiudadP.DataSource = accion2.Listado();
            Cb_CiudadP.ValueMember = "idciudades";
            Cb_CiudadP.DisplayMember = "descripcion";
        }

        private void btn_GuardarP_Click(object sender, EventArgs e)
        {
            Profesionales obj = new Profesionales();
            if (txt_cedulaP.Text.Trim() != "") 
            {
                if(Program.Evento == 0)
                {
                    try
                    {
                        obj.ccProfesional = txt_cedulaP.Text.ToUpper();
                        obj.nombres = txt_NombresP.Text.ToUpper();
                        obj.apellidos = txt_apellidosP.Text.ToUpper();
                        obj.direccion = txt_direccionP.Text.ToUpper();
                        obj.telefono = txt_telefonoP.Text.ToUpper();
                        obj.correo = txt_correoP.Text.ToUpper();
                        obj.idciudades = Convert.ToInt32(Cb_CiudadP.SelectedValue);

                        accion.Agregar(obj);
                        MensajeConfirmacion("Se Agrego Correctamente");
                        Program.Evento = 0;
                        LimpiarText();
                        Close();
                    }
                    catch (Exception)
                    {
                        MensajeError("No se Pudo Agregar EL Registro");
                    }
                }
                else
                {
                    try
                    {
                        obj.idProfesional = Convert.ToInt32(txt_codigoP.Text.ToUpper());
                        obj.ccProfesional = txt_cedulaP.Text.ToUpper();
                        obj.nombres = txt_NombresP.Text.ToUpper();
                        obj.apellidos = txt_apellidosP.Text.ToUpper();
                        obj.direccion = txt_direccionP.Text.ToUpper();
                        obj.telefono = txt_telefonoP.Text.ToUpper();
                        obj.correo = txt_correoP.Text.ToUpper();
                        obj.idciudades = Convert.ToInt32(Cb_CiudadP.SelectedValue);

                        accion.Actualizar(obj);
                        MensajeConfirmacion("Se Modifico Correctamente");
                        Program.Evento = 0;
                        LimpiarText();
                        Close();
                    }
                    catch (Exception)
                    {
                        MensajeError("No se Pudo Modificar EL Registro");
                    }
                }

            }
            else
            {
                MensajeError("Debe llenar los campos para agregar el registro");
            }
        }

        private void Btn_CancelarP_Click(object sender, EventArgs e)
        {
            LimpiarText();
        }



        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
