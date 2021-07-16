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
    public partial class FrmOrdenes : Form
    {
        Servicios servicios;

        public FrmOrdenes()
        {
            servicios = new Servicios();
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmOrdenes_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Repositorio.Instancia.estado++;
            procesarFormulario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmOrdenes_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmManejoOrdenes newform =  FrmManejoOrdenes.instancia;
            newform.Show();
        }



        private void LoadComboBox()
        {

            CbxEntrada.Items.Add("Seleccione una opcion");
            CbxEntrada.Items.Add("Pastelitos de queso");
            CbxEntrada.Items.Add("Mariscos al ajillo");
            CbxEntrada.Items.Add("Croquetas de jamón");
            CbxEntrada.Items.Add("Arepas de chicharrón");
            CbxEntrada.Items.Add("Ceviche de camarón y mango");
            CbxEntrada.SelectedItem = "Seleccione una opcion";

            CbxFuerte.Items.Add("Seleccione una opcion");
            CbxFuerte.Items.Add("Atún a la Plancha");
            CbxFuerte.Items.Add("Arroz con Pollo");
            CbxFuerte.Items.Add("Arroz con Camarones");
            CbxFuerte.Items.Add("Arroz con Mariscos");
            CbxFuerte.Items.Add("Camarones Jumbo");
            CbxFuerte.Items.Add("Filete de Pescado");
            CbxFuerte.Items.Add("Pescado Entero Frito");
            CbxFuerte.Items.Add("Sopa de Mariscos");
            CbxFuerte.Items.Add("Sopa de calamar ");
            CbxFuerte.Items.Add("Sopa de camarón");
            CbxFuerte.SelectedItem = "Seleccione una opcion";

            CbxPostre.Items.Add("Seleccione una opcion");
            CbxPostre.Items.Add("Mil crepas de matcha");
            CbxPostre.Items.Add("Volcán de dulce de leche");
            CbxPostre.Items.Add("Moshi ice de té verde");
            CbxPostre.Items.Add("Chocolate de pie de limón");
            CbxPostre.Items.Add("Fondant de chocolate");
            CbxPostre.Items.Add("Pastel de chocolate oaxaqueño");
            CbxPostre.Items.Add("Helado de lavanda");
            CbxPostre.Items.Add("Pastel de miel");
            CbxPostre.Items.Add("Chocolatin");
            CbxPostre.Items.Add("Croissant de almendra");
            CbxPostre.SelectedItem = "Seleccione una opcion";

            CbxBebida.Items.Add("Seleccione una opcion");
            CbxBebida.Items.Add("Vino");
            CbxBebida.Items.Add("Gaseosa");
            CbxBebida.Items.Add("Café");
            CbxBebida.Items.Add("Refresco");
            CbxBebida.Items.Add("Jugos");
            CbxBebida.SelectedItem = "Seleccione una opcion";
        }

        private void procesarFormulario()
        {

            if (TxtNombre.Text != "Seleccione una opcion" && CbxEntrada.Text != "Seleccione una opcion" && CbxFuerte.Text != "Seleccione una opcion" 
                && CbxPostre.Text != "Seleccione una opcion" && CbxBebida.Text != "Seleccione una opcion")
            {
                Ordenes orden = new Ordenes(TxtNombre.Text,CbxEntrada.Text,CbxFuerte.Text,CbxPostre.Text,CbxBebida.Text);
                servicios.AgregarOrdenPorMesas(orden);
                this.Close();
             
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos" , "Advertencia");
            }
        }
    }
}
