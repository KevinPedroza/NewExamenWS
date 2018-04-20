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
using System.Xml;
using System.IO;

namespace ExamenWS
{
    public partial class Form1 : Form
    {
        Components c = new Components();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            c.CargarEfemerides(lblSolSale, lblSolSale, lblLunaSale, lblLunaPone, lblFaseLunar);
            c.CargarRegiones(cbxRegiones);
        }

        private void gMapControl1_MouseClick(object sender, MouseEventArgs e)
        {
            c.GClick(gMapControl1, e);
        }

        private void cbxRegiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.SelectedIndexRegion(cbxRegiones, comboBox1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.ComboClick(comboBox1,panel1,panel2,panel3,gMapControl1,pbxCM,lblCCM,lblCTM,pbxCT,lblCCT,lblCTT,pbxCN,lblCCN,lblCTN);
        }
    }
}
