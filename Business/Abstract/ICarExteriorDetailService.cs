using Business.Requests.CarExteriorDetail;
using Business.Responses.CarExteriorDetail;
using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarExteriorDetailService
    {
        IDataResult<List<ListCarExteriorDetailResponse>> GetAll();
        IDataResult<CarExteriorDetail> Add(CreateCarExteriorDetailRequest request);
        IResult Delete(DeleteCarExteriorDetailRequest request);
        IResult Update(UpdateCarExteriorDetailRequest request);
    }
}
