using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = "This is supposed to be very long post blah blah blah";
            var shortnedPost = post.Shorten(5);
            System.Console.WriteLine(shortnedPost);    
        }
    }
}
