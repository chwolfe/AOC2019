using System;
using System.Collections;
using System.IO;
using System.Linq;

namespace AOC2019
{
    class DayTwo
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllText("C:\\Users\\cjw\\Source\\Repos\\AOC2019\\input.txt").Split(','); //"1,1,1,4,99,5,6,0,99".Split(',');

            Console.WriteLine(runAlgo(input, 12, 2)); // part a 

            int possibleNoun = 0;
            int possibleVerb = 0; 


            for (possibleNoun = 0; possibleNoun < 99; possibleNoun++)
            {
                for (possibleVerb = 0; possibleVerb < 99; possibleVerb++)
                {
                    int output = runAlgo(input, possibleNoun, possibleVerb);

                    if (output == 19690720)
                    {
                        Console.WriteLine(100 * possibleNoun + possibleVerb); //part b
                        return;
                    }
                }
            }

        }

        private static int runAlgo(string[] input, int noun, int verb)
        {
            int[] inputArray = new int[input.Length];

            for (int ct = 0; ct < input.Length; ct++)
            {
                inputArray[ct] = (int.Parse(input[ct]));
            }

            inputArray[1] = noun;
            inputArray[2] = verb;

            for (int index = 0; index < inputArray.Length; index++)
            {
                int cur = inputArray[index];

                if (index % 4 == 0)
                {
                    if (cur == 99)
                    {
                        break;
                    }

                    if (cur == 1)
                    {
                        inputArray[inputArray[index + 3]] = inputArray[inputArray[index + 1]] + inputArray[inputArray[index + 2]];
                    }

                    if (cur == 2)
                    {
                        inputArray[inputArray[index + 3]] = inputArray[inputArray[index + 1]] * inputArray[inputArray[index + 2]];
                    }

                }
            }

            return inputArray[0];
        }
    }
}
