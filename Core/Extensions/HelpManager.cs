
using Core.Infrastructure;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Managers
{
    public static class HelpManager
    {
        public static int ReadInteger(string caption)
        {
        l1:
            Console.Write(caption);
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            if (!int.TryParse(Console.ReadLine(), out int value))
            {
                PrintError("Wrong!!,Try again");
                goto l1;
            }
            Console.ResetColor();
            return value;
        }
        
        public static string ReadString(string caption)
        {
        l1:


            Console.Write(caption);
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            string value = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(value))
            {
                PrintError("Wrong!!,Try again");
                goto l1;
            }
            Console.ResetColor();
            return value;
        }
        public static void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(message);
            Console.ResetColor();
        }


        public static T ReadMenu<T>(string caption) where T : struct, Enum
        {
        l1:

            Console.Write(caption);
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            if (!Enum.TryParse(Console.ReadLine(), out T m))
            {

                PrintError("You did not choose from Menu,Try again!!!");
                goto l1;
            }
            Console.ResetColor();
            return m;
        }
        public static bool FullnameChecker(string str) 
        {
            if (str.Length >= 3 && str[0].ToString() == str[0].ToString().ToUpper())
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == ' ')
                    {
                        return false;
                    }
                }
            }
            else 
                return false;


            return true;
        }
        public static bool ClassNameChecker(string className)
        {
            if (className.Length == 5)
            {

                for (int i = 0; i < className.Length - 3; i++)
                {
                    if (!(className[i] >= 65 && className[i] <= 90))
                    {
                        return false;
                    }

                }
                for (int j = className.Length - 3; j < className.Length; j++)
                {
                    if (!(className[j] >= 48 && className[j] <= 57))
                    {
                        return false;
                    }
                }

            }
            else
            {
                return false;
            }

            return true;
        }
    }
}
