using AutoMapper;
using Business.Requests.Car;
using Business.Responses.Car;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class CarMapperProfile:Profile
    {
        public CarMapperProfile()
        {
            CreateMap<Car, ListCarResponse>();
            CreateMap<CreateCarRequest, Car>();
            CreateMap<UpdateCarRequest, Car>();
            CreateMap<DeleteCarRequest, Car>();
        }
    }
}
