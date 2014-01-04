using System;
using System.Web;
using System.Reflection;
using System.Configuration;

namespace LI.Collaborate.Data.NH.Utils
{
    public sealed class DataProviderInitializer
    {
        private String assemblyName;
        private Assembly assembly;
        private static readonly Object mutex = new Object();


        public DataProviderInitializer()
        {
            assemblyName = ConfigurationManager.AppSettings["DAL"];
            assembly = Assembly.Load(assemblyName);
        }

        /// <summary>
        /// 使用反射创建普通实例
        /// </summary>
        /// <typeparam name="T">被反射对象实现的接口</typeparam>
        /// <param name="className">被创建实例的类名</param>
        /// <returns>被反射对象实现的接口</returns>
        public T CreateInstance<T>(String className)
        {
            String fullyQualifiedName = assemblyName + "." + className;
            T instance = (T)HttpRuntime.Cache[fullyQualifiedName];

            if (instance == null)
            {
                lock (DataProviderInitializer.mutex)
                {
                    if (instance == null)
                    {
                        instance = (T)assembly.CreateInstance(fullyQualifiedName);
                        HttpRuntime.Cache.Insert(fullyQualifiedName, instance);
                    }
                }
            }

            return instance;
        }

        /// <summary>
        /// 使用反射创建泛型实例
        /// </summary>
        /// <typeparam name="T">被反射对象实现的接口</typeparam>
        /// <param name="className">被创建实例的类名</param>
        /// <param name="typeArguments">创建泛型实例所需的一个或多个泛型类型</param>
        /// <returns>被反射对象实现的接口</returns>
        public T CreateInstance<T>(String className, params Type[] typeArguments)
        {
            String fullyQualifiedName = assemblyName + "." + className;
            T instance = (T)HttpRuntime.Cache[fullyQualifiedName];

            if (instance == null)
            {
                lock (DataProviderInitializer.mutex)
                {
                    if (instance == null)
                    {
                        Type genericType = Assembly.Load(assemblyName)
                            .GetType(fullyQualifiedName)
                            .MakeGenericType(typeArguments);
                        instance = (T)Activator.CreateInstance(genericType);

                        HttpRuntime.Cache.Insert(fullyQualifiedName, instance);
                    }
                }
            }

            return instance;
        }
    }
}
