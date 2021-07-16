
namespace AppRestaurante
{
    partial class FrmManejoOrdenes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.brnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxCantidadDePersonas = new System.Windows.Forms.ComboBox();
            this.btnAnadirNuevaOrden = new System.Windows.Forms.Button();
            this.LblEstado = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.DGVOrdenesMesas = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fuerte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrdenesMesas)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.625F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.555555F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.43356F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.055944F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 765);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(66, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(874, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manejo de ordenes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.brnCancelar, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.CbxCantidadDePersonas, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnAnadirNuevaOrden, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.LblEstado, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnGuardar, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.DGVOrdenesMesas, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(66, 76);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(874, 654);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // brnCancelar
            // 
            this.brnCancelar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.brnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brnCancelar.Location = new System.Drawing.Point(3, 558);
            this.brnCancelar.Name = "brnCancelar";
            this.brnCancelar.Size = new System.Drawing.Size(431, 93);
            this.brnCancelar.TabIndex = 1;
            this.brnCancelar.Text = "Cancelar";
            this.brnCancelar.UseVisualStyleBackColor = false;
            this.brnCancelar.Click += new System.EventHandler(this.brnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(128, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 65);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad de personas en la mesa: ";
            // 
            // CbxCantidadDePersonas
            // 
            this.CbxCantidadDePersonas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CbxCantidadDePersonas.FormattingEnabled = true;
            this.CbxCantidadDePersonas.Location = new System.Drawing.Point(440, 3);
            this.CbxCantidadDePersonas.Name = "CbxCantidadDePersonas";
            this.CbxCantidadDePersonas.Size = new System.Drawing.Size(431, 28);
            this.CbxCantidadDePersonas.TabIndex = 5;
            this.CbxCantidadDePersonas.SelectedIndexChanged += new System.EventHandler(this.CbxCantidadDePersonas_SelectedIndexChanged);
            // 
            // btnAnadirNuevaOrden
            // 
            this.btnAnadirNuevaOrden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnadirNuevaOrden.Location = new System.Drawing.Point(440, 68);
            this.btnAnadirNuevaOrden.Name = "btnAnadirNuevaOrden";
            this.btnAnadirNuevaOrden.Size = new System.Drawing.Size(431, 92);
            this.btnAnadirNuevaOrden.TabIndex = 4;
            this.btnAnadirNuevaOrden.Text = "Añadir Nueva orden";
            this.btnAnadirNuevaOrden.UseVisualStyleBackColor = true;
            this.btnAnadirNuevaOrden.Click += new System.EventHandler(this.button3_Click);
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LblEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblEstado.Location = new System.Drawing.Point(3, 65);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(431, 98);
            this.LblEstado.TabIndex = 7;
            this.LblEstado.Text = "Ordenes: 0 de 0";
            this.LblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Green;
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGuardar.Location = new System.Drawing.Point(440, 558);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(431, 93);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // DGVOrdenesMesas
            // 
            this.DGVOrdenesMesas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGVOrdenesMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVOrdenesMesas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Entrada,
            this.Fuerte,
            this.Postre,
            this.Bebida});
            this.tableLayoutPanel3.SetColumnSpan(this.DGVOrdenesMesas, 2);
            this.DGVOrdenesMesas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVOrdenesMesas.Location = new System.Drawing.Point(3, 166);
            this.DGVOrdenesMesas.Name = "DGVOrdenesMesas";
            this.DGVOrdenesMesas.RowHeadersWidth = 51;
            this.DGVOrdenesMesas.RowTemplate.Height = 29;
            this.DGVOrdenesMesas.Size = new System.Drawing.Size(868, 386);
            this.DGVOrdenesMesas.TabIndex = 8;
            this.DGVOrdenesMesas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVOrdenesMesas_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            // 
            // Entrada
            // 
            this.Entrada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Entrada.HeaderText = "Entrada";
            this.Entrada.MinimumWidth = 6;
            this.Entrada.Name = "Entrada";
            // 
            // Fuerte
            // 
            this.Fuerte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fuerte.HeaderText = "Fuerte";
            this.Fuerte.MinimumWidth = 6;
            this.Fuerte.Name = "Fuerte";
            // 
            // Postre
            // 
            this.Postre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Postre.HeaderText = "Postre";
            this.Postre.MinimumWidth = 6;
            this.Postre.Name = "Postre";
            // 
            // Bebida
            // 
            this.Bebida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Bebida.HeaderText = "Bebida";
            this.Bebida.MinimumWidth = 6;
            this.Bebida.Name = "Bebida";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.375F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // FrmManejoOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 765);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmManejoOrdenes";
            this.Text = "FrmManejoOrdenes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmManejoOrdenes_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmManejoOrdenes_FormClosed);
            this.Load += new System.EventHandler(this.FrmManejoOrdenes_Load);
            this.VisibleChanged += new System.EventHandler(this.FrmManejoOrdenes_VisibleChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrdenesMesas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button brnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxCantidadDePersonas;
        private System.Windows.Forms.Button btnAnadirNuevaOrden;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.DataGridView DGVOrdenesMesas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fuerte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bebida;
    }
}