using AutoMapper;
using Business.Abstract;
using Business.Requests.CarSafetyDetail;
using Business.Responses.CarSafetyDetail;
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
    public class CarSafetyDetailManager : ICarSafetyDetailService
    {
        IMapper _mapper;
        ICarSafetyDetailDal _carSafetyDetailDal;
        public CarSafetyDetailManager(IMapper mapper, ICarSafetyDetailDal carSafetyDetailDal)
        {
            _carSafetyDetailDal = carSafetyDetailDal;
            _mapper = mapper;
        }

        public IDataResult<CarSafetyDetail> Add(CreateCarSafetyDetailRequest request)
        {
            CarSafetyDetail carSafetyDetail = _mapper.Map<CarSafetyDetail>(request);
            _carSafetyDetailDal.Add(carSafetyDetail);
            return new SuccessDataResult<CarSafetyDetail>(carSafetyDetail);
        }

        public IResult Delete(DeleteCarSafetyDetailRequest request)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ListCarSafetyDetailResponse>> GetAll()
        {
            List<CarSafetyDetail> carSafetyDetails = _carSafetyDetailDal.GetAll();
            List<ListCarSafetyDetailResponse> responses = _mapper.Map<List<ListCarSafetyDetailResponse>>(carSafetyDetails);
            return new SuccessDataResult<List<ListCarSafetyDetailResponse>>(responses);
        }

        public IResult Update(UpdateCarSafetyDetailRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
