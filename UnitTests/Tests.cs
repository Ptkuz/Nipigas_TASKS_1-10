using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Tasks;

namespace UnitTests
{
    public class Tests
    {

        #region Тесты для первого задания
        [Test]
        public static void Nipigas_Find_Test1()
        {
            int[] exampleTest1 = { 2, 6, 8, -10, 3 };
            Assert.IsTrue(3 == Nipigas.Find(exampleTest1));
        }

        [Test]
        public static void Nipigas_Find_Test2()
        {
            int[] exampleTest2 = { 206847684, 1056521, 7, 17, 1901, 21104421, 7, 1, 35521, 1, 7781 };
            Assert.IsTrue(206847684 == Nipigas.Find(exampleTest2));
        }

        [Test]
        public static void Nipigas_Find_Test3()
        {
            int[] exampleTest3 = { int.MaxValue, 0, 1 };
            Assert.IsTrue(0 == Nipigas.Find(exampleTest3));
        }

        [Test]
        public static void Nipigas_Find_Test4()
        {
            int[] exampleTest4 = { 206847684, 1056521, 8, 17, 1901, 21104421, 7, 1, 35521, 1, 7781 };
            
            Assert.Throws<ArgumentException>(()=> Nipigas.Find(exampleTest4));
        }
        #endregion


        #region Тесты для второго задания
        private static object[] sampleTestCases = new object[]
        {
            new object[] {"samurai", "ai", true},
            new object[] {"sumo", "omo", false},
            new object[] {"ninja", "ja", true},
            new object[] {"sensei", "i", true},
            new object[] {"samurai", "ra", false},
            new object[] {"abc", "abcd", false},
            new object[] {"abc", "abc", true},
            new object[] {"abcabc", "bc", true},
            new object[] {"ails", "fails", false},
            new object[] {"fails", "ails", true},
            new object[] {"this", "fails", false},
            new object[] {"abc", "", true},
            new object[] {":-)", ":-(", false},
            new object[] {"!@#$%^&*() :-)", ":-)", true},
            new object[] {"abc\n", "abc", false},
            new object[] {"345345345", "32", false},
             new object[] {"345345345", "45", true},
        };

        [Test, TestCaseSource("sampleTestCases")]
        public void Nipigas_Solution_Test1(string str, string ending, bool expected)
        {
            Assert.AreEqual(expected, Nipigas.Solution(str, ending));
        }
        #endregion


        #region Тесты для третьего задания
        [Test]
        public void Nipigas_Compare_Test1()
        {
            Assert.AreEqual(true, Nipigas.Compare("AD", "BC"));
        }

        [Test]
        public void Nipigas_Compare_Test2()
        {
            Assert.AreEqual(false, Nipigas.Compare("AD", "DD"));
        }

        [Test]
        public void Nipigas_Compare_Test3()
        {
            Assert.AreEqual(true, Nipigas.Compare("gf", "FG"));
        }

        [Test]
        public void Nipigas_Compare_Test4()
        {
            Assert.AreEqual(true, Nipigas.Compare("zz1", ""));
        }

        [Test]
        public void Nipigas_Compare_Test5()
        {
            Assert.AreEqual(true, Nipigas.Compare("ZzZz", "ffPFF"));
        }

        [Test]
        public void Nipigas_Compare_Test6()
        {
            Assert.AreEqual(false, Nipigas.Compare("kl", "lz"));
        }

        [Test]
        public void Nipigas_Compare_Test7()
        {
            Assert.AreEqual(true, Nipigas.Compare(null, ""));
        }

        [Test]
        public void Nipigas_Compare_Test8()
        {
            Assert.AreEqual(true, Nipigas.Compare(null, "456"));
        }
        #endregion

        #region Тесты для четвертого задания
        [Test]
        public void Nipigas_Divisors_Test1()
        {
            Assert.AreEqual(new int[] { 3, 5 }, Nipigas.Divisors(15));
            Assert.AreEqual(new int[] { 2, 4, 8 }, Nipigas.Divisors(16));
            Assert.AreEqual(new int[] { 11, 23 }, Nipigas.Divisors(253));
            Assert.AreEqual(new int[] { 2, 3, 4, 6, 8, 12 }, Nipigas.Divisors(24));
            Assert.AreEqual(null, Nipigas.Divisors(13));
            Assert.Throws<ArgumentException>(() => Nipigas.Divisors(-5));
            Assert.Throws<ArgumentException>(() => Nipigas.Divisors(1));           
        }


        #endregion

        #region Тесты для пятого задания
        [Test]
        public static void Nipigas_SpinWords_Test1()
        {
            Assert.AreEqual("emocleW", Nipigas.SpinWords("Welcome"));
        }

        [Test]
        public static void Nipigas_SpinWords_Test2()
        {
            Assert.AreEqual("Hey wollef sroirraw", Nipigas.SpinWords("Hey fellow warriors"));
        }

        [Test]
        public static void Nipigas_SpinWords_Test3()
        {
            Assert.AreEqual("This is a test", Nipigas.SpinWords("This is a test"));
        }

        [Test]
        public static void Nipigas_SpinWords_Test4()
        {
            Assert.AreEqual("This is rehtona test", Nipigas.SpinWords("This is another test"));
        }

        [Test]
        public static void Nipigas_SpinWords_Test5()
        {
            Assert.AreEqual("You are tsomla to the last test", Nipigas.SpinWords("You are almost to the last test"));
        }

        [Test]
        public static void Nipigas_SpinWords_Test6()
        {
            Assert.AreEqual("Just gniddik ereht is llits one more", Nipigas.SpinWords("Just kidding there is still one more"));
        }

        #endregion

        #region Тесты для шестого задания
        [Test]
        public void Nipigas_UniqueInOrder_Test1()
        {
            Assert.AreEqual("", Nipigas.UniqueInOrder(""));
           
        }
        [Test]
        public void Nipigas_UniqueInOrder_Test2()
        {
            Assert.AreEqual("ABCDAB", Nipigas.UniqueInOrder("AAAABBBCCDAABBB"));
            
        }

        [Test]
        public void Nipigas_UniqueInOrder_Test3()
        {
            Assert.AreEqual("ABCAD", Nipigas.UniqueInOrder("ABBcCAD"));

        }

        [Test]
        public void Nipigas_UniqueInOrder_Test4()
        {
            int[] mass = new int[] { 1, 2, 2, 3, 3 };
            int[] result = new int[] { 1, 2, 3 };

            Assert.AreEqual(result, Nipigas.UniqueInOrder(mass));

        }

        [Test]
        public void Nipigas_UniqueInOrder_Test5()
        {
            double[] mass = new double[] { 1.34, 2.54, 2.54, 3.22, 3.22 };
            double[] result = new double[] { 1.34, 2.54, 3.22 };

            Assert.AreEqual(result, Nipigas.UniqueInOrder(mass));
        }

        // Но вариацию без учета регистра я тоже сделал.
        // Просто нужно указать дополнительный необязательный параметр NoRegister = true
        [Test]
        public void Nipigas_UniqueInOrder_Test7()
        {
            List<string> list = new List<string> { "Павел", "павел", "Андрей", "Андрей", "Игорь", "Андрей" };
            List<string> result = new List<string>();
            IEnumerable items = Nipigas.UniqueInOrder(list);
            foreach (var item in items)
                result.Add(item.ToString());

            Assert.AreEqual(result[0], "павел".ToUpper());
            Assert.AreEqual(result[1], "Андрей".ToUpper());
            Assert.AreEqual(result[2], "Игорь".ToUpper());
            Assert.AreEqual(result[3], "Андрей".ToUpper());
        }

        #endregion

        #region Тесты для седьмого задания
        [Test]
        public void Nipigas_XO_Test1()
        {
            Assert.AreEqual(true, Nipigas.XO("xo"));
            Assert.AreEqual(true, Nipigas.XO("xxOo"));
            Assert.AreEqual(false, Nipigas.XO("xxxm"));
            Assert.AreEqual(false, Nipigas.XO("Oo"));
            Assert.AreEqual(false, Nipigas.XO("ooom"));
            Assert.AreEqual(false, Nipigas.XO("zpzpzpp"));
            Assert.AreEqual(true, Nipigas.XO("zzoo"));
        }

        #endregion

        #region Тесты для восьмого задания
        [Test]
        public void CountBits()
        {
            Assert.AreEqual(0, Nipigas.CountBits(0));
            Assert.AreEqual(1, Nipigas.CountBits(4));
            Assert.AreEqual(3, Nipigas.CountBits(7));
            Assert.AreEqual(2, Nipigas.CountBits(9));
            Assert.AreEqual(2, Nipigas.CountBits(10));
            Assert.Throws<ArgumentException>(() => Nipigas.CountBits((int)-5.32));

        }

        #endregion

        #region Тесты для девятого задания
        [Test]
        public void Nipigas_AlphabetPosition_SampleTest()
        {
            Assert.AreEqual("20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11", Nipigas.AlphabetPosition("The sunset sets at twelve o' clock."));
            Assert.AreEqual("20 8 5 14 1 18 23 8 1 12 2 1 3 15 14 19 1 20 13 9 4 14 9 7 8 20", Nipigas.AlphabetPosition("The narwhal bacons at midnight."));
        }

        #endregion

        #region Тесты для десятого задания
        [Test]
        public void Nipigas_SeriesSum_Test1()
        {
            Assert.AreEqual("0.00", Nipigas.SeriesSum(0));
        }
        [Test]
        public void Nipigas_SeriesSum_Test2()
        {
            Assert.AreEqual("1.77", Nipigas.SeriesSum(9));
        }

        [Test]
        public void Nipigas_SeriesSum_Test3()
        {
            Assert.Throws<ArgumentException>(() => Nipigas.SeriesSum(-5));
        }

        [Test]
        public void Nipigas_SeriesSum_Test4()
        {
            Assert.AreEqual("1.25", Nipigas.SeriesSum(2));
        }

        [Test]
        public void Nipigas_SeriesSum_Test5()
        {
            Assert.AreEqual("1.57", Nipigas.SeriesSum(5));
        }


        #endregion




    }
}