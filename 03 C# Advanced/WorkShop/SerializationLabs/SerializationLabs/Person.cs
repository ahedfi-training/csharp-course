using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace SerializationLabs
{
    [Serializable]
    public class Person 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }


    [DataContract]
    public class Employee
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}
