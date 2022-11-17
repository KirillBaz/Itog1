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
string[] CreateNewArray(string[] originalArray)
{
    int newSize = 0;
    for (int i = 0; i < originalArray.Length; i++)
    {
        if (originalArray[i].Length<=3)
        {
            newSize++;
        } 
    }
    var newArray = new string[newSize]; 
    for (int j = 0; j < newSize; j++)
    {
        for (int k = 0; k < originalArray.Length; k++)
        {
            if (originalArray[k].Length<=3) 
            {
                newArray[j]=originalArray[k];
                originalArray[k]=originalArray[k]+"    ";
                break;
            }
        }
    }
return newArray;
}
void PrintNewArray(string[] changedArray)
{
Console.Write("Новый массив: [");
for (int i = 0; i < changedArray.Length-1; i++) Console.Write($"{changedArray[i]}, ");
Console.Write(changedArray[changedArray.Length-1]+"]");
}
PrintNewArray(CreateNewArray(EnterArray(4)));