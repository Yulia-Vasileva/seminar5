// Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[]array ={9,100,2,7,43};

int max=array[0];
int min=array[0];
for (int i = 0; i < array.Length; i++)
{
if(array[i]>max)
{
    max=array[i];
}
else if(array[i]<min)
{
    min=array[i];
}
}
Console.WriteLine ($"Максимальное значение массива = {max}");
Console.WriteLine ($"Минимальное значение массива = {min}");

int difference=max-min;

Console.WriteLine ($"Разница = {difference}");
