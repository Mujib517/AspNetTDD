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
                        s.AssembliesAndExecutablesFromApplicationBaseDirectory();
                        s.TheCallingAssembly();
                        s.WithDefaultConventions();
                    });
                });

                return container;
            }
        }

    }
}