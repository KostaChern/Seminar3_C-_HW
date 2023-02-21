// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу
// кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Clear();
int number = InputInt("Введите число N, до которого получаем квадраты: ");  
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

for (int i = 1; i <= number; i++)   
{
    int square = i * i;              
    System.Console.Write($"{square} ");
} 
