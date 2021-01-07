using System;

namespace StaticLab
{
    partial class Program
    {
        //public enum Days : byte
        //{
        //    Monday = 1,
        //    Tuesday = 2,
        //    Wenesday = 3,
        //    Thursday = 4,
        //    Firday = 5,
        //    Saturday = 6,
        //    Sunday = 7
        //}

        [Flags]
        public enum Days : byte
        {
            None = 0,       //0000000
            Monday = 1,     //0000001
            Tuesday = 2,    //0000010
            Wenesday = 4,   //0000100
            Thursday = 8,   //0001000
            Firday = 16,    //0010000
            Saturday = 32,  //0100000
            Sunday = 64,    //1000000
            All = 127,      //1111111
        }




    }
}
