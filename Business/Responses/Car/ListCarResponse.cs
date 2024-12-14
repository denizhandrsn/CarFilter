using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Responses.CarDetail;
using Entities.Concrete;
namespace Business.Responses.Car;

public class ListCarResponse
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Generation { get; set; }

    public ListCarDetailResponse ListCarDetailResponse { get; set; }
}
