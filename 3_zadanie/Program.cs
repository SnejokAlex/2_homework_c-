// Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите номер четверти");
int number = int.Parse(Console.ReadLine());
if (number==1) Console.WriteLine("В этой четверти координаты X>0, Y>0");
else if (number==2) Console.WriteLine("В этой четверти координаты X<0, Y>0");
else if (number==3) Console.WriteLine("В этой четверти координаты X<0, Y<0");
else if (number==4) Console.WriteLine("В этой четверти координаты X>0, Y<0");
else Console.WriteLine("Введите число от 1 до 4");