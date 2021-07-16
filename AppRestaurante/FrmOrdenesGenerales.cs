using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using BusinesLayer;
using System.Windows.Forms;

namespace AppRestaurante
{
    public partial class FrmOrdenesGenerales : Form
    {
        public FrmOrdenesGenerales()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmOrdenesGenerales_Load(object sender, EventArgs e)
        {
            LoadDataTable();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmOrdenesGenerales_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmPrinsipal newFrom = FrmPrinsipal.instancia;
            newFrom.Show();
        }

        private void LoadDataTable()
        {
            foreach(Ordenes Item in Repositorio.Instancia.OrdenesGeneral)
            {
                DgvDatos.Rows.Add(Item.NombreCliente, Item.PlatilloDeEntrada, Item.PlatoFuerte, Item.Postre, Item.Bebida);
            }
        }

    }
}
