using SwissTransport.Core;
using SwissTransport.Models;

namespace SBBLite
{
    public partial class Abfahrtstafel : Form
    {
        private ITransport _transport = new Transport();
        public Abfahrtstafel(string stationName, string stationId)
        {
            InitializeComponent();
            StationBoardRoot abfahrtstafel = _transport.GetStationBoard(stationName, stationId);
            try
            {
                foreach (StationBoard station in abfahrtstafel.Entries)
                {
                    dgvAbfahrtstafel.Rows.Add
                        (
                        station.To,
                        station.Number,
                        station.Stop.Departure.ToString("HH:mm")
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\nÜberprüfen Sie Ihre Internetverbindung.");
            }
        }
    }
}
