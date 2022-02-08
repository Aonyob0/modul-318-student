using SwissTransport.Core;
using SwissTransport.Models;

namespace SBBLite
{
    public partial class Verbindungen : Form
    {
        private ITransport _transport = new Transport();
        public Verbindungen()
        {
            InitializeComponent();
        }

        private void btnStationenFormsClick(object sender, EventArgs e)
        {
            this.Hide();
            Form stationen = new Stationen();
            stationen.Closed += (s, args) => this.Close();
            stationen.Show();
        }

        private void btnVerbindungenFormsClick(object sender, EventArgs e)
        {
            MessageBox.Show("Sie befinden sich bereits auf dieser Seite.");
        }

        private void btnSuchenVerbindungClick(object sender, EventArgs e)
        {
            dgvVerbindungSuchen.Rows.Clear();
            Connections suchResultat = _transport.GetConnections(tbxVerbindungStart.Text, tbxVerbindungZiel.Text, dtpTime.Value, dtpDatum.Value);
            
            foreach (Connection connection in suchResultat.ConnectionList)
            {
                dgvVerbindungSuchen.Rows.Add
                    (
                    $"{connection.From.Station.Name} -> {connection.To.Station.Name}",
                    connection.From.Departure.Value.ToString("HH:mm"),
                    connection.To.Arrival.Value.ToString("HH:mm"),
                    $"{connection.From.Platform} -> {connection.To.Platform}",
                    connection.Duration
                    );
            }
        }
    }
}