// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Promted()
{
    Console.WriteLine("Введите число: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}
int Summa(int num)
{
    int i = 0;
    while (num > 0)
    {
       i = i + num%10;
       num = num/10;
    }
    return i;
}
int num = Promted();
Console.WriteLine($"Сумма цифр в числе {num} равна {Summa(num)}");