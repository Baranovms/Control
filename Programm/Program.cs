// Написать программу, которая из имющегося массива строк формирует массив из строк,
//  длина которых меньше либо равна 3 символа. 
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения 
//  алгоритма. При решении не рекомендуется пользоваться коллекциями,
//  лучше обойтись исключительно массивами.



int Prompt(string message) //метод преобразования строки в целое число
{
    Console.Write(message);
    bool isDigit = int.TryParse(Console.ReadLine(), out int number);
    if (isDigit)
    {
        return number;
    }
    throw new Exception("Вы ввели не число");
}

string[] GenerateArray(int length) // метод создания строкового массива
{
    string[] answer = new string[length];
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] =Console.ReadLine();
    }
    return answer;
}

void PrintArray(string[] array) //метод печати массива
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"\"{array[i]}\"" + "  ");
    }
    System.Console.WriteLine();
}

string[] LengthWords (string[] array)
{
    string[] newArray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[i] = array[i];
        }
    }
    return newArray;
}

Console.Clear();
int length = Prompt("Введите количество вводимых слов: ");
string[] array = GenerateArray(length);
PrintArray(LengthWords(array));
