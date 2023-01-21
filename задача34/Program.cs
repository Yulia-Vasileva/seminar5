//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int []GetRandomArray(int size,int leftRange,int rightRange)
{
    int[]array=new int [size];
   
    for (int i=0; i<size; i++)
    {
        array[i] =new Random().Next(100,1000);
    }
    return array;
    
}
Console.WriteLine("Введите размер массива: ");

int size = Convert.ToInt32(Console.ReadLine());

int[]massive=GetRandomArray(size,100,1000);
Console.WriteLine(string.Join("," , massive));


int Number(int[]array)
{
    int count = 0;
    for(int i=0; i<size; i++)
{
if(array[i]%2==0)
count++;
}
return count;
}

int result=Number(massive);
Console.WriteLine($"Количество чётных чисел  {result}");




