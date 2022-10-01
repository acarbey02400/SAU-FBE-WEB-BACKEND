using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.DependencyResolves.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)  
        {
          
            //SingleInstance ben ekledim
            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();
            builder.RegisterType<AcademicDegreeManager>().As<IAcademicDegreeService>();
            builder.RegisterType<EfAcademicDegreeDal>().As<IAcademicDegreeDal>();
            builder.RegisterType<AnnouncementCategoryManager>().As<IAnnouncementCategoryService>();
            builder.RegisterType<EfAnnouncementCategoryDal>().As<IAnnouncementCategoryDal>();
            builder.RegisterType<AnnouncementManager>().As<IAnnouncementService>();
            builder.RegisterType<EfAnnouncementDal>().As<IAnnouncementDal>();
            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();
            builder.RegisterType<PositionManager>().As<IPositionService>();
            builder.RegisterType<EfPositionDal>().As<IPositionDal>();
            builder.RegisterType<PrelectorPositionManager>().As<IPrelectorPositionService>();
            builder.RegisterType<EfPrelectorPositionDal>().As<IPrelectorPositionDal>();
            builder.RegisterType<PrelectorManager>().As<IPrelectorService>();
            builder.RegisterType<EfPrelectorDal>().As<IPrelectorDal>();
            builder.RegisterType<ProgramManager>().As<IProgramService>();
            builder.RegisterType<EfPorgramDal>().As<IProgramDal>();
            builder.RegisterType<UserTypeManager>().As<IUserTypeService>();
            builder.RegisterType<EfUserTypeDal>().As<IUserTypeDal>();
            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
