using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;
using System.Diagnostics;

namespace Execute_Caller
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string targetFile = "";
            Process executibleFile = new Process();
            targetFile = ConfigurationManager.AppSettings["Name"];
            try
            {
                executibleFile.StartInfo.UseShellExecute = true;
                executibleFile.StartInfo.FileName = targetFile;
                executibleFile.Start();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
