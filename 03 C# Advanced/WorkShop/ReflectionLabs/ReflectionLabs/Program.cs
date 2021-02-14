using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = 42;
            //System.Type type = number.GetType();
            //System.Type typev2 = typeof(int);

            Assembly pluginAssembly = Assembly.Load("ReflectionLabs");
            var plugins = from type in pluginAssembly.GetTypes()
                          where typeof(IPlugin).IsAssignableFrom(type) && !type.IsInterface
                          select type;

            foreach (Type pluginType in plugins)
            {
                IPlugin plugin = Activator.CreateInstance(pluginType) as IPlugin;
                DumpObject(plugin.GetType(), plugin);
            }
        }

        static void DumpObject(Type type, object obj)
        {
            FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public);
            var methodsInfo = type.GetMethods(BindingFlags.Instance | BindingFlags.Public);
            foreach (FieldInfo field in fields)
            {
                if (field.FieldType == typeof(int))
                {
                    Console.WriteLine(field.GetValue(obj));
                }
            }
        }
    }
}
