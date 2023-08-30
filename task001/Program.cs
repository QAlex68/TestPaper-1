// Контрольная задача - реализация C#: Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

List<string> GetShortStrings(List<string> array)
{  
    List<string> newArray = new List<string>();
    for (int i = 0; i < array.Count; i++)
    {
        if (array[i].Length <= 3) newArray.Add(array[i]);          
    }
    return newArray; 
}

List<string> GetDynamicArray()
{
    List<string> dArray = new List<string>();
    Console.WriteLine("Введите строковые переменные любой длины (окончание ввода пустая строка):");    
    while(true)
    {
        Console.Write("Следующая переменная: ");
        string? input = Console.ReadLine();
        //if (!string.IsNullOrWhiteSpace(input)) dArray.Add(input);
        if (input!.Length != 0) dArray.Add(input);
        else break;              
    }       
    return dArray;
}

List<string> myArray = GetDynamicArray();
Console.WriteLine($"Сгенерирован массив - [{String.Join(", ", myArray)}]");
List<string> shortArray = GetShortStrings(myArray);
Console.WriteLine($"Массив строк длиной более 3 элементов - [{String.Join(", ", shortArray)}]");

