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
    public partial class ReportesHorarios : Form
    {
        public ReportesHorarios()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ReportesHorarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'reporteProfesoresCurso.curos_horario' Puede moverla o quitarla según sea necesario.
            this.curos_horarioTableAdapter.Fill(this.reporteProfesoresCurso.curos_horario);

            this.reportViewer1.RefreshReport();
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(43, 32);
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(49, 38);
        }
    }
}
