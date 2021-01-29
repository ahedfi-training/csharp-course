using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaceLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            var moveableObj = new MoveableOject();
            //moveableObj.Move();
            ILeft left = moveableObj;
            left.Move();

            ((ILeft)moveableObj).Move();
            ((IRight)moveableObj).Move();
        }
    }
}
