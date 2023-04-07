// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int ReadLInt(string message)
{
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}
int ax = ReadLInt("Koord x first point");
int ay = ReadLInt("Koord y first point");
int bx = ReadLInt("Koord x seconde point");
int by = ReadLInt("Koord y seconde point");
int cx = ReadLInt("Koord x third point");
int cy = ReadLInt("Koord y third point");

int koordX = (ax - bx - cx);
int koordY = (ay - by - cx);

double W = Math.Sqrt(Math.Pow(koordX,2) + Math.Pow(koordY,2));
Console.WriteLine(W);
Console.WriteLine($"Shox result {W:f2}" );
