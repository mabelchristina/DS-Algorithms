using System;
using System.IO;

namespace DS_AlgorithmPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\my git\DS-Algorithms\DS_AlgorithmPrograms\List.txt";
            string text = File.ReadAllText(filePath);
            string[] stringArray = text.Split(" ");

            Console.WriteLine("1.Unordered List\n2.Ordered List\n3.Balanced Paranthesis");
            Console.WriteLine("Enter Your Option");
            int choice = (Convert.ToInt32(Console.ReadLine()));
            switch (choice)
            {

                case 1:
                    UnorderedList<string> unOrdered = new UnorderedList<string>();
                    for (int i = 0; i < stringArray.Length; i++)
                    {
                        unOrdered.AddLast(stringArray[i]);
                    }
                    //Get the input from user
                    Console.WriteLine("Enter the word to searched:");
                    string word = Console.ReadLine();
                    int found = unOrdered.SearchNode(word);
                    if (found == 1)
                    {
                        unOrdered.DeleteNode(word);
                    }
                    else
                    {
                        unOrdered.AddLast(word);
                    }
                    string data = unOrdered.Display();
                    File.WriteAllText(filePath, data);
                    break;
            }
        }
    }
}
