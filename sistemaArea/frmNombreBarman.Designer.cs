namespace sistemaArea
{
    partial class frmNombreBarman
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.txtBarman1 = new System.Windows.Forms.TextBox();
            this.txtBarman2 = new System.Windows.Forms.TextBox();
            this.txtBarman4 = new System.Windows.Forms.TextBox();
            this.txtBarman3 = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lbBarman1 = new System.Windows.Forms.Label();
            this.lbBarman2 = new System.Windows.Forms.Label();
            this.lbBarman3 = new System.Windows.Forms.Label();
            this.lbBarman4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(186)))), ((int)(((byte)(175)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(12, 405);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(212, 61);
            this.btnCerrar.TabIndex = 25;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Prompt Medium", 12F, System.Drawing.FontStyle.Bold);
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(88, 55);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(620, 24);
            this.lbTitle.TabIndex = 26;
            this.lbTitle.Text = "ESCRIBA EL NOMBRE DE CADA BARMAN PARA ASIGNARLE UN NÚMERO";
            // 
            // txtBarman1
            // 
            this.txtBarman1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBarman1.Location = new System.Drawing.Point(109, 174);
            this.txtBarman1.Name = "txtBarman1";
            this.txtBarman1.Size = new System.Drawing.Size(253, 30);
            this.txtBarman1.TabIndex = 27;
            // 
            // txtBarman2
            // 
            this.txtBarman2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtBarman2.Location = new System.Drawing.Point(438, 174);
            this.txtBarman2.Name = "txtBarman2";
            this.txtBarman2.Size = new System.Drawing.Size(253, 30);
            this.txtBarman2.TabIndex = 28;
            // 
            // txtBarman4
            // 
            this.txtBarman4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtBarman4.Location = new System.Drawing.Point(438, 280);
            this.txtBarman4.Name = "txtBarman4";
            this.txtBarman4.Size = new System.Drawing.Size(253, 30);
            this.txtBarman4.TabIndex = 30;
            // 
            // txtBarman3
            // 
            this.txtBarman3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBarman3.Location = new System.Drawing.Point(109, 280);
            this.txtBarman3.Name = "txtBarman3";
            this.txtBarman3.Size = new System.Drawing.Size(253, 30);
            this.txtBarman3.TabIndex = 29;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(26)))), ((int)(((byte)(21)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(572, 405);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(212, 61);
            this.btnGuardar.TabIndex = 31;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lbBarman1
            // 
            this.lbBarman1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbBarman1.AutoSize = true;
            this.lbBarman1.BackColor = System.Drawing.Color.Transparent;
            this.lbBarman1.ForeColor = System.Drawing.Color.White;
            this.lbBarman1.Location = new System.Drawing.Point(105, 149);
            this.lbBarman1.Name = "lbBarman1";
            this.lbBarman1.Size = new System.Drawing.Size(80, 22);
            this.lbBarman1.TabIndex = 32;
            this.lbBarman1.Text = "Barman 1:";
            // 
            // lbBarman2
            // 
            this.lbBarman2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbBarman2.AutoSize = true;
            this.lbBarman2.BackColor = System.Drawing.Color.Transparent;
            this.lbBarman2.ForeColor = System.Drawing.Color.White;
            this.lbBarman2.Location = new System.Drawing.Point(434, 149);
            this.lbBarman2.Name = "lbBarman2";
            this.lbBarman2.Size = new System.Drawing.Size(84, 22);
            this.lbBarman2.TabIndex = 33;
            this.lbBarman2.Text = "Barman 2:";
            // 
            // lbBarman3
            // 
            this.lbBarman3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbBarman3.AutoSize = true;
            this.lbBarman3.BackColor = System.Drawing.Color.Transparent;
            this.lbBarman3.ForeColor = System.Drawing.Color.White;
            this.lbBarman3.Location = new System.Drawing.Point(105, 255);
            this.lbBarman3.Name = "lbBarman3";
            this.lbBarman3.Size = new System.Drawing.Size(84, 22);
            this.lbBarman3.TabIndex = 34;
            this.lbBarman3.Text = "Barman 3:";
            // 
            // lbBarman4
            // 
            this.lbBarman4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbBarman4.AutoSize = true;
            this.lbBarman4.BackColor = System.Drawing.Color.Transparent;
            this.lbBarman4.ForeColor = System.Drawing.Color.White;
            this.lbBarman4.Location = new System.Drawing.Point(434, 255);
            this.lbBarman4.Name = "lbBarman4";
            this.lbBarman4.Size = new System.Drawing.Size(84, 22);
            this.lbBarman4.TabIndex = 35;
            this.lbBarman4.Text = "Barman 4:";
            // 
            // frmNombreBarman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(105)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(796, 478);
            this.Controls.Add(this.lbBarman4);
            this.Controls.Add(this.lbBarman3);
            this.Controls.Add(this.lbBarman2);
            this.Controls.Add(this.lbBarman1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtBarman4);
            this.Controls.Add(this.txtBarman3);
            this.Controls.Add(this.txtBarman2);
            this.Controls.Add(this.txtBarman1);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnCerrar);
            this.Font = new System.Drawing.Font("Prompt", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmNombreBarman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNombreBarman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lbBarman1;
        private System.Windows.Forms.Label lbBarman2;
        private System.Windows.Forms.Label lbBarman3;
        private System.Windows.Forms.Label lbBarman4;
        public System.Windows.Forms.TextBox txtBarman1;
        public System.Windows.Forms.TextBox txtBarman2;
        public System.Windows.Forms.TextBox txtBarman4;
        public System.Windows.Forms.TextBox txtBarman3;
    }
}