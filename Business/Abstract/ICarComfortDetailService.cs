using Business.Requests.CarComfortDetail;
using Business.Responses.CarComfortDetail;
using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarComfortDetailService
    {
        IDataResult<List<ListCarComfortDetailResponse>> GetAll();
        IDataResult<CarComfortDetail> Add(CreateCarComfortDetailRequest request);
        IResult Delete(DeleteCarComfortDetailRequest request);
        IResult Update(UpdateCarComfortDetailRequest request);
    }
}
