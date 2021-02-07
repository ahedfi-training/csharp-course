using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public class Container : IDisposable
    {
        public void Dispose()
        {

        }
    }
    public class FileManager
    {
        public void Process()
        {
            var fileinfo = new FileInfo(@"c:\Temp\folder\path.txt");

            //try
            //{
            //    using (var fileStream = fileinfo.Open(FileMode.Open))
            //    {
            //        using(var steamReader = new StreamReader(fileStream))
            //        {
            //            using (var container = new Container()) {
            //                Read(steamReader);
            //                return;
            //            }
            //        }
            //    }
            //}
            var fileStream = fileinfo.Open(FileMode.Open);
            var steamReader = new StreamReader(fileStream);
            try
            {
                Read(steamReader, 0);
                // check validation rules
                throw new ApplicationException("Validation Error");
                return;
            }
            catch (ArithmeticException e)
            {

            }
            catch (Exception e)
            {
                // Log exception into file : Log4Net/Serilog
                // Log.Error(e);

                //throw;
                //throw e;
                //throw new Exception("error");
            }
            finally
            {
                fileStream.Dispose();
                steamReader.Dispose();
            }
        }

        private static void Read(StreamReader steamReader, int number)
        {
            while (!steamReader.EndOfStream)
            {
                Console.WriteLine(steamReader.ReadLine());
            }
            var result = 10 / number;
            throw new Exception("Read");

        }
    }
}
