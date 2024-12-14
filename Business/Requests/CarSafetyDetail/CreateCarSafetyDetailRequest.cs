using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.CarSafetyDetail
{
    public class CreateCarSafetyDetailRequest
    {
        public int Id { get; set; }
        public bool ABS { get; set; }
        public bool BrakeAssist { get; set; }
        public bool EmergencyBraking { get; set; }
        public bool BlindSpotAssist { get; set; }
        public bool StabilityControl { get; set; }
        public bool TractionControl { get; set; }
        public bool DriverAirbag { get; set; }
        public bool PassangerAirbag { get; set; }
        public bool SideAirbag { get; set; }
        public bool HeadAirbag { get; set; }
        public bool KneeAirbag { get; set; }
        public bool LaneAirbag { get; set; }
        public bool FatigueSensor { get; set; }
        public bool TirePressureSensor { get; set; }
        public bool TrafficSignRecognition { get; set; }
        public bool CollisionWarningSystem { get; set; }
        public bool AutomaticLevelControl { get; set; }
    }
}
