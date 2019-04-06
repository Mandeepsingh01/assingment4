using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingment4

{
    class Program
    {
        ArrayList Beowulf;
        static void Main(string[] args)
        {

            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.ReadTextFiles();

            p.ReadTextFiles();
            p.WordCounter();
            p.Wordfinder();
            Console.ReadLine();
        }

        public void Run()
        { this.ReadTextFiles(); }
        public void ReadTextFiles()
        {
            // Read file using StreamReader. Read file line by line
            using (StreamReader file = new StreamReader("U:/Users/732152/New folder/New folder/assingment4/assingment4/Beowulf.txt"))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);
                }
                file.Close();
                Console.WriteLine($"File has {counter} lines.");
                counter = File.ReadLines("U:/Users/732152/New folder/New folder/assingment4/assingment4/Beowulf.txt").Count();
                Console.WriteLine("\n This file contains " + counter + " lines");
            }
        }
        public int FindNumberOfBlankeSpaces(string line)
        {
            // https://stackoverflow.com/questions/17812566/count-words-and-spaces-in-string-c-
            int countletters = 0;
            int countSpaces = 0;
            foreach (char c in line)
            {
                if (char.IsLetter(c)) { countletters++; }
                if (char.IsWhiteSpace(c)) { countSpaces++; }
            }
            return countSpaces;

        }

        public void CountLinesReader()
        {
            long lineCounter = 0;
            using (StreamReader fil = new StreamReader("U:/Users/732152/New folder/New folder/assingment4/assingment4/Beowulf.txt"))
            {
                while (fil.ReadLine() != null)
                {
                    lineCounter++;
                }
                Console.WriteLine("\n This file contains " + lineCounter + " lines");
            }
        }

        public void WordCounter()
        {

            StreamReader reader = new StreamReader("U:/Users/732152/New folder/New folder/assingment4/assingment4/Beowulf.txt");
            string script = reader.ReadToEnd();
            var text = script.Trim();
            int wordCount = 0, index = 0;
            while (index < text.Length)
            {

                while (index < text.Length && !char.IsWhiteSpace(text[index]))
                    index++;
                wordCount++;

                while (index < text.Length && char.IsWhiteSpace(text[index]))
                    index++;
            }

            Console.WriteLine("\n This file contains " + wordCount + " lines");


            Console.WriteLine("\n This file contains " + wordCount + " words");

        }
        public void Wordfinder()
        {
            int w = 0;
            foreach (var line in File.ReadAllLines("U:/Users/732152/New folder/New folder/assingment4/assingment4/Beowulf.txt"))
            {
                if (line.Contains("sea") && line.Contains("fare"))
                {
                    w++;
                }


            }
            Console.WriteLine("\n This file contains " + w);
        }
    }

}
