﻿using Tasks;


public static class Program
{
    static void Main(string[] args)
    {

        int[] array1 = { 2, 4, 0, 100, 4, 11, 2602, 36 };
        int[] array2 = { 160, 3, 1719, 19, 11, 13, -21 };



        Console.WriteLine(Nipigas.Find(array1).ToString());
        Console.WriteLine(Nipigas.Find(array2).ToString());

        bool str = Nipigas.Solution("!@#$%^&*() :-)", ":-)");
        bool comp = Nipigas.Compare(null, "");
        int[] maas = Nipigas.Divisors(15);

        string perever = Nipigas.SpinWords("Hey wollef sroirraw");
        bool rr = Nipigas.XO("Oo");
        int num = Nipigas.CountBits(0);
        string alpha = Nipigas.AlphabetPosition("ck.");
        string alpha2 = Nipigas.AlphabetPosition("The narwhal bacons at midnight.");

        string task10 = Nipigas.SeriesSum(0);

        //Console.WriteLine(perever);
        //Console.WriteLine(new string(Nipigas.UniqueInOrder("AAAABBBCCDAABBB").ToArray()));
        //Console.WriteLine(rr);
        //Console.WriteLine(num);
        //Console.WriteLine(alpha);
        Console.WriteLine(task10);

    }


}