using Models;
using System;

namespace ModifierAccessLabs
{
    class Customer : Person
    {
        public DateTime InscriptionDate { get; set; }
        void Promote()
        {
            Console.WriteLine(this.Name);
        }
      
    }

}
