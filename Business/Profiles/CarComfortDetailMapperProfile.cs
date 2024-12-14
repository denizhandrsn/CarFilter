using AutoMapper;
using Business.Requests.CarComfortDetail;
using Business.Responses.CarComfortDetail;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class CarComfortDetailMapperProfile:Profile
    {
        public CarComfortDetailMapperProfile()
        {
            CreateMap<CarComfortDetail, ListCarComfortDetailResponse>();
            CreateMap<CreateCarComfortDetailRequest, CarComfortDetail>();
            CreateMap<DeleteCarComfortDetailRequest, CarComfortDetail>();
            CreateMap<UpdateCarComfortDetailRequest, CarComfortDetail>();
        }

    }
}
