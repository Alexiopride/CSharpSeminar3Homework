// Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine(); 

void Palindrome(string text)
{
    int length = text.Length;
    if (length == 5) 
    {
        int start = 0;
        int end = length - 1; 

        while (start < end)
        {
            if (text[start] == text[end])
            {
                start++;
                end--;
            }
            else
            {
                Console.WriteLine("Число не является палиндромом");
                return;
            }
        }
     Console.WriteLine("Число является палиндромом");
    } 
    else 
    {
        Console.WriteLine("Вы ввели не верное число. Введите пятизначное число");
    }
}
Palindrome(number);