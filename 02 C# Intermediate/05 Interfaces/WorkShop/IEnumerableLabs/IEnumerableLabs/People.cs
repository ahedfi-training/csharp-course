using System.Collections;
using System.Collections.Generic;

namespace IEnumerableLabs
{
    class People : IEnumerable<Person>
    {
        public People(Person[] people)
        {
            this.people = people;
        }
        Person[] people;
        public IEnumerator<Person> GetEnumerator()
        {
            for (int index = 0; index < people.Length; index++)
            {
                yield return people[index];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
