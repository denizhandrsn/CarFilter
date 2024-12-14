using Business.Requests.CarGeneralDetail;
using Business.Requests.CarInteriorDetail;
using Business.Responses.CarGeneralDetail;
using Business.Responses.CarInteriorDetail;
using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarInteriorDetailService
    {
        IDataResult<List<ListCarInteriorDetailResponse>> GetAll();
        IDataResult<CarInteriorDetail> Add(CreateCarInteriorDetailRequest request);
        IResult Delete(DeleteCarInteriorDetailRequest request);
        IResult Update(UpdateCarInteriorDetailRequest request);
    }
}
