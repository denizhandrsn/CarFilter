using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFrameWork;

public class CarFilterContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=CarFilterDb;Trusted_Connection = true");
    }

    

    public DbSet<Car> Cars { get; set; }
    public DbSet<CarDetail> CarDetails { get; set; }
    public DbSet<CarComfortDetail> CarComfortDetails { get; set; }
    public DbSet<CarExteriorDetail> CarExteriorDetails { get; set; }
    public DbSet<CarGeneralDetail> CarGeneralDetails { get; set; }
    public DbSet<CarInteriorDetail> CarInteriorDetails { get; set; }
    public DbSet<CarPerformanceDetail> CarPerformanceDetails { get; set; }
    public DbSet<CarSafetyDetail> CarSafetyDetails { get; set; }



}
