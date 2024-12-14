using AutoMapper;
using Business.Requests.CarInteriorDetail;
using Business.Responses.CarInteriorDetail;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class CarInteriorDetailMapperProfile:Profile
    {
        public CarInteriorDetailMapperProfile()
        {
            CreateMap<CarInteriorDetail, ListCarInteriorDetailResponse>();
            CreateMap<CreateCarInteriorDetailRequest, CarInteriorDetail>();
            CreateMap<UpdateCarInteriorDetailRequest, CarInteriorDetail>();
            CreateMap<DeleteCarInteriorDetailRequest, CarInteriorDetail>();
        }
    }
}
