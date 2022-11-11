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
    public partial class FrmClientes : Form
    {
        S_Clientes accion = new S_Clientes();
        S_Ciudades accion2 = new S_Ciudades();

       
        public FrmClientes()
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
            txt_codigoC.Text = "";
            txt_RUC.Text = "";
            txt_RazonSocial.Text = "";
            txt_direccionC.Text = "";
            txt_telefonoC.Text = "";
            txt_correoC.Text = "";
            txt_codigoC.Focus();
        }

        private void LLenarCombo()
        {
            Cb_CiudadC.DataSource = accion2.Listado();
            Cb_CiudadC.ValueMember = "idciudades";
            Cb_CiudadC.DisplayMember = "descripcion";

            cbx_profesionalC.DataSource = accion2.Listado();
            cbx_profesionalC.ValueMember = "idprofesionales";
            cbx_profesionalC.DisplayMember = "nombres";
        }

        private void btn_GuardarC_Click(object sender, EventArgs e)
        {
            Clientes obj = new Clientes();
            if (txt_RUC.Text.Trim() != "" | txt_RazonSocial.Text.Trim() != "")
            {
                if (Program.Evento == 0)
                {
                    try
                    {
                        obj.ccoruc = txt_RUC.Text.ToUpper();
                        obj.razonsocial = txt_RazonSocial.Text.ToUpper();
                        obj.direccion = txt_direccionC.Text.ToUpper();
                        obj.telefono = txt_telefonoC.Text.ToUpper();
                        obj.correo = txt_correoC.Text.ToUpper();
                        obj.idProfesional = Convert.ToInt32(cbx_profesionalC.SelectedValue);
                        obj.IdCiudades = Convert.ToInt32(Cb_CiudadC.SelectedValue);

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
                        obj.idClientes = Convert.ToInt32(txt_codigoC.Text.ToUpper());
                        obj.ccoruc = txt_RUC.Text.ToUpper();
                        obj.razonsocial = txt_RazonSocial.Text.ToUpper();
                        obj.direccion = txt_direccionC.Text.ToUpper();
                        obj.telefono = txt_telefonoC.Text.ToUpper();
                        obj.correo = txt_correoC.Text.ToUpper();
                        obj.idProfesional = Convert.ToInt32(cbx_profesionalC.SelectedValue);
                        obj.IdCiudades = Convert.ToInt32(Cb_CiudadC.SelectedValue);

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

        private void Btn_CancelarC_Click(object sender, EventArgs e)
        {
            LimpiarText();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
