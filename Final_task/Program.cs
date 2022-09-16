string[] array = { "hello", "2", "world", ":-)" };
int CalcNewArrayLength(string[] array)
{
    int length = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            length++;
    }
    return length;
}

string[] NewArray(string[] array, int N)
{
    string[] newArray = new string[N];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

void PrintArray(string[] arr)
{
    int length = arr.Length;
    Console.Write("[");
    for (int i = 0; i < length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[length - 1] + "]");
}
int newArrayLength = CalcNewArrayLength(array);
string[] newArray = NewArray(array, newArrayLength);
PrintArray(newArray);
