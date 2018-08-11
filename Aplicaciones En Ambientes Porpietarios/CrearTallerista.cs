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
    public partial class CrearTallerista : Form
    {
        BaseDeDatos bd = new BaseDeDatos();
        ValidarSoloLetrasSoloNumeros validar = new ValidarSoloLetrasSoloNumeros();
        public CrearTallerista()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pBCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
            
        }
        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.NumerosDecimal(e);
        }
    }
}
