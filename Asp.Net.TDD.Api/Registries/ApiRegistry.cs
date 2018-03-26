using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp.Net.TDD.Api.Registries
{
    public class ApiRegistry : Registry
    {
        public ApiRegistry()
        {
            Scan(s =>
            {
                s.TheCallingAssembly();
                s.WithDefaultConventions();
            });
        }
    }
}