// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
int a = new Random ().Next(1,8);
Console.WriteLine(a);
if (a==6 || a==7) Console.WriteLine("Это выходной день");
else Console.WriteLine("Это будний день");