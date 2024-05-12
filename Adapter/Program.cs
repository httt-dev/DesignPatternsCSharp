using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Sample2;

namespace Adapter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string someXml = @"<?xml version='1.0' encoding='UTF-8' standalone='yes'?>
                    <note>
                        <to>John</to>
                        <from>Jane</from>
                        <heading>Reminder</heading>
                        <body>Remember to pick me up at work!</body>
                    </note>";
            IXmlParser<Note> parser = new XmlParser<Note>();
            Note note = parser.Parser(someXml);
            Console.WriteLine(parser.ConvertToXml(note));
            
            // IJsonParser<Note> parser = new XmlToJsonAdapter<Note>();
            // Note note = parser.Parser(someXml);
            // Console.WriteLine(parser.ConvertToJson(note));
            
            // Sample 2
            // https://sourcemaking.com/
            List<IShape> shapes = new List<IShape>()
                { new LineAdapter(new LegacyLine()), new RectangleAdapter(new LegacyRectangle()) };

            int x1 = 5, y1 = 10, x2 = -3, y2 = 2;
            
            shapes.ForEach(shape => shape.Draw(x1,x2,y1,y2));
            
        }
    }
}