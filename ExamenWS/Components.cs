using ExamenWS.Pronostico;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static ExamenWS.XMLCode;

namespace ExamenWS
{
    public class Components
    {
        public string Address { get; set; }
        public static string Latitude = null;
        public static string Longitude = null;
        public static GMarkerGoogle marker = null;
        GMapOverlay mapOverlay = null;
        //The Geocoding here i.e getting the latt/long of address
        public void GeoCode(ComboBox comboBox1)
        {
            //to Read the Stream
            StreamReader sr = null;
            this.Address = comboBox1.SelectedValue.ToString() + ", Costa Rica";
            //The Google Maps API Either return JSON or XML. We are using XML Here
            //Saving the url of the Google API 
            string url = String.Format("http://maps.googleapis.com/maps/api/geocode/xml?address=" +
            this.Address + "&sensor=false");

            //to Send the request to Web Client 
            WebClient wc = new WebClient();
            try
            {
                sr = new StreamReader(wc.OpenRead(url));
            }
            catch (Exception ex)
            {
                throw new Exception("The Error Occured" + ex.Message);
            }

            try
            {
                XmlTextReader xmlReader = new XmlTextReader(sr);
                bool latread = false;
                bool longread = false;
                while (xmlReader.Read())
                {
                    xmlReader.MoveToElement();
                    switch (xmlReader.Name)
                    {
                        case "lat":

                            if (!latread)
                            {
                                xmlReader.Read();
                                Latitude = xmlReader.Value.ToString();
                                latread = true;

                            }
                            break;
                        case "lng":
                            if (!longread)
                            {
                                xmlReader.Read();
                                Longitude = xmlReader.Value.ToString();
                                longread = true;
                            }

                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An Error Occured" + ex.Message);
            }
        }
        public void CargarEfemerides(Label lblSolSale, Label lblSolPone, Label lblLunaSale, Label lblLunaPone, Label lblFaseLunar)
        {
            WSMeteorologicoClient ws = new WSMeteorologicoClient("WSMeteorologico");
            EFEMERIDES ef = ws.efemerides(new efemerides()).ParseXML<EFEMERIDES>();
            lblSolSale.Text = String.Format("Sale: {0}", ef.EFEMERIDE_SOL.SALE);
            lblSolPone.Text = String.Format("Se oculta: {0}", ef.EFEMERIDE_SOL.SEPONE);

            lblLunaSale.Text = String.Format("Sale: {0}", ef.EFEMERIDE_LUNA.SALE);
            lblLunaPone.Text = String.Format("Se oculta: {0}", ef.EFEMERIDE_LUNA.SEPONE);

            lblFaseLunar.Text = ef.FASELUNAR.Value;
        }
        public void CargarCiudades(PRONOSTICO_REGIONALREGIONCIUDAD[] ciudades, ComboBox comboBox1)
        {
            comboBox1.DataSource = ciudades;
        }
        public void CargarRegiones(ComboBox cbxRegiones)
        {
            WSMeteorologicoClient ws = new WSMeteorologicoClient("WSMeteorologico");
            PRONOSTICO_REGIONAL reg = ws.pronosticoRegional(new pronosticoRegion()).ParseXML<PRONOSTICO_REGIONAL>();
            cbxRegiones.DataSource = reg.REGIONES;
        }

        public void cargarMapa(double latini, double lonini, GMapControl gMapControl1)
        {
            //Cargar Mapa
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new GMap.NET.PointLatLng(latini, lonini);
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

        public void SelectedIndexRegion(ComboBox cbxRegiones,ComboBox comboBox1)
        {
            WSMeteorologicoClient ws = new WSMeteorologicoClient("WSMeteorologico");
            int id = (cbxRegiones.SelectedItem as PRONOSTICO_REGIONALREGION)?.idRegion ?? -1;
            PRONOSTICO_REGIONAL reg = ws.pronosticoRegionalxID(id).ParseXML<PRONOSTICO_REGIONAL>();
            if (id != -1)
                CargarCiudades(reg.REGIONES[0].CIUDADES, comboBox1);
        }
        public void GClick(GMapControl gMapControl1,MouseEventArgs e)
        {
            //obtener info y mostrar
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double ln = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;
            //posicionar el marker
            marker.Position = new PointLatLng(lat, ln);
            //mostrar texto en tooltip
            marker.ToolTipText = String.Format("Ubicación: \n Latitud:{0} \n Longitud:{1}", lat, ln);
        }

        public void ComboClick(ComboBox comboBox1, Panel panel1,Panel panel2, Panel panel3, GMapControl gMapControl1, PictureBox pbxCM, TextBox lblCCM, Label lblCTM, 
            PictureBox pbxCT, TextBox lblCCT, Label lblCTT, PictureBox pbxCN, TextBox lblCCN, Label lblCTN)
        {
            PRONOSTICO_REGIONALREGIONCIUDAD ciudad = comboBox1.SelectedItem as PRONOSTICO_REGIONALREGIONCIUDAD;
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            try
            {
                GeoCode(comboBox1);
                string newla = Components.Latitude.Replace(".", ",");
                string newlo = Components.Longitude.Replace(".", ",");
                gMapControl1.Overlays.Clear();
                cargarMapa(Convert.ToDouble(newla), Convert.ToDouble(newlo), gMapControl1);

            }
            catch (Exception err)
            {
                return;
            }

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
