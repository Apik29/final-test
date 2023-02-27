// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

string[] createArray()
{
    Console.WriteLine("Введите данные через пробел ");
    string createArray = Console.ReadLine();
    if (createArray == null) { createArray = ""; };
    char[] share = new char[] { ',', ' ' };
    string[] array = createArray.Split(share, StringSplitOptions.RemoveEmptyEntries);
    return array;
}

int Сounting(string[] array)
{
    int counter = 0;
    foreach (string item in array)
    {
        if (item.Length <= 3)
        {
            counter++;
        }
    }
    return counter;
}

string[] NewArray(string[] array)
{
    int resultArrayLength = Сounting(array);
    string[] resultArray = new string[resultArrayLength];
    int i = 0;
    foreach (string item in array)
    {
        if (item.Length <= 3)
        {
            resultArray[i] = item;
            i++;
        }
    }
    return resultArray;
}
string PrintArray(string[] array)
{
    string stringArray = "";
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            stringArray += $"\"{array[i]}\"";
            break;
        }
        stringArray += ($"\"{array[i]}\", ");
    }
    stringArray += "";
    return stringArray;
}
string[] array = createArray();
string[] resultArray = NewArray(array);
string finalArray = PrintArray(resultArray);
Console.WriteLine(finalArray);