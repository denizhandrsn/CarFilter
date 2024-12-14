using Business.Responses.CarComfortDetail;
using Business.Responses.CarExteriorDetail;
using Business.Responses.CarGeneralDetail;
using Business.Responses.CarInteriorDetail;
using Business.Responses.CarPerformanceDetail;
using Business.Responses.CarSafetyDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.CarDetail
{
    public class ListCarDetailResponse
    {
        public ListCarGeneralDetailResponse ListCarGeneralDetailResponse { get; set; }
        public ListCarSafetyDetailResponse ListCarSafetyDetailResponse { get; set; }
        public ListCarPerformanceDetailResponse ListCarPerformanceDetailResponse { get; set; }
        public ListCarComfortDetailResponse ListCarComfortDetailResponse { get; set; }
        public ListCarInteriorDetailResponse ListCarInteriorDetailResponse { get; set; }
        public ListCarExteriorDetailResponse ListCarExteriorDetailResponse { get; set; }

    }
}
