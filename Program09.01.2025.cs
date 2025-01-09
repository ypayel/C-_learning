using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Dictionary<string, int> dictionary = new Dictionary<string, int>();

             dictionary.Add("Anna", 25);
             dictionary.Add("Patryk", 26);
             dictionary.Add("Marta", 23);

             if (dictionary.ContainsKey("Patryk"))
             {
                 //Console.WriteLine(dictionary["Patryk"]);
             }

             foreach (var pair in dictionary)
             {
                 string name = pair.Key;
                 int age = pair.Value;

                 Console.WriteLine($"{name}: {age} lat");
             }

             dictionary["Patryk"] = 27;

             dictionary["Piotr"] = 27;
             dictionary.Remove("Marta");

             var keys = dictionary.Keys.ToList();
             var values = dictionary.Values.ToList();



             //File.WriteAllText("plik.txt", "Hello world!");

             string content = File.ReadAllText("plik.txt");

             File.AppendAllText("plik.txt", "\nNowa Linia");
             Console.WriteLine(content);*/


            string filePath = "plik.txt";

            try
            {
                LinkedList<string> sentenceList = new LinkedList<string>();
                Zadanie1(filePath, ref sentenceList);

                Console.WriteLine("Lista zdań: ");
                foreach(var sentence in sentenceList)
                {
                    Console.WriteLine(sentence);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                char mostFrequent = Zadanie3(filePath);
                Console.WriteLine(mostFrequent);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        static void Zadanie1(string filePath, ref LinkedList<string> sentenceList)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException();
            }

            using (StreamReader sr = new StreamReader(filePath)) 
            {
                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] sentences = line.Split('.');
                    foreach (string sentence in sentences)
                    {

                        if (!string.IsNullOrWhiteSpace(sentence))
                        {
                            sentenceList.AddLast(sentence.Trim());
                        }
                    }  
                }
            }


        }



        static char Zadanie3(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException();
            }

            string fileContent = File.ReadAllText(filePath);

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach(char c in fileContent)
            {
                if (!char.IsWhiteSpace(c))
                {
                    if (charCount.ContainsKey(c))
                    {
                        charCount[c]++;
                    }
                    else
                    {
                        charCount[c] = 1;
                    }
                }
            }
            foreach (var pair in charCount)
            {
                char name = pair.Key;
                int age = pair.Value;

                Console.WriteLine($"{name}: {age}");
            }
            char mostFrequent = charCount.OrderByDescending(pair => pair.Value).First().Key;
            return mostFrequent;
        }
    }
}
