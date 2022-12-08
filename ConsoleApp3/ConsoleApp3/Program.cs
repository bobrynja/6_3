using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void f()
        {
            try
            {
                int buf;
                Console.WriteLine("Введите размерность массива: ");
                Console.Write("n = ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.Write("m = ");
                int m = Convert.ToInt32(Console.ReadLine());
                if (n <= 0 || m <= 0) Console.WriteLine("Размер массива не может быть отрицательным или равным 0");
                else
                {
                    int[,] arr = new int[n, m];
                    Console.WriteLine("Введите числа: ");

                    //Заполнение массива
                    for (int i = 0; i < n; i++)
                    {
                        string[] b = Console.ReadLine().Split(' ');
                        for (int j = 0; j < m; j++)
                        {
                            arr[i, j] = Convert.ToInt32(b[j]);
                        }
                    }
                    int st_1 = 0;
                    int st_2 = 0;
                    if (m % 2 == 0)
                    {
                        st_1 = m / 2 - 1;
                        st_2 = m / 2;
                    }
                    else
                    {
                        st_1 = 0;
                        st_2 = m / 2;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        buf = arr[i, st_1];
                        arr[i, st_1] = arr[i, st_2];
                        arr[i, st_2] = buf;
                    }

                    Console.WriteLine("Вывод результата");
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            Console.Write(arr[i, j] + "  ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            catch { Console.WriteLine("Некорректный ввод данных!!!"); }

        }
        static void Main(string[] args)
        {

                f();
            Console.ReadKey();
        }
    }
}
