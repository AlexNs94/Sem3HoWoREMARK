//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Clear();
int DataEntryXY(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}
double Distantion(int x1, int x2, int y1, int y2, int z1, int z2)
{
    // return Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    double rast = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    return rast;
}

int x1 = DataEntryXY("Введите координаты x1 = ");
int y1 = DataEntryXY("Введите координаты y1 = ");
int z1 = DataEntryXY("Введите координаты z1 = ");
int x2 = DataEntryXY("Введите координаты x2 = ");
int y2 = DataEntryXY("Введите координаты y2 = "); 
int z2 = DataEntryXY("Введите координаты z2 = ");

double points = Distantion(x1, x2, y1, y2, z1, z2);

Console.WriteLine(points);
