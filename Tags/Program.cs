using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Tags
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WindowWidth = 150;
            string str = @"Vítr skoro nefouká a tak by se na první pohled mohlo zdát, že se <capital>balónky</capital> snad vůbec nepohybují.
Jenom tak klidně levitují ve vzduchu.
Jelikož slunce jasně září a na obloze byste od východu k západu hledali mráček marně, balónky působí jako jakási fata morgána uprostřed pouště.";

            char[] ch = str.ToCharArray();


            /*
< capital ></ capital >
< hide ></ hide >
< red ></ red >
< blue ></ blue >
< backwhite ></ backwhite >
*/






            //string output = str.Replace("balónky", "balónky".ToUpper());
            Regex regCapital = new Regex(@"\<(?:capital)\>.+\<\/(?:capital)\>$");           //změní písmo na CAPS ON
            Regex regHide = new Regex(@"\<(?:hide)\>.+\<\/(?:hide)\>$");                    //přepíše písmo na ****
            Regex regRed = new Regex(@"\<(?:red)\>.+\<\/(?:red)\>$");                       //změní barvu písma na červenou
            Regex regBlue = new Regex(@"\<(?:blue)\>.+\<\/(?:blue)\>$");                    //změní barvu písma na modrou
            Regex regBackwhite = new Regex(@"\<(?:backwhite)\>.+\<\/(?:backwhite)\>$");     //změní barvu pozadí písma na bílou a zároveň barvu písma na černou




            //int i = source.IndexOf(toRemove);
            //int i = str.IndexOf("první");

            //if (regCapital.IsMatch(str))
            //{
            //    MatchCollection www = regCapital.Matches(str);
            //    //int ii = str.IndexOf();
            //}

            //----------------------


            MatchCollection CapitalMatch = regCapital.Matches(ch.ToString());
            MatchCollection HideMatch = regHide.Matches(ch.ToString());
            MatchCollection RedMatch = regRed.Matches(ch.ToString());
            MatchCollection BlueMatch = regBlue.Matches(ch.ToString());
            MatchCollection BackwhiteMatch = regBackwhite.Matches(ch.ToString());


            foreach (char item in ch)
            {
                if (regCapital.IsMatch(str))
                {

                }
            }




            foreach (Match item in CapitalMatch)
            {
                if (regCapital.IsMatch(str))
                {
                    str = str.Replace(item.Value, RemoveSyntaxOfTag(item.Value, "capital"));

                }
            }

            Console.WriteLine(str);

        }
        public static string RemoveSyntaxOfTag(string text, string NameOfTag)
        {
            text = text.Replace($"<{NameOfTag}>", "");
            text = text.Replace($"</{NameOfTag}>", "");

            return text;
        }


    }
}
