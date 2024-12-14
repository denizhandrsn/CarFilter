using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.CarInteriorDetail
{
    public class ListCarInteriorDetailResponse
    {
        public bool HeightAdjustmentSeat { get; set; }
        public bool ElectricAdjustmentSeat { get; set; }
        public bool HeatedSeats { get; set; }
        public bool VentilatedSeats { get; set; }
        public bool SportsSeat { get; set; }
        public bool AdjustableSteeringWheel { get; set; }
        public bool HeatedSteeringWheel { get; set; }
        public bool RearHeadrest { get; set; }
        public bool FoldingRearSeat { get; set; }
        public bool SlidingRearSeat { get; set; }
        public bool CentralArmRest { get; set; }
        public bool MakeUpMirror { get; set; }
        public bool AdjustableDashboardLighting { get; set; }
        public bool Tachometer { get; set; }
        public bool DayCounter { get; set; }
        public bool CoolantTemperatureGauge { get; set; }
        public bool OutsiteTemperatureGauge { get; set; }
        public bool BoardComputer { get; set; }
        public bool AudioSystem { get; set; }
        public bool DigitalRadio { get; set; }
        public string AudioInput { get; set; }
        public int NavigationSystem { get; set; }
        public int Bluetooth { get; set; }
    }
}
