using AutoMapper;
using Business.Requests.CarPerformanceDetail;
using Business.Responses.CarPerformanceDetail;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class CarPerformanceDetailMapperProfile:Profile
    {
        public CarPerformanceDetailMapperProfile()
        {
            CreateMap<CarPerformanceDetail, ListCarPerformanceDetailResponse>();
            CreateMap<CreateCarPerformanceDetailRequest, CarPerformanceDetail>();
            CreateMap<UpdateCarPerformanceDetailRequest, CarPerformanceDetail>();
            CreateMap<DeleteCarPerformanceDetailRequest, CarPerformanceDetail>();
        }
    }
}
