//нахождение четных чисел от 100 до 999
/*void InputArray(double[] array)
{
    for (double i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}
double CountEventNumbers (double[] array)
{
double count = 0;
    for (double i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0 )
        count++;
    }
   return count;
}
Console.Write("введите кол-во элементов массива");
double n = Convert.Todouble32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"начальный массив: [{string.Join(", ", array)}]");
Console.Write(CountEventNumbers(array));*/







//сумма чисел стоящих на нечетных позициях
/*void InputArray(double[] array)
{
    for (double i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 10);
}
double CountEventNumbers(double[] array)
{
double count = 0;
    for (double i = 1; i < array.Length; i+=2)
    {
       
        count+=array[i];
    }
    return count;
}
Console.Write("введите кол-во элементов массива");
double n = Convert.Todouble32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"начальный массив: [{string.Join(", ", array)}]");
Console.Write(CountEventNumbers(array));*/







//нахождение разницы между макс и мин
/*void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().NextDouble() * 10;
}
double CountEventNumbers(double[] array)
{
    double Max = array[0], Min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
    if (Max<array[i])
        Max = array[i];
        else if (Min>array[i])
        Min = array[i];
}
   return Max-Min;
}
Console.Write("введите кол-во элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"начальный массив: [{string.Join(", ", array)}]");
Console.Write($"разница между Макс и Мин: {CountEventNumbers(array)}");*/

