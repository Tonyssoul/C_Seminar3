// Задача 19: Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли 
// оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да


int InputNumber(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

int x = InputNumber("Введите пятизначное число ");

int[] arr = new int[5];
if (x>9999 && x<100000)
{
    for (int i = 4; i >= 0; i--)
    {
        arr[i] = x % 10;
        x = x / 10;
    }


    if (arr[0] == arr[4] && arr[1] == arr[3])
    {
        System.Console.WriteLine("Да");
    }
    else
    {
        System.Console.WriteLine("Нет");
    }
}
else
{
    System.Console.WriteLine("Число не является пятизначным");
}    