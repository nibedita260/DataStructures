using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataStructures
{
    class HashingForSearchNUm
    {
        public static string PATH = @"D:\git\DataStructures\DataStructures\NumberSearch.txt";
        public LinkedList<int> linkedList = new LinkedList<int>();
        public void IsSearchNumberFoundAndSave()
        {
            string text = File.ReadAllText(PATH);
            string[] words = new string[50];
            words = text.Split(' ');
            int[] numbers = Array.ConvertAll(words, int.Parse);
            //ascending order
            Array.Sort(numbers);
            //For Hahing function, initialize an array to store the numbers 
            int[] hash = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                //Console.WriteLine(Words[i]);
                //do the hashing operations
                for(int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] % 11 == j)
                    {
                        hash[j] = numbers[i];
                        linkedList.Add(hash[j]);
                    }
                }
            }
            Console.WriteLine("enter a number which you want to search from the textfile");
            int num = Convert.ToInt32(Console.ReadLine());
            foreach (var res in numbers)
            {
                if (res.Equals(num))
                {
                    linkedList.RemoveElem(num);
                    linkedList.Display();
                    return;
                }
            }
            linkedList.Add(num);
            Console.Write("\nList Numbers:");
            linkedList.Display();
        }
    }
}
