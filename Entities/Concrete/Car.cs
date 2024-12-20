﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete;

public class Car:IEntity
{
    public int Id { get; set; }
    public int CarDetailId { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Generation { get; set; }

    public CarDetail CarDetail { get; set; }
}
