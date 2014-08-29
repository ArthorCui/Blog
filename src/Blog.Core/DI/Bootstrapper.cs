using OnePiece.Framework.Core;
using StructureMap;
using StructureMap.Configuration.DSL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core
{
    public class Bootstrapper
    {
        private static bool _hasBeenIntialized = false;
        internal const string CURRENT_ASSEMBLY = "Blog.Core";

        public static void Start()
        {
            if (!_hasBeenIntialized)
            {
                Register(CURRENT_ASSEMBLY);
                _hasBeenIntialized = true;
            }
        }

        #region Registry

        private static void Register(string assemblyName)
        {
            if (SingletonBase<IocFacotry>.Instance.Container == null)
            {
                SingletonBase<IocFacotry>.Instance.Container = new StructureMapContainer();
            }
            RegisterDIRegistry(assemblyName);
            SingletonBase<BootHeart>.Instance.Boot(assemblyName);
            RegisterMapper(assemblyName);
        }

        public static void RegisterBootable(Func<Assembly> getAssembly)
        {
            if (getAssembly != null)
            {
                Assembly assembly = getAssembly();
                SingletonBase<BootHeart>.Instance.Boot(assembly.FullName);
            }
        }

        private static void RegisterDIRegistry(Func<Assembly> getAssembly)
        {
            if (getAssembly != null)
            {
                List<Type> source = (from x in getAssembly().GetTypes()
                                     where x.IsSubclassOf(typeof(BasicRegistry)) && !x.IsAbstract
                                     select x).ToList<Type>();
                if (source.Any<Type>())
                {
                    source.ForEach(delegate(Type t)
                    {
                        Action<ConfigurationExpression> configure = null;
                        Registry instance = Activator.CreateInstance(t) as Registry;
                        if (instance != null)
                        {
                            if (configure == null)
                            {
                                configure = x => x.AddRegistry(instance);
                            }
                            ObjectFactory.Configure(configure);
                        }
                    });
                }
            }
        }

        internal static void RegisterDIRegistry(string assemblyName)
        {
            List<Type> source = (from x in Assembly.Load(assemblyName).GetTypes()
                                 where x.IsSubclassOf(typeof(BasicRegistry)) && !x.IsAbstract
                                 select x).ToList<Type>();
            if (source.Any<Type>())
            {
                source.ForEach(delegate(Type t)
                {
                    Action<ConfigurationExpression> configure = null;
                    Registry instance = Activator.CreateInstance(t) as Registry;
                    if (instance != null)
                    {
                        if (configure == null)
                        {
                            configure = x => x.AddRegistry(instance);
                        }
                        ObjectFactory.Configure(configure);
                    }
                });
            }
        }

        internal static void RegisterMapper(string assembly)
        {
            SingletonBase<EntityMapping>.Instance.Register(assembly);
        }

        #endregion
    }
}
