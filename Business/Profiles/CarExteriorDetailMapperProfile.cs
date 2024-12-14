using AutoMapper;
using Business.Requests.CarExteriorDetail;
using Business.Responses.CarExteriorDetail;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class CarExteriorDetailMapperProfile:Profile
    {
        public CarExteriorDetailMapperProfile()
        {
            CreateMap<CarExteriorDetail, ListCarExteriorDetailResponse>();
            CreateMap<CreateCarExteriorDetailRequest, CarExteriorDetail>();
            CreateMap<UpdateCarExteriorDetailRequest, CarExteriorDetail>();
            CreateMap<DeleteCarExteriorDetailRequest, CarExteriorDetail>();
        }
    }
}
