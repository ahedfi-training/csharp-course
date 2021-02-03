using PhotoManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var photoFilters = new PhotoFilters();

            //PhotoProcessor.PhotoFilterHandler filterHandler = photoFilters.ApplyBrightness;
            Action<Photo> filterHandler = photoFilters.ApplyBrightness;
            filterHandler += photoFilters.ApplyContrast;
            filterHandler += photoFilters.Resize;
            filterHandler += RemoveRedEyes;

            processor.Process("photo.jpeg", filterHandler);
        }

        public static void RemoveRedEyes(Photo photo)
        {
            Console.WriteLine("Red eyes were removed.");
        }


    }
}
