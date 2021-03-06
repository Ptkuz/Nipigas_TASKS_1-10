using System.Collections;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Tasks
{
    public class Nipigas
    {
        #region Задание 1: Поиск четных и нечетных элементов в массивах

        public static int Find(int[] mass)
        {
            try
            {
                var chetMass = mass.Where(x => x % 2 == 0).ToArray();
                var nechetMass = mass.Where(x => x % 2 == 1).ToArray();
                if (chetMass.Length > 1 && nechetMass.Length == 1)
                    return nechetMass[0];
                else if (chetMass.Length == 1 && nechetMass.Length > 1)
                    return chetMass[0];
                else
                    throw new ArgumentException($"Массив {nameof(mass)} некорректный");
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Задание 2: Содержит ли строка подстроку
        public static bool Solution(string str, string ending)
        {
            // Если метод EndsWith вернет true, то мы тоже вернем true;
            // Не учитываем регистр
            if (str.EndsWith(ending, true, null))
                return true;
            return false;
        }
        #endregion

        #region Задание 3: Сравнивание строк
        public static bool Compare(string s1, string s2)
        {

            // Если одна из строк равна null, содержит что-то кроме букв латинского алфавита, или пуста, 
            // то обе строки будут пустыми
            if (s1 == null ||
                s2 == null ||
                !Regex.IsMatch(s1, @"^[a-zA-Z]+$") ||
                !Regex.IsMatch(s1, @"^[a-zA-Z]+$") ||
                s1 == "" || s2 == ""
                )
            {
                s1 = "";
                s2 = "";
            }

            // Получаем массив байтов у обеих строк
            byte[] aciiS1 = Encoding.ASCII.GetBytes(s1.ToUpper());
            byte[] aciiS2 = Encoding.ASCII.GetBytes(s2.ToUpper());
            // Переменные, хранящие сумму элементов массивов
            byte number1 = 0;
            byte number2 = 0;

            // Значение элементов каждого из массивов записываются в переменные
            for (int i = 0; i < aciiS1.Length; i++)
                number1 += aciiS1[i];

            for (int i = 0; i < aciiS2.Length; i++)
                number2 += aciiS2[i];


            // Если переменные равны, то вернем true
            if (number1 == number2)
                return true;
            return false;



        }


        #endregion

        #region Задание 4: Массив с делителям Divisors
        public static int[] Divisors(int n)
        {
            if (n <= 1 || n.GetType() != typeof(int))
                throw new ArgumentException($"Число должно быть целым и больше 1");


            int x = 0; // Длина массива 
            int[] mass = new int[x]; // Создание массива
            for (int i = 2; i < n; i++) // Перебор от 2 до предпоследнего числа в параметре
            {
                if (n % i == 0) // Если нет остатка
                {
                    x++; // Увеличиваем длину массива
                    Array.Resize<int>(ref mass, x); // Увеличиваем длину массива
                    mass[x - 1] = i; // На место текущего элемента вставляем значение
                }
            }
            if (mass.Length == 0) // Если не найдено ни одного элемента
                return null; // Вернем null
            else
                return mass; // Иначе вернем массив
        }

        #endregion

        #region Задание 5: переворот слов
        public static string SpinWords(string sentence)
        {
            // СтрингБилдер для создания новой строки из перевернутых слов
            StringBuilder sb = new StringBuilder();

            // Делим входную строку на массив слов
            string[] massString = sentence.Split(' ');

            // Перебираем массив
            for (int i = 0; i < massString.Length; i++)
            {
                if (massString[i].Length >= 5) // Переварачиваем, если длина слова больше либо равно 5 
                {
                    char[] arr = massString[i].ToCharArray(); // преобразуем строку в массив чаров
                    Array.Reverse(arr); // Переварачиваем массив
                    string newword = new string(arr); // Создаем объет новой строки и закидываем туда массив чаров
                    massString[i] = newword; // перезаписываем новое слово на место старого
                }
                sb.Append(massString[i]); // Добавляем слово в стрингБилдер
                if (massString.Length > 1 && i != massString.Length - 1) // Если слов больше одного и индекс последнего слова не равен последнему индексу массива
                    sb.Append(' '); // Добавляем пробел
            }
            return sb.ToString(); // Возвращаем перевернутую строку
        }

        #endregion

        #region Задание 6: Убрать дублирование символов UniqueInOrder

        public static IEnumerable UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            var prevT = default(T); // Если любой другой тип
            char prevC = default!;
            string prevS = "";

            var stringOrChars = iterable.
                Where(x => x.GetType() == typeof(char) || x.GetType() == typeof(string)).
                ToArray();

            if (stringOrChars.Count()>0)
            {
                foreach (var item in stringOrChars)
                {
                    if (stringOrChars.GetType() == typeof(char[]))
                    {
                        if (Char.ToUpper(Convert.ToChar(item)).Equals(Char.ToUpper(prevC)))
                            continue;
                        prevC = Char.ToUpper(Convert.ToChar(item));
                        yield return prevC;
                    }
                    if (stringOrChars.GetType() == typeof(string[])) 
                    {
                        if (item.ToString().ToUpper().Equals(prevS.ToUpper()))
                            continue;
                        prevS = item.ToString().ToUpper();
                        yield return prevS;
                    }
                }

            }
            else
            {
                foreach (var item in iterable)
                {
                    if (item.Equals(prevT))
                        continue;

                    prevT = item;

                    yield return item;
                }

            }
        }



        #endregion

        #region Задание 7: Одинаковое количество символов А и В
        public static bool XO(string input)
        {
            var unicChar = input.ToUpper().Distinct().ToArray();
            if (unicChar.Length == 2)
            {
                var firstChar = input.ToUpper().First(); // Находим первый символ в строке    
                var result = input.ToUpper().Where(x => x.Equals(firstChar)); // Находим все экземпляры данного символа                  
                var count = result.Count(); // Считаем количество этих символов
                if (count == (input.Length - count)) // Если количество равдно длине строки минус количество
                    return true;
            }
            return false;
        }

        #endregion

        #region Задание 8: Количество битов числа
        public static int CountBits(int n)
        {
            if (n >= 0 && n.GetType() == typeof(int)) // Число должно быть целым и не отрицательным
            {
                string str = Convert.ToString(n, 2); // Конвертируем в строку в двоичном виде
                var result = str.Where(x => x.Equals('1')); // Ищем еденицы
                var count = result.Count(); // Считаем количество 1

                return count;
            }
            else
                throw new ArgumentException("Число должно быть целым и не отрицательным!");


        }

        #endregion

        #region Задание 9: Замена буквы цифрой в алфавите
        public static string AlphabetPosition(string text)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz"; // массив букв алфавита
            StringBuilder sb = new StringBuilder(); // Будем собирать с помощью СтрингБилдера

            for (int i = 0; i < text.Length; i++) // Обходим вводимый текст
            {
                if (Regex.IsMatch(text[i].ToString(), @"^[a-zA-Z]+$")) // Проверяем, буквали это
                {
                    int index = alphabet.IndexOf(text[i].ToString().ToLower()) + 1; // Получаеми индекс и привабляем 1
                    sb.Append(index.ToString()); // Добавляем в СтрингБилдер
                    sb.Append(" "); // Пробел после каждого символа
                }

            }
            return sb.ToString().Trim(); // Обрежем лишний пробел
        }

        #endregion

        #region Задание 10: Сумма ряда
        public static string SeriesSum(int n)
        {
            if (n < 0 || n.GetType() != typeof(int))
                throw new ArgumentException($"Число должно быть целым и больше либо равно 0");


            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-EN"); // Настройки культуры для отображения дробей
            double sum = 1; // Сумма ряда
            double drob = 1; // дробная часть
            if (n == 0)
            {
                sum = 0.00;
                return sum.ToString("0.00");
            }


            if (n == 1)
                return sum.ToString("0.##");

            for (double i = 1; i < n; i++)
            {
                sum += (1 / (drob += 3));
            }

            return sum.ToString("0.##");
        }

        #endregion




    }
}
