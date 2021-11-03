/*
 * Created by SharpDevelop.
 * User: Thiwanka Kaushal
 * Date: 11/1/2021
 * Time: 3:19 PM
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Serialization;
using Console = Colorful.Console;

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

                                                           
                                                           


            List<char> @chars = new List<char>()
            {
                '\t',' ',
                '.','.','.','.','.','.',' ','.','.','.',
                '.','.','.',' ',' ','.','.',' ',' ',' ',
                ' ','.','.',' ','.','.','.','.','.','.',
                ' ',' ','.','.','.','.','.','.','.','.',
                ' ',' ','.','.','.','.','.','.',' ',' ',
                '.','.','.','.','.','.',' ',' ','\n','\t','.',
                '.',' ',' ',' ',' ',' ',' ','.','.',' ',
                ' ',' ','.','.',' ',' ','.','.',' ',' ',
                '.','.',' ',' ','.','.',' ',' ',' ','.',
                '.',' ',' ',' ',' ','.','.',' ',' ',' ',
                ' ','.','.',' ',' ',' ',' ','.','.',' ',
                '.','.',' ',' ',' ','.','.',' ','\n','\t','.',
                '.',' ',' ',' ',' ',' ',' ','.','.','.',
                '.','.','.',' ',' ',' ',' ','.','.','.',
                '.',' ',' ',' ','.','.','.','.','.','.',
                ' ',' ',' ',' ',' ','.','.',' ',' ',' ',
                ' ','.','.',' ',' ',' ',' ','.','.',' ',
                '.','.','.','.','.','.',' ',' ','\n','\t','.',
                '.',' ',' ',' ',' ',' ',' ','.','.',' ',
                ' ',' ','.','.',' ',' ',' ',' ','.','.',
                ' ',' ',' ',' ','.','.',' ',' ',' ',' ',
                ' ',' ',' ',' ',' ','.','.',' ',' ',' ',
                ' ','.','.',' ',' ',' ',' ','.','.',' ',
                '.','.',' ',' ',' ','.','.',' ','\n','\t',' ',
                '.','.','.','.','.','.',' ','.','.',' ',
                ' ',' ','.','.',' ',' ',' ',' ','.','.',
                ' ',' ',' ',' ','.','.',' ',' ',' ',' ',
                ' ',' ',' ',' ',' ','.','.',' ',' ',' ',
                ' ',' ','.','.','.','.','.','.',' ',' ',
                '.','.',' ',' ',' ','.','.',' ',
            };
            Random r = new Random();
            int rInt = r.Next(128, 255);
            for (var i = 0; i < chars.Count; i++)
            {
                if(chars[i] == '.')
                    chars[i] = (char)rInt;
                
            }

            //Console.WriteWithGradient(chars, Color.Yellow, Color.Fuchsia, 14);
            Console.WriteWithGradient(chars, Color.Yellow, Color.Magenta, 14);
            
            //Console.WriteWithGradient(chars, ColorTranslator.FromHtml("#ee9ca7"), ColorTranslator.FromHtml("#ffdde1"), 14);

        }



        public static void About()
		{

			Console.Clear();
			Console.Title = "Cryptor - By Thiwanka Kaushal  |  About";
			Logo();
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
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