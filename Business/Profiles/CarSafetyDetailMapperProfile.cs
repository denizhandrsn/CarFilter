using AutoMapper;
using Business.Requests.CarSafetyDetail;
using Business.Responses.CarSafetyDetail;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class CarSafetyDetailMapperProfile:Profile
    {
        public CarSafetyDetailMapperProfile()
        {
            CreateMap<CarSafetyDetail, ListCarSafetyDetailResponse>();
            CreateMap<CreateCarSafetyDetailRequest, CarSafetyDetail>();
            CreateMap<UpdateCarSafetyDetailRequest, CarSafetyDetail>();
            CreateMap<DeleteCarSafetyDetailRequest, CarSafetyDetail>();
        }
    }
}
