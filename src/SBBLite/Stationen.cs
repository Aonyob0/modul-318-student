using SwissTransport.Core;
using SwissTransport.Models;

namespace SBBLite
{
    public partial class Stationen : Form
    {
        private ITransport _transport = new Transport();

        public Stationen()
        {
            InitializeComponent();
        }

        private void btnVerbindungenFormsClick(object sender, EventArgs e)
        {
            this.Hide();
            Form verbindungen = new Verbindungen();
            verbindungen.Closed += (s, args) => this.Close();
            verbindungen.Show();
        }

        private void btnStationenFormsClick(object sender, EventArgs e)
        {
            MessageBox.Show("Sie befinden sich bereits auf dieser Seite.");
        }

        private void btnStationSuchenClick(object sender, EventArgs e)
        {
            dgvStationen.Rows.Clear();
            try
            {
                Stations suchResultat = _transport.GetStations(tbxStationEingabe.Text);
                foreach (Station station in suchResultat.StationList.Where(x => x.Id != null))
                {
                    dgvStationen.Rows.Add(station.Name, station.Id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\nÜberprüfen Sie Ihre Internetverbindung.");
            }
        }

        private void dgvStationen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string stationName = dgvStationen.SelectedCells[0].FormattedValue.ToString();
            string stationId = dgvStationen.SelectedCells[1].FormattedValue.ToString();

            Form abfahrtstafel = new Abfahrtstafel(stationName, stationId);
            abfahrtstafel.Closed += (s, args) => this.Close();
            abfahrtstafel.Show();
        }
    }
}
