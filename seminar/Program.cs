// task 31

/*void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}

int SummaPositiveNumbers(int[] array)
{
    int summaP = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            summaP += array[i];
    }
    return summaP;
}
int SummaNegativNumbers(int[] array)
{
    int summaN = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            summaN -= array[i];
    }
    return summaN;
}

Console.Clear();
int[] array = new int[12];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"сумма положительных элементов равна: {SummaPositiveNumbers(array)}");
Console.WriteLine($"сумма отрецательных элементов равна: {SummaNegativNumbers(array)}");*/


//напишите программу по замене отр цифр на полож и на оборот


/*void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}

void ReleaseArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = array[i] * (-1);

    
}


Console.Clear();
Console.Write("введитекол-во элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[12];
InputArray(array);
Console.WriteLine($"начальный массив: [{string.Join(", ", array)}]");
ReleaseArray(array);
Console.WriteLine($"конечный массив: [{string.Join(", ", array)}]");*/




/*void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
    }

string ReleaseArray(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {   
    if (array[i] == number)
       return "yes";
    }
    return "no";
}
 Console.Write("введите кол-во элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"начальный массив: [{string.Join(", ", array)}]");
Console.Write("введите число которое вы хотите найти");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"{ReleaseArray(array, m)}");*/


//нахождение сколько элементов от 10 до 99

/*void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 100);
}
int ReleaseArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
  {
      if (array[i]>= 10 && array[i]<=99)
    count++;
  }
  return count;
}
Console.Write("введите кол-во элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"начальный массив: [{string.Join(", ", array)}]");
Console.Write(ReleaseArray(array));*/


// программа которая умнажает в массиве первое и последнее число второе и предпоследнее
/*
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 6);
}
void ReleaseArray(int[] array)
{

    for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
    {
        Console.Write($"{array[i] * array[array.Length - i - 1]} ");

    }
}
Console.Write("введите кол-во элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"начальный массив: [{string.Join(", ", array)}]");
ReleaseArray(array);*/

