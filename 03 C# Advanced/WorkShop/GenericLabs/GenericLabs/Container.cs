using System;
namespace GenericLabs
{
    public class EntityBase
    {
        public int Id;
    }
    public class ContainerV2
    {
        public void Display<T>(string message, T a)
        {
            Console.WriteLine(a);
        }
    }

    public interface IContainer<in T>
    {
        T Value { get; }
    }
    public class Container<T> : IContainer<T>
        //where T : EntityBase, IComparable, new()// constraints

    {
        private string _name;
        private T _value;
        public Container(T t)
        {
            // The field has the same type as the parameter.
            this._value = t;
        }

        public T Value
        {
            get
            {
                return _value;
            }
        }

        public void Display()
        {
            //var p = new T();
            Console.WriteLine();
        }

        public bool IsValid()
        {
            return false;
        }
    }

    //public class ContainerInt
    //{
    //    private int _value;
    //    public ContainerInt(int t)
    //    {
    //        // The field has the same type as the parameter.
    //        this._value = t;
    //    }

    //    public void Display()
    //    {
    //        Console.WriteLine(_value);
    //    }

    //    public bool IsValid()
    //    {
    //        return false;
    //    }
    //}

    //public class ContainerString
    //{
    //    private string _value;
    //    public ContainerString(string t)
    //    {
    //        // The field has the same type as the parameter.
    //        this._value = t;
    //    }

    //    public void Display()
    //    {
    //        Console.WriteLine(_value);
    //    }

    //    public bool IsValid()
    //    {
    //        return false;
    //    }
    //}

    //public class ContainerDatetime
    //{
    //    private DateTime _value;
    //    public ContainerDatetime(DateTime t)
    //    {
    //        // The field has the same type as the parameter.
    //        this._value = t;
    //    }

    //    public void Display()
    //    {
    //        Console.WriteLine(_value);
    //    }

    //    public bool IsValid()
    //    {
    //        return false;
    //    }
    //}
}
