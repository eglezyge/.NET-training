using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WinFormsApp1
{
    public class Logic
    {
        public static void NewFolder()
        {
            string rootPath = @"C:\Users\VM\Desktop\Kokosa";
            Directory.CreateDirectory(rootPath + @"\test");
        }
    }
}
