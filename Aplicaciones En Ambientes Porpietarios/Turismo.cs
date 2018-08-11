using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Aplicaciones_En_Ambientes_Porpietarios
{
    public partial class Turismo : Form
    {
        ValidarSoloLetrasSoloNumeros validar = new ValidarSoloLetrasSoloNumeros();
        BaseDeDatos bd = new BaseDeDatos();
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;
        int filaSeleccionada = 0;
        double LatInicial = -0.210319;
        double LngInicial = -78.489065;
        int NumParada = 0;
        string Nombre = "";
        string Descripcion = "";
        public Turismo()
        {
            InitializeComponent();
        }

        private void Turismo_Load(object sender, EventArgs e)

        {
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Nombre", typeof(String)));
            dt.Columns.Add(new DataColumn("Descripción",typeof(String )));
            dt.Columns.Add(new DataColumn("Número de Parada", typeof(int)));
            dt.Columns.Add(new DataColumn("Latitud", typeof(double)));
            dt.Columns.Add(new DataColumn("Longitud", typeof(double)));
            dt.Rows.Add("Epn","Facultad de Sistemas",NumParada,LatInicial,LngInicial);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;

            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;

            //Marcador
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(LatInicial, LngInicial), GMarkerGoogleType.blue);
            markerOverlay.Markers.Add(marker);

            /*ToolTip de Texto
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Nombre: {0}\n Descripción: {1} \n ", Nombre, Descripcion);
			*/
            //Agregar al mapa
            gMapControl1.Overlays.Add(markerOverlay);
        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Obtener datos de longitud y latitud
            double lat = gMapControl1.FromLocalToLatLng(e.X,e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            //Posision en el txt de longitud y latitud
            txtLatitud.Text = lat.ToString();
            txtLongitud.Text = lng.ToString();
            
            //Mover el marcador a la posición
            marker.Position = new PointLatLng(lat, lng);

            // Agregar Tooltip
           // marker.ToolTipText = string.Format("Nombre: {0}\n Descripción:{1} ",Nombre,Descripcion);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(txtNombreP.Text,txtDescripcion.Text,Convert.ToInt32(txtNumParada.Text),txtLatitud.Text,txtLongitud.Text);
            Nombre = txtNombreP.Text;
            Descripcion = txtDescripcion.Text;
            marker.ToolTipText = string.Format("Nombre: {0}\n Descripción:{1} ", Nombre, Descripcion);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(filaSeleccionada);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            filaSeleccionada = e.RowIndex;
            txtNombreP.Text = dataGridView1.Rows[filaSeleccionada].Cells[0].Value.ToString();
            txtDescripcion.Text = dataGridView1.Rows[filaSeleccionada].Cells[1].Value.ToString();
            txtNumParada.Text = dataGridView1.Rows[filaSeleccionada].Cells[2].Value.ToString();
            txtLatitud.Text = dataGridView1.Rows[filaSeleccionada].Cells[3].Value.ToString();
            txtLongitud.Text = dataGridView1.Rows[filaSeleccionada].Cells[4].Value.ToString();
            marker.Position = new PointLatLng(Convert.ToDouble(txtLatitud.Text),Convert.ToDouble(txtLongitud.Text));
            gMapControl1.Position = marker.Position;
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            GMapOverlay Ruta = new GMapOverlay("Ruta");
            List<PointLatLng> puntos = new List<PointLatLng>();
            double lng, lat;
            for (int filas =0; filas < dataGridView1.Rows.Count; filas++)
            {
                lat = Convert.ToDouble(dataGridView1.Rows[filas].Cells[3].Value);
                lng = Convert.ToDouble(dataGridView1.Rows[filas].Cells[4].Value);
                puntos.Add(new PointLatLng(lat, lng));
               
            }
            GMapRoute mapRoute = new GMapRoute(puntos, "Ruta");
            Ruta.Routes.Add(mapRoute);
            gMapControl1.Overlays.Add(Ruta);
            gMapControl1.Zoom = gMapControl1.Zoom + 1;
            gMapControl1.Zoom = gMapControl1.Zoom - 1;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void txtNumParada_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(txtNombreP.Text, txtDescripcion.Text, Convert.ToInt32(txtNumParada.Text), txtLatitud.Text, txtLongitud.Text);
            Nombre = txtNombreP.Text;
            Descripcion = txtDescripcion.Text;
            marker.ToolTipText = string.Format("Nombre: {0}\n Descripción:{1} ", Nombre, Descripcion);
        }
        private void agregarRuta()
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(filaSeleccionada);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            graficarRuta();
        }
        private void graficarRuta()
        {
            GMapOverlay Ruta = new GMapOverlay("Ruta");
            List<PointLatLng> puntos = new List<PointLatLng>();
            double lng, lat;
            for (int filas = 0; filas < dataGridView1.Rows.Count; filas++)
            {
                lat = Convert.ToDouble(dataGridView1.Rows[filas].Cells[3].Value);
                lng = Convert.ToDouble(dataGridView1.Rows[filas].Cells[4].Value);
                puntos.Add(new PointLatLng(lat, lng));

            }
            GMapRoute mapRoute = new GMapRoute(puntos, "Ruta");
            Ruta.Routes.Add(mapRoute);
            gMapControl1.Overlays.Add(Ruta);
            gMapControl1.Zoom = gMapControl1.Zoom + 1;
            gMapControl1.Zoom = gMapControl1.Zoom - 1;
        }

        private void txtLongitud_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(43, 44);
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(49, 50);
        }
        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(50, 35);
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(56, 41);
        }
        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(50, 35);
        }
        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(56, 41);
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(50, 35);
        }
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(56, 41);
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(50, 35);
        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(56, 41);
        }

    }
}

