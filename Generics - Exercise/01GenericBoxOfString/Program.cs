﻿namespace _01GenericBoxOfString
{
    public class StartUp
    {
        static void Main()
        {
            Box<string> box = new Box<string>();
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                box.Add(Console.ReadLine());
            }
            Console.WriteLine(box);
        }
    }
}