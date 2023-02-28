/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с 
клавиатуры, либо задать на старте выполнения алгоритма. Не использовать списки.
*/

public class SomeNewClass
{
    static string[] arr = { "It", "It's", "It isn't", "Kotlin!", "is!", "awesome!" };

    static string[] NewArray(string[] mas)
    {
        int x = 0;
        for (int i = 0; i < mas.Length; i++) if (mas[i].Length <= 3) x++;

        string[] mas2 = new string[x];

        int ind = 0;
        for (int i = 0; i < mas.Length; i++) if (mas[i].Length <= 3) { mas2[ind] = mas[i]; ind++; };

        return mas2;
    }

    static void ShowArray(string[] array)
    {
        Console.Write("[\"");
        Console.Write(String.Join("\", \"", array));
        Console.Write("\"]");
    }

    static void Main()
    {
        ShowArray(arr);
        string[] newarr = NewArray(arr);
        Console.Write(" -> ");
        ShowArray(newarr);

    }
}
