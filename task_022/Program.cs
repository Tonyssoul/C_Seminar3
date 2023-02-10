// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4



int InputNumber(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

int n = InputNumber("Введите число ");
System.Console.WriteLine();

for (int i = 1; i < n; i++)
{
    System.Console.WriteLine(Math.Pow(i, 2));
}