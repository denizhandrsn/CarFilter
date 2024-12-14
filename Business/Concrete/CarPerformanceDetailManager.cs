using AutoMapper;
using Business.Abstract;
using Business.Requests.CarPerformanceDetail;
using Business.Responses.CarPerformanceDetail;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarPerformanceDetailManager : ICarPerformanceDetailService
    {
        IMapper _mapper;
        ICarPerformanceDetailDal _carPerformanceDal;
        public CarPerformanceDetailManager(IMapper mapper, ICarPerformanceDetailDal carPerformanceDetailDal)
        {
            _carPerformanceDal = carPerformanceDetailDal;
            _mapper = mapper;
        }

        public IDataResult<CarPerformanceDetail> Add(CreateCarPerformanceDetailRequest request)
        {
            CarPerformanceDetail carPerformanceDetail = _mapper.Map<CarPerformanceDetail>(request);
            _carPerformanceDal.Add(carPerformanceDetail);
            return new SuccessDataResult<CarPerformanceDetail>(carPerformanceDetail);
        }

        public IResult Delete(DeleteCarPerformanceDetailRequest request)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ListCarPerformanceDetailResponse>> GetAll()
        {
            List<CarPerformanceDetail> carPerformanceDetails = _carPerformanceDal.GetAll();
            List<ListCarPerformanceDetailResponse> response = _mapper.Map<List<ListCarPerformanceDetailResponse>>(carPerformanceDetails);
            return new SuccessDataResult<List<ListCarPerformanceDetailResponse>>(response);
        }

        public IResult Update(UpdateCarPerformanceDetailRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
