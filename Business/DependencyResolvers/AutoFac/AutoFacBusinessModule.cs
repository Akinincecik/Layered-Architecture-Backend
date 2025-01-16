using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using System.Text;
using System.Threading.Tasks;
using Business.Concrete;
using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;

namespace Business.DependencyResolvers.AutoFac
{
    public class AutoFacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();
        }
    }
}
