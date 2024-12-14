using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.AutoFac
{
    public class AutoFacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EfCarComfortDetailDal>().As<ICarComfortDetailDal>().SingleInstance();
            builder.RegisterType<CarComfortDetailManager>().As<ICarComfortDetailService>().SingleInstance();

            builder.RegisterType<EfCarDal>().As<ICarDal>().SingleInstance();
            builder.RegisterType<CarManager>().As<ICarService>().SingleInstance();

            builder.RegisterType<EfCarDetailDal>().As<ICarDetailDal>().SingleInstance();
            builder.RegisterType<CarDetailManager>().As<ICarDetailService>().SingleInstance();

            builder.RegisterType<EfCarSafetyDetailDal>().As<ICarSafetyDetailDal>().SingleInstance();
            builder.RegisterType<CarSafetyDetailManager>().As<ICarSafetyDetailService>().SingleInstance();

            builder.RegisterType<EfCarGeneralDetailDal>().As<ICarGeneralDetailDal>().SingleInstance();
            builder.RegisterType<CarGeneralDetailManager>().As<ICarGeneralDetailService>().SingleInstance();

            builder.RegisterType<EfCarPerformanceDetailDal>().As<ICarPerformanceDetailDal>().SingleInstance();
            builder.RegisterType<CarPerformanceDetailManager>().As<ICarPerformanceDetailService>().SingleInstance();

            builder.RegisterType<EfCarInteriorDetailDal>().As<ICarInteriorDetailDal>().SingleInstance();
            builder.RegisterType<CarInteriorDetailManager>().As<ICarInteriorDetailService>().SingleInstance();

            builder.RegisterType<EfCarExteriorDetailDal>().As<ICarExteriorDetailDal>().SingleInstance();
            builder.RegisterType<CarExteriorDetailManager>().As<ICarExteriorDetailService>().SingleInstance();



        }
    }
}
