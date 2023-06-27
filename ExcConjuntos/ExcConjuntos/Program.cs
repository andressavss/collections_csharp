using System.Collections.Generic;
using System.ComponentModel;

namespace Set;
class Program
{
    static void Main(string[] args)
    {
        HashSet<int> courseA = new HashSet<int>();
        HashSet<int> courseB = new HashSet<int>();
        HashSet<int> courseC = new HashSet<int>();

        Console.Write("How many students course A? ");
        int number = int.Parse(Console.ReadLine());
        for (int i = 0; i < number; i++)
        {
            int codStudent = int.Parse(Console.ReadLine());
            courseA.Add(codStudent);
        }

        Console.Write("How many students course B? ");
        number = int.Parse(Console.ReadLine());
        for (int i = 0; i < number; i++)
        {
            int codStudent = int.Parse(Console.ReadLine());
            courseA.Add(codStudent);
        }

        Console.Write("How many students course C? ");
        number = int.Parse(Console.ReadLine());
        for (int i = 0; i < number; i++)
        {
            int codStudent = int.Parse(Console.ReadLine());
            courseA.Add(codStudent);
        }

        HashSet<int> all = new HashSet<int>(courseA);
        all.UnionWith(courseB);
        all.UnionWith(courseC);
        Console.Write($"Total students: {all.Count}");
    }
}
