Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int c = 0;

Console.Write("Выберите операцию:\n1-сложение \n2-вычитание \n3-умножение \n4-деление \n \n");
int o = Convert.ToInt32(Console.ReadLine());

if (o == 1)
{
    Console.WriteLine($"Сложение");
    c = a + b;
}
else if (o == 2)
{
    Console.WriteLine($"Вычитание");
    c = a - b;
}
else if (o == 3)
{
    Console.WriteLine($"Умножение");
    c = a * b;
}
else if (o == 4)
{
    Console.WriteLine($"Деление");
    c = a / b;
}
else 
{
    Console.WriteLine($"Ошибка");
}

Console.WriteLine($"\nИтого:{c}");
//Console.WriteLine($"Итого: {a} + {b} = {a + b}");

