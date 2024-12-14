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
    public class UpdateCarDetailRequest
    {
        public UpdateCarGeneralDetailRequest UpdateCarGeneralDetailRequest { get; set; }
        public UpdateCarSafetyDetailRequest UpdateCareSafetyDetailRequest { get; set; }
        public UpdateCarPerformanceDetailRequest UpdateCarPerformanceDetailRequest { get; set; }
        public UpdateCarComfortDetailRequest UpdateCarComfortDetailRequest { get; set; }
        public UpdateCarInteriorDetailRequest UpdateCarInteriorDetailRequest { get; set; }
        public UpdateCarExteriorDetailRequest UpdateCarExteriorDetailRequest { get; set; }
    }
}
