Console.WriteLine("Игра угадай число! \nДано 5 попыток \nДиапозон от 1 до 100");
Console.WriteLine("\nВведите число: ");
int p = 5;
int d = 100;
Random rnd1 = new Random();
bool f = true;
int c = rnd1.Next(1, d + 1);

while (f)
{
    int a = Convert.ToInt32(Console.ReadLine());

    if (a == c)
    {
        Console.WriteLine("Ты угадал!\nПоздравляю!");
        f = false;
    }
    else if (a < c)
    {
        Console.WriteLine("Загаданое число больше!");
        pop();
    }
    else
    {
        Console.WriteLine("Загаданое число меньше!");
        pop();
    }
}

void pop()
{
    p -= 1;
    Console.WriteLine($"Осталось {p} попыток");
    if (p == 0)
    {
        //Console.WriteLine($"delete system32...");
        Console.WriteLine($"Увы,ты проиграл!");
        Console.WriteLine($"Загаданное число было {c}!");
        f = false;
    }
}