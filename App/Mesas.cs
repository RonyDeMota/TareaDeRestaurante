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
    public sealed partial class Mesas : Form
    {

        Servicio Servic;
        public static Mesas Instancia { get; } = new Mesas();

        #region Events

      

        Princi Principal = Princi.instancia;
        private Mesas()
        {

            Servic = new Servicio();

            InitializeComponent();
        }

        private void lbltemale_Click(object sender, EventArgs e)
        {

        }
        private void FrmManejoOrdenes_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Principal.Show();
        }
        private void FrmManejoOrdenes_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
        private void FrmManejoOrdenes_Load(object sender, EventArgs e)
        {

            CantPers();

        }
        private void cbxCantidadPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {

            Disable();

        }

        private void BtnMesaAnadirOrd_Click(object sender, EventArgs e)
        {
            MostrarFrmOrdenes();
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {

            this.Hide();

            Principal.Show();

        }
        private void FrmManejoOrdenes_VisibleChanged(object sender, EventArgs e)
        {

            CargarOrden();
           
        }
        private void btnAddOrden_Click(object sender, EventArgs e)
        {
            GuardarOrdenes();
        }
        #endregion


        #region Methods


        private void CargarOrden()
        {
            TableViewOrden.Rows.Clear();

            foreach (Orden Item in Repositorio.Instancia.OrdenesPorMesas)
            {

                TableViewOrden.Rows.Add(Item.Nombre, Item.Entradas, Item.PlatosFuertes, Item.Bebidas, Item.Postres);

            }
        }

        private void CantPers()
        {
            cbxCantidadPersonas.Items.Add("Seleccione una Opción");

            cbxCantidadPersonas.Items.Add("1");
            cbxCantidadPersonas.Items.Add("2");
            cbxCantidadPersonas.Items.Add("3");
            cbxCantidadPersonas.Items.Add("4");

            cbxCantidadPersonas.SelectedItem = "Seleccione una Opción";
        }

        private void MostrarFrmOrdenes()
        {
            if(cbxCantidadPersonas.Text != "Seleccione una Opción")
            {
                if (cbxCantidadPersonas.Text != "Seleccione una Opción")
                {
                    HacerOrden FormOrdenes = new HacerOrden();
                    FormOrdenes.Show();
                    this.Hide();
                }
                else
                { MessageBox.Show("No puede realizar mas ordenes");}
                }
            else
            { MessageBox.Show("Seleccione una Opción"); }
        }

        private void GuardarOrdenes()
        {
            foreach(Orden Item in Repositorio.Instancia.OrdenesPorMesas)
            {
                Servic.AgregarOrdenGeneral(Item);
            }

             this.Hide();

             Princi newForm = Princi.instancia;

             newForm.Show();
        }

        public void Limpiar()
        {
            Repositorio.Instancia.OrdenesPorMesas.Clear();

            cbxCantidadPersonas.SelectedItem = "Seleccione una Opción";

            cbxCantidadPersonas.Enabled = true;
        }

        private void Disable()
        {
            if(cbxCantidadPersonas.Text != "Seleccione una Opción")
            {
                cbxCantidadPersonas.Enabled=false;}
        }

        #endregion

    }
}
