using Autofac;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Infrastructure
{
    public class InfrastructureRegistrationModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            var dataAccess = Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(dataAccess)
                    .Where(t => t.Name.EndsWith("Service"))
                    .AsImplementedInterfaces();
        }

       
    }
}
