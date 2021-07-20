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
    public sealed partial class Princi : Form
    {

        #region Events

       
        public static Princi instancia { get; } = new Princi();

        private Princi()
        {
            InitializeComponent();
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnMesa1_Click_1(object sender, EventArgs e)
        {
            Mesas();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Mesas();
        }
        private void btnMesa3_Click(object sender, EventArgs e)
        {
            Mesas();
        }
        private void btnMesa4_Click(object sender, EventArgs e)
        {
            Mesas();
        }
        private void btnMesa5_Click(object sender, EventArgs e)
        {
            Mesas();
        }

        private void btnOrdenes_Click_1(object sender, EventArgs e)
        {
            
            VerOrdenes VerOrdenes = new VerOrdenes();
            this.Hide();
            VerOrdenes.Show();
        }
        private void Princi_VisibleChanged(object sender, EventArgs e)
        {
            AppRestaurante.Mesas.Instancia.Limpiar();
        }


 #endregion


        #region Methods

      





        private void Mesas()
        {
            Mesas Mesas =  Mesas.Instancia;

            Mesas.Show();
            this.Hide();
        }





        #endregion

       
    }
}
