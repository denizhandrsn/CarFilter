using Business.Requests.CarSafetyDetail;
using Business.Responses.CarSafetyDetail;
using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarSafetyDetailService
    {
        IDataResult<List<ListCarSafetyDetailResponse>> GetAll();
        IDataResult<CarSafetyDetail> Add(CreateCarSafetyDetailRequest request);
        IResult Delete(DeleteCarSafetyDetailRequest request);
        IResult Update(UpdateCarSafetyDetailRequest request);
    }
}
