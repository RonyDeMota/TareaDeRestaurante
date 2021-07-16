
namespace AppRestaurante
{
    partial class FrmOrdenesGenerales
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
            this.DgvDatos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fuerte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bebidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.997014F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.76639F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.236598F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DgvDatos, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnRegresar, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1121, 759);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(59, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1011, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ordenes Guardadas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DgvDatos
            // 
            this.DgvDatos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Entrada,
            this.Fuerte,
            this.Postre,
            this.Bebidas});
            this.DgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvDatos.Location = new System.Drawing.Point(59, 78);
            this.DgvDatos.Name = "DgvDatos";
            this.DgvDatos.RowHeadersWidth = 51;
            this.DgvDatos.RowTemplate.Height = 29;
            this.DgvDatos.Size = new System.Drawing.Size(1011, 601);
            this.DgvDatos.TabIndex = 1;
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
            // Bebidas
            // 
            this.Bebidas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Bebidas.HeaderText = "Bebidas";
            this.Bebidas.MinimumWidth = 6;
            this.Bebidas.Name = "Bebidas";
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnRegresar.Location = new System.Drawing.Point(397, 696);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(334, 49);
            this.BtnRegresar.TabIndex = 2;
            this.BtnRegresar.Text = "REGRESAR";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // FrmOrdenesGenerales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 759);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmOrdenesGenerales";
            this.Text = "FrmOrdenesGenerales";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmOrdenesGenerales_FormClosed);
            this.Load += new System.EventHandler(this.FrmOrdenesGenerales_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fuerte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bebidas;
        private System.Windows.Forms.Button BtnRegresar;
    }
}