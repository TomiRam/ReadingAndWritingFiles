using System;
using static.System.Console;

namespace BinaryFileWrite
{ 
	class Program 
	{
		static void Main(string[] args)
		{
			
			try{
				var data = new byte[]{120,64, 97};
				var filePath=@"C:\tmp\file.out";

				File.WriteAllBytes(filePath, data);

				}catch(IOExeception e){
				Writeline(e.Message);
			}
		}

	}
}
