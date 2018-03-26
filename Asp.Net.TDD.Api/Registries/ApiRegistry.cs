using Asp.Net.TDD.Api.App_Start;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.Net.TDD.Api.Registries
{
    public class ApiRegistry : Registry
    {
        internal static IContainer ApiContainer
        {
            get
            {
                var container = new Container(x =>
                {
                    x.Scan(s =>
                    {
                        s.TheCallingAssembly();
                        s.WithDefaultConventions();
                    });
                });

                DependencyResolver.SetResolver(new ApiDependencyResolver(container));
                return container;
            }
        }

    }
}