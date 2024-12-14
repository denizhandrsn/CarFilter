using Business.Requests.CarDetail;
using Business.Responses.CarDetail;
using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarDetailService
    {
        IDataResult<List<ListCarDetailResponse>> GetAll();
        IDataResult<CarDetail> Add(CreateCarDetailRequest request);
        IResult Delete(DeleteCarDetailRequest request);
        IResult Update(UpdateCarDetailRequest request);
    }
}
