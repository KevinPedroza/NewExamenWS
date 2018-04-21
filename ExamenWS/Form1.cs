using System;
using System.Windows.Forms;
using Capa_Negocios;

namespace ExamenWS
{
    public partial class Form1 : Form
    {
        Getting_Methods c = new Getting_Methods();
        Getting_Info gt = new Getting_Info();
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
            gt.CargarEfemerides(lblSolSale, lblSolPone, lblLunaSale, lblLunaPone, lblFaseLunar);
            gt.CargarRegiones(cbxRegiones);
        }

        private void gMapControl1_MouseClick(object sender, MouseEventArgs e)
        {
            c.GClick(gMapControl1, e);
        }

        private void cbxRegiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            gt.SelectedIndexRegion(cbxRegiones, comboBox1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            gt.ComboClick(comboBox1,panel1,panel2,panel3,gMapControl1,pbxCM,lblCCM,lblCTM,pbxCT,lblCCT,lblCTT,pbxCN,lblCCN,lblCTN);
        }
    }
}
