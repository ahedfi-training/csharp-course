using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumLabs
{
    partial class Program
    {
        static void Main(string[] args)
        {
            const int Gold = 1;
            const int Silver = 2;
            const int Bronze = 3;

            var userMemeberType = MemberType.Gold;

            Console.WriteLine("MemberType.Gold value = " + (byte)userMemeberType);
            CalcDeduction(userMemeberType);
        }

        static double CalcDeduction(MemberType memberType)
        {
            double deduction = 0;

            if (memberType == MemberType.Gold)
            {
                deduction = 15;
            }
            else if (memberType == MemberType.Silver)
            {
                deduction = 10;
            }
            else if (memberType == MemberType.Bronze)
            {
                deduction = 5;
            }

            return deduction;
        }
    }
}
