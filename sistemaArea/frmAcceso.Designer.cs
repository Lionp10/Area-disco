namespace sistemaArea
{
    partial class frmAcceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcceso));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.btnQR = new System.Windows.Forms.Button();
            this.lbIniciarSesion = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbContrasena = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.llbOlvidastePass = new System.Windows.Forms.LinkLabel();
            this.lbErrorMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(26)))), ((int)(((byte)(21)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Prompt", 11.25F);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(26, 302);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(248, 56);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(26)))), ((int)(((byte)(21)))));
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Prompt", 11.25F);
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(26, 240);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(177, 56);
            this.btnIniciarSesion.TabIndex = 3;
            this.btnIniciarSesion.Text = "INICIAR SESIÓN";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnQR
            // 
            this.btnQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(26)))), ((int)(((byte)(21)))));
            this.btnQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQR.FlatAppearance.BorderSize = 0;
            this.btnQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQR.Font = new System.Drawing.Font("Prompt", 11.25F);
            this.btnQR.Location = new System.Drawing.Point(210, 240);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(64, 56);
            this.btnQR.TabIndex = 4;
            this.btnQR.Text = "QR";
            this.btnQR.UseVisualStyleBackColor = false;
            this.btnQR.Click += new System.EventHandler(this.btnQR_Click);
            // 
            // lbIniciarSesion
            // 
            this.lbIniciarSesion.AutoSize = true;
            this.lbIniciarSesion.Font = new System.Drawing.Font("Prompt Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIniciarSesion.Location = new System.Drawing.Point(80, 21);
            this.lbIniciarSesion.Name = "lbIniciarSesion";
            this.lbIniciarSesion.Size = new System.Drawing.Size(135, 22);
            this.lbIniciarSesion.TabIndex = 3;
            this.lbIniciarSesion.Text = "INICIAR SESIÓN";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbUsuario.Font = new System.Drawing.Font("Prompt", 11.25F);
            this.lbUsuario.Location = new System.Drawing.Point(22, 57);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(67, 22);
            this.lbUsuario.TabIndex = 4;
            this.lbUsuario.Text = "Usuario:";
            // 
            // lbContrasena
            // 
            this.lbContrasena.AutoSize = true;
            this.lbContrasena.BackColor = System.Drawing.Color.Transparent;
            this.lbContrasena.Font = new System.Drawing.Font("Prompt", 11.25F);
            this.lbContrasena.Location = new System.Drawing.Point(22, 124);
            this.lbContrasena.Name = "lbContrasena";
            this.lbContrasena.Size = new System.Drawing.Size(97, 22);
            this.lbContrasena.TabIndex = 5;
            this.lbContrasena.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Prompt", 11.25F);
            this.txtUsuario.Location = new System.Drawing.Point(26, 82);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(248, 30);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Prompt", 11.25F);
            this.txtContrasena.Location = new System.Drawing.Point(26, 149);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(248, 30);
            this.txtContrasena.TabIndex = 1;
            // 
            // llbOlvidastePass
            // 
            this.llbOlvidastePass.AutoSize = true;
            this.llbOlvidastePass.BackColor = System.Drawing.Color.Transparent;
            this.llbOlvidastePass.Font = new System.Drawing.Font("Prompt", 11.25F);
            this.llbOlvidastePass.LinkColor = System.Drawing.Color.White;
            this.llbOlvidastePass.Location = new System.Drawing.Point(22, 215);
            this.llbOlvidastePass.Name = "llbOlvidastePass";
            this.llbOlvidastePass.Size = new System.Drawing.Size(203, 22);
            this.llbOlvidastePass.TabIndex = 2;
            this.llbOlvidastePass.TabStop = true;
            this.llbOlvidastePass.Text = "¿Olvidaste tu contraseña?";
            // 
            // lbErrorMsg
            // 
            this.lbErrorMsg.AutoSize = true;
            this.lbErrorMsg.BackColor = System.Drawing.Color.Transparent;
            this.lbErrorMsg.Font = new System.Drawing.Font("Prompt", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorMsg.Image = ((System.Drawing.Image)(resources.GetObject("lbErrorMsg.Image")));
            this.lbErrorMsg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbErrorMsg.Location = new System.Drawing.Point(22, 182);
            this.lbErrorMsg.Name = "lbErrorMsg";
            this.lbErrorMsg.Size = new System.Drawing.Size(116, 22);
            this.lbErrorMsg.TabIndex = 6;
            this.lbErrorMsg.Text = "Error message";
            this.lbErrorMsg.Visible = false;
            // 
            // frmAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(105)))), ((int)(((byte)(94)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(295, 376);
            this.ControlBox = false;
            this.Controls.Add(this.lbErrorMsg);
            this.Controls.Add(this.llbOlvidastePass);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lbContrasena);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.lbIniciarSesion);
            this.Controls.Add(this.btnQR);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.btnSalir);
            this.Font = new System.Drawing.Font("Prompt", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAcceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar sesión";
            this.Load += new System.EventHandler(this.frmAcceso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Button btnQR;
        private System.Windows.Forms.Label lbIniciarSesion;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.LinkLabel llbOlvidastePass;
        private System.Windows.Forms.Label lbErrorMsg;
    }
}