﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,,] matrix1 = new int[3, 3, 6];
            ////int[,] matrix = new int[3, 3];
            //int[,] matrix = {
            //    { 6, 9, 3, 4}, //0
            //    { 4, 5, 6, 5}, //1
            //    { 7, 8, 9, 7}, //2
            //    { 4, 5, 6, 5}  //3
            //};
            //Console.WriteLine(matrix.GetLength(0)); // ilość wierszy w tablicy
            //Console.WriteLine(matrix.GetLength(1)); // ilość kolumn w tablicy

            //int min = matrix[0, 0];
            //for (int i = matrix.GetLength(0) / 2; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = matrix.GetLength(1) / 2; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write(matrix[i, j] + " ");
            //        if (matrix[i, j] < min)
            //        {
            //            min = matrix[i, j];
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Minimum: " + min);

            // Tablica nieregularna dwuwymiarowa
            //int[][] tablica = new int[3][];
            //tablica[0] = new int[] { 3, 6, 5 };
            //tablica[1] = new int[] { 5, 8, 7, 6, 4, 7, 9 };
            //tablica[2] = new int[] { 3 };

            //for (int i = 0; i < tablica.Length; i++)
            //{
            //    //Console.WriteLine(tablica[i].Length);
            //    for (int j = 0; j < tablica[i].Length; j++)
            //    {
            //        Console.Write(tablica[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            // Zadanie 1
            //string[][] paragraphs = new string[3][];
            //paragraphs[0] = new string[] { "Ala", "ma", "kota" };
            //paragraphs[1] = new string[] { "Kot", "ma", "pchły" };
            //paragraphs[2] = new string[] { "Ala", "też", "ma", "pchły" };

            //for (int i = 0; i < paragraphs.Length; i++)
            //{
            //    int iloscZnakow = 0;
            //    int iloscSlow = paragraphs[i].Length;
            //    for (int j = 0; j < paragraphs[i].Length; j++)
            //    {
            //        iloscZnakow += paragraphs[i][j].Length;
            //    }
            //    Console.WriteLine($"Akapit {i + 1} zawiera {iloscZnakow} znaków");
            //    Console.WriteLine($"Akapit {i + 1} zawiera {iloscSlow} słów");
            //    Console.WriteLine();
            //}

            // Zadanie 2
            /*            double[,] temperatures = new double[4, 7]
                        {
                            { 12.5, 6.0, 4.7, 10.2, 10.5, 12.4, 14.2},
                            { 12.2, 5.0, 2.7, 7.2, 8.5, 9.4, 10.2},
                            { 12.5, 6.3, 4.9, 10.9, 9.5, 9.4, 14.2},
                            { 10, 10, 10, 10, 10, 10, 10}
                        };
                        for (int location = 0 ; location < temperatures.Length; location++)
                        {
                            double totalTemp = 0;
                            for(int day = 0 ; day < 7; day++)
                            {
                                totalTemp += temperatures[location, day];
                            }
                            double avgTemp = totalTemp / 7;
                            Console.WriteLine($"Średnia temperatura w lokalizacji {location + 1}: {avgTemp:F1}");
                        }*/


            // Zadanie 5
            //a
            //int minimum;
            //int[][] tab = new int[5][];
            //tab[0] = new int[] { 3, 6, 5, 6, 3 };
            //tab[1] = new int[] { 5, 8, 7, 6, 4 };
            //tab[2] = new int[] { 8, 3, 1, 3, 4 };
            //tab[3] = new int[] { 5, 8, 7, 6, 4 };
            //tab[4] = new int[] { 5, 2, 5, 4, 5 };

            //minimum = tab[0][0];


            //for (int i = 0; i < tab.Length; i++)
            //{
            //    for (int j = 0; j < tab[i].Length; j++)
            //    {

            //        if (tab[i][j] < minimum)
            //        {
            //            minimum = tab[i][j];
            //        }
            //    }
            //}
            //Console.WriteLine("Minimalny element w tablicy: " + minimum);


            //b
            //int[][] tab = new int[5][];
            //tab[0] = new int[] { 3, 6, 5, 6, 3 };
            //tab[1] = new int[] { 5, 8, 7, 6, 4 };
            //tab[2] = new int[] { 8, 3, 1, 3, 4 };
            //tab[3] = new int[] { 5, 8, 7, 6, 4 };
            //tab[4] = new int[] { 5, 2, 5, 4, 5 };

            //int minimum = tab[0][0];
            //for (int i = 1; i < tab.Length; i++)
            //{
            //    if (tab[i][i] < minimum)
            //    {
            //        minimum = tab[i][i];
            //    }
            //}

            //Console.WriteLine("Minimalny element na głównej przekątnej: " + minimum);


            // c)
            //int minimum;
            //int[][] tabC = new int[5][];
            //tabC[0] = new int[] { 3, 6, 5, 6, 3 };
            //tabC[1] = new int[] { 5, 8, 7, 6, 4 };
            //tabC[2] = new int[] { 8, 3, 1, 3, 4 };
            //tabC[3] = new int[] { 5, 8, 7, 6, 4 };
            //tabC[4] = new int[] { 5, 2, 5, 4, 5 };



            //for (int i = 0; i < tabC.Length; i++)
            //{
            //    minimum = tabC[i][0];
            //    for (int j = 0; j < tabC[i].Length; j++)
            //    {
            //        if (tabC[i][j] < minimum)
            //        {
            //            minimum = tabC[i][j];
            //        }
            //    }
            //    Console.WriteLine($"Minimum {i}- tego wiersza to: {minimum}");

            // d)
            //int[][] tab = new int[5][];
            //tab[0] = new int[] { 3, 6, 5, 6, 3 };
            //tab[1] = new int[] { 5, 8, 7, 6, 4 };
            //tab[2] = new int[] { 8, 3, 1, 3, 4 };
            //tab[3] = new int[] { 5, 8, 7, 6, 4 };
            //tab[4] = new int[] { 5, 2, 5, 4, 5 };

            //int minimum;
            ////int k = 0; // kolumna w której jestem
            //for (int i = 0; i < 5; i++)
            //{
            //    minimum = tab[0][i];
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (tab[j][i] < minimum)
            //        {
            //            minimum = tab[j][i];
            //        }
            //    }
            //    Console.WriteLine($"Minimum {i}- tej kolumny to: {minimum}");
            //}
            //// Zadanie 6
            //a
            //int[][] tab = new int[5][];
            //tab[0] = new int[] { 3, 6, 5, 6, 3 };
            //tab[1] = new int[] { 5, 8, 7, 6, 4 };
            //tab[2] = new int[] { 8, 3, 1, 3, 4 };
            //tab[3] = new int[] { 5, 8, 7, 6, 4 };
            //tab[4] = new int[] { 5, 2, 5, 4, 5 };

            //int sum = 0;

           
            //for (int i = 0; i < tab.Length; i++)
            //{
                
            //    for (int j = i + 1; j < tab[i].Length; j++)
            //    {
            //        sum += tab[i][j];  
            //    }
            //}

            //Console.WriteLine("Suma elementów w górnej połowie tablicy: " + sum);

            //b 
            int[][] tab = new int[5][];
            tab[0] = new int[] { 3, 6, 5, 6, 3 };
            tab[1] = new int[] { 5, 8, 7, 6, 4 };
            tab[2] = new int[] { 8, 3, 1, 3, 4 };
            tab[3] = new int[] { 5, 8, 7, 6, 4 };
            tab[4] = new int[] { 5, 2, 5, 4, 5 };

            int sum = 0;

            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0;
            }
        }
             
            

            ///d)
            /////int[][] tab = new int[5][];
            //tab[0] = new int[] { 3, 6, 5, 6, 3 };
            //tab[1] = new int[] { 5, 8, 7, 6, 4 };
            //tab[2] = new int[] { 8, 3, 1, 3, 4 };
            //tab[3] = new int[] { 5, 8, 7, 6, 4 };
            //tab[4] = new int[] { 5, 2, 5, 4, 5 };
            //int start = 1;
            //int iloscWierszy = tab.Length / 2;
            //int sumaElementow = 0;
            //for (int i = tab.Length - 1; i > tab.Length / 2; i--)
            //{
            //    for (int j = start; j < tab.Length - start; j++)
            //    {
            //        sumaElementow += tab[i][j];
            //    }
            //    start += 1;

            //}
            //Console.WriteLine("Suma elementów poniżej przekątnych wynosi: " + sumaElementow);


        }
    }
    



   

   









