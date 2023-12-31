﻿namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operations = int.Parse(Console.ReadLine());

            string text = string.Empty;

            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < operations; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                if (command[0] == "1")
                {
                    stack.Push(text);
                    text += command[1];
                }
                else if (command[0] == "2")
                {
                    stack.Push(text);
                    int count = int.Parse(command[1]);
                    text = text.Substring(0, text.Length - count - 1);
                }
                else if (command[0] == "3")
                {
                    int index = int.Parse(command[1]);
                    Console.WriteLine(text[index - 1]);
                }
                if (command[0] == "4")
                {
                    text = stack.Pop();
                }
            }
        }
    }
}