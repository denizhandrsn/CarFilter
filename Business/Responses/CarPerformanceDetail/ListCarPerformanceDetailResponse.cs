﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.CarPerformanceDetail
{
    public class ListCarPerformanceDetailResponse
    {
        public int TopSpeed { get; set; }
        public string Acceleration { get; set; }
        public string UrbanConsumption { get; set; }
        public string Emmision { get; set; }
        public string PowerConsumption { get; set; }
        public int BatteryRange { get; set; }
    }
}
