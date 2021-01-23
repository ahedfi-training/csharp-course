using System;
using System.Collections;
using System.Collections.Generic;

namespace BoxingUnboxingLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 10;
            ArrayList arrayList = new ArrayList(); // Should not be used
            arrayList.Add(number); // boxing : statck -> heap
            arrayList.Add("john");
            arrayList.Add(2.3); // boxing: 

            int newNumber = (int)arrayList[0]; // unboxing : heap -> stack

            var list = new List<int>(); //Solution : use generic list
            list.Add(number);

            newNumber = list[0];
        }
    }
}
