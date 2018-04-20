using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Device.Location;
using ExamenWS.Pronostico;
using static ExamenWS.XMLCode;
using GoogleMaps.LocationServices;

namespace ExamenWS
{
    public partial class Form1 : Form
    {
        GMarkerGoogle marker = null;
        GMapOverlay mapOverlay = null;
        double latitu = 0;
        double longit = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cargarMapa(double latini, double lonini)
        {
            //Cargar Mapa
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(latini, lonini);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;
            //Marcador
            mapOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(latini, lonini), GMarkerGoogleType.green);
            mapOverlay.Markers.Add(marker);
            //Mostrador
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicación : \n Latitud:{0} \n Longitud:{1}", latini, lonini);
            //Agregar a Mapa
            gMapControl1.Overlays.Add(mapOverlay);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarEfemerides();
            CargarRegiones();
            cargarMapa(latitu, longit);
        }

        private void gMapControl1_MouseClick(object sender, MouseEventArgs e)
        {
            //obtener info y mostrar
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double ln = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;
            //posicionar el marker
            marker.Position = new PointLatLng(lat, ln);
            //mostrar texto en tooltip
            marker.ToolTipText = String.Format("Ubicación: \n Latitud:{0} \n Longitud:{1}", lat, ln);

        }
        private void CargarCiudades(PRONOSTICO_REGIONALREGIONCIUDAD[] ciudades)
        {
            comboBox1.DataSource = ciudades;
        }
        private void CargarRegiones()
        {
            WSMeteorologicoClient ws = new WSMeteorologicoClient("WSMeteorologico");
            PRONOSTICO_REGIONAL reg = ws.pronosticoRegional(new pronosticoRegion()).ParseXML<PRONOSTICO_REGIONAL>();
            cbxRegiones.DataSource = reg.REGIONES;
        }

        private void CargarEfemerides()
        {
            WSMeteorologicoClient ws = new WSMeteorologicoClient("WSMeteorologico");
            EFEMERIDES ef = ws.efemerides(new efemerides()).ParseXML<EFEMERIDES>();
            lblSolSale.Text = String.Format("Sale: {0}", ef.EFEMERIDE_SOL.SALE);
            lblSolPone.Text = String.Format("Se oculta: {0}", ef.EFEMERIDE_SOL.SEPONE);

            lblLunaSale.Text = String.Format("Sale: {0}", ef.EFEMERIDE_LUNA.SALE);
            lblLunaPone.Text = String.Format("Se oculta: {0}", ef.EFEMERIDE_LUNA.SEPONE);

            lblFaseLunar.Text = ef.FASELUNAR.Value;
        }

        private void cbxRegiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            WSMeteorologicoClient ws = new WSMeteorologicoClient("WSMeteorologico");
            int id = (cbxRegiones.SelectedItem as PRONOSTICO_REGIONALREGION)?.idRegion ?? -1;
            PRONOSTICO_REGIONAL reg = ws.pronosticoRegionalxID(id).ParseXML<PRONOSTICO_REGIONAL>();
            if (id != -1)
                CargarCiudades(reg.REGIONES[0].CIUDADES);
        }
        public string lati(string region, string ciudad)
        {
            var address = ciudad + ", " + region + ", " + "Costa Rica";

            var locationService = new GoogleLocationService();
            var point = locationService.GetLatLongFromAddress(address);

            var latitude = point.Latitude;
            return latitude.ToString();
        }
        public string longi(string region, string ciudad)
        {
            var address = ciudad + ", " + region + ", " + "Costa Rica";

            var locationService = new GoogleLocationService();
            var point = locationService.GetLatLongFromAddress(address);

            var longitude = point.Longitude;
            return longitude.ToString();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PRONOSTICO_REGIONALREGIONCIUDAD ciudad = comboBox1.SelectedItem as PRONOSTICO_REGIONALREGIONCIUDAD;
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            latitu = Convert.ToDouble(lati(cbxRegiones.SelectedValue.ToString(), comboBox1.SelectedValue.ToString()));
            longit = Convert.ToDouble(longi(cbxRegiones.SelectedValue.ToString(), comboBox1.SelectedValue.ToString()));
            //cargarMapa(latitu, longit);
            MessageBox.Show(latitu + " " + longit);
            marker.Position = new PointLatLng(Convert.ToDouble(lati(cbxRegiones.SelectedValue.ToString(),comboBox1.SelectedValue.ToString())), Convert.ToDouble(longi(cbxRegiones.SelectedValue.ToString(), comboBox1.SelectedValue.ToString())));
            //mostrar texto en tooltip
            marker.ToolTipText = String.Format("Ubicación: \n Latitud:{0} \n Longitud:{1}", latitu, longit);

            if (ciudad.ESTADOMANANA != null)
            {
                pbxCM.ImageLocation = String.Format("https://www.imn.ac.cr{0}", ciudad.ESTADOMANANA.imgPath);
                lblCCM.Text = ciudad.COMENTARIOMANANA;
                lblCTM.Text = ciudad.ESTADOMANANA.Value;
                panel1.Show();
            }

            if (ciudad.ESTADOTARDE != null)
            {
                pbxCT.ImageLocation = String.Format("https://www.imn.ac.cr{0}", ciudad.ESTADOTARDE.imgPath);
                lblCCT.Text = ciudad.COMENTARIOTARDE;
                lblCTT.Text = ciudad.ESTADOTARDE.Value;
                panel2.Show();
            }

            if (ciudad.ESTADONOCHE != null)
            {
                pbxCN.ImageLocation = String.Format("https://www.imn.ac.cr{0}", ciudad.ESTADONOCHE.imgPath);
                lblCCN.Text = ciudad.COMENTARIONOCHE;
                lblCTN.Text = ciudad.ESTADONOCHE.Value;
                panel3.Show();
            }
        }
    }
}
