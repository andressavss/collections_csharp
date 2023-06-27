using System;
using System.IO;
using System.Collections.Generic;

namespace Collections;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter file full path: ");
        string path = Console.ReadLine();

        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                Dictionary<string, int> votes = new Dictionary<string, int>();

                while (!sr.EndOfStream)
                {
                    string[] voting = sr.ReadLine().Split(',');
                    string name = voting[0];
                    int number = int.Parse(voting[1]);

                    if (votes.ContainsKey(name))
                    {
                        votes[name] += number;
                    }
                    else
                    {
                        votes[name] = number;
                    }
                }
                foreach (KeyValuePair<string, int> pair in votes)
                {
                    Console.WriteLine($"{pair.Key}: {pair.Value}");
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("An error occurred!");
            Console.WriteLine(e.Message);
        }
    }
}