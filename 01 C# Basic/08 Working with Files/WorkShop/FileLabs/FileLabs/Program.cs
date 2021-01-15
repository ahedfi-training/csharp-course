using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLabs
{
    public class Demo
    {
        public void DisplyMsg()
        {
            Console.WriteLine("hello");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\demo\path.txt";

            var pathForInstanceMethod = @"c:\demo\pathForInstanceMethod.txt";
            // static method
           
            if (File.Exists(path))
            {
				File.Copy(path, @"c:\demo\path2.txt", true);
            }

            var content = File.ReadAllText(path);
            File.Delete(path);

            // instance methods
            var fileinfo = new FileInfo(pathForInstanceMethod);
            fileinfo.CopyTo(@"c:\demo\path2.txt", true);

            if (fileinfo.Exists)
            {
                //
            }
            fileinfo.Delete();
            #region Directory
            Directory.CreateDirectory(@"c:\temp\folderC#Demo");
            var files = Directory.GetFiles(@"c:\demo" , "*.txt" , SearchOption.AllDirectories);
            foreach (var filePath in files)
            {
                Console.WriteLine(File.ReadAllText(filePath));
            }
            #endregion
            #region Path
            //var fragments = path.Split('\\');
            //var fileName = fragments[fragments.Length - 1];
            //var extensionfragment = fileName.Split('.');
            //var extension = "." + extensionfragment[1]

            Console.WriteLine("Extension : " + Path.GetExtension(path));
            Console.WriteLine("File Name : " + Path.GetFileName(path));
            Console.WriteLine("File Name Without Extension : " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory name : " + Path.GetDirectoryName(path));
            #endregion
        }
    }
}
