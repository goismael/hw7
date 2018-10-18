using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Palindrome
{
    class Class1
    {
        static ReverseString(char[] TheWord) => Array.Reverse(TheWord);
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter your words here");
                    string text = Console.ReadLine();
                    char[] TheWord = text.ToCharArray();
                    ReverseString(TheWord);
                    foreach(char count in TheWord)
                    {
                        Console.WriteLine(count);
                        Console.WriteLine();
                    }
                    while(true)
                    {
                        Console.Write("Would you like to try again [Yes/Exit]?");
                        string response = Console.ReadLine().ToUpper();
                        if (answer == "Yes")
                            break;
                        if (response == "Exit")
                            return;
                    }

                }
                }
            catch (IndexOutOfRangeException ioe)

            {
                Console.WriteLine("Index Out of range Exception caught!");
            }
            catch (Exception ge)
            {
                Console.WriteLine("General Exception Caught!");
            }
            }
            }
    }



    

