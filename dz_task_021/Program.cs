// Задача 21: Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int InputNumber(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = InputNumber("Введите координату х первого числа ");
int y1 = InputNumber("Введите координату у первого числа ");
int z1 = InputNumber("Введите координату z первого числа ");
int x2 = InputNumber("Введите координату х второго числа ");
int y2 = InputNumber("Введите координату у второго числа ");
int z2 = InputNumber("Введите координату z первого числа ");

System.Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)),2));