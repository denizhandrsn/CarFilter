using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.CarGeneralDetail
{
    public class CreateCarGeneralDetailRequest
    {
        public int Id { get; set; }
        public string BodyType { get; set; }
        public string Transmission { get; set; }
        public int NumberOfSeats { get; set; }
        public string Segment { get; set; }
        public string DriveWheel { get; set; }
        public string FuelType { get; set; }
        public int HorsePower { get; set; }
        public int Torque { get; set; }
        public string EngineCapacity { get; set; }
        public bool Turbo { get; set; }
        public int FuelTankCapacity { get; set; }
        public int CargoCapacity { get; set; }
    }
}
