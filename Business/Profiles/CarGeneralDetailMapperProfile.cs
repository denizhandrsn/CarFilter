using AutoMapper;
using Business.Requests.CarGeneralDetail;
using Business.Responses.CarGeneralDetail;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class CarGeneralDetailMapperProfile:Profile
    {
        public CarGeneralDetailMapperProfile()
        {
            CreateMap<CarGeneralDetail, ListCarGeneralDetailResponse>();
            CreateMap<CreateCarGeneralDetailRequest, CarGeneralDetail>();
            CreateMap<UpdateCarGeneralDetailRequest, CarGeneralDetail>();
            CreateMap<DeleteCarGeneralDetailRequest, CarGeneralDetail>();
        }
    }
}
