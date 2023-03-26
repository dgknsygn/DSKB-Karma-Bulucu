using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSKB___Karma_Bulucu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "DSKB - Karma Bulucu";
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("8888888b.   .d8888b.  888    d8P  888888b.   \r\n888  \"Y88b d88P  Y88b 888   d8P   888  \"88b  \r\n888    888 Y88b.      888  d8P    888  .88P  \r\n888    888  \"Y888b.   888d88K     8888888K.  \r\n888    888     \"Y88b. 8888888b    888  \"Y88b \r\n888    888       \"888 888  Y88b   888    888 \r\n888  .d88P Y88b  d88P 888   Y88b  888   d88P \r\n8888888P\"   \"Y8888P\"  888    Y88b 8888888P\" ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nKarma Bulucu v1.0");
            Console.WriteLine("by dgknsygn");
            Console.Write("\nKarma Değeri: ");
            string AlinanDeger = Console.ReadLine();

            Console.WriteLine("\nKarma Türleri -----");

            if (AlinanDeger.Length == 32)
            {
                bool MD5 = true;

                for (int i = 0; i < 32; i++)
                {
                    string K = AlinanDeger[i].ToString();

                    if (K != "0" && K != "1" && K != "2" && K != "3" && K != "4" && K != "5" && K != "5" && K != "6" && K != "7" && K != "8" && K != "9" && K != "a" && K != "b" && K != "c" && K != "d" && K != "e" && K != "f")
                    {
                        MD5 = false;
                        break;
                    }
                }

                if (MD5)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" MD5    [+]");
                }
                else if (!MD5)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(" MD5    [-]");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(" MD5    [-]");
            }

            if (AlinanDeger.Length == 40)
            {
                bool SHA1 = true;

                for (int i = 0; i < 40; i++)
                {
                    string K = AlinanDeger[i].ToString();

                    if (K != "0" && K != "1" && K != "2" && K != "3" && K != "4" && K != "5" && K != "5" && K != "6" && K != "7" && K != "8" && K != "9" && K != "a" && K != "b" && K != "c" && K != "d" && K != "e" && K != "f")
                    {
                        SHA1 = false;
                        break;
                    }
                }

                if (SHA1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" SHA1   [+]");
                }
                else if (!SHA1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(" SHA1   [-]");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(" SHA1   [-]");
            }

            if (AlinanDeger.Length == 64)
            {
                bool SHA256 = true;

                for (int i = 0; i < 64; i++)
                {
                    string K = AlinanDeger[i].ToString();

                    if (K != "0" && K != "1" && K != "2" && K != "3" && K != "4" && K != "5" && K != "5" && K != "6" && K != "7" && K != "8" && K != "9" && K != "a" && K != "b" && K != "c" && K != "d" && K != "e" && K != "f")
                    {
                        SHA256 = false;
                        break;
                    }
                }

                if (SHA256)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" SHA256 [+]");
                }
                else if (!SHA256)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(" SHA256 [-]");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(" SHA256 [-]");
            }

            if (AlinanDeger.Length == 96)
            {
                bool SHA384 = true;

                for (int i = 0; i < 96; i++)
                {
                    string K = AlinanDeger[i].ToString();

                    if (K != "0" && K != "1" && K != "2" && K != "3" && K != "4" && K != "5" && K != "5" && K != "6" && K != "7" && K != "8" && K != "9" && K != "a" && K != "b" && K != "c" && K != "d" && K != "e" && K != "f")
                    {
                        SHA384 = false;
                        break;
                    }
                }

                if (SHA384)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" SHA384 [+]");
                }
                else if (!SHA384)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(" SHA384 [-]");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(" SHA384 [-]");
            }

            if (AlinanDeger.Length == 128)
            {
                bool SHA512 = true;

                for (int i = 0; i < 128; i++)
                {
                    string K = AlinanDeger[i].ToString();

                    if (K != "0" && K != "1" && K != "2" && K != "3" && K != "4" && K != "5" && K != "5" && K != "6" && K != "7" && K != "8" && K != "9" && K != "a" && K != "b" && K != "c" && K != "d" && K != "e" && K != "f")
                    {
                        SHA512 = false;
                        break;
                    }
                }

                if (SHA512)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" SHA512 [+]");
                }
                else if (!SHA512)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(" SHA512 [-]");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(" SHA512 [-]");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("-------------------");

            Console.ReadKey();
        }
    }
}