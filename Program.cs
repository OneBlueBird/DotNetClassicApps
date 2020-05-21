using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudifyClassicApps
{
    public class Program
    {
        public static void Main(string[] args)
        {
			try
			{
				Console.WriteLine("Hello classic dotnet");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Exception occurred inside Main method : " + ex.Message);
			}
        }
    }
}
