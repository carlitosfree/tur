using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicaciones_En_Ambientes_Porpietarios
{
    public partial class VentanaLogin : Form
    {
        public VentanaLogin()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();
        Menu menu = new Menu();
        string tipoAdmin;
        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Ingrese sus credenciales");
            }
            else
            {
                string usuario = (bd.selectstring("select USUARIO FROM LOGIN WHERE USUARIO ='" + txtUsuario.Text + "'"));
                //MessageBox.Show(usuario + "");
                if ((txtUsuario.Text.Trim() == (usuario.Trim())))
                {

                    string contraseña = (bd.selectstring("select CONTRASENIA FROM LOGIN WHERE USUARIO ='" + txtUsuario.Text + "'"));
                    // MessageBox.Show(usuario + "---"+txtPassword.Text);
                    string tipo = (bd.selectstring("select PERMISO FROM LOGIN WHERE USUARIO ='" + txtUsuario.Text + "'"));
                    if (txtPassword.Text.Trim() == contraseña.Trim())
                    {
                        MessageBox.Show("Bienvenidos al Sistema SISEM");
                        tipoAdmin = tipo;
                        menu.txtTipoUsuario.Text = tipoAdmin;
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña Incorrecta");
                        txtPassword.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no existe");
                    txtUsuario.Text = "";
                    txtPassword.Text = "";

                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
        Point fromPosicion;
        Boolean mouseAccion;
        private void VentanaLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseAccion == true)
            {
                Location = new Point(Cursor.Position.X - fromPosicion.X, Cursor.Position.Y - fromPosicion.Y);
            }
        }

        private void VentanaLogin_MouseDown(object sender, MouseEventArgs e)
        {
            fromPosicion = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mouseAccion = true;
        }

        private void VentanaLogin_MouseUp(object sender, MouseEventArgs e)
        {
            mouseAccion = false;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pBCerrar.Size = new Size(54, 51);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pBIngresar.Size = new Size(54, 51);
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pBIngresar.Size = new Size(60, 57);
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pBCerrar.Size = new Size(60, 57);
        }

        private void VentanaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
