using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        //private const int tamañogrid = 10;
        //private const int aremouse = 132;
        //private const int botonizquierdo = 17;
        //private Rectangle rectangulogrid;


        //protected override void OnSizeChanged(EventArgs e)
        //{
        //    base.OnAutoSizeChanged(e);

        //    var region = new Region(new Rectangle(0, 0, ClientRectangle.Width, ClientRectangle.Height));
        //    rectangulogrid = new Rectangle(ClientRectangle.Width - tamañogrid, ClientRectangle.Height - tamañogrid, tamañogrid, tamañogrid);

        //    region.Exclude(rectangulogrid);

        //    panel_Principal.Region = region;
        //    Invalidate();
        //}

        //protected override void WndProc(ref Message sms)
        //{
        //    switch (sms.Msg)
        //    {
        //        case aremouse:
        //            base.WndProc(ref sms);

        //            var RefPoint = PointToClient(new Point(sms.LParam.ToInt32() & 0xffff, sms.LParam.ToInt32() >> 16));

        //            if (!rectangulogrid.Contains(RefPoint))
        //            {
        //                break;
        //            }

        //            sms.Result = new IntPtr(botonizquierdo);
        //            break;
        //        default:
        //            base.WndProc(ref sms);
        //            break;
        //    }
        //}

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    SolidBrush solidBrush = new SolidBrush(Color.FromArgb(60, 60, 60));

        //    e.Graphics.FillRectangle(solidBrush, rectangulogrid);
        //    base.OnPaint(e);
        //    ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, rectangulogrid);
        //}

        int lx, ly;

        private void btn_Maximizar_Click(object sender, EventArgs e)
        {
            lx = Location.X;
            ly = Location.Y;
            sw = Size.Width;
            sh = Size.Height;

            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;

            btn_Maximizar.Visible = false;
            btn_restaurar.Visible = true;
        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            Size = new Size(sw, sh);
            Location = new Point(lx, ly);

            btn_restaurar.Visible = false;
            btn_Maximizar.Visible = true;
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de cerrar el prog ?", "!Alerta¡", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                Application.Exit();
            }

        }
        int sw, sh;

        private void btn_Profesionales_Click(object sender, EventArgs e)
        {
            AbrirFormularios<FrmProfesional>();
        }

        private void btn_Ciudades_Click(object sender, EventArgs e)
        {
            AbrirFormularios<FrmCiudades>();
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            AbrirFormularios<FrmClientes>();
        }

        private void AbrirFormularios<FormularioAbrir>()where FormularioAbrir : Form,new()
        {
            Form Formularios;

            Formularios = panel_Contenedor.Controls.OfType<FormularioAbrir>().FirstOrDefault();

            if(Formularios == null)
            {
                Formularios = new FormularioAbrir
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill
                };

                panel_Contenedor.Controls.Add(Formularios);
                panel_Contenedor.Tag = Formularios;

                Formularios.Show();

                Formularios.BringToFront();
            }
            else
            {
                Formularios.BringToFront();
            }
        }
        
        
        
   


    }
}
