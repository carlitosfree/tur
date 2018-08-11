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
    public partial class CrearFactura : Form
    {
        BaseDeDatos bd = new BaseDeDatos();
        ValidarSoloLetrasSoloNumeros validar = new ValidarSoloLetrasSoloNumeros();
        public CrearFactura()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Location = new Point(199, 155);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel2.Location = new Point(199, 155);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.Location = new Point(408, 88);
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(73, 58);
            panel3.Visible = true;
            panel3.Location = new Point(408, 88);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(67, 52);
            
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(73, 58);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(67, 52);
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void pictureBox14_MouseHover(object sender, EventArgs e)
        {
            pictureBox14.Size = new Size(76, 69);
        }

        private void pictureBox14_MouseLeave(object sender, EventArgs e)
        {
            pictureBox14.Size = new Size(70, 63);
        }
        private void pictureBox12_MouseHover(object sender, EventArgs e)
        {
            pictureBox12.Size = new Size(76, 69);
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox12.Size = new Size(70, 63);
        }
        private void pictureBox13_MouseHover(object sender, EventArgs e)
        {
            pictureBox13.Size = new Size(76, 69);
        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            pictureBox13.Size = new Size(70, 63);
        }
        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(58, 45);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(52, 39);
        }
        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(45, 38);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(39, 32);
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Size = new Size(70, 63);
        }
        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            pictureBox9.Size = new Size(76, 69);
        }
        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.Size = new Size(70, 63);
        }
        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            pictureBox10.Size = new Size(76, 69);
        }
        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            pictureBox11.Size = new Size(70, 63);
        }
        private void pictureBox11_MouseHover(object sender, EventArgs e)
        {
            pictureBox11.Size = new Size(76, 69);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Size = new Size(43, 32); 
        }
        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.Size = new Size(49, 38);
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            pictureBox8.Size = new Size(49, 38);
        }
        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Size = new Size(43, 32);
        }
        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Size = new Size(35, 29); 
        }
        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            pictureBox7.Size = new Size(41, 35);
        }

        private void pictureBox16_MouseLeave(object sender, EventArgs e)
        {
            pictureBox16.Size = new Size(35, 33);
        }
        private void pictureBox16_MouseHover(object sender, EventArgs e)
        {
            pictureBox16.Size = new Size(41, 39);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }
    }
}
