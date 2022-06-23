using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Tasks
{
    public class Nipigas
    {
        #region Задание 1: Поиск четных и нечетных элементов в массивах

        #region Поиск нечетного числа в четном массиве

        // Инкапсулированный метод, находящий нечетное число в четном массиве
        private static bool CheckNeChetniy(int[] mass, out int number)
        {
            bool nechet = false; // Найдено ли четеное число
            int count = 0; // Количество найденных элементов
            number = 0; // Найденное нечетное число

            foreach (var item in mass)
            {
                if (item % 2 == 0) // Если число четное
                    count++; // Увеличиваем количество элементов
                else if (item % 2 != 0 && !nechet) // Елси число нечетное и оно еще не было найдено
                {
                    nechet = true; // говорим, что мы его нашли
                    number = item; // и записываем его в выходной параметр
                }
                else if (item % 2 != 0 && nechet) // Если число нечетное и э элемент найден
                    return false; // Вернем false, значит массив задан некорректно

            }
            if (count == mass.Length - 1) // Если количество элементов равно длине массива минус найденное число
                return true;
            return false;
        }

        #endregion
        #region Поиск четного числа в нечетном массиве

        // Аналагочино первому методу, только ищем четное число в нечетном массиве
        private static bool CheckChetniy(int[] mass, out int number)
        {
            bool chet = false;
            int count = 0;
            number = 0;

            foreach (var item in mass)
            {
                if (item % 2 != 0)
                    count++;
                else if (item % 2 == 0 && !chet)
                {
                    chet = true;
                    number = item;
                }
                else if (item % 2 == 0 && chet)
                    return false;
            }
            if (count == mass.Length - 1)
                return true;
            return false;
        }
        #endregion


        public static int Find(int[] mass)
        {
            try
            {
                int result = 0;
                if (CheckChetniy(mass, out result))
                    return result;
                else if (CheckNeChetniy(mass, out result))
                    return result;
                else
                    throw new Exception($"Массив {nameof(mass)} некорректный");
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
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            T prev = default!; // Предыдущий символ
            bool hasPrev = false; // Есть ли предыдущий символ
            foreach (T item in iterable) // перебираем IEnumerable
            {
                // Если нет предыдущего элемента, говорим что теперь он есть
                // Или если предыдущией элемент равен текущему
                if ((!hasPrev && (hasPrev = true)) || !EqualityComparer<T>.Default.Equals(item, prev))
                    yield return item; // определяет возвращаемый элемент

                // Теперь предыщий элемент равен текущему
                prev = item;
            }

        }

        #endregion

        #region Задание 7: Одинаковое количество символов А и В
        public static bool XO(string input)
        {
            var firstChar = input.ToUpper().First(); // Находим первый символ в строке    
            var result = input.ToUpper().Where(x => x.Equals(firstChar)); // Находим все экземпляры данного символа                  
            var count = result.Count(); // Считаем количество этих символов
            if (count == (input.Length - count)) // Если количество равдно длине строки минус количество
                return true;
            return false;
        }

        #endregion

        #region Задание 8: Количество битов числа
        public static int CountBits(int n)
        {
            string str = Convert.ToString(n, 2);
            var result = str.Where(x => x.Equals('1'));
            var count = result.Count();

            return count;


        }

        #endregion

        #region Задание 9: Замена буквы цифрой в алфавите
        public static string AlphabetPosition(string text)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            //String.Format(text.ToLower());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (Regex.IsMatch(text[i].ToString(), @"^[a-zA-Z]+$"))
                {
                    int index = alphabet.IndexOf(text[i].ToString().ToLower()) + 1;
                    sb.Append(index.ToString());
                    sb.Append(" ");
                }

            }
            return sb.ToString().Trim();
        }

        #endregion

        #region Задание 10: Сумма ряда
        public static string SeriesSum(int n)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-EN");
            double sum = 1;
            double drob = 1;
            if (n == 0)
            {
                sum = 0.00;
                return sum.ToString("0.00");
            }

                
            if (n == 1)
                return sum.ToString("0.##");

            for (double i = 1; i<n;i++) 
            {
                sum += (1 / (drob+=3));
            }

            return sum.ToString("0.##");
        }

        #endregion




    }
}
