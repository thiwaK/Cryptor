/*
 * Created by SharpDevelop.
 * User: Thiwanka Kaushal
 * Date: 11/1/2021
 * Time: 3:19 PM
 */

using Colorful;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        	Print.Help();
	
            string method = @"";
            string path = @"";
            

            if (args.Length <= 1)
            {
                ConsoleKeyInfo cki = Console.ReadKey();
                switch (cki.KeyChar.ToString().ToUpper())
                {
                    case "H":
                        break;

                    case "A":
                        break;

                    default:
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

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
        
        
    }
    
    static class Print{
    	
    	public static void Help()
		{
			Console.Clear();
			Console.Title = "Cryptor  |  Help";
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("");
			Console.ForegroundColor = Color.Red;
			Console.WriteLine("\t\t\t\t\t\t     C R Y P T O R    ");
			Console.ForegroundColor = Color.White;
			Console.WriteLine("\t\t\t\t\t\t=======================");
			Console.ForegroundColor = Color.Magenta;
			Console.WriteLine("");
			Console.WriteLine(String.Format("\t\t\tCRYPTOR {0} x86   Copyright (C) 2018 Thiwanka Kaushal   {1}\n", Program.VERSION, Program.DATE));

			Console.ForegroundColor = Color.DarkGray;
			Console.WriteLine("");
			Console.WriteLine("\tUsage:");
			Console.ForegroundColor = Color.White;
			Console.WriteLine("\t\tcryptor [path] [action] [options]");
			
			Console.ForegroundColor = Color.DarkGray;
			Console.WriteLine("");
			Console.WriteLine("\tArguments:");
			Console.ForegroundColor = Color.White;
			Console.WriteLine("\t\t[<path>]\tdirectory or path you want to encrypt or decrypt");
			Console.WriteLine("\t\t[action]\tencrypt or decrypt");

			Console.ForegroundColor = Color.DarkGray;
			Console.WriteLine("");
			Console.WriteLine("\tOptions:");
			Console.ForegroundColor = Color.White;
			Console.WriteLine("\t\t-e\tencrypt content");
			Console.WriteLine("\t\t-d\tdecrypt content");
			Console.WriteLine("\t\t-o\tsave output to (<directory> or a <file> based on your input)");
			Console.WriteLine("\t\t-d\tdelete sources after complete the process. (fast)");
			Console.WriteLine("\t\t-w\tsecure delete sources after complete the process. (slow)");
			
			Console.ForegroundColor = Color.DarkGray;
			Console.WriteLine("");
			Console.WriteLine("\tOptions: when working with directory");
			Console.ForegroundColor = Color.White;
			Console.WriteLine("\t\t-f\tfilter input files based on extention. use as last argument.");
			Console.WriteLine("\t\t-oe\tuse custom extention when saving outputs. valid for both actions.");
			
			Console.ForegroundColor = Color.DarkGray;
			Console.WriteLine("");
			Console.WriteLine("\tExamples:");
			Console.ForegroundColor = Color.White;
			Console.WriteLine("\t\tcryptor filename.mp4 -e -o output.mp4 -w");
			Console.WriteLine("\t\tcryptor C:\\path_to_content -e -d");
			Console.WriteLine("\t\tcryptor C:\\path_to_content -e -o C:\\encrypted_data -f *.mp4 *.mkv");
			Console.WriteLine("\t\tcryptor C:\\path_to_content -d -o C:\\decrypted_data");
			
			Console.ReadKey();


		}
    
		public static void Logo()
		{
        	                                         
            List<char> @chars = new List<char>(){
                '\n','	','	','	',' ','.','.','.','.','.',
				'.',' ',' ','.','.','.','.','.','.',' ',
				' ',' ','.','.',' ',' ',' ',' ','.','.',
				' ',' ','.','.','.','.','.','.',' ',' ',
				' ','.','.','.','.','.','.','.','.',' ',
				' ',' ','.','.','.','.','.','.',' ',' ',
				' ','.','.','.','.','.','.',' ',' ','\n',
				'	','	','	','.','.',' ',' ',' ',' ',' ',
				' ',' ','.','.',' ',' ',' ','.','.',' ',
				' ',' ','.','.',' ',' ','.','.',' ',' ',
				' ','.','.',' ',' ',' ','.','.',' ',' ',
				' ',' ',' ','.','.',' ',' ',' ',' ',' ',
				'.','.',' ',' ',' ',' ','.','.',' ',' ',
				'.','.',' ',' ',' ','.','.',' ','\n','	',
				'	','	','.','.',' ',' ',' ',' ',' ',' ',
				' ','.','.','.','.','.','.',' ',' ',' ',
				' ',' ','.','.','.','.',' ',' ',' ',' ',
				'.','.','.','.','.','.',' ',' ',' ',' ',
				' ',' ','.','.',' ',' ',' ',' ',' ','.',
				'.',' ',' ',' ',' ','.','.',' ',' ','.',
				'.','.','.','.','.',' ',' ','\n','	','	',
				'	','.','.',' ',' ',' ',' ',' ',' ',' ',
				'.','.',' ',' ',' ','.','.',' ',' ',' ',
				' ',' ','.','.',' ',' ',' ',' ',' ','.',
				'.',' ',' ',' ',' ',' ',' ',' ',' ',' ',
				' ','.','.',' ',' ',' ',' ',' ','.','.',
				' ',' ',' ',' ','.','.',' ',' ','.','.',
				' ',' ',' ','.','.',' ','\n','	','	','	',
				' ','.','.','.','.','.','.',' ',' ','.',
				'.',' ',' ',' ','.','.',' ',' ',' ',' ',
				' ','.','.',' ',' ',' ',' ',' ','.','.',
				' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',
				'.','.',' ',' ',' ',' ',' ',' ','.','.',
				'.','.','.','.',' ',' ',' ','.','.',' ',
				' ',' ','.','.',' ',
            };
			
			
            Random r = new Random();
            int rInt = r.Next(176, 255);
            for (var i = 0; i < chars.Count; i++)
            {
                if(chars[i] == '.')
                    chars[i] = (char)rInt;
                
            }

            //Console.WriteWithGradient(chars, Color.Yellow, Color.Fuchsia, 14);
            //Console.WriteWithGradient(chars, ColorTranslator.FromHtml("#ee9ca7"), ColorTranslator.FromHtml("#ffdde1"), 14);
            Console.WriteWithGradient(chars, Color.WhiteSmoke, Color.Black, 14);
            
        }

        public static void About()
		{

			Console.Clear();
			Console.Title = "Cryptor v1.0 | About";
			Console.WriteLine("\n");
			Logo();
			Console.WriteLine("\n");

            StyleSheet styleSheet = new StyleSheet(Color.White);
            styleSheet.AddStyle("═|║|╔|╗|╝|╚|╩|╦", Color.White);
 			styleSheet.AddStyle("Version|Compiled|Source|License|on", Color.White);
            
            Console.WriteLineStyled(@"
            
				      [ CRYPTOR File Encryptor & Decryptor ]
            
					    Written by Thiwanka Kaushal
            
            
	                       ╔═════════════╦═══════════════════════════════════╗
	                       ║ Version     ║ v" + Program.VERSION + @"                              ║
	                       ║             ║                                   ║
	                       ║ Compiled on ║ " + Program.DATE + @"                       ║
	                       ║             ║                                   ║
	                       ║ Source      ║ https://github.com/thiwaK/Cryptor ║
	                       ║             ║                                   ║
	                       ║ License     ║ Apache-2.0                        ║
	                       ╚═════════════╩═══════════════════════════════════╝
            ", styleSheet);

        }
    }
}