/*
 * Created by SharpDevelop.
 * User: Thiwanka Kaushal
 * Date: 11/1/2021
 * Time: 3:19 PM
 */
using System;

namespace Cryptor
{
	class Program
	{
		public const string VERSION = "1.0";
		public const string DATE = "1 Nov 2021";
		static bool includeSubfolders = false;
		
		const string ERROR_INVALID_OPTION = @"
	[-] This is not a valid entry. Press H to HELP
	[!] Press A to see ABOUT
		";
		
		public static void Main(string[] args){
				
			string method = @"";
			string path = @"";
			
			if (args.Length <= 1){
//				log.Error(ERROR_MSG, "  |  Input Error", false);
				ConsoleKeyInfo cki = Console.ReadKey();
				
				switch(cki.KeyChar.ToString().ToUpper()){
				
					case "H":
						break;
						
					case "A":
						break;
					
					default:
//						log.Exit();
						break;
				}


			}
			
			foreach (var item in args){
				
				switch(item.ToUpper()){
				
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
}