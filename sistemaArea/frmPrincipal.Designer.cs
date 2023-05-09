namespace sistemaArea
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.picLogoMain = new System.Windows.Forms.PictureBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lbFechaHora = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.linkLbMiPerfil = new System.Windows.Forms.LinkLabel();
            this.btnSincronizar = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnAdmUsers = new System.Windows.Forms.Button();
            this.btnCajas = new System.Windows.Forms.Button();
            this.btnBarras = new System.Windows.Forms.Button();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.btnEntradas = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lbNombreCajero = new System.Windows.Forms.Label();
            this.lbRol = new System.Windows.Forms.Label();
            this.lbNombreCompleto = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.timerFechaHora = new System.Windows.Forms.Timer(this.components);
            this.panelContenedor.SuspendLayout();
            this.panelFormularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoMain)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panelContenedor.Controls.Add(this.panelFormularios);
            this.panelContenedor.Controls.Add(this.panelMenu);
            this.panelContenedor.Controls.Add(this.panelBarraTitulo);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1366, 768);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelFormularios
            // 
            this.panelFormularios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(105)))), ((int)(((byte)(94)))));
            this.panelFormularios.Controls.Add(this.picLogoMain);
            this.panelFormularios.Controls.Add(this.panelFooter);
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(250, 40);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(1116, 728);
            this.panelFormularios.TabIndex = 2;
            // 
            // picLogoMain
            // 
            this.picLogoMain.BackColor = System.Drawing.Color.Transparent;
            this.picLogoMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogoMain.Image = ((System.Drawing.Image)(resources.GetObject("picLogoMain.Image")));
            this.picLogoMain.Location = new System.Drawing.Point(0, 0);
            this.picLogoMain.Name = "picLogoMain";
            this.picLogoMain.Size = new System.Drawing.Size(1116, 688);
            this.picLogoMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogoMain.TabIndex = 5;
            this.picLogoMain.TabStop = false;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(26)))), ((int)(((byte)(21)))));
            this.panelFooter.Controls.Add(this.lbFechaHora);
            this.panelFooter.Controls.Add(this.lbVersion);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 688);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1116, 40);
            this.panelFooter.TabIndex = 4;
            // 
            // lbFechaHora
            // 
            this.lbFechaHora.AutoSize = true;
            this.lbFechaHora.BackColor = System.Drawing.Color.Transparent;
            this.lbFechaHora.Font = new System.Drawing.Font("Prompt Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaHora.ForeColor = System.Drawing.Color.White;
            this.lbFechaHora.Location = new System.Drawing.Point(6, 10);
            this.lbFechaHora.Name = "lbFechaHora";
            this.lbFechaHora.Size = new System.Drawing.Size(122, 22);
            this.lbFechaHora.TabIndex = 9;
            this.lbFechaHora.Text = "FECHA Y HORA";
            // 
            // lbVersion
            // 
            this.lbVersion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbVersion.AutoSize = true;
            this.lbVersion.BackColor = System.Drawing.Color.Transparent;
            this.lbVersion.Font = new System.Drawing.Font("Prompt Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersion.ForeColor = System.Drawing.Color.White;
            this.lbVersion.Location = new System.Drawing.Point(941, 13);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(163, 18);
            this.lbVersion.TabIndex = 0;
            this.lbVersion.Text = "Sistema area - verisión 1.0";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(96)))), ((int)(((byte)(70)))));
            this.panelMenu.Controls.Add(this.linkLbMiPerfil);
            this.panelMenu.Controls.Add(this.btnSincronizar);
            this.panelMenu.Controls.Add(this.btnReportes);
            this.panelMenu.Controls.Add(this.btnAdmUsers);
            this.panelMenu.Controls.Add(this.btnCajas);
            this.panelMenu.Controls.Add(this.btnBarras);
            this.panelMenu.Controls.Add(this.btnDeposito);
            this.panelMenu.Controls.Add(this.btnEntradas);
            this.panelMenu.Controls.Add(this.btnCerrarSesion);
            this.panelMenu.Controls.Add(this.lbNombreCajero);
            this.panelMenu.Controls.Add(this.lbRol);
            this.panelMenu.Controls.Add(this.lbNombreCompleto);
            this.panelMenu.Controls.Add(this.lbUsuario);
            this.panelMenu.Controls.Add(this.pictureUser);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 40);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 728);
            this.panelMenu.TabIndex = 1;
            // 
            // linkLbMiPerfil
            // 
            this.linkLbMiPerfil.AutoSize = true;
            this.linkLbMiPerfil.BackColor = System.Drawing.Color.Transparent;
            this.linkLbMiPerfil.LinkColor = System.Drawing.Color.White;
            this.linkLbMiPerfil.Location = new System.Drawing.Point(8, 113);
            this.linkLbMiPerfil.Name = "linkLbMiPerfil";
            this.linkLbMiPerfil.Size = new System.Drawing.Size(69, 22);
            this.linkLbMiPerfil.TabIndex = 42;
            this.linkLbMiPerfil.TabStop = true;
            this.linkLbMiPerfil.Text = "Mi perfil";
            this.linkLbMiPerfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbMiPerfil_LinkClicked);
            // 
            // btnSincronizar
            // 
            this.btnSincronizar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSincronizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(91)))), ((int)(((byte)(59)))));
            this.btnSincronizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSincronizar.FlatAppearance.BorderSize = 0;
            this.btnSincronizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSincronizar.ForeColor = System.Drawing.Color.White;
            this.btnSincronizar.Image = ((System.Drawing.Image)(resources.GetObject("btnSincronizar.Image")));
            this.btnSincronizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSincronizar.Location = new System.Drawing.Point(0, 464);
            this.btnSincronizar.Name = "btnSincronizar";
            this.btnSincronizar.Size = new System.Drawing.Size(250, 40);
            this.btnSincronizar.TabIndex = 41;
            this.btnSincronizar.Text = "Sincronizar";
            this.btnSincronizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSincronizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSincronizar.UseVisualStyleBackColor = false;
            // 
            // btnReportes
            // 
            this.btnReportes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(91)))), ((int)(((byte)(59)))));
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 424);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(250, 40);
            this.btnReportes.TabIndex = 40;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = false;
            // 
            // btnAdmUsers
            // 
            this.btnAdmUsers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdmUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(91)))), ((int)(((byte)(59)))));
            this.btnAdmUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmUsers.FlatAppearance.BorderSize = 0;
            this.btnAdmUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmUsers.ForeColor = System.Drawing.Color.White;
            this.btnAdmUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmUsers.Image")));
            this.btnAdmUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmUsers.Location = new System.Drawing.Point(0, 384);
            this.btnAdmUsers.Name = "btnAdmUsers";
            this.btnAdmUsers.Size = new System.Drawing.Size(250, 40);
            this.btnAdmUsers.TabIndex = 39;
            this.btnAdmUsers.Text = "Usuarios";
            this.btnAdmUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmUsers.UseVisualStyleBackColor = false;
            // 
            // btnCajas
            // 
            this.btnCajas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCajas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(91)))), ((int)(((byte)(59)))));
            this.btnCajas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCajas.FlatAppearance.BorderSize = 0;
            this.btnCajas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCajas.ForeColor = System.Drawing.Color.White;
            this.btnCajas.Image = ((System.Drawing.Image)(resources.GetObject("btnCajas.Image")));
            this.btnCajas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCajas.Location = new System.Drawing.Point(0, 344);
            this.btnCajas.Name = "btnCajas";
            this.btnCajas.Size = new System.Drawing.Size(250, 40);
            this.btnCajas.TabIndex = 37;
            this.btnCajas.Text = "Cajas";
            this.btnCajas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCajas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCajas.UseVisualStyleBackColor = false;
            this.btnCajas.Click += new System.EventHandler(this.btnCajas_Click);
            // 
            // btnBarras
            // 
            this.btnBarras.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBarras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(91)))), ((int)(((byte)(59)))));
            this.btnBarras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBarras.FlatAppearance.BorderSize = 0;
            this.btnBarras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarras.ForeColor = System.Drawing.Color.White;
            this.btnBarras.Image = ((System.Drawing.Image)(resources.GetObject("btnBarras.Image")));
            this.btnBarras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBarras.Location = new System.Drawing.Point(0, 304);
            this.btnBarras.Name = "btnBarras";
            this.btnBarras.Size = new System.Drawing.Size(250, 40);
            this.btnBarras.TabIndex = 35;
            this.btnBarras.Text = "Barras";
            this.btnBarras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBarras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBarras.UseVisualStyleBackColor = false;
            // 
            // btnDeposito
            // 
            this.btnDeposito.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDeposito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(91)))), ((int)(((byte)(59)))));
            this.btnDeposito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeposito.FlatAppearance.BorderSize = 0;
            this.btnDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposito.ForeColor = System.Drawing.Color.White;
            this.btnDeposito.Image = ((System.Drawing.Image)(resources.GetObject("btnDeposito.Image")));
            this.btnDeposito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeposito.Location = new System.Drawing.Point(0, 264);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(250, 40);
            this.btnDeposito.TabIndex = 34;
            this.btnDeposito.Text = "Depósito";
            this.btnDeposito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeposito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeposito.UseVisualStyleBackColor = false;
            // 
            // btnEntradas
            // 
            this.btnEntradas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEntradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(91)))), ((int)(((byte)(59)))));
            this.btnEntradas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntradas.FlatAppearance.BorderSize = 0;
            this.btnEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntradas.ForeColor = System.Drawing.Color.White;
            this.btnEntradas.Image = ((System.Drawing.Image)(resources.GetObject("btnEntradas.Image")));
            this.btnEntradas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntradas.Location = new System.Drawing.Point(0, 224);
            this.btnEntradas.Name = "btnEntradas";
            this.btnEntradas.Size = new System.Drawing.Size(250, 40);
            this.btnEntradas.TabIndex = 31;
            this.btnEntradas.Text = "Entradas";
            this.btnEntradas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntradas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEntradas.UseVisualStyleBackColor = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(91)))), ((int)(((byte)(59)))));
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 688);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(250, 40);
            this.btnCerrarSesion.TabIndex = 30;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // lbNombreCajero
            // 
            this.lbNombreCajero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNombreCajero.AutoSize = true;
            this.lbNombreCajero.BackColor = System.Drawing.Color.Transparent;
            this.lbNombreCajero.Font = new System.Drawing.Font("Prompt Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreCajero.ForeColor = System.Drawing.Color.White;
            this.lbNombreCajero.Location = new System.Drawing.Point(86, 75);
            this.lbNombreCajero.Name = "lbNombreCajero";
            this.lbNombreCajero.Size = new System.Drawing.Size(99, 22);
            this.lbNombreCajero.TabIndex = 29;
            this.lbNombreCajero.Text = "name cajero";
            // 
            // lbRol
            // 
            this.lbRol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbRol.AutoSize = true;
            this.lbRol.BackColor = System.Drawing.Color.Transparent;
            this.lbRol.Font = new System.Drawing.Font("Prompt Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRol.ForeColor = System.Drawing.Color.White;
            this.lbRol.Location = new System.Drawing.Point(86, 97);
            this.lbRol.Name = "lbRol";
            this.lbRol.Size = new System.Drawing.Size(30, 22);
            this.lbRol.TabIndex = 27;
            this.lbRol.Text = "Rol";
            // 
            // lbNombreCompleto
            // 
            this.lbNombreCompleto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNombreCompleto.AutoSize = true;
            this.lbNombreCompleto.BackColor = System.Drawing.Color.Transparent;
            this.lbNombreCompleto.Font = new System.Drawing.Font("Prompt Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreCompleto.ForeColor = System.Drawing.Color.White;
            this.lbNombreCompleto.Location = new System.Drawing.Point(86, 75);
            this.lbNombreCompleto.Name = "lbNombreCompleto";
            this.lbNombreCompleto.Size = new System.Drawing.Size(146, 22);
            this.lbNombreCompleto.TabIndex = 28;
            this.lbNombreCompleto.Text = "Apellido y nombre";
            // 
            // lbUsuario
            // 
            this.lbUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbUsuario.Font = new System.Drawing.Font("Prompt Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.Color.White;
            this.lbUsuario.Location = new System.Drawing.Point(86, 53);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(80, 22);
            this.lbUsuario.TabIndex = 26;
            this.lbUsuario.Text = "Username";
            // 
            // pictureUser
            // 
            this.pictureUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureUser.BackColor = System.Drawing.Color.Transparent;
            this.pictureUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureUser.Image")));
            this.pictureUser.Location = new System.Drawing.Point(8, 46);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(67, 64);
            this.pictureUser.TabIndex = 25;
            this.pictureUser.TabStop = false;
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(26)))), ((int)(((byte)(21)))));
            this.panelBarraTitulo.Controls.Add(this.btnMinimizar);
            this.panelBarraTitulo.Controls.Add(this.btnRestaurar);
            this.panelBarraTitulo.Controls.Add(this.btnMaximizar);
            this.panelBarraTitulo.Controls.Add(this.btnCerrar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1366, 40);
            this.panelBarraTitulo.TabIndex = 0;
            this.panelBarraTitulo.DoubleClick += new System.EventHandler(this.panelBarraTitulo_DoubleClick);
            this.panelBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseMove);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1273, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(16, 16);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1306, 12);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(16, 16);
            this.btnRestaurar.TabIndex = 2;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1306, 12);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(16, 16);
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1338, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 16);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // timerFechaHora
            // 
            this.timerFechaHora.Tick += new System.EventHandler(this.timerFechaHora_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panelContenedor);
            this.Font = new System.Drawing.Font("Prompt", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(800, 650);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area disco";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelFormularios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoMain)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        public System.Windows.Forms.Label lbNombreCajero;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Timer timerFechaHora;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lbFechaHora;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Button btnEntradas;
        public System.Windows.Forms.Label lbRol;
        public System.Windows.Forms.Label lbNombreCompleto;
        public System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Button btnBarras;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Button btnCajas;
        private System.Windows.Forms.Button btnAdmUsers;
        private System.Windows.Forms.Button btnSincronizar;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.PictureBox picLogoMain;
        private System.Windows.Forms.LinkLabel linkLbMiPerfil;
        public System.Windows.Forms.Panel panelFormularios;
    }
}