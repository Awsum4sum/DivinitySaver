using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DivinitySaver
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string dateNow = DateTime.Now.ToString();

                dateNow = dateNow.Replace('/', '-');
                dateNow = dateNow.Replace(':', '-');

                string newPath = @"D:\Divinity Saves\HonourMode - " + dateNow;

                Directory.CreateDirectory(newPath);
                File.Copy(@"C:\Users\Awsum4sum\Documents\Larian Studios\Divinity Original Sin 2\PlayerProfiles\Awsum4sum\Savegames\Story\HonourMode\HonourMode.lsv", newPath + @"\HonourMode.lsv");
                File.Copy(@"C:\Users\Awsum4sum\Documents\Larian Studios\Divinity Original Sin 2\PlayerProfiles\Awsum4sum\Savegames\Story\HonourMode\HonourMode.png", newPath + @"\HonourMode.png");
                
            }
            catch (Exception exc)
            {

            }
           

        }
        
    }
}
