// Написать программу, которая из имеющегося строкового массива сформирует массив из строк, длина которых не превышает 3 элемента
string[] EnterArray(int size1)
{
    var array1 = new string[size1];
    for (int i = 0; i < size1; i++)
    {
        Console.WriteLine($"Введите {i+1}ю строку");
        array1[i]=Console.ReadLine();
    }
Console.Write("Введен массив: [");
for (int j = 0; j < size1-1; j++)
{
    Console.Write($"{array1[j]}, ");
}
Console.WriteLine($"{array1[size1-1]}]");
return array1;
}