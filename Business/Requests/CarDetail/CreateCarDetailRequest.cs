using Business.Requests.CarComfortDetail;
using Business.Requests.CarExteriorDetail;
using Business.Requests.CarGeneralDetail;
using Business.Requests.CarInteriorDetail;
using Business.Requests.CarPerformanceDetail;
using Business.Requests.CarSafetyDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.CarDetail
{
    public class CreateCarDetailRequest
    {

        public CreateCarGeneralDetailRequest CreateCarGeneralDetailRequest { get; set; }
        public CreateCarSafetyDetailRequest CreateCarSafetyDetailRequest { get; set; }
        public CreateCarPerformanceDetailRequest CreateCarPerformanceDetailRequest { get; set; }
        public CreateCarComfortDetailRequest CreateCarComfortDetailRequest { get; set; }
        public CreateCarInteriorDetailRequest CreateCarInteriorDetailRequest { get; set; }
        public CreateCarExteriorDetailRequest CreateCarExteriorDetailRequest { get; set; }
    }
}
