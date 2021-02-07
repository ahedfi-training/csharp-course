using System;
using System.Text.RegularExpressions;

namespace RegexLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Step 1: create new Regex.
            //Regex regex = new Regex(@"\d+");

            //// Step 2: call Match on Regex instance.
            //Match match = regex.Match("a550a");

            //// Step 3: test for Success.
            //if (match.Success)
            //{
            //    Console.WriteLine("MATCH VALUE: " + match.Value);
            //}

            // Part 1: the input string.
            //string input = "/content/alternate-1.aspx";

            //// Part 2: call Regex.Match.
            //Match match = Regex.Match(input, @"content/([A-Za-z0-9\-]+)\.aspx$");

            //// Part 3: check the Match for Success.
            //if (match.Success)
            //{
            //    // Part 4: get the Group value and display it.
            //    string key = match.Groups[1].Value;
            //    Console.WriteLine(key);
            //}

            string test = "xxyy";

            // Match the start of a string.
            //if (Regex.IsMatch(test, "^xx"))
            //{
            //    Console.WriteLine("START MATCHES");
            //}

            //// Match the end of a string.
            //if (Regex.IsMatch(test, "yy$"))
            //{
            //    Console.WriteLine("END MATCHES");
            //}

            // string value = "4 AND 5";

            //// Step 1: get first match.
            //Match match = Regex.Match(value, @"\d");
            //if (match.Success)
            //{
            //    Console.WriteLine(match.Value);
            //}

            //// Step 2: get second match.
            //match = match.NextMatch();
            //if (match.Success)
            //{
            //    Console.WriteLine(match.Value);
            //}

            // Replace 2 or more digit pattern with a string.
            Regex regex = new Regex(@"\d+");
            //string result = regex.Replace("cat 123 456", "bird");
            var result = Regex.Replace("cat 123 456", @"\d+", "dog");
            Console.WriteLine("RESULT: {0}", result);
        }


        void Main2()
        {
            // Part 1: the input string.
            string input = "/content/alternate-1.aspx";

            // Part 2: call Regex.Match.
            Match match = Regex.Match(input, @"content/([A-Za-z0-9\-]+)\.aspx$",
                RegexOptions.IgnoreCase);

            // Part 3: check the Match for Success.
            if (match.Success)
            {
                // Part 4: get the Group value and display it.
                string key = match.Groups[1].Value;
                Console.WriteLine(key);
            }
        }
        void Main3()
        {
            string test = "xxyy";

            // Match the start of a string.
            if (Regex.IsMatch(test, "^xx"))
            {
                Console.WriteLine("START MATCHES");
            }

            // Match the end of a string.
            if (Regex.IsMatch(test, "yy$"))
            {
                Console.WriteLine("END MATCHES");
            }
        }

        void Main4()
        {
            string value = "4 AND 5";

            // Step 1: get first match.
            Match match = Regex.Match(value, @"\d");
            if (match.Success)
            {
                Console.WriteLine(match.Value);
            }

            // Step 2: get second match.
            match = match.NextMatch();
            if (match.Success)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
