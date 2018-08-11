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
    public partial class CrearTurista : Form
    {
        BaseDeDatos bd = new BaseDeDatos();
        ValidarSoloLetrasSoloNumeros validar = new ValidarSoloLetrasSoloNumeros();
        public CrearTurista()
        {
            InitializeComponent();
        }

        private void pBCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
            if (textBox3.TextLength == 10)
            {
                validar.VerificarCedula(textBox3.Text);
            }
            
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }
    }
}
