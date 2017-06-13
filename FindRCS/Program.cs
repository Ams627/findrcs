using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindRCS
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                var document = XDocument.Load(@"s:\test.xml");
                //var elems = document.Descendants("F").Where(x =>x.Descendants("FF").Where(g=>g.Attribute("fm").Value == "00001").Any());
                var elems = document.Descendants("FlowData");//.Where(x => x.Descendants("FF").Any());
                var count = elems.Count();
                Console.WriteLine("");
            }
            catch (Exception ex)
            {
                var codeBase = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
                var progname = Path.GetFileNameWithoutExtension(codeBase);
                Console.Error.WriteLine(progname + ": Error: " + ex.Message);
            }

        }
    }
}
