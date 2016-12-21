using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyFileTransfer
{
    class Program
    {
        private static DateTime dd;
        private static string path = @"C:\Users\Student\Desktop\Folder A";
        private static string destination = @"C:\Users\Student\Desktop\Folder B\";

        static void Main(string[] args)
        {
            if (Directory.Exists(path))
            {
                ProcessDirectory(path);
            }
        }

        public static void ProcessDirectory(string path)
        {
            string[] files = Directory.GetFiles(path);
            foreach (string fileName in files)
            {              
                ProcessFile(fileName);
            }
        }

        public static void ProcessFile(string fileName)
        {
            DateTime now = DateTime.Now;
            DateTime dd = now.Subtract(new TimeSpan(1, 0, 0, 0));
            DateTime dt = File.GetLastAccessTime(fileName);
            if (dt > dd)
            {
                var fileInfo = new FileInfo(fileName);
                fileInfo.MoveTo(destination + Path.GetFileName(fileName));
            }
        }

    }
}
