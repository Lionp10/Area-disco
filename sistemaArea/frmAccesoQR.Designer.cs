namespace sistemaArea
{
    partial class frmLoginQR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginQR));
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbMsgError = new System.Windows.Forms.Label();
            this.txtQR = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Prompt Medium", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(108, 24);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(284, 36);
            this.lbTitle.TabIndex = 17;
            this.lbTitle.Text = "ESCANEE SU TARJETA";
            // 
            // lbMsgError
            // 
            this.lbMsgError.AutoSize = true;
            this.lbMsgError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMsgError.Image = ((System.Drawing.Image)(resources.GetObject("lbMsgError.Image")));
            this.lbMsgError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbMsgError.Location = new System.Drawing.Point(34, 159);
            this.lbMsgError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMsgError.Name = "lbMsgError";
            this.lbMsgError.Size = new System.Drawing.Size(107, 18);
            this.lbMsgError.TabIndex = 19;
            this.lbMsgError.Text = "Error message";
            this.lbMsgError.Visible = false;
            // 
            // txtQR
            // 
            this.txtQR.Location = new System.Drawing.Point(37, 124);
            this.txtQR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQR.Name = "txtQR";
            this.txtQR.PasswordChar = '*';
            this.txtQR.Size = new System.Drawing.Size(427, 30);
            this.txtQR.TabIndex = 16;
            this.txtQR.TextChanged += new System.EventHandler(this.txtQR_TextChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.ForeColor = System.Drawing.Color.Black;
            this.btnVolver.Location = new System.Drawing.Point(73, 213);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(355, 56);
            this.btnVolver.TabIndex = 20;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmLoginQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(26)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbMsgError);
            this.Controls.Add(this.txtQR);
            this.Font = new System.Drawing.Font("Prompt", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLoginQR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso QR";
            this.Load += new System.EventHandler(this.frmAccesoQR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbMsgError;
        private System.Windows.Forms.TextBox txtQR;
        private System.Windows.Forms.Button btnVolver;
    }
}