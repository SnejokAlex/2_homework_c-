// Найти расстояние между точками в пространстве 2D/3D
int XA = new Random().Next(-100,100);
int YA = new Random().Next(-100,100);
int ZA = new Random().Next(-100,100);
Console.WriteLine("координаты Точки A " + XA);
Console.Write(", " +YA);
Console.Write(", " +ZA);
int XB = new Random().Next(-100,100);
int YB = new Random().Next(-100,100);
int ZB = new Random().Next(-100,100);
Console.WriteLine("координаты Точки B "+XB);
Console.Write(", " +YB);
Console.Write(", " +ZB);

int result1 = XB-XA;
result1 = result1*result1;
int result2 = YB-YA;
result2 = result2*result2;
int result = result1+result2;
double resultat = Math.Sqrt(result);
Console.Write("Расстояние между точками 2D: " +resultat);
int result3 = ZB-ZA;
result3 = result3*result3;
result3 = result+result3;
double resultat3d = Math.Sqrt(result3);
Console.Write("Расстояние между точками 3D: " +resultat3d);