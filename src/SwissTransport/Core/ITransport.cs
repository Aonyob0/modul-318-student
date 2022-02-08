namespace SwissTransport.Core
{
    using SwissTransport.Models;
    using System;

    public interface ITransport
    {
        Stations GetStations(string query);

        StationBoardRoot GetStationBoard(string station, string id);

        Connections GetConnections(string fromStation, string toStation);

        Connections GetConnections(string fromStation, string toStation, DateTime time, DateTime date);

    }
}