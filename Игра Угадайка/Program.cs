using System.ComponentModel;

while (true)
{
    Console.WriteLine("1)Угадай число\n2)Табилца Умножения\n3)Вывод делителей числа");
    Console.Write("Ввод:");
    string? choose = Console.ReadLine();
    switch (choose)
    {
        case "1":
            Random rnd = new Random();
            int value = rnd.Next(0, 100);
            int x = -1000;
            Console.WriteLine("Угадайте число");
            Console.WriteLine("Чтобы выйти введите число -1");
            while (x != value)
            {
                Console.Write("Ввод:");
                x = Convert.ToInt32(Console.ReadLine());
                if (x == value)
                {
                    Console.WriteLine("Вы угадали");
                }
                else if(x == -1)
                {
                    break;
                }
            }
            break;
        case "2":
            
            var table = new int[10, 10];
            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < 10; ++j)
                {
                    table[i, j] = i * j;
                }
            }
            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < 10; ++j)
                {
                    Console.Write("{0, 3}", table[i, j]);
                }
                Console.WriteLine();
            }
            break;
        case "3":
            int z = -1000;
            while (z != -1)
            {
                Console.Write("Введите число: ");
                z = Convert.ToInt32(Console.ReadLine());
                if (z != -1)
                {
                    List<int> numbers = new List<int>() { };
                    for (int i = 1; i <= z; i++)
                    {
                        if (z % i == 0)
                        {
                            numbers.Add(i);
                        }
                    }
                    foreach (int y in numbers)
                    {
                        Console.WriteLine(y);
                    }
                    Console.WriteLine("Для выхода введите число -1");
                }
            }
            break;
    }
}