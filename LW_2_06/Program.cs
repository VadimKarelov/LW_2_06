using System;

namespace LW_2_06
{
    class Program
    {
        private static Random rn = new();

        static void Main(string[] args)
        {
            char[][] jaggedArray = null;
            string text = "";

            string vvod = "";
            while (vvod != "0")
            {
                Console.Clear();
                Console.WriteLine(@"0 - завершение программы
Задание 1
1 - вывод массива на экран
2 - ввод массива char[][] вручную
3 - заполнение массива char[][] ДСЧ
4 - удалить последнюю строку, в которой не меньше 3-х цифр
Задание 2
5 - ввод строки
6 - найти ключевые слова C#
7 - распечатать строку");

                vvod = Console.ReadLine();

                switch (vvod)
                {
                    case "0": break;
                    case "1": Print(jaggedArray); break;
                    case "3": jaggedArray = AutoCreation(); break;
                }
            }
        }

        static private void Print(char[][] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                Console.WriteLine("Массив пуст");
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        Console.Write(arr[i][j]);
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }

        static private char[][] AutoCreation()
        {
            int n;
            do
            {
                Console.WriteLine("Введите количество строк");
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 1);

            string letters = "йцукенгшщзхъфывапролджэячсмитьбюёЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ";

            char[][] res = new char[n][];

            for (int i = 0; i < n; i++)
            {
                int length = rn.Next(0, 30);
                string row = "";
                for (int j = 0; j < length; j++)
                {
                    row += letters[rn.Next(0, letters.Length)]; // t
                }
                res[i] = row.ToCharArray();
            }

            Console.WriteLine("Массив создан");
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();

            return res;
        }
    }
}
