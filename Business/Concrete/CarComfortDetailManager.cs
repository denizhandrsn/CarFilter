using Business.Abstract;
using Business.Requests.CarComfortDetail;
using Business.Responses.CarComfortDetail;
using Core.Utilities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarComfortDetailManager : ICarComfortDetailService
    {
        ICarComfortDetailDal _carComfortDetailDal;
        IMapper _mapper;

        public CarComfortDetailManager(IMapper mapper, ICarComfortDetailDal carComfortDetailDal)
        {
            _carComfortDetailDal = carComfortDetailDal;
            _mapper = mapper;
        }

        public IDataResult<CarComfortDetail> Add(CreateCarComfortDetailRequest request)
        {
            CarComfortDetail carComfortDetail = _mapper.Map<CarComfortDetail>(request);
            _carComfortDetailDal.Add(carComfortDetail);
            return new SuccessDataResult<CarComfortDetail>(carComfortDetail);
        }

        public IResult Delete(DeleteCarComfortDetailRequest request)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ListCarComfortDetailResponse>> GetAll()
        {
            List<CarComfortDetail> carComfortDetails = _carComfortDetailDal.GetAll();
            List<ListCarComfortDetailResponse> responses = _mapper.Map<List<ListCarComfortDetailResponse>>(carComfortDetails);
            return new SuccessDataResult<List<ListCarComfortDetailResponse>>(responses);
        }

        public IResult Update(UpdateCarComfortDetailRequest request)
        {
            CarComfortDetail carComfortDetail = _mapper.Map<CarComfortDetail>(request);
            _carComfortDetailDal.Update(carComfortDetail);
            return new SuccessResult("Okay");
        }
    }
}
