// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

//Формула для нахождения растояния между двумя точками квадратный корень из (х2-х1)в квадрате + (у2-у1)в квадрате


int InputNumber(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = InputNumber("Введите координату х первого числа ");
int y1 = InputNumber("Введите координату у первого числа ");
int x2 = InputNumber("Введите координату х второго числа ");
int y2 = InputNumber("Введите координату у второго числа ");

System.Console.WriteLine(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));