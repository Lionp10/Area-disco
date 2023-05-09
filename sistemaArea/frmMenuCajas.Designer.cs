namespace sistemaArea
{
    partial class frmMenuCajas
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnDance = new System.Windows.Forms.Button();
            this.btnVip = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Prompt Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(183, 138);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(752, 44);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "SELECCIONE EL SECTOR DONDE VAS A TRABAJAR";
            // 
            // btnDance
            // 
            this.btnDance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(26)))), ((int)(((byte)(21)))));
            this.btnDance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDance.FlatAppearance.BorderSize = 0;
            this.btnDance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDance.Font = new System.Drawing.Font("Prompt", 11.25F);
            this.btnDance.ForeColor = System.Drawing.Color.White;
            this.btnDance.Location = new System.Drawing.Point(244, 273);
            this.btnDance.Name = "btnDance";
            this.btnDance.Size = new System.Drawing.Size(200, 200);
            this.btnDance.TabIndex = 4;
            this.btnDance.Text = "DANCE";
            this.btnDance.UseVisualStyleBackColor = false;
            this.btnDance.Click += new System.EventHandler(this.btnDance_Click);
            // 
            // btnVip
            // 
            this.btnVip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(26)))), ((int)(((byte)(21)))));
            this.btnVip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVip.FlatAppearance.BorderSize = 0;
            this.btnVip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVip.Font = new System.Drawing.Font("Prompt", 11.25F);
            this.btnVip.ForeColor = System.Drawing.Color.White;
            this.btnVip.Location = new System.Drawing.Point(672, 273);
            this.btnVip.Name = "btnVip";
            this.btnVip.Size = new System.Drawing.Size(200, 200);
            this.btnVip.TabIndex = 5;
            this.btnVip.Text = "VIP";
            this.btnVip.UseVisualStyleBackColor = false;
            this.btnVip.Click += new System.EventHandler(this.btnVip_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(186)))), ((int)(((byte)(175)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(12, 615);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(212, 61);
            this.btnCerrar.TabIndex = 20;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmMenuCajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(105)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1116, 688);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnVip);
            this.Controls.Add(this.btnDance);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Prompt", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMenuCajas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuCajas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        public System.Windows.Forms.Button btnDance;
        public System.Windows.Forms.Button btnVip;
        private System.Windows.Forms.Button btnCerrar;
    }
}