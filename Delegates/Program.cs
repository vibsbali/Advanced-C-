using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();

            //Notice we did not call it just pointed to it
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEye;
            processor.Process("photo.jpg", filterHandler);
        }

        static void RemoveRedEye(Photo photo)
        {
            Console.WriteLine("Removed Red Eye");
        }
    }
}
