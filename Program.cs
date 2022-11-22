// Final task

/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символов. Первоначальный массив можно ввести с
клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется
пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

void PrintArray(string[] strArray)
{
    Console.Write("[");
    for (int i = 0; i < strArray.Length; i++)
    {
        Console.Write($"{strArray[i]}");
        if (i < strArray.Length - 1) Console.Write(",");
    }
    Console.Write("]");
}

Console.Clear();
Console.Write("Количество строк в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());
string[] array = new string[num];
for (int i = 0; i < num; i++)
{
    Console.Write($"Введите элемент {i + 1}: ");
    array[i] = Console.ReadLine();
}

PrintArray(array);

int count = 0;
for (int i = 0; i < num; i++)
{
    if (array[i].Length <= 3) count++;
}

string[] newArray = new string[count];
int j = 0;
for (int i = 0; i < num; i++)
{
    if (array[i].Length <= 3) newArray[j++] = array[i];
}

Console.WriteLine("\n");
Console.WriteLine("Результирующий массив");
PrintArray(newArray);
