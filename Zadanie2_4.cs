using System;
using System.Collections.Generic;
using System.IO;
using static System.Net.WebRequestMethods;
class Program
{
    //Zadanie 2  
    static void Main(string[] args)
    {
        string filePath = "plik.txt";
        var statistics = GetCharacterStatistics(filePath);

        foreach (var entry in statistics)
        {
            Console.WriteLine($"Znak: '{entry.Key}' - Wystąpienia: {entry.Value}");
        }
    }

    public static Dictionary<char, int> GetCharacterStatistics(string filePath)
    {
        var charStats = new Dictionary<char, int>();

        try
        {

            string fileContent = System.IO.File.ReadAllText(filePath);


            foreach (char c in fileContent)
            {

                if (charStats.ContainsKey(c))
                {
                    charStats[c]++;
                }
                else
                {

                    charStats[c] = 1;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Wystąpił błąd: {ex.Message}");
        }

        return charStats;
    }
}


//class Program
//{
//    //Zadanie 4
//    static void Main(string[] args)
//    {
//        string file1Path = "file1.txt";
//        string file2Path = "file2.txt";
//        string outputFilePath = "output.txt";

//        try
//        {
//            MergeAndWriteSortedList(file1Path, file2Path, outputFilePath);
//            Console.WriteLine("Plik został utworzony pomyślnie.");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Wystąpił błąd: {ex.Message}");
//        }
//    }

//    public static void MergeAndWriteSortedList(string file1Path, string file2Path, string outputFilePath)
//    {

//        List<string> namesFromFile1 = ReadNamesFromFile(file1Path);
//        List<string> namesFromFile2 = ReadNamesFromFile(file2Path);


//        List<string> mergedNames = MergeSortedLists(namesFromFile1, namesFromFile2);


//        System.IO.File.WriteAllLines(outputFilePath, mergedNames);
//    }


//    private static List<string> ReadNamesFromFile(string filePath)
//    {
//        if (!System.IO.File.Exists(filePath))
//            throw new FileNotFoundException($"Plik {filePath} nie istnieje.");

//        return new List<string>(System.IO.File.ReadAllLines(filePath));
//    }


//    private static List<string> MergeSortedLists(List<string> list1, List<string> list2)
//    {
//        List<string> mergedList = new List<string>();
//        int i = 0, j = 0;


//        while (i < list1.Count && j < list2.Count)
//        {
//            if (string.Compare(list1[i], list2[j]) <= 0)
//            {
//                mergedList.Add(list1[i]);
//                i++;
//            }
//            else
//            {
//                mergedList.Add(list2[j]);
//                j++;
//            }
//        }


//        while (i < list1.Count)
//        {
//            mergedList.Add(list1[i]);
//            i++;
//        }


//        while (j < list2.Count)
//        {
//            mergedList.Add(list2[j]);
//            j++;
//        }

//        return mergedList;
//    }
//}

