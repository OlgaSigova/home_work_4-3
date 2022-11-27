//Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] GetArray(int size)
{
    int[] array1 = new int[size];

    for (int i = 0; i < size; i++)
    {
        array1[i] = new Random().Next(0,100);
    }

    return array1;

}
int[] array = GetArray(8);

Console.WriteLine(String.Join(",", array[0],array[1],array[2],array[3],array[4]));
Console.WriteLine(String.Join(",", array[5],array[6],array[7]));
