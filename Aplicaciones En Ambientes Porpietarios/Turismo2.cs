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
    public partial class Turismo2 : Form
    {
        public Turismo2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu mainMenu = new Menu();
            mainMenu.Show();
            this.Hide();
        }

        private void nuevoRecorridoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Turismo rutaNueva = new Turismo();
            rutaNueva.TopLevel = false;
            rutaNueva.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(rutaNueva);
            rutaNueva.Dock = DockStyle.Left;
            rutaNueva.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            rutaNueva.Show();
        }

        private void actualizarRecorridoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ActualizarRecorrido actualizarRecorrido = new ActualizarRecorrido();
            actualizarRecorrido.TopLevel = false;
            actualizarRecorrido.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(actualizarRecorrido);
            actualizarRecorrido.Dock = DockStyle.Left;
            actualizarRecorrido.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            actualizarRecorrido.Show();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(54, 54);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(48, 48);
        }

        private void nuevoGuiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoGuia actualizarRecorrido = new NuevoGuia();
            actualizarRecorrido.TopLevel = false;
            actualizarRecorrido.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(actualizarRecorrido);
            actualizarRecorrido.Dock = DockStyle.Left;
            actualizarRecorrido.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            actualizarRecorrido.Show();
        }

        private void actualizarGuiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarGuia actualizarRecorrido = new ModificarGuia();
            actualizarRecorrido.TopLevel = false;
            actualizarRecorrido.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(actualizarRecorrido);
            actualizarRecorrido.Dock = DockStyle.Left;
            actualizarRecorrido.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            actualizarRecorrido.Show();
        }
    }
}
