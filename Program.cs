/*
 * Created by SharpDevelop.
 * User: Thiwanka Kaushal
 * Date: 11/1/2021
 * Time: 3:19 PM
 */

using System;
using System.Collections.Generic;

namespace Cryptor
{
    static class Program
    {
        public const string VERSION = "1.0";
        public const string DATE = "01 Nov 2021";
        static bool includeSubfolders = false;

        const string ERROR_INVALID_OPTION = @"
	[-] This is not a valid entry. Press H to HELP
	[!] Press A to see ABOUT
		";
        
        public static void Main(string[] args)
        {
        	//Print.Logo();
        	Print.About();
	
            string method = @"";
            string path = @"";
            

            if (args.Length <= 1)
            {
				//log.Error(ERROR_MSG, "  |  Input Error", false);
				Console.WriteLine(ERROR_INVALID_OPTION);
                ConsoleKeyInfo cki = Console.ReadKey();

                switch (cki.KeyChar.ToString().ToUpper())
                {
                    case "H":
                        break;

                    case "A":
                        break;

                    default:
                        //						log.Exit();
                        break;
                }
            }

            foreach (var item in args)
            {

                switch (item.ToUpper())
                {

                    case "-H":
                        break;

                    case "--HELP":
                        break;

                    case "-S":
                        break;
                }
            }


            Console.WriteLine(ERROR_INVALID_OPTION);

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
        
        
    }
    
    static class Print{
    
    	public static int s = 15; // COL
		public static int r = 4; // ROW
    	
		public static void Logo()
		{
        	
			
			string[] C = new string[]
			{

				" $$$$$$$",
				"$$      ",
				"$$      ",
				"$$      ",
				" $$$$$$$"
			};


			string[] R = new string[]
			{

				"$$$$$$$ ",
				"$$    $$",
				"$$$$$$$ ",
				"$$   $$ ",
				"$$    $$"
			};



			string[] Y = new string[]
			{
			   "$$    $$",
			   " $$  $$ ",
			   "   $$   ",
			   "   $$   ",
			   "   $$   "
			};


			string[] P = new string[]
			{
			   "$$$$$$$ ",
			   "$$    $$",
			   "$$$$$$$ ",
			   "$$      ",
			   "$$      "
			};

			string[] T = new string[]
			{
			  "$$$$$$$$$$",
			  "    $$    ",
			  "    $$    ",
			  "    $$    ",
			  "    $$    "
			};

			string[] O = new string[]
			{
			  "  $$$$$$$ ",
			  " $$     $$",
			  " $$     $$",
			  " $$     $$",
			  "  $$$$$$$ "
			};

			string[] U = new string[]
			{
			  "___________________________________________________________________"
			};


			
			WriteColoredLines(U, s + 0, 2, ConsoleColor.DarkGray);
			WriteColoredLines(C, s + 1, r, ConsoleColor.Red);
			WriteColoredLines(R, s + 10, r, ConsoleColor.Green);
			WriteColoredLines(Y, s + 19, r, ConsoleColor.Gray);
			WriteColoredLines(P, s + 28, r, ConsoleColor.Magenta);
			WriteColoredLines(T, s + 37, r, ConsoleColor.Cyan);
			WriteColoredLines(O, s + 47, r, ConsoleColor.Blue);
			WriteColoredLines(R, s + 58, r, ConsoleColor.Yellow);
			WriteColoredLines(U, s + 0, 9, ConsoleColor.DarkGray);

				
		}
    
        private static void WriteColoredLines(string[] lines, int start, int end, ConsoleColor color)
		{
			Console.ForegroundColor = color;
			for (int row = 0; row < lines.Length; row++)
			{
				Console.SetCursorPosition(start, end + row);
				Console.Write(lines[row]);
			}
		}
    
    
        public static void About()
		{

			Console.Clear();
			Console.Title = "Cryptor - By Thiwanka Kaushal  |  About";
			Logo();
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.WriteLine(@"			
			╔═════════════╦═══════════════════════════════════╗
			║ Version     ║ v" + Program.VERSION + @"                              ║
			║             ║                                   ║
			║ Compiled on ║ " + Program.DATE + @"                       ║
			║             ║                                   ║
			║ Source      ║ https://github.com/thiwaK/Cryptor ║
			║             ║                                   ║
			║ License     ║ Apache-2.0                        ║
			╚═════════════╩═══════════════════════════════════╝
			");


        }
    }
}