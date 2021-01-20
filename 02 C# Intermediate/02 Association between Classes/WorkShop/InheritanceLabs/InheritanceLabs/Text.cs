using System;

namespace InheritanceLabs
{
    public class Text : PersentationObject
    {
        public string Color;
        public string Font;

        public void AddHyperLink(string url)
        {
            Console.WriteLine("hyperlink was added to " + url);
        }
    }
}
