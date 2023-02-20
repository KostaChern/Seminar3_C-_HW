// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом. Проверка без применения строк

// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Clear();

int number = InputInt("Введите  пятизначное число > ");
int InputInt(string message)
{
    System.Console.Write($"{message}> ");
    int value;
    if (int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}


bool Validate(int numb)
{
    if (numb > 9999 && numb <= 99999)
    {
        return true;
    }

    Console.WriteLine("число не 5-значное");
    return false;
}



if (Validate(number))
{
    int num1 = number / 10000;
    int num2 = number % 10;
    int num3 = number / 1000 % 10;
    int num4 = number % 100 / 10;

    if (num1 == num2 && num3 == num4)
    {
        Console.WriteLine($"число {number} зеркальное, ПАЛИНДРОМ");
        Environment.Exit(1);
    }

    Console.WriteLine($"число {number} не зеркальное");

}



