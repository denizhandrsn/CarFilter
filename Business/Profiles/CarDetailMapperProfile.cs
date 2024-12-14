using AutoMapper;
using Business.Requests.CarDetail;
using Business.Responses.CarDetail;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class CarDetailMapperProfile:Profile
    {
        public CarDetailMapperProfile()
        {
            CreateMap<CarDetail, ListCarDetailResponse>();
            CreateMap<CreateCarDetailRequest, CarDetail>();
            CreateMap<UpdateCarDetailRequest, CarDetail>();
            CreateMap<DeleteCarDetailRequest, CarDetail>();
        }
    }
}
