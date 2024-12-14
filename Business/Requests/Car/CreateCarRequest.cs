using Business.Requests.CarDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Car
{
    public class CreateCarRequest
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Generation { get; set; }

        public CreateCarDetailRequest CreateCarDetailRequest { get; set; }
    }
}
