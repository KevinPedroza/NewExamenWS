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

namespace Capa_Negocios
{
    public class Getting_Methods
    {
        public static string Address { get; set; }
        public static string Latitude = null;
        public static string Longitude = null;
        public static GMarkerGoogle marker = null;
        static GMapOverlay mapOverlay = null;
        //The Geocoding here i.e getting the latt/long of address
        public static void GeoCode(ComboBox comboBox1)
        {
            //to Read the Stream
            StreamReader sr = null;
            Address = comboBox1.SelectedValue.ToString() + ", Costa Rica";
            //The Google Maps API Either return JSON or XML. We are using XML Here
            //Saving the url of the Google API 
            string url = String.Format("http://maps.googleapis.com/maps/api/geocode/xml?address=" +
            Address + "&sensor=false");

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

        public static void cargarMapa(double latini, double lonini, GMapControl gMapControl1)
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
        public void GClick(GMapControl gMapControl1, MouseEventArgs e)
        {
            //obtener info y mostrar
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double ln = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;
            //posicionar el marker
            marker.Position = new PointLatLng(lat, ln);
            //mostrar texto en tooltip
            marker.ToolTipText = String.Format("Ubicación: \n Latitud:{0} \n Longitud:{1}", lat, ln);
        }

        }
}
