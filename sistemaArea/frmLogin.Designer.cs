namespace sistemaArea
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panelLoginMenu = new System.Windows.Forms.Panel();
            this.btnQR = new System.Windows.Forms.Button();
            this.btnTexto = new System.Windows.Forms.Button();
            this.picLogoArea = new System.Windows.Forms.PictureBox();
            this.panelLoginTopIzq = new System.Windows.Forms.Panel();
            this.panelLoginContenedor = new System.Windows.Forms.Panel();
            this.panelLoginTopDer = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panelLoginMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoArea)).BeginInit();
            this.panelLoginContenedor.SuspendLayout();
            this.panelLoginTopDer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLoginMenu
            // 
            this.panelLoginMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(105)))), ((int)(((byte)(94)))));
            this.panelLoginMenu.Controls.Add(this.btnQR);
            this.panelLoginMenu.Controls.Add(this.btnTexto);
            this.panelLoginMenu.Controls.Add(this.picLogoArea);
            this.panelLoginMenu.Controls.Add(this.panelLoginTopIzq);
            this.panelLoginMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLoginMenu.Location = new System.Drawing.Point(0, 0);
            this.panelLoginMenu.Name = "panelLoginMenu";
            this.panelLoginMenu.Size = new System.Drawing.Size(250, 350);
            this.panelLoginMenu.TabIndex = 0;
            // 
            // btnQR
            // 
            this.btnQR.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(26)))), ((int)(((byte)(21)))));
            this.btnQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQR.FlatAppearance.BorderSize = 0;
            this.btnQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQR.Location = new System.Drawing.Point(28, 271);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(195, 52);
            this.btnQR.TabIndex = 3;
            this.btnQR.Text = "QR";
            this.btnQR.UseVisualStyleBackColor = false;
            this.btnQR.Click += new System.EventHandler(this.btnQR_Click);
            // 
            // btnTexto
            // 
            this.btnTexto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(26)))), ((int)(((byte)(21)))));
            this.btnTexto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTexto.FlatAppearance.BorderSize = 0;
            this.btnTexto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTexto.Location = new System.Drawing.Point(28, 213);
            this.btnTexto.Name = "btnTexto";
            this.btnTexto.Size = new System.Drawing.Size(195, 52);
            this.btnTexto.TabIndex = 2;
            this.btnTexto.Text = "TEXTO";
            this.btnTexto.UseVisualStyleBackColor = false;
            this.btnTexto.Click += new System.EventHandler(this.btnTexto_Click);
            // 
            // picLogoArea
            // 
            this.picLogoArea.BackColor = System.Drawing.Color.Transparent;
            this.picLogoArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogoArea.Image = ((System.Drawing.Image)(resources.GetObject("picLogoArea.Image")));
            this.picLogoArea.Location = new System.Drawing.Point(0, 40);
            this.picLogoArea.Name = "picLogoArea";
            this.picLogoArea.Size = new System.Drawing.Size(250, 150);
            this.picLogoArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogoArea.TabIndex = 1;
            this.picLogoArea.TabStop = false;
            // 
            // panelLoginTopIzq
            // 
            this.panelLoginTopIzq.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLoginTopIzq.Location = new System.Drawing.Point(0, 0);
            this.panelLoginTopIzq.Name = "panelLoginTopIzq";
            this.panelLoginTopIzq.Size = new System.Drawing.Size(250, 40);
            this.panelLoginTopIzq.TabIndex = 0;
            this.panelLoginTopIzq.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelLoginTopIzq_MouseMove);
            // 
            // panelLoginContenedor
            // 
            this.panelLoginContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(26)))), ((int)(((byte)(21)))));
            this.panelLoginContenedor.Controls.Add(this.panelLoginTopDer);
            this.panelLoginContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoginContenedor.Location = new System.Drawing.Point(250, 0);
            this.panelLoginContenedor.Name = "panelLoginContenedor";
            this.panelLoginContenedor.Size = new System.Drawing.Size(500, 350);
            this.panelLoginContenedor.TabIndex = 1;
            // 
            // panelLoginTopDer
            // 
            this.panelLoginTopDer.Controls.Add(this.btnMinimizar);
            this.panelLoginTopDer.Controls.Add(this.btnCerrar);
            this.panelLoginTopDer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLoginTopDer.Location = new System.Drawing.Point(0, 0);
            this.panelLoginTopDer.Name = "panelLoginTopDer";
            this.panelLoginTopDer.Size = new System.Drawing.Size(500, 40);
            this.panelLoginTopDer.TabIndex = 0;
            this.panelLoginTopDer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelLoginTopDer_MouseMove);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(444, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(16, 16);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(472, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 16);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 350);
            this.Controls.Add(this.panelLoginContenedor);
            this.Controls.Add(this.panelLoginMenu);
            this.Font = new System.Drawing.Font("Prompt", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(750, 350);
            this.MinimumSize = new System.Drawing.Size(750, 350);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panelLoginMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoArea)).EndInit();
            this.panelLoginContenedor.ResumeLayout(false);
            this.panelLoginTopDer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLoginMenu;
        private System.Windows.Forms.Panel panelLoginTopIzq;
        private System.Windows.Forms.Panel panelLoginContenedor;
        private System.Windows.Forms.Panel panelLoginTopDer;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox picLogoArea;
        private System.Windows.Forms.Button btnQR;
        private System.Windows.Forms.Button btnTexto;
    }
}