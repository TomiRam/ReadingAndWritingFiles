using System;
using static.System.Console;

namespace BinaryFileRead
{ 
	class Program 
	{
		static void Main(string[] args)
		{
			var filePath =@"C:\tmp\file.out";
			
			try{
				var data = 
					File.ReadAllBytes(filePath);

				}catch(IOExeception e){
				Writeline(e.Message);
			}
		}

	}
}
