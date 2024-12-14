using AutoMapper;
using Business.Abstract;
using Business.Requests.CarExteriorDetail;
using Business.Responses.CarExteriorDetail;
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
    public class CarExteriorDetailManager : ICarExteriorDetailService
    {
        IMapper _mapper;
        ICarExteriorDetailDal _carExteriorDetailDal;
        public CarExteriorDetailManager(IMapper mapper, ICarExteriorDetailDal carExteriorDetailDal)
        {
            _carExteriorDetailDal = carExteriorDetailDal;
            _mapper = mapper;
        }



        public IDataResult<CarExteriorDetail> Add(CreateCarExteriorDetailRequest request)
        {
            CarExteriorDetail carExteriorDetail = _mapper.Map<CarExteriorDetail>(request);
            _carExteriorDetailDal.Add(carExteriorDetail);
            return new SuccessDataResult<CarExteriorDetail>(carExteriorDetail);
        }

        public IResult Delete(DeleteCarExteriorDetailRequest request)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ListCarExteriorDetailResponse>> GetAll()
        {
            List<CarExteriorDetail> carExteriorDetails = _carExteriorDetailDal.GetAll();
            List<ListCarExteriorDetailResponse> responses = _mapper.Map<List<ListCarExteriorDetailResponse>>(carExteriorDetails);
            return new SuccessDataResult<List<ListCarExteriorDetailResponse>>(responses);
        }

        public IResult Update(UpdateCarExteriorDetailRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
