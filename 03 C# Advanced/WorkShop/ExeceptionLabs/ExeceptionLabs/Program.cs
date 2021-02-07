using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeceptionLabs
{
   
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var fileManager = new FileManager.FileManager();
                fileManager.Process();
            }
            catch(ApplicationException e)
            {

            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry, unexcepted error.");
            }
           ///

        }
    }
}
