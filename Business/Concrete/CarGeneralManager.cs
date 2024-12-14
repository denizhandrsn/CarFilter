using AutoMapper;
using Business.Abstract;
using Business.Requests.CarGeneralDetail;
using Business.Responses.CarGeneralDetail;
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
    public class CarGeneralDetailManager : ICarGeneralDetailService
    {
        IMapper _mapper;
        ICarGeneralDetailDal _carGeneralDetailDal;
        public CarGeneralDetailManager(IMapper mapper, ICarGeneralDetailDal carGeneralDetailDal)
        {
            _carGeneralDetailDal = carGeneralDetailDal;
            _mapper = mapper;
        }


        public IDataResult<CarGeneralDetail> Add(CreateCarGeneralDetailRequest request)
        {
            CarGeneralDetail carGeneralDetail = _mapper.Map<CarGeneralDetail>(request);
            _carGeneralDetailDal.Add(carGeneralDetail);
            return new SuccessDataResult<CarGeneralDetail>(carGeneralDetail);
        }

        public IResult Delete(DeleteCarGeneralDetailRequest request)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ListCarGeneralDetailResponse>> GetAll()
        {
            List<CarGeneralDetail> carGeneralDetails = _carGeneralDetailDal.GetAll();
            List<ListCarGeneralDetailResponse> listCarGeneralDetailResponses = _mapper.Map<List<ListCarGeneralDetailResponse>>(carGeneralDetails);
            return new SuccessDataResult<List<ListCarGeneralDetailResponse>>(listCarGeneralDetailResponses);
        }

        public IResult Update(UpdateCarGeneralDetailRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
