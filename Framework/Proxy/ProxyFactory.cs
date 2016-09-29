using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace IDesign.Framework.Proxy
{
    public static class ProxyFactory
    {
        static Dictionary<string, string> Container = null;
        static ProxyFactory()
        {
            Container = new Dictionary<string, string>();
            Container.Add("IMenuingEngine", "OrderingEngine");
            Container.Add("IProfileAccess", "CustomerAccess");
        }

        static Type GetServiceType<I>() where I : class
        {
            string typeName = string.Empty;

            string serviceName = typeof(I).Name.Replace("I", "");
            if (Container.Keys.Contains(typeof(I).Name))
            {
                typeName = typeof(I).Namespace + "." + Container[typeof(I).Name];
            }
            else if (typeof(I).Namespace.Contains("Contract"))
            {
                typeName = typeof(I).Namespace.Replace("Contract", "Manager") + "." + serviceName;
            }
            else
            {
                typeName = typeof(I).Namespace + "." + serviceName;
            }

            Type implementationType = typeof(I).Assembly.GetType(typeName);
            Debug.Assert(implementationType != null, "You did not follow the rules...");

            return implementationType;
        }
        public static I Create<I>() where I : class
        {
            return Activator.CreateInstance(GetServiceType<I>()) as I;
        }
    }
}