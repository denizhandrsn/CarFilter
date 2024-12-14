using AutoMapper;
using Business.Abstract;
using Business.Requests.CarDetail;
using Business.Responses.CarDetail;
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
    public class CarDetailManager : ICarDetailService
    {
        IMapper _mapper;
        ICarDetailDal _carDetailDal;
        ICarComfortDetailService _carComfortDetailService;
        ICarExteriorDetailService _carExteriorDetailService;
        ICarSafetyDetailService _carSafetyDetailService;
        ICarPerformanceDetailService _carPerformanceDetailService;
        ICarInteriorDetailService _carInteriorDetailService;
        ICarGeneralDetailService _carGeneralDetailService;
        public CarDetailManager(IMapper mapper, ICarDetailDal carDetailDal, ICarSafetyDetailService carSafetyDetailService, 
            ICarPerformanceDetailService carPerformanceDetailService, ICarInteriorDetailService carInteriorDetailService, 
            ICarGeneralDetailService carGeneralDetailService, ICarExteriorDetailService carExteriorDetailService, ICarComfortDetailService carComfortDetailService)
        {
            _mapper = mapper;
            _carDetailDal = carDetailDal;
            _carSafetyDetailService = carSafetyDetailService;
            _carPerformanceDetailService = carPerformanceDetailService;
            _carInteriorDetailService = carInteriorDetailService;
            _carGeneralDetailService = carGeneralDetailService;
            _carExteriorDetailService = carExteriorDetailService;
            _carComfortDetailService = carComfortDetailService;
        }


        public IDataResult<CarDetail> Add(CreateCarDetailRequest request)
        {
            CarDetail carDetail = _mapper.Map<CarDetail>(request);

            carDetail.CarGeneralDetail = _mapper.Map<CarGeneralDetail>(request.CreateCarGeneralDetailRequest);
            carDetail.CarExteriorDetail = _mapper.Map<CarExteriorDetail>(request.CreateCarExteriorDetailRequest);
            carDetail.CarSafetyDetail = _mapper.Map<CarSafetyDetail>(request.CreateCarSafetyDetailRequest);
            carDetail.CarPerformanceDetail = _mapper.Map<CarPerformanceDetail>(request.CreateCarPerformanceDetailRequest);
            carDetail.CarInteriorDetail = _mapper.Map<CarInteriorDetail>(request.CreateCarInteriorDetailRequest);
            carDetail.CarComfortDetail = _mapper.Map<CarComfortDetail>(request.CreateCarComfortDetailRequest);


            var safeData = _carSafetyDetailService.Add(request.CreateCarSafetyDetailRequest);
            carDetail.CarSafetyDetail.Id = safeData.Data.Id;
            carDetail.CarSafetyDetailId = safeData.Data.Id;

            var  perfData = _carPerformanceDetailService.Add(request.CreateCarPerformanceDetailRequest);
            carDetail.CarPerformanceDetail.Id = perfData.Data.Id;
            carDetail.CarPerformanceDetailId = perfData.Data.Id;

            var interData = _carInteriorDetailService.Add(request.CreateCarInteriorDetailRequest);
            carDetail.CarInteriorDetail.Id = interData.Data.Id;
            carDetail.CarInteriorDetailId = interData.Data.Id;

            var  generalData = _carGeneralDetailService.Add(request.CreateCarGeneralDetailRequest);
            carDetail.CarGeneralDetail.Id = generalData.Data.Id;
            carDetail.CarGeneralDetailId = generalData.Data.Id;

            var exterData = _carExteriorDetailService.Add(request.CreateCarExteriorDetailRequest);
            carDetail.CarExteriorDetail.Id= exterData.Data.Id;
            carDetail.CarExteriorDetailId = exterData.Data.Id;

            var comfortData = _carComfortDetailService.Add(request.CreateCarComfortDetailRequest);
            carDetail.CarComfortDetail.Id = comfortData.Data.Id;
            carDetail.CarComfortDetailId = comfortData.Data.Id;
               

            _carDetailDal.Add(carDetail);

            return new SuccessDataResult<CarDetail>(carDetail);




            //carDetail.CarGeneralDetail = _mapper.Map<CarGeneralDetail>(request.CreateCarGeneralDetailRequest);
            //carDetail.CarExteriorDetail = _mapper.Map<CarExteriorDetail>(request.CreateCarExteriorDetailRequest);
            //carDetail.CarSafetyDetail = _mapper.Map<CarSafetyDetail>(request.CreateCarSafetyDetailRequest);
            //carDetail.CarPerformanceDetail = _mapper.Map<CarPerformanceDetail>(request.CreateCarPerformanceDetailRequest);
            //carDetail.CarInteriorDetail = _mapper.Map<CarInteriorDetail>(request.CreateCarInteriorDetailRequest);
            //carDetail.CarComfortDetail = _mapper.Map<CarComfortDetail>(request.CreateCarComfortDetailRequest);
            //carDetail.CarComfortDetailId = request.CreateCarComfortDetailRequest.Id;
            //carDetail.CarExteriorDetailId = request.CreateCarExteriorDetailRequest.Id;
            //carDetail.CarGeneralDetailId = request.CreateCarGeneralDetailRequest.Id;
            //carDetail.CarPerformanceDetailId = request.CreateCarPerformanceDetailRequest.Id;
            //carDetail.CarInteriorDetailId = request.CreateCarInteriorDetailRequest.Id;
            //carDetail.CarSafetyDetailId = request.CreateCarSafetyDetailRequest.Id;
        }

        public IResult Delete(DeleteCarDetailRequest request)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ListCarDetailResponse>> GetAll()
        {
            List<CarDetail> carDetailResponses = _carDetailDal.GetAll();
            List<ListCarDetailResponse> response = _mapper.Map<List<ListCarDetailResponse>>(carDetailResponses);
            return new SuccessDataResult<List<ListCarDetailResponse>>(response);
        }

        public IResult Update(UpdateCarDetailRequest request)
        {
            CarDetail carDetail = _mapper.Map<CarDetail>(request);
            _carDetailDal.Update(carDetail);
            return new SuccessResult();
        }
    }
}
