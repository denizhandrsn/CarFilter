using AutoMapper;
using Business.Abstract;
using Business.Requests.Car;
using Business.Responses.Car;
using Business.Responses.CarDetail;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        IMapper _mapper;
        ICarDal _carDal;
        ICarDetailService _carDetailService;
        public CarManager(IMapper mapper, ICarDal carDal, ICarDetailService carDetailService)
        {
            _mapper = mapper;
            _carDal = carDal;
            _carDetailService = carDetailService;
        }
        public IDataResult<Car> Add(CreateCarRequest request)
        { 
            Car car = _mapper.Map<Car>(request);
            var carDetailData = _carDetailService.Add(request.CreateCarDetailRequest);
            car.CarDetail = carDetailData.Data;
            car.CarDetailId = carDetailData.Data.Id;
            _carDal.Add(car);
            return new SuccessDataResult<Car>(car);
        }

        public IResult Delete(DeleteCarRequest request)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetAll()
        {
            List<Car> cars = _carDal.GetAll(include: b => b.Include(b => b.CarDetail.CarInteriorDetail).Include(b => b.CarDetail.CarComfortDetail)
            .Include(b => b.CarDetail.CarExteriorDetail).Include(b => b.CarDetail.CarGeneralDetail).Include(b => b.CarDetail.CarPerformanceDetail)
            .Include(b => b.CarDetail.CarSafetyDetail)
            );
            return new SuccessDataResult<List<Car>>(cars);
        }

        public IResult Update(UpdateCarRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
