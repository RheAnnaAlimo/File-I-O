using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {

        static void Main(string[] args)
        {
            string path = File.ReadAllText("C:\\Devil.txt");

            Console.WriteLine(path); // display file on console

            Console.WriteLine("Characters: " + path.Length); // total characters

            Console.WriteLine("Total Lines (with whitespace) : " + (path.Split('\n').Length));  // total lines

            Console.WriteLine("Total Words: " + path.Split(' ').Length); // total words

            int count = 0;

            if (string.IsNullOrEmpty(path) == true)
            {
                count++;
                Console.WriteLine(count);
            }

        }
    }
}


  