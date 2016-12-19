using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

//Serialization BLOB
namespace ConsoleApplication1
{
    [Serializable]
    public class SadAttempt2Blob
    {
        public string statement = "I have no idea what I'm doing";
        public string plea = "I need an adult";
        public int sense = 0;
    }
    public class everything
    {
        static void Main()
        {
            SadAttempt2Blob sab = new SadAttempt2Blob();
            sab.plea = "Please Fix Me";


            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, sab);
            stream.Close();
            Console.WriteLine(sab.statement + sab.plea + sab.sense);
            DeCerealize();
        }

        static void DeCerealize()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            SadAttempt2Blob sab = (SadAttempt2Blob)formatter.Deserialize(stream);
            stream.Close();
            Console.WriteLine(sab.plea, sab.sense);
            Console.ReadLine();
        }
    }

}





