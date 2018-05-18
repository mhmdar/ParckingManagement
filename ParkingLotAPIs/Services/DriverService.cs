using ParkingLotAtomic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingLotAPIs.Services
{
    public class DriverService
    {
        public DriverPreference GetDriverReference( string driverId)
        {
            return new DriverPreference() { CarId = "12313", Currency = "NIS", Language = "En", Name = "Hamoudeh" };
        }

        public bool Login(string username, string password)
        {
            return true;
        }
    }
}