// Написать программу, которая из имеющегося массива слов
// формирует массив из строк, длина которых меньше либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать в начале.
// Использовать массивы.




string[] CreateArray(int size) //Создаем массив, его длина вводится с клавиатуры (size).
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {   
        Console.WriteLine("Введите слово");
        string word = Console.ReadLine();
        array[i] = word;
    }
    return array;
}

int Counter (string[] array) //Считаем количество слов с длиной, меньшей 4 символов
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) counter++;
    }
    return counter;
}

string[] ArrayOfPassedWords(string[] array, int newSize) // Создаем новый массив с длиной, равной значению, 
{                                                        // полученному в методе Counter
    int index = 0;                                       // Создаем счетчик индексов нового массива (index). 
    string[] newArray = new string[newSize];             // Он будет увеличиваться на единицу, если условие выполнится.
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            newArray[index] = array[i];
            index++;
        }
    }
    return newArray;
}
    
void PrintStringArray(string[] array) // Этот метод выводит массив на экран (первый и второй массивы).
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        Console.Write($"\"{array[i]}\", ");
        else Console.Write($"\"{array[i]}\"");
    }
    Console.WriteLine("]");
}

Console.WriteLine("Введите желаемое количество слов");
int size = Convert.ToInt32(Console.ReadLine());
string[] arrayOfWords = CreateArray(size);

PrintStringArray(arrayOfWords);

int counter = Counter(arrayOfWords);
Console.WriteLine($"Количество слов до 4 знаков --> {counter}");
string[] arrayPassed = ArrayOfPassedWords(arrayOfWords, counter);

PrintStringArray(arrayPassed);