using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;
namespace laba3._3._2
{
    class WordCounter
    {
        static void Main()
        {
            String line;
            int count = 0;
            string counts = "";

            //Opens a file in read mode  
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\yuras\Desktop\2-Семестр\oop\laba3\laba3.3.1\input.txt");

            //Gets each line till end of file is reached  
            while ((line = file.ReadLine()) != null)
            {
                //Splits each line into words  
                String[] words = line.Split(' ');
                //Counts each word  
                count = count + words.Length;
            }
            counts += count;
            Console.WriteLine("Number of words present in given file: " + counts);
            string path = @"C:\Users\yuras\Desktop\2-Семестр\oop\laba3\laba3.3.1\output.txt";
            File.AppendAllText(path, counts);
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
    }
}

