using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace _201104_File_Stream
{
    class Program
    {
        static void Main(string[] args)
        {
            long someValue = 0x123456789ABCDEF0;
            Console.WriteLine("{0,-1} : 0x{1:X16}","Orinal data", someValue);

            Stream outStream = new FileStream("a.dat", FileMode.Create);
            byte[] wBytes = BitConverter.GetBytes(someValue);

            foreach (byte b in wBytes)
                Console.WriteLine("{0: X2}", b);
            Console.WriteLine();

            outStream.Write(wBytes, 0, wBytes.Length);
            outStream.Close();

            Stream inStream = new FileStream("a.dat", FileMode.Open);
            byte[] rBytes = new byte[8];

            int i =  0;

            while (inStream.Position < inStream.Length)
            {
                rBytes[i++] = (byte)inStream.ReadByte();
            }
            long readValue = BitConverter.ToInt64(rBytes, 0);
            Console.WriteLine("{0,-13} : 0x{1:x16}", "Read Data", readValue);
            inStream.Close();
        }
    }
}
