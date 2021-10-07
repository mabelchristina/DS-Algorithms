﻿using System;
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
                case 2:
                    OrderedList<string> ordered = new OrderedList<string>();

                    for (int i = 0; i < stringArray.Length; i++)
                    {
                        ordered.Add(stringArray[i]);
                    }
                    //Get the input from user
                    Console.WriteLine("Enter the word to searched:");
                    string word1 = Console.ReadLine();
                    int found1 = ordered.SearchNode(word1);
                    if (found1 == 1)
                    {
                        ordered.DeleteNode(word1);
                    }
                    else
                    {
                        ordered.Add(word1);
                    }
                    string data1 = ordered.Display();
                    File.WriteAllText(filePath, data1);
                    break;
                case 3:
                    BalancedParenthesis<char> stack = new BalancedParenthesis<char>();
                    string expression = "((5+6)∗(7+8)/(4+3(5+6)∗(7+8)/(4+3))";
                    for (int i = 0; i < expression.Length; i++)
                    {
                        if (expression[i].Equals('('))
                        {
                            stack.Push(expression[i]);
                        }
                        else if (expression[i].Equals(')'))
                        {
                            stack.Pop();
                        }
                    }
                    if (stack.CheckParanthesis() == 1)
                    {
                        Console.WriteLine("Arithmetic Expression is balanced");
                    }
                    else
                    {
                        Console.WriteLine("Arithmetic Expression is unbalanced");
                    }
                    break;
            }
        }
    }
}
