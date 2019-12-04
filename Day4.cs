using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Text.RegularExpressions;

namespace Day4
{
    class Day4
    {
        static void Main(string[] args)
        {
            Regex r = new Regex("(.)\\1+", RegexOptions.IgnoreCase | RegexOptions.Compiled);

            int Low = 138307;
            int High = 654504;
            //int Low = 112233;
            //int High = 112233;

            int possiblePasswordCount = 0;

            for (int x = Low; x <= High; x++)
            {
                string xStr = x.ToString();

                bool adjSame = false;              

                MatchCollection matches = r.Matches(xStr);

                foreach (Match m in matches)
                {
                    if (m.Length == 2) //comment this if statement out to run part a
                    {
                        adjSame = true;
                    }
                }

                //Original solution to find same adjacent values (used in part a initally) 

                //for (int i = 0; i < xStr.Length; i++)
                //{


                //    if (i == xStr.Length - 1)
                //    {
                //        continue;
                //    }


                //    try
                //    {
                //        if (xStr[i] == xStr[i + 1] && (xStr[i + 1] != xStr[i + 2]))
                //        {
                //            adjSame = true;
                //            break;
                //        }
                //    }
                //    catch { }


                //}

                if (!adjSame)
                {
                    continue;
                }

                bool neverDecreases = true;

                for (int i = 0; i < xStr.Length; i++)
                {
                    if (i == xStr.Length - 1)
                    {
                        continue;
                    }

                    if (int.Parse(xStr[i].ToString()) > int.Parse(xStr[i + 1].ToString()))
                    {
                        neverDecreases = false;
                        break;
                    }
                }

                if (!neverDecreases)
                {
                    continue;
                }


                possiblePasswordCount++;
            }

            Console.WriteLine(possiblePasswordCount);

        }
    }
}
