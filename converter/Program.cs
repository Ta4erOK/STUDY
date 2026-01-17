/*
Console.WriteLine("Конвертер");
Console.WriteLine("Введите число для перевода: ");

double a = Convert.ToDouble(Console.ReadLine());

Dictionary<string, double> units = new Dictionary<string, double>()
{
    {"km", 1000.0},      // 1 км = 1000 м
    {"m", 1.0},          // базовая единица
    {"cm", 0.01},        // 1 см = 0.01 м
    {"mm", 0.001},       // 1 мм = 0.001 м
    {"mile", 1609.34},   // 1 миля = 1609.34 м
    {"foot", 0.3048},    // 1 фут = 0.3048 м
    {"inch", 0.0254},    // 1 дюйм = 0.0254 м
    {"yard", 0.9144}     // 1 ярд = 0.9144 м
};

double ConvertLength(double value, string fromUnit, string toUnit)
{
    double fromCoefficient = units[fromUnit]; // units["m"] вернёт 1.0
    double toCoefficient = units[toUnit];     // units["km"] вернёт 1000.0

    double result = (value * fromCoefficient) / toCoefficient;

    return result;
}

// Пример вызова
double kilometersToMeters = ConvertLength(a, "km", "m");
// 5 км → метров: (5 * 1000) / 1 = 5000

Console.WriteLine(kilometersToMeters);
*/






Dictionary<string, string> phones = new Dictionary<string, string>()
{
    {"Петя", "123"},      
    {"Маша", "1234"},          
    {"Каша", "12345"},        
    {"Дима", "123456"},       
    {"Даня", "1234567"},   
    {"Игорь", "12345678"},    
    {"Саша", "123456789"},    
    {"Глеб", "1234567890"}    
};

Console.WriteLine("Введите имя: ");
string ?nameadd = Console.ReadLine();
Console.WriteLine("Введите Телефон: ");
string ?phoneadd = Console.ReadLine();
phones.Add(nameadd, phoneadd);
Console.WriteLine("Контакт добавлен!");


Console.WriteLine("Введите имя для поиска: ");
string ?name = Console.ReadLine();

if (phones.ContainsKey(name))  
{
    string phoneNumber = phones[name];
    Console.WriteLine($"{name}: {phoneNumber}");
}
else
{
    Console.WriteLine($"Контакт '{name}' не найден");
}


phones.Remove("Глеб");


Console.WriteLine("------------------------------------------------\nВесь список!");
foreach (var person in phones)
{
    Console.WriteLine($"key: {person.Key}  value: {person.Value}");
}

