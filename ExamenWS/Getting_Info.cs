using ExamenWS.Prono;
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
using Capa_Negocios;
using static ExamenWS.XMLCode;

namespace ExamenWS
{
    public class Getting_Info
    {
        public void ComboClick(ComboBox comboBox1, Panel panel1, Panel panel2, Panel panel3, GMapControl gMapControl1, PictureBox pbxCM, TextBox lblCCM, Label lblCTM,
    PictureBox pbxCT, TextBox lblCCT, Label lblCTT, PictureBox pbxCN, TextBox lblCCN, Label lblCTN)
        {
            PRONOSTICO_REGIONALREGIONCIUDAD ciudad = comboBox1.SelectedItem as PRONOSTICO_REGIONALREGIONCIUDAD;
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            try
            {
                Getting_Methods.GeoCode(comboBox1);
                string newla = Getting_Methods.Latitude.Replace(".", ",");
                string newlo = Getting_Methods.Longitude.Replace(".", ",");
                gMapControl1.Overlays.Clear();
                Capa_Negocios.Getting_Methods.cargarMapa(Convert.ToDouble(newla), Convert.ToDouble(newlo), gMapControl1);

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
        public void CargarEfemerides(Label lblSolSale, Label lblSolPone, Label lblLunaSale, Label lblLunaPone, Label lblFaseLunar)
        {
            WSMeteorologicoClient ws = new WSMeteorologicoClient("WSMeteorologico");
            EFEMERIDES ef = ws.efemerides(new efemerides()).ParseXML<EFEMERIDES>();
            lblSolSale.Text = String.Format("Sale: {0}", ef.EFEMERIDE_SOL.SALE + " AM");
            lblSolPone.Text = String.Format("Se oculta: {0}", ef.EFEMERIDE_SOL.SEPONE + " PM");
            lblLunaSale.Text = String.Format("Sale: {0}", ef.EFEMERIDE_LUNA.SALE + "AM");
            lblLunaPone.Text = String.Format("Se oculta: {0}", ef.EFEMERIDE_LUNA.SEPONE + "PM");

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
        public void SelectedIndexRegion(ComboBox cbxRegiones, ComboBox comboBox1)
        {
            WSMeteorologicoClient ws = new WSMeteorologicoClient("WSMeteorologico");
            int id = (cbxRegiones.SelectedItem as PRONOSTICO_REGIONALREGION)?.idRegion ?? -1;
            PRONOSTICO_REGIONAL reg = ws.pronosticoRegionalxID(id).ParseXML<PRONOSTICO_REGIONAL>();
            if (id != -1)
                CargarCiudades(reg.REGIONES[0].CIUDADES, comboBox1);
        }
    }
}
