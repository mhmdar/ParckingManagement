using ParkingLotAtomic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingLotAtomic.Services
{
    public class SlotService
    {
        List<Slot> slots = new List<Slot>();
        public SlotService()
        {
            //initialize dummy data
            slots.Add(new Slot() { Cost = 10, DeviceId = "100", Id = "123131", Level = "2", Location = "32.1231:32.123131", NumberofLanes = "2", streetId = "12" });
        }
        public double GetSlotCost(string slotId)
        {
            try
            {
                var cost = slots.Where(x => x.Id == slotId).FirstOrDefault().Cost;
                return cost;
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public double GetDistanceFromSlot(string slotId, string currentLocation)
        {
            return new Random().NextDouble();
        }

        public List<Slot> GetSlotsByParkingStructure(string structureId)
        {
            return slots;
        }

        public void ReserveSlot(string slotid, string driverId)
        {
            return;
        }
    }
}