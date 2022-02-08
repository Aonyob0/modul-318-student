using SwissTransport.Core;
using SwissTransport.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBBLite
{
    public partial class Abfahrtstafel : Form
    {
        private ITransport _transport = new Transport();
        public Abfahrtstafel(string stationName, string stationId)
        {
            InitializeComponent();
            StationBoardRoot abfahrtstafel = _transport.GetStationBoard(stationName, stationId);
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
    }
}
