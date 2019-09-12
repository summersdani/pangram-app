using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PanGramApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your verse...");
            string inputVal = Console.ReadLine().ToUpper();
            
            Dictionary<char, int> letterList = new Dictionary<char, int>();
            var message = string.Empty;

            for (int i = 0; i < inputVal.Length; i++)
            {
                if (Char.IsLetter(inputVal[i]))
                {
                    if (letterList.ContainsKey(inputVal[i]))
                    {
                        letterList[inputVal[i]]++;
                    }
                    else
                    {
                        letterList.Add(inputVal[i], 1);
                    }

                    if (letterList.Keys.Count() == 26)
                    {
                        if (letterList.Values.Distinct().Count() == 1)
                        {
                            message = "Congrats! This is a PERFECT Pangram!";
                        }
                        else
                        {
                            message = "This is a Pangram, but not a perfect one :(";
                        }
                    }
                    else
                    {
                        message = "Sorry, this is not a Pangram.";
                    }
                }
            }
            Console.WriteLine(message);

            Console.WriteLine("Press enter to quit.");
            Console.ReadLine();
            
        }
    }
}
