using Business.Requests.CarGeneralDetail;
using Business.Responses.CarGeneralDetail;
using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarGeneralDetailService
    {
        IDataResult<List<ListCarGeneralDetailResponse>> GetAll();
        IDataResult<CarGeneralDetail> Add(CreateCarGeneralDetailRequest request);
        IResult Delete(DeleteCarGeneralDetailRequest request);
        IResult Update(UpdateCarGeneralDetailRequest request);
    }
}
