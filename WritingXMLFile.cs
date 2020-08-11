using System;
using static.System.Console;

namespace XMLWrite
{ 
	class Program 
	{
		static void Main(string[] args)
		{
			//XML Example:
			//<Lines>
			//  <Line id="1">one</Line>
			//  <Line id="2">two</Line>
			//</Lines>

			var filePath =@"C:\tmp\data.xml";
			XDocument doc = new XDocument(
				new XElement("Lines",
					new XElement("Line", "one",
						new XAttribute("id", "1")),
					new XElement("Line", "two",
						new XAttribute("id", "2"))));
			doc.Save(filePath);
		}

	}
}