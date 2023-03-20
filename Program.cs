// Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine()!;
// int len = number.Length;

// if (len == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine("Число " + number + " - палиндром");
//     }
//     else
//     {
//         Console.WriteLine("Число " + number + " - не палиндром");
//     }
// }
// else
// {
//     Console.WriteLine("Число не является пятизначным");
// }

// Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// int ReadInt(String text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int[] a = new int[3];
// int[] b = new int[3];

// a[0] = ReadInt("Введите координату X точки А: "); 
// a[1] = ReadInt("Введите координату Y точки А: ");
// a[2] = ReadInt("Введите координату Z точки А: ");
// b[0] = ReadInt("Введите координату X точки B: "); 
// b[1] = ReadInt("Введите координату Y точки B: ");
// b[2] = ReadInt("Введите координату Z точки B: ");

// double res = Math.Sqrt(Math.Pow(b[0]-a[0],2) + Math.Pow(b[1]-a[1],2) + Math.Pow(b[2]-a[2],2));

// System.Console.WriteLine("Расстояние между точками = " + Math.Round(res, 2));

//Задача 3.Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int ReadInt(String text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int num =ReadInt("Введите число на вход: ");
for (int i=1; i<=num; i++)
{
    System.Console.Write(Math.Pow(i,3)+ " ");
}