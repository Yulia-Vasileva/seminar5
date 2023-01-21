// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int []GetRandomArray(int size,int leftRange,int rightRange)
{
    int[]array=new int [size];
    size = 123;

    for (int i=0; i<size; i++)
    {
        array[i] =new Random().Next(0,151);
    }
    return array;
    
}
int[]massive=GetRandomArray(123,0,151);
Console.WriteLine(string.Join("," , massive));


int Number(int[]array)
{
    int count = 0;
    for(int i=0; i<array.Length; i++)
    {   
        if (array [i] > 10 && array[i]< 99)
          count++;
    }
return count;
}

int result=Number(massive);
Console.WriteLine($"Количество элементов: {result}");

