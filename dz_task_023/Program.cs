// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9. 
// 5 -> 1, 8, 27, 64, 125

// 3 -> 1, 8, 27 
// 5 -> 1, 8, 27, 64, 125






int InputNumber(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

int n = InputNumber("Введите число ");
System.Console.WriteLine();

for (int i = 1; i <= n; i++)
{
    System.Console.WriteLine(Math.Pow(i, 3));
}