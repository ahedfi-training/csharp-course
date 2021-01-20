using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            var httpCookies = new HttpCookies();
            httpCookies.Fill();
            var usrename = httpCookies.GetCookie("username");
            httpCookies.SetCookie("key", "value");

            //httpCookies["username"] = "ahedfi001";
            //Console.WriteLine(httpCookies["username"]);

            var cards = new Cards();
            //cards._elements[0] = 1;k
            Console.WriteLine(cards[0]);
        }
    }
}
