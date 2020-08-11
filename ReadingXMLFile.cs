using System;
using static.System.Console;

namespace XMLRead
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
			XDocument doc = XDocument.Load(filePath);
			var root= doc.Elements("Lines");
			Debug.Assert(root != null,
				"Document is empty");

			foreach(var element in root.Elements())
			{
				var idAttribute = element.Attribute("id")
				Debug.Assert(idAttribute != null,
					"idAttribute != null");
				var line =
				"value"+element.Value +
				", id"+idAttribute.Value;
				WriteLine(line);
			}			
			//printed 
			//value: one id: 1
			//value: two id: 2
	}
}