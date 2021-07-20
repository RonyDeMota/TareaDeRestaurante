using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AppRestaurante.CustomControlItem;
using BusinesLayer;

namespace AppRestaurante
{
    public partial class HacerOrden : Form
    {

        Servicio Servic;
        public HacerOrden()
        {

            Servic = new Servicio();

            InitializeComponent();
        }

        #region Events

        
        private void FrmOrdenes_Load(object sender, EventArgs e)
        {
            AgregarComida();
        }
        private void BtnAddGet_Click(object sender, EventArgs e)
        {
            Validacion();
        }
        private void btnCancelarGen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmOrdenes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mesas Mesas =  Mesas.Instancia;
            Mesas.Show();
        }
#endregion


        #region Methods
        private void AgregarComida()
        {
            //Default
            CbxEntrada.Items.Add("Seleccione una opcion");
            CbxPlatFuert.Items.Add("Seleccione una opcion");
            CbxPostre.Items.Add("Seleccione una opcion");
            CbxBebida.Items.Add("Seleccione una opcion");
            //Entradas
            CbxEntrada.Items.Add("Croquetas de queso");
            CbxEntrada.Items.Add("Croquetas de pollo");
            CbxEntrada.Items.Add("Chicharron de pollo con tostones");
            CbxEntrada.Items.Add("Sopa de pescado");
            CbxEntrada.Items.Add("Sancocho");
            //Platos Fuertes
            CbxPlatFuert.Items.Add("Pechuga a la plancha");
            CbxPlatFuert.Items.Add("Pechuga a la crema");
            CbxPlatFuert.Items.Add("Camarones a la crema");
            CbxPlatFuert.Items.Add("Camarones al ajillo");
            CbxPlatFuert.Items.Add("Pasta Con Carne");
            CbxPlatFuert.Items.Add("Espaguetis con tostones de platano");
            CbxPlatFuert.Items.Add("Espagueti con albondigas");
            CbxPlatFuert.Items.Add("Chuleta de cerdo con pure de papa");
            CbxPlatFuert.Items.Add("Guisado de cerdo");
            CbxPlatFuert.Items.Add("Veguetales pon pollo");
            //Bebidas
            CbxBebida.Items.Add("Jugo");
            CbxBebida.Items.Add("Vino");
            CbxBebida.Items.Add("Smirnoff");
            CbxBebida.Items.Add("Soda");
            CbxBebida.Items.Add("Cerveza");
            //Postres
            CbxPostre.Items.Add("Flan");
            CbxPostre.Items.Add("Pastel tres leches");
            CbxPostre.Items.Add("Helado de deule de leche");
            CbxPostre.Items.Add("Cheese cake");
            CbxPostre.Items.Add("Red velvet");
 
            CbxEntrada.SelectedItem = "Seleccione una opcion";
            CbxPlatFuert.SelectedItem = "Seleccione una opcion";
            CbxPostre.SelectedItem = "Seleccione una opcion";
            CbxBebida.SelectedItem = "Seleccione una opcion";
        }

        private void Validacion()
        { 
            if ( TxtNombre.Text != "Seleccione una opcion" && CbxEntrada.Text != "Seleccione una opcion" && CbxPlatFuert.Text != "Seleccione una opcion" 
                && CbxPostre.Text != "Seleccione una opcion" && CbxBebida.Text != "Seleccione una opcion")
            {

                Orden OrdenesHechas = new Orden(TxtNombre.Text,CbxEntrada.Text, CbxPlatFuert.Text,CbxPostre.Text,CbxBebida.Text);
                Servic.AgregarOrdenPorMesas(OrdenesHechas);
                this.Close();
            }
            else
            {
                MessageBox.Show("Faltan Campos Por llenar");
            }
        } 
        
        #endregion
    }
}
