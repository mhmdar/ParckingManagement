using ParkingLotAtomic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace ParkingLotAtomic.Controllers
{
    public class SlotController : ApiController
    {
        private SlotService _slotservice;
        public SlotController()
        {
            _slotservice = new SlotService();
        }
        [HttpGet]
        [ActionName("GetSlotCost")]
        public HttpResponseMessage GetSlotCost(string SlotId)
        {
            var cost = _slotservice.GetSlotCost(SlotId);
            return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK, Content = new StringContent( "{ \"Cost\":\"" + cost + "\"" ) };
        }
        [HttpGet]
        [ActionName("GetSlotDistance")]
        public HttpResponseMessage GetSlotDistance(string SlotId, string CurrentLocation)
        {
            var distance = _slotservice.GetDistanceFromSlot(SlotId, CurrentLocation);
            return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK, Content = new StringContent("{ \"Distance\":\"" + distance + "\"") };
        }
        [HttpGet]
        [ActionName("GetSlotsByParkingStructure")]

        public HttpResponseMessage GetSlotsByParkingStructure(string structureId)
        {
            var slots = _slotservice.GetSlotsByParkingStructure(structureId);
            var jsonObj = new JavaScriptSerializer().Serialize(slots);
            return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK, Content = new StringContent(jsonObj) };
        }
        [HttpPost]
        [ActionName("ReserveSlot")]

        public HttpResponseMessage ReserveSlot(string slotid, string driverId)
        {
             _slotservice.ReserveSlot(slotid, driverId);
             return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK, Content = new StringContent("Reserved Successfully") };
        }

    }
}
