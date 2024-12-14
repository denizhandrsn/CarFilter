using Business.Requests.Car;
using Business.Responses.Car;
using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> Add(CreateCarRequest request);
        IResult Delete(DeleteCarRequest request);
        IResult Update(UpdateCarRequest request);
    }
}
