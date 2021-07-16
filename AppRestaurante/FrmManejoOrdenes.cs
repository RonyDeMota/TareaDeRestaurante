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
    public sealed partial class FrmManejoOrdenes : Form
    {

        public static FrmManejoOrdenes instancia { get; } = new FrmManejoOrdenes();
        FrmPrinsipal newForm = FrmPrinsipal.instancia;

        Servicios servicios;

        private FrmManejoOrdenes()
        {
            servicios = new Servicios();
            InitializeComponent();
        }

        private void FrmManejoOrdenes_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            newForm.Show();
        }

        private void FrmManejoOrdenes_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmManejoOrdenes_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private void CbxCantidadDePersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModificarEstado();
            BloquearComboBox();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MostrarFrmOrdenes();
        }

        private void brnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            newForm.Show();
        }

        private void FrmManejoOrdenes_VisibleChanged(object sender, EventArgs e)
        {
            LoadDataTable();
            ModificarEstado();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarOrdenes();
        }

        private void DGVOrdenesMesas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        private void LoadDataTable()
        {
            DGVOrdenesMesas.Rows.Clear();
            foreach (Ordenes Item in Repositorio.Instancia.OrdenesPorMesas)
            {
                DGVOrdenesMesas.Rows.Add(Item.NombreCliente, Item.PlatilloDeEntrada, Item.PlatoFuerte, Item.Postre, Item.Bebida);
            }
        }

        private void LoadComboBox()
        {
            CbxCantidadDePersonas.Items.Add("Seleccione una opcion");
            CbxCantidadDePersonas.Items.Add("1");
            CbxCantidadDePersonas.Items.Add("2");
            CbxCantidadDePersonas.Items.Add("3");
            CbxCantidadDePersonas.Items.Add("4");
            CbxCantidadDePersonas.SelectedItem = "Seleccione una opcion";
        }

        private void ModificarEstado()
        {
            if (CbxCantidadDePersonas.Text != "Seleccione una opcion")
            {
                LblEstado.Text = $"Orden: {Repositorio.Instancia.estado} de {CbxCantidadDePersonas.Text}";
            }
            else
            {
                LblEstado.Text = $"Orden: {Repositorio.Instancia.estado} de {0}";
            }
               
        }

        private void MostrarFrmOrdenes()
        {
            if(CbxCantidadDePersonas.Text != "Seleccione una opcion")
            {
                if (Convert.ToString(Repositorio.Instancia.estado) != CbxCantidadDePersonas.Text)
                {
                    FrmOrdenes FormOrdenes = new FrmOrdenes();
                    FormOrdenes.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No puede realizar mas ordenes");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una opcion");
            }
         
        }

        private void GuardarOrdenes()
        {
            foreach(Ordenes Item in Repositorio.Instancia.OrdenesPorMesas)
            {
                servicios.AgregarOrdenGeneral(Item);
            }

             this.Hide();
             FrmPrinsipal newForm = FrmPrinsipal.instancia;
             newForm.Show();
        }

        public void ReiniciarEstado()
        {
            Repositorio.Instancia.estado = 0;
            Repositorio.Instancia.OrdenesPorMesas.Clear();

            CbxCantidadDePersonas.SelectedItem = "Seleccione una opcion";
            CbxCantidadDePersonas.Enabled = true;
        }

        private void BloquearComboBox()
        {
            if(CbxCantidadDePersonas.Text == "1" || CbxCantidadDePersonas.Text == "2" || CbxCantidadDePersonas.Text == "3"|| CbxCantidadDePersonas.Text == "4")
            {
                CbxCantidadDePersonas.Enabled=false;
            }
        }

    }
}
