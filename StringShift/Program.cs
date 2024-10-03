using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите строку:");
        string input = Console.ReadLine();

        // Удаляем пробелы из строки
        input = RemoveSpaces(input);

        if (input.Length % 2 == 0)
        {
            // Строка имеет четное количество символов
            int mid = input.Length / 2;
            string firstHalf = input.Substring(0, mid);
            string secondHalf = input.Substring(mid);

            // Переворачиваем обе подстроки
            string reversedFirstHalf = ReverseString(firstHalf);
            string reversedSecondHalf = ReverseString(secondHalf);

            // Соединяем подстроки обратно
            string result = reversedFirstHalf + reversedSecondHalf;
            Console.WriteLine("Результат: " + result);
        }
        else
        {
            // Строка имеет нечетное количество символов
            string reversedInput = ReverseString(input);
            string result = reversedInput + input;
            Console.WriteLine("Результат: " + result);
        }
    }

    // Метод для переворота строки
    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    // Метод для удаления пробелов из строки
    static string RemoveSpaces(string str)
    {
        return str.Replace(" ", "");
    }
}
