using System;
using System.Collections.Generic;

namespace GenericLabs
{
    public class Person : EntityBase, IComparable
    {
        private readonly string _name;

        public Person(string name)
        {
            _name = name;
        }
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }

    //public class SubPerson : Person
    //{
    //    public int CompareTo(object obj)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    class Program
    {
        static void Main()
        {
            //var containerInt = new ContainerInt(10);
            //var containerString = new ContainerString("hello");
            //var containerDateTime = new ContainerDatetime(DateTime.Now);


            //var containerInt = new Container<int>(10);
            //var containerString = new Container<string>("hello");
            //var containerDateTime = new Container<DateTime>(DateTime.Now);
            //var containerPerson = new Container<Person>(new Person("ahmed"));
            //var containerV2 = new ContainerV2();
            //containerV2.Display<int>("hello", 2);

            var containerString = new Container<string>("hello");
            var value = containerString.Value;

            //var containerObject = new Container<object>(new object());
            IContainer<string> icontainerString = (IContainer<string>)containerString;
            //IContainer<object> containerObject = icontainerString;
            // interface type derived => inteface type base
            var utilities = new Utilities();
            IContainer<object> containerObject = new Container<object>(new object());
            icontainerString = containerObject;
            var result = utilities.Max<double>(3.5, 5.23);





            var list = GetInitializedList<string>("cat", 5);
            var listInt = GetInitializedList<int>(5, 3);
            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }
        }

        static List<T> GetInitializedList<T>(T defaultValue, int count)
        {
            List<T> list = new List<T>();
            AddItems(defaultValue, count, list);
            return list;
        }

        private static void AddItems<T>(T defaultValue, int count, List<T> list)
        {
            for (int i = 0; i < count; i++)
            {
                list.Add(defaultValue);
            }
        }
    }
}
