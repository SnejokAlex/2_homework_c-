// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Введите 1 число");
int numbera = int.Parse(Console.ReadLine ());
Console.WriteLine("Введите 2 число");
int numberb = int.Parse(Console.ReadLine ());
int a = numbera * numbera;
int b = numberb * numberb;
if (numbera==b || numberb==a) Console.WriteLine("Одно из числе является квадратом другого");
else Console.WriteLine("Числа не являются квадратами друг друга");
