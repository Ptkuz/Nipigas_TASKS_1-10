using System.Collections;
using Tasks;


public static class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Задание 1
            int[] array1 = { 2, 4, 0, 100, 4, 11, 2602, 36 };
            int[] array2 = { 160, 3, 1719, 19, 11, 13, -21 };
            

            Console.WriteLine(Nipigas.Find(array1).ToString());
            Console.WriteLine(Nipigas.Find(array2).ToString());
            




            bool str = Nipigas.Solution("!@#$%^&*() :-)", ":-)");
            bool comp = Nipigas.Compare(null, "");
            int[] maas = Nipigas.Divisors(15);

            int[] mass = new int[] { 1, 1, 2, 2, 3 };
            IEnumerable ts = Nipigas.UniqueInOrder(mass);
            //foreach (int i in ts)
            //    Console.Write(i);


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
            //Console.WriteLine(Nipigas.CountBits((int)5.32));


            //string items = Nipigas.UniqueInOrder2("AABBCC");
            //foreach (char item in items)
            // Console.WriteLine(items);

            //IEnumerable result =  Nipigas.UniqueInOrder2("AAAABBBCCDAABBB");
            // foreach(var item in result)
            //     Console.Write(item);


            //string[] mass1 = new string[] { "павел", "Павел", "Андрей", "Андрей", "Игорь", "Андрей" };
            ////string[] mass2 = new string[] { "Павел", "Андрей", "Игорь", "Андрей" };

            //IEnumerable result1 = Nipigas.UniqueInOrder(mass1);
            //foreach (var item in result1)
            //{
            //    Console.Write(item + " ");

            //}
            string[] strs = new string[] { "Павел", "Павел", "Андрей", "Андрей", "Игорь", "Андрей" };

            IEnumerable charsResult = Nipigas.UniqueInOrder(strs);

            foreach (var c in charsResult)
                Console.Write(c + " ");




        }
        catch (ArgumentException ex) 
        {
            Console.WriteLine(ex.Message);
        }

    }


}