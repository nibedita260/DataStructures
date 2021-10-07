using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataStructures
{
    class UnOrderedList
    {
        public static string PATH = @"D:\git\DataStructures\DataStructures\WordSearch.txt";
        public LinkedList<string> linkedList = new LinkedList<string>();
        public void IsSearchWordFound()
        {
            string text = File.ReadAllText(PATH);
            string[] Words = new string[50];
            Words = text.Split(' ');
            for (int i = 0; i < Words.Length; i++)
            {
                //Console.WriteLine(Words[i]);
                linkedList.Add(Words[i]);
            }
            Console.WriteLine("enter a word which you want to search from the textfile");
            string word = Console.ReadLine();
            foreach(var res in Words)
            {
                if (res.Equals(word))
                {
                    linkedList.RemoveElem(word);
                    linkedList.Display();
                    return;
                }
            }
            linkedList.Add(word);
            linkedList.Display();
        }
    }
}
