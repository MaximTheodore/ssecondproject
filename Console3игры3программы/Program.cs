while (true)
{
    Console.WriteLine("Выберите программу, которую хотите запустить");
    Console.WriteLine("1. Угадай число");
    Console.WriteLine("2. Таблица умножения");
    Console.WriteLine("3. Вывод делителей числа");
    Console.WriteLine("4. Закрыть программу");



    int a = Convert.ToInt32(Console.ReadLine());

    switch (a)
    {
        case 1:
            {
                Console.WriteLine("Угадай число от 0 до 100");
                Random ran = new Random();
                int i = ran.Next(0, 100);
                int c = 0;

                Console.WriteLine("Введите число:");
                int k;
                do
                {

                    k = Convert.ToInt32(Console.ReadLine());

                    if (k < i)
                        Console.WriteLine("число больше");
                    if (k > i)
                        Console.WriteLine(" число меньше");

                    c++;
                } while (k != i);
                Console.WriteLine("Угадал");
            }
            break;
        case 2:
            {
                Int32[,] table9x9 = new Int32[10, 10];

                for (int i = 1; i < table9x9.GetLength(0); i++)
                {

                    for (int j = 1; j < table9x9.GetLength(1); j++)
                    {
                        table9x9[i, j] = i * j;

                    }

                }
                for (int i = 1; i < table9x9.GetLength(0); i++)
                {

                    for (int j = 1; j < table9x9.GetLength(1); j++)
                    {
                        Console.Write(table9x9[i, j] + " ");
                    }
                    Console.WriteLine(" ");
                }



            }
            break;
        case 3:
            {
                Console.Write("Введите число:");
                double f = Convert.ToDouble(Console.ReadLine());

                for (int p = 1; p <= f; p++)
                {
                    if (f % p == 0)
                        Console.Write(" {0}", p);
                }
                Console.WriteLine();
            }
            break;
        case 4:
            {
                Environment.Exit(0);
            }
            break;
    }
}
