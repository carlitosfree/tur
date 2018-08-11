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
    public partial class ReportesProfesores : Form
    {
        public ReportesProfesores()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



        private void ReportesProfesores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'reporteProfesoresCurso.profesor_Curso' Puede moverla o quitarla según sea necesario.
            this.profesor_CursoTableAdapter.Fill(this.reporteProfesoresCurso.profesor_Curso);
            reportViewer2.RefreshReport();


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
