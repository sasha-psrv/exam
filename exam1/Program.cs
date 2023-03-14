// Из имеющего массива выбрать массив, длинна которого не более 3 строк

Console.Clear();
string[] GetArray = new string[5] {"472", "8", "59370", "hi", "hello"};
int CountNumber(string[] array)
{
    int count = 0;

    for (int i = 0; i < GetArray.Length; i++)
    {
        if (GetArray[i].Length <= 3)
        {
            count++;
        }
        
    }
    return count;
}

Console.WriteLine(String.Join(", ", GetArray));
int count = CountNumber(GetArray);
Console.WriteLine(count);