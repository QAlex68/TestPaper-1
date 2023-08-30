// Контрольная задача - реализация C#: Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] GetShortStrings(string[] array, int count, int shortCount)
{  
    string[] shortArray = new string[shortCount];
    int j = 0;
    for (int i = 0; i < count; i++)
    {
        if (array[i].Length <= 3)
        {
            shortArray[j] = array[i];
            j++;
        }         
    }
    return shortArray; 
}

int CountShortStr(string[] array, int count)
{
    int small = 0;
    for (int i = 0; i < count; i++)
    {
        if (array[i].Length <= 3) small++;
        
    }
    return small;
}

string[] GetStrArray(int count)
{
    string[] inputArray = new string[count];    
    Console.WriteLine($"Введите строковые переменные любой длины {count} раз:");
    for (int i = 0; i < count; i++)   
    {
        Console.Write("Следующая переменная: ");
        string? input = Console.ReadLine();
        if (input!.Length != 0) inputArray[i] = input;
        else inputArray[i] = "_";
    }
    return inputArray;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите количество элементов массива: ");
string [] myArray = GetStrArray(m);
Console.WriteLine($"Сгенерирован массив - [{String.Join(", ", myArray)}]");
int shortCount = CountShortStr(myArray, m);
string [] shortArray = GetShortStrings(myArray, m, shortCount);
Console.WriteLine($"Массив строк длиной не более 3 символов - [{String.Join(", ", shortArray)}]");