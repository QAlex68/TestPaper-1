// Контрольная задача - реализация C#: Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void PositiveNumber(List<int> array)
{  
    int count = 0;
    for (int i = 0; i < array.Count; i++)
    {
        if (array[i] > 0) count++;          
    }
    Console.WriteLine($"Количество чисел > 0 в массиве - {count} !!");
}

void PrintArray(double[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(massive[i,j],2)}\t", -5);
        }
        Console.WriteLine();
    }
}

List<string> GetDynamicArray()
{
    List<string> dArray = new List<string>();
    string str;
    bool isValidStr = false;
    Console.WriteLine("Введите строковые переменные любой длины (окончание ввода пустая строка):");    
    do
    {
        Console.Write("Следующая переменная: ");
        string input = Console.ReadLine();
        if (str.Length > 0) isValidStrNumber = true;
        {              
            dArray.Add(str);             
        }
    }    
    while(isValidStr);
    Console.WriteLine($"Сгенерирован массив - [{String.Join(", ", dArray)}]");
    return dArray;
}

PositiveNumber(GetDynamicArray());
