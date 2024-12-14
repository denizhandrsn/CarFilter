using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.CarComfortDetail
{
    public class ListCarComfortDetailResponse
    {
        public bool CentralDoorLock { get; set; }
        public bool KeylessEntry { get; set; }
        public bool StartButton { get; set; }
        public bool ControlCircut { get; set; }
        public bool ElectricWindowsFront { get; set; }
        public bool ElectricWindowsBack { get; set; }
        public bool PowerSteering { get; set; }
        public bool CruiseControl { get; set; }
        public bool AirConditioning { get; set; }
        public bool ParkingSensors { get; set; }
        public bool ReverseCamera { get; set; }
        public bool ParkingMachine { get; set; }
        public bool StartStopSystem { get; set; }
    }
}
