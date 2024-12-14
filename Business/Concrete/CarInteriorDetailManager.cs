using AutoMapper;
using Business.Abstract;
using Business.Requests.CarInteriorDetail;
using Business.Responses.CarInteriorDetail;
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
    public class CarInteriorDetailManager : ICarInteriorDetailService
    {
        IMapper _mapper;
        ICarInteriorDetailDal _carInteriorDetailDal;
        public CarInteriorDetailManager(IMapper mapper, ICarInteriorDetailDal carInteriorDetailDal)
        {
            _mapper = mapper;
            _carInteriorDetailDal = carInteriorDetailDal;
        }
        public IDataResult<CarInteriorDetail> Add(CreateCarInteriorDetailRequest request)
        {
            CarInteriorDetail carInteriorDetail = _mapper.Map<CarInteriorDetail>(request);
            _carInteriorDetailDal.Add(carInteriorDetail);
            return new SuccessDataResult<CarInteriorDetail>(carInteriorDetail);
        }

        public IResult Delete(DeleteCarInteriorDetailRequest request)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ListCarInteriorDetailResponse>> GetAll()
        {
            List<CarInteriorDetail> carInteriorDetails = _carInteriorDetailDal.GetAll();
            List<ListCarInteriorDetailResponse> responses = _mapper.Map<List<ListCarInteriorDetailResponse>>(carInteriorDetails);
            return new SuccessDataResult<List<ListCarInteriorDetailResponse>>(responses);
        }

        public IResult Update(UpdateCarInteriorDetailRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
