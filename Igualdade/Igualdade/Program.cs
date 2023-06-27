using System;
using Igualdade.Entities;
using System.Collections.Generic;

namespace Set;
class Program
{
    static void Main(string[] args)
    {
        HashSet<Product> a = new HashSet<Product>();
        a.Add(new Product("TV", 1500));
        a.Add(new Product("Notebook", 2800));

        HashSet<Point> b = new HashSet<Point>();
        b.Add(new Point(3, 4));
        b.Add(new Point(5, 10));

        Product product = new Product("Notebook", 2800);
        Console.WriteLine(a.Contains(product));

        Point point = new Point(3, 4);
        Console.WriteLine(b.Contains(point));
    }
}