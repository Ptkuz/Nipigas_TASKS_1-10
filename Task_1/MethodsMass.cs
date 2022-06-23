using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public static class MethodsMass
    {


        public static int MethodResult(int[] mass)
        {
            try
            {
                int result = 0;
                if (CheckChetniy(mass, out result))
                {
                    return result;
                }
                else if (CheckNeChetniy(mass, out result))
                {
                    return result;
                }
                else
                {
                    throw new Exception($"Массив {nameof(mass)} некорректный");
                }

            }
            catch
            {
                throw;
            }
        }


        // Поиск нечетного числа в четном массиве
        private static bool CheckNeChetniy(int[] mass, out int number)
        {
            bool nechet = false;
            int count = 0;
            number = 0;

            foreach (var item in mass)
            {
                if (item % 2 == 0)
                    count++;
                else if (item % 2 != 0 && !nechet)
                {
                    nechet = true;
                    number = item;
                }
                else if (item % 2 != 0 && nechet)
                    return false;

            }
            if (count == mass.Length - 1)
                return true;
            return false;
        }


        // Поиск четного числа в не четном массиве
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
    }
}
