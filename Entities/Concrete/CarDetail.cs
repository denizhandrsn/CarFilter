using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete;

public class CarDetail:IEntity
{
    public int Id { get; set; }
    public int CarGeneralDetailId { get; set; }
    public int CarPerformanceDetailId { get; set; }
    public int CarSafetyDetailId { get; set; }
    public int CarComfortDetailId { get; set; }
    public int CarInteriorDetailId { get; set; }
    public int CarExteriorDetailId { get; set; }
    //[ForeignKey("Id")]
    public CarGeneralDetail CarGeneralDetail { get; set; }
    public CarSafetyDetail CarSafetyDetail { get; set; }
    public CarPerformanceDetail CarPerformanceDetail { get; set; }
    public CarComfortDetail CarComfortDetail { get; set; }
    public CarInteriorDetail CarInteriorDetail { get; set; }
    public CarExteriorDetail CarExteriorDetail { get; set; }
}
