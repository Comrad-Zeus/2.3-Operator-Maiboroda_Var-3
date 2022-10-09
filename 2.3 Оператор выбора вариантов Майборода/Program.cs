// 2.3. Оператор выбора вариантов - Майборода - Вар 3 - Средний Уровень (5)
double x, y=0, b=0, m=0, n=0;
byte option;

try

{
    Console.Write("Введите x:");
    x = double.Parse(Console.ReadLine());
    Console.Write("Введите вариант:");
    option = byte.Parse(Console.ReadLine());

    switch (option)
    {
        case 1: b = -1.6; m = 0.9; n = -1.4; break;
        case 2: b = 4.5; m = -2; n = 2.2; break;
        case 3: b = -4.5; m = 0.5; n = -1.5; break;
        default: Console.WriteLine("Нет такого варианта."); break;

    }

    if (Math.Abs(b * m) > x * x) y = Math.Sin(b * m + Math.Cos(n * x));
    else if (Math.Abs(b * m) < x * x) y = Math.Cos(b * m - Math.Sin(x));
    else if (Math.Abs(b * m) == x * x) y = Math.Sqrt(Math.Exp(Math.Abs(Math.Cos(x)))) + Math.Sqrt(Math.Abs(b * m * x));

    Console.WriteLine($"Y = {y:F2}");
}

catch (Exception ex)

{ 
    Console.WriteLine(ex.Message); 
}