using System;

class Program
{
    public static void Main()
    {
        Test01();
        Test02();
        Test03();
        Test04();
    }

    public static void Test01()
    {
        IJosephus j = new JosephusLinkedListImpl(41);
        j.PassBy = 3;
        Console.WriteLine(j);

        j.EliminateNextSoldier();
        Console.WriteLine(j);

        j.EliminateNextSoldier();
        Console.WriteLine(j);
    }

    public static void Test02()
    {
        IJosephus j = new JosephusArrayImpl(17);
        // IJosephus j = new JosephusLinkedListImpl(17);
        j.PassBy = 3;

        Console.WriteLine("Josephus Problem: Number of soldiers: {0}", j.Count);
        Console.WriteLine("Eliminating: Each {0}", j.PassBy);
        Console.WriteLine();

        Console.WriteLine(j);
        while (j.Alive > 1)
        {
            j.EliminateNextSoldier();
            Console.WriteLine("Removed {0,2}    ", j.LastEliminated);
        }

        Console.WriteLine();
        Console.WriteLine("Last soldier: {0}", j.LastAlive);
        Console.WriteLine("Last eliminated: {0}", j.LastEliminated);
    }

    public static void Test03()
    {
        IJosephus j = new JosephusArrayImpl(41);
        // IJosephus j = new JosephusLinkedListImpl(41);
        j.PassBy = 3;

        Console.WriteLine("Josephus Problem: Number of soldiers: {0}", j.Count);
        Console.WriteLine("Eliminating: Each {0}", j.PassBy);
        Console.WriteLine();

        while (j.Alive > 1)
        {
            j.EliminateNextSoldier();
            Console.WriteLine("Removed {0,2}    ", j.LastEliminated);
        }

        Console.WriteLine();
        Console.WriteLine("Last soldier: {0}", j.LastAlive);
        Console.WriteLine("Last eliminated: {0}", j.LastEliminated);
    }

    public static void Test04()
    {
        //IJosephus j = new JosephusArrayImpl(41);
        IJosephus j = new JosephusLinkedListImpl(41);
        j.PassBy = 10;

        Console.WriteLine("Josephus Problem: Number of soldiers: {0}", j.Count);
        Console.WriteLine("Eliminating: Each {0}", j.PassBy);
        j.EliminateAll();
        Console.WriteLine("Last soldier: {0}", j.LastAlive);
        Console.WriteLine("Last eliminated: {0}", j.LastEliminated);
    }
}