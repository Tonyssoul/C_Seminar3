// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).




int InputNumber(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

int a = InputNumber("Введите номер четверти ");

if (a == 1)
{
    System.Console.WriteLine("Диапозон точек в заданой четверти х>0 и y>0 ");
}

else if (a == 2)
{
    System.Console.WriteLine("Диапозон точек в заданой четверти х<0 и y>0 ");
}

else if (a == 3)
{
    System.Console.WriteLine("Диапозон точек в заданой четверти х<0 и y<0 ");
}

else if (a == 4)
{
    System.Console.WriteLine("Диапозон точек в заданой четверти х>0 и y<0 "); ;
}

else
{
    System.Console.WriteLine("Такой четверти не существует");
}


