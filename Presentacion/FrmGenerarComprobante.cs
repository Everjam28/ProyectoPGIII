using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;
using Entidades;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmGenerarComprobante : Form
    {
        S_GenerarComprobantes generarComprobantes = new S_GenerarComprobantes();
        public int IDVENTAS;
        public FrmGenerarComprobante()
        {
            InitializeComponent();

        }

        private void GenerarComprobante(int idventas)
        {
            generarComprobantes.GenerarComprobantes(idventas);
            sGenerarComprobantesBindingSource.DataSource = generarComprobantes.generarComprobante;
            reportViewer1.RefreshReport();
        }

        private void GenerarComprobante_Load(object sender, EventArgs e)
        {
            GenerarComprobante(IDVENTAS);
           
        }
    }
}
