namespace sistemaArea
{
    partial class frmUserCajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserCajero));
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbNombreCajero = new System.Windows.Forms.Label();
            this.txtNombreCajero = new System.Windows.Forms.TextBox();
            this.txtApellidoCajero = new System.Windows.Forms.TextBox();
            this.lbApellidoCajero = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.lbErrorMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Prompt Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(41, 23);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(285, 22);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "ESCRIBA SU NOMBRE Y APELLIDO";
            // 
            // lbNombreCajero
            // 
            this.lbNombreCajero.AutoSize = true;
            this.lbNombreCajero.BackColor = System.Drawing.Color.Transparent;
            this.lbNombreCajero.Font = new System.Drawing.Font("Prompt", 11.25F);
            this.lbNombreCajero.Location = new System.Drawing.Point(37, 65);
            this.lbNombreCajero.Name = "lbNombreCajero";
            this.lbNombreCajero.Size = new System.Drawing.Size(71, 22);
            this.lbNombreCajero.TabIndex = 1;
            this.lbNombreCajero.Text = "Nombre:";
            // 
            // txtNombreCajero
            // 
            this.txtNombreCajero.Location = new System.Drawing.Point(41, 90);
            this.txtNombreCajero.Name = "txtNombreCajero";
            this.txtNombreCajero.Size = new System.Drawing.Size(288, 30);
            this.txtNombreCajero.TabIndex = 0;
            // 
            // txtApellidoCajero
            // 
            this.txtApellidoCajero.Location = new System.Drawing.Point(41, 150);
            this.txtApellidoCajero.Name = "txtApellidoCajero";
            this.txtApellidoCajero.Size = new System.Drawing.Size(288, 30);
            this.txtApellidoCajero.TabIndex = 1;
            // 
            // lbApellidoCajero
            // 
            this.lbApellidoCajero.AutoSize = true;
            this.lbApellidoCajero.BackColor = System.Drawing.Color.Transparent;
            this.lbApellidoCajero.Font = new System.Drawing.Font("Prompt", 11.25F);
            this.lbApellidoCajero.Location = new System.Drawing.Point(37, 125);
            this.lbApellidoCajero.Name = "lbApellidoCajero";
            this.lbApellidoCajero.Size = new System.Drawing.Size(73, 22);
            this.lbApellidoCajero.TabIndex = 3;
            this.lbApellidoCajero.Text = "Apellido:";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(26)))), ((int)(((byte)(21)))));
            this.btnOk.ForeColor = System.Drawing.Color.Black;
            this.btnOk.Location = new System.Drawing.Point(41, 213);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(288, 52);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lbErrorMsg
            // 
            this.lbErrorMsg.AutoSize = true;
            this.lbErrorMsg.BackColor = System.Drawing.Color.Transparent;
            this.lbErrorMsg.Font = new System.Drawing.Font("Prompt", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorMsg.Image = ((System.Drawing.Image)(resources.GetObject("lbErrorMsg.Image")));
            this.lbErrorMsg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbErrorMsg.Location = new System.Drawing.Point(37, 182);
            this.lbErrorMsg.Name = "lbErrorMsg";
            this.lbErrorMsg.Size = new System.Drawing.Size(116, 22);
            this.lbErrorMsg.TabIndex = 7;
            this.lbErrorMsg.Text = "Error message";
            this.lbErrorMsg.Visible = false;
            // 
            // frmUserCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(105)))), ((int)(((byte)(94)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(367, 303);
            this.ControlBox = false;
            this.Controls.Add(this.lbErrorMsg);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtApellidoCajero);
            this.Controls.Add(this.lbApellidoCajero);
            this.Controls.Add(this.txtNombreCajero);
            this.Controls.Add(this.lbNombreCajero);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Prompt", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUserCajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Username cajero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbNombreCajero;
        private System.Windows.Forms.Label lbApellidoCajero;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lbErrorMsg;
        public System.Windows.Forms.TextBox txtNombreCajero;
        public System.Windows.Forms.TextBox txtApellidoCajero;
    }
}