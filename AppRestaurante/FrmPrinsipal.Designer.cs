
namespace AppRestaurante
{
    partial class FrmPrinsipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMesa1 = new System.Windows.Forms.Button();
            this.btnMesa2 = new System.Windows.Forms.Button();
            this.btnMesa3 = new System.Windows.Forms.Button();
            this.btnMesa4 = new System.Windows.Forms.Button();
            this.btnMesa5 = new System.Windows.Forms.Button();
            this.btnMesa6 = new System.Windows.Forms.Button();
            this.btnMesa7 = new System.Windows.Forms.Button();
            this.btnMesa8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrdenes = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.25F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnOrdenes, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.5061F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.756098F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(982, 751);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnMesa1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnMesa2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnMesa3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnMesa4, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnMesa5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnMesa6, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnMesa7, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnMesa8, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(114, 91);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(724, 583);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnMesa1
            // 
            this.btnMesa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMesa1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMesa1.Location = new System.Drawing.Point(3, 3);
            this.btnMesa1.Name = "btnMesa1";
            this.btnMesa1.Size = new System.Drawing.Size(356, 139);
            this.btnMesa1.TabIndex = 0;
            this.btnMesa1.Text = "Mesa 1";
            this.btnMesa1.UseVisualStyleBackColor = true;
            this.btnMesa1.Click += new System.EventHandler(this.btnMesa1_Click);
            // 
            // btnMesa2
            // 
            this.btnMesa2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMesa2.Location = new System.Drawing.Point(365, 3);
            this.btnMesa2.Name = "btnMesa2";
            this.btnMesa2.Size = new System.Drawing.Size(356, 139);
            this.btnMesa2.TabIndex = 1;
            this.btnMesa2.Text = "Mesa 2";
            this.btnMesa2.UseVisualStyleBackColor = true;
            this.btnMesa2.Click += new System.EventHandler(this.btnMesa2_Click);
            // 
            // btnMesa3
            // 
            this.btnMesa3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMesa3.Location = new System.Drawing.Point(3, 148);
            this.btnMesa3.Name = "btnMesa3";
            this.btnMesa3.Size = new System.Drawing.Size(356, 139);
            this.btnMesa3.TabIndex = 2;
            this.btnMesa3.Text = "Mesa 3";
            this.btnMesa3.UseVisualStyleBackColor = true;
            this.btnMesa3.Click += new System.EventHandler(this.btnMesa3_Click_1);
            // 
            // btnMesa4
            // 
            this.btnMesa4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMesa4.Location = new System.Drawing.Point(365, 148);
            this.btnMesa4.Name = "btnMesa4";
            this.btnMesa4.Size = new System.Drawing.Size(356, 139);
            this.btnMesa4.TabIndex = 3;
            this.btnMesa4.Text = "Mesa 4";
            this.btnMesa4.UseVisualStyleBackColor = true;
            this.btnMesa4.Click += new System.EventHandler(this.btnMesa4_Click);
            // 
            // btnMesa5
            // 
            this.btnMesa5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMesa5.Location = new System.Drawing.Point(3, 293);
            this.btnMesa5.Name = "btnMesa5";
            this.btnMesa5.Size = new System.Drawing.Size(356, 139);
            this.btnMesa5.TabIndex = 4;
            this.btnMesa5.Text = "Mesa 5";
            this.btnMesa5.UseVisualStyleBackColor = true;
            this.btnMesa5.Click += new System.EventHandler(this.btnMesa5_Click);
            // 
            // btnMesa6
            // 
            this.btnMesa6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMesa6.Location = new System.Drawing.Point(365, 293);
            this.btnMesa6.Name = "btnMesa6";
            this.btnMesa6.Size = new System.Drawing.Size(356, 139);
            this.btnMesa6.TabIndex = 5;
            this.btnMesa6.Text = "Mesa 6";
            this.btnMesa6.UseVisualStyleBackColor = true;
            this.btnMesa6.Click += new System.EventHandler(this.btnMesa6_Click);
            // 
            // btnMesa7
            // 
            this.btnMesa7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMesa7.Location = new System.Drawing.Point(3, 438);
            this.btnMesa7.Name = "btnMesa7";
            this.btnMesa7.Size = new System.Drawing.Size(356, 142);
            this.btnMesa7.TabIndex = 6;
            this.btnMesa7.Text = "Mesa 7";
            this.btnMesa7.UseVisualStyleBackColor = true;
            this.btnMesa7.Click += new System.EventHandler(this.btnMesa7_Click);
            // 
            // btnMesa8
            // 
            this.btnMesa8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMesa8.Location = new System.Drawing.Point(365, 438);
            this.btnMesa8.Name = "btnMesa8";
            this.btnMesa8.Size = new System.Drawing.Size(356, 142);
            this.btnMesa8.TabIndex = 7;
            this.btnMesa8.Text = "Mesa 8";
            this.btnMesa8.UseVisualStyleBackColor = true;
            this.btnMesa8.Click += new System.EventHandler(this.btnMesa8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(114, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(724, 88);
            this.label1.TabIndex = 1;
            this.label1.Text = "SELECCIONE LA MESA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOrdenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOrdenes.Location = new System.Drawing.Point(114, 680);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Size = new System.Drawing.Size(724, 68);
            this.btnOrdenes.TabIndex = 2;
            this.btnOrdenes.Text = "ORDENES";
            this.btnOrdenes.UseVisualStyleBackColor = false;
            this.btnOrdenes.Click += new System.EventHandler(this.btnOrdenes_Click);
            // 
            // FrmPrinsipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 751);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmPrinsipal";
            this.Text = "FrmPrinsipal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.VisibleChanged += new System.EventHandler(this.FrmPrinsipal_VisibleChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnMesa1;
        private System.Windows.Forms.Button btnMesa2;
        private System.Windows.Forms.Button btnMesa3;
        private System.Windows.Forms.Button btnMesa4;
        private System.Windows.Forms.Button btnMesa5;
        private System.Windows.Forms.Button btnMesa6;
        private System.Windows.Forms.Button btnMesa7;
        private System.Windows.Forms.Button btnMesa8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrdenes;
    }
}

