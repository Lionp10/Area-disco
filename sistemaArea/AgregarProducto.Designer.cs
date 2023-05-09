namespace sistemaArea
{
    partial class AgregarProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCantidadMax = new System.Windows.Forms.Label();
            this.dplProducto = new System.Windows.Forms.ComboBox();
            this.dplBarra = new System.Windows.Forms.ComboBox();
            this.DgDeposito = new System.Windows.Forms.DataGridView();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.DgProductosBarras = new System.Windows.Forms.DataGridView();
            this.btnCargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgDeposito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgProductosBarras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(643, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Barra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad";
            // 
            // lbCantidadMax
            // 
            this.lbCantidadMax.Location = new System.Drawing.Point(457, 79);
            this.lbCantidadMax.Name = "lbCantidadMax";
            this.lbCantidadMax.Size = new System.Drawing.Size(49, 13);
            this.lbCantidadMax.TabIndex = 3;
            // 
            // dplProducto
            // 
            this.dplProducto.FormattingEnabled = true;
            this.dplProducto.Location = new System.Drawing.Point(41, 68);
            this.dplProducto.Name = "dplProducto";
            this.dplProducto.Size = new System.Drawing.Size(311, 21);
            this.dplProducto.TabIndex = 4;
            this.dplProducto.SelectedIndexChanged += new System.EventHandler(this.dplProducto_SelectedIndexChanged);
            // 
            // dplBarra
            // 
            this.dplBarra.FormattingEnabled = true;
            this.dplBarra.Location = new System.Drawing.Point(646, 68);
            this.dplBarra.Name = "dplBarra";
            this.dplBarra.Size = new System.Drawing.Size(311, 21);
            this.dplBarra.TabIndex = 5;
            this.dplBarra.SelectedIndexChanged += new System.EventHandler(this.dplBarra_SelectedIndexChanged);
            // 
            // DgDeposito
            // 
            this.DgDeposito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgDeposito.Location = new System.Drawing.Point(45, 164);
            this.DgDeposito.Name = "DgDeposito";
            this.DgDeposito.Size = new System.Drawing.Size(417, 405);
            this.DgDeposito.TabIndex = 6;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(40, 106);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(156, 20);
            this.txtCantidad.TabIndex = 7;
            // 
            // DgProductosBarras
            // 
            this.DgProductosBarras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgProductosBarras.Location = new System.Drawing.Point(493, 164);
            this.DgProductosBarras.Name = "DgProductosBarras";
            this.DgProductosBarras.Size = new System.Drawing.Size(417, 405);
            this.DgProductosBarras.TabIndex = 8;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(946, 466);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(113, 102);
            this.btnCargar.TabIndex = 9;
            this.btnCargar.Text = "cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // AgregarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 592);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.DgProductosBarras);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.DgDeposito);
            this.Controls.Add(this.dplBarra);
            this.Controls.Add(this.dplProducto);
            this.Controls.Add(this.lbCantidadMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AgregarProductos";
            this.Text = "AgregarProducto";
            this.Load += new System.EventHandler(this.AgregarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgDeposito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgProductosBarras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCantidadMax;
        private System.Windows.Forms.ComboBox dplProducto;
        private System.Windows.Forms.ComboBox dplBarra;
        private System.Windows.Forms.DataGridView DgDeposito;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridView DgProductosBarras;
        private System.Windows.Forms.Button btnCargar;
    }
}