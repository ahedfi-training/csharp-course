using System;
using System.Collections.Generic;

namespace PropertiesLabs
{
    public class Person
    {
        private string _name;
        private readonly List<Person> _children = new List<Person>();
        private DateTime _birthDate;

        public void SetName(string name)
        {
            _name = name;
        }
        public string GetName()
        {
            return _name;
        }
        public Person()
        {
            Nationality = "Tunisian";
        }
        public Person(string name, DateTime birthDate)
        {
            this._name = name;
            this._birthDate = birthDate;
        }

        public void Introduce()
        {
            Name = string.Empty;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new NullReferenceException("value should not be null or empty");
                _name = value;
            }
        }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - _birthDate.Year;
            }
        }
       
        public string Nationality { get; private set; }
        /*private string _nationality
       public string Nationality
       {
           get { return _nationality; }
           set { _nationality = value; }
       }*/
    }
}
