using SwissTransport.Core;
using SwissTransport.Models;

namespace SBBLite
{
    public partial class Form1 : Form
    {
        private ITransport _transport = new Transport();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStationenFormsClick(object sender, EventArgs e)
        {

        }

        private void btnAbfahrtstafelFormsClick(object sender, EventArgs e)
        {

        }

        private void btnSuchenFormsClick(object sender, EventArgs e)
        {

        }

        private void btnSuchenVerbindungClick(object sender, EventArgs e)
        {
            Connections suchResultat = _transport.GetConnections(tbxVerbindungStart.Text, tbxVerbindungZiel.Text);
            suchResultat.ConnectionList[0].From
        }
    }
}