// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int []GetRandomArray(int size,int leftRange,int rightRange)
{
    int[]array=new int [size];
   
    for (int i=0; i<size; i++)
    {
        array[i] =new Random().Next(leftRange,rightRange+1);
    }
    return array;
    
}
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите левую границу массива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите правую границу массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[]massive=GetRandomArray(size,min,max);
Console.WriteLine(string.Join("," , massive));


int Sum(int[]array)
{
    int count = 0;
    for(int i=0; i<size; i++)
{
if(i%2 != 0)
count+=array[i];
}
return count;
}

int result=Sum(massive);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {result}");

