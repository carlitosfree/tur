namespace Aplicaciones_En_Ambientes_Porpietarios
{
    partial class VentanaLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaLogin));
            this.pBIngresar = new System.Windows.Forms.PictureBox();
            this.pBCerrar = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBIngresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pBIngresar
            // 
            this.pBIngresar.BackColor = System.Drawing.Color.Transparent;
            this.pBIngresar.Cursor = System.Windows.Forms.Cursors.Default;
            this.pBIngresar.Image = ((System.Drawing.Image)(resources.GetObject("pBIngresar.Image")));
            this.pBIngresar.Location = new System.Drawing.Point(533, 327);
            this.pBIngresar.Name = "pBIngresar";
            this.pBIngresar.Size = new System.Drawing.Size(53, 55);
            this.pBIngresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBIngresar.TabIndex = 14;
            this.pBIngresar.TabStop = false;
            this.pBIngresar.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pBIngresar.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pBIngresar.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // pBCerrar
            // 
            this.pBCerrar.BackColor = System.Drawing.Color.Transparent;
            this.pBCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pBCerrar.Image")));
            this.pBCerrar.Location = new System.Drawing.Point(563, 12);
            this.pBCerrar.Name = "pBCerrar";
            this.pBCerrar.Size = new System.Drawing.Size(54, 51);
            this.pBCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBCerrar.TabIndex = 13;
            this.pBCerrar.TabStop = false;
            this.pBCerrar.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pBCerrar.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pBCerrar.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.Font = new System.Drawing.Font("Forte", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.MediumPurple;
            this.txtPassword.Location = new System.Drawing.Point(401, 280);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ShortcutsEnabled = false;
            this.txtPassword.Size = new System.Drawing.Size(146, 25);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Forte", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.MediumPurple;
            this.txtUsuario.Location = new System.Drawing.Point(401, 247);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(146, 25);
            this.txtUsuario.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label2.Location = new System.Drawing.Point(282, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label1.Location = new System.Drawing.Point(282, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Login: ";
            // 
            // VentanaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(629, 394);
            this.Controls.Add(this.pBIngresar);
            this.Controls.Add(this.pBCerrar);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login ";
            this.Load += new System.EventHandler(this.VentanaLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VentanaLogin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VentanaLogin_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.VentanaLogin_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pBIngresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pBIngresar;
        private System.Windows.Forms.PictureBox pBCerrar;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

