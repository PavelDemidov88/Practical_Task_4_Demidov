// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
//  возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Number()
{
    Console.WriteLine("Введите число: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}
int Degree()
{
    Console.WriteLine("Введите степень: ");
    int deg = int.Parse(Console.ReadLine());
    return deg;
}
int num = Number();
int deg = Degree();

Console.Write($"Число {num} в степени {deg} равняется {Math.Pow(num, deg)}");