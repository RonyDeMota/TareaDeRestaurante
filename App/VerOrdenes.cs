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
    public partial class VerOrdenes : Form
    {
       

        public VerOrdenes()

        {
            InitializeComponent();
        }

         #region Events
                private void FrmOrdenesGenerales_Load(object sender, EventArgs e)
                {

                    ViewOrdenes();

                }
                private void BtnAtra_Click(object sender, EventArgs e)
                {
                    this.Close();
                }
                private void label1_Click(object sender, EventArgs e)
                {

                }
                private void FrmOrdenesGenerales_FormClosed(object sender, FormClosedEventArgs e)
                {
                    Princi Principal = Princi.instancia;
                    Principal.Show();
                }

                private void dvgVerOrdenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
                {

                }
                #endregion

        #region Methods



        private void ViewOrdenes()
        {
            foreach(Orden Item in Repositorio.Instancia.OrdenesGeneral)
            {

               dvgVerOrdenes.Rows.Add(Item.Nombre, Item.Entradas, Item.PlatosFuertes, Item.Bebidas, Item.Postres);

            }
        }

        #endregion

    }
}
