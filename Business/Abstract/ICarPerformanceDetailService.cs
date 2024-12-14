using Business.Requests.CarPerformanceDetail;
using Business.Responses.CarPerformanceDetail;
using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarPerformanceDetailService
    {
        IDataResult<List<ListCarPerformanceDetailResponse>> GetAll();
        IDataResult<CarPerformanceDetail> Add(CreateCarPerformanceDetailRequest request);
        IResult Delete(DeleteCarPerformanceDetailRequest request);
        IResult Update(UpdateCarPerformanceDetailRequest request);
    }
}
