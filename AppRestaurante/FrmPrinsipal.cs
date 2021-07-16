using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinesLayer;
using System.Windows.Forms;

namespace AppRestaurante
{
    public sealed partial class FrmPrinsipal : Form
    {
        public static FrmPrinsipal instancia { get; } = new FrmPrinsipal();

        private FrmPrinsipal()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMesa1_Click(object sender, EventArgs e)
        {
            MostrarManejoDeOrdenes();
        }

        private void btnMesa2_Click(object sender, EventArgs e)
        {
            MostrarManejoDeOrdenes();
        }

        private void btnMesa3_Click_1(object sender, EventArgs e)
        {
            MostrarManejoDeOrdenes();
        }

        private void btnMesa4_Click(object sender, EventArgs e)
        {
            MostrarManejoDeOrdenes();
        }

        private void btnMesa5_Click(object sender, EventArgs e)
        {
            MostrarManejoDeOrdenes();
        }

        private void btnMesa6_Click(object sender, EventArgs e)
        {
            MostrarManejoDeOrdenes();
        }

        private void btnMesa7_Click(object sender, EventArgs e)
        {
            MostrarManejoDeOrdenes();
        }

        private void btnMesa8_Click(object sender, EventArgs e)
        {
            MostrarManejoDeOrdenes();
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmOrdenesGenerales newForm = new FrmOrdenesGenerales();
            newForm.Show();

        }

        private void FrmPrinsipal_VisibleChanged(object sender, EventArgs e)
        {
            FrmManejoOrdenes.instancia.ReiniciarEstado();
        }


        private void MostrarManejoDeOrdenes()
        {
            FrmManejoOrdenes newform =  FrmManejoOrdenes.instancia;
            newform.Show();
            this.Hide();
        }

    }
}
