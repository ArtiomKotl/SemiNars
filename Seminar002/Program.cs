// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

int number = new Random().Next(100, 999);

Console.WriteLine("Сгенерировано число: " + number);

int firstDigit = number / 10;
int secondDigit = number % 10;

int maxDigit = 0;

if (firstDigit > secondDigit)
    maxDigit = firstDigit;
else
    maxDigit = secondDigit;

Console.WriteLine("Наибольшая цифра в числе " + number + ": " + maxDigit);

//Пример 2

if(int.TryParse(Console.ReadLine(), out int number))
    Console.WriteLine("Прочитали число: " + number);
else
    Console.WriteLine("Ввод неверный. Пожалуйста, введите корректное число");





// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98

int num = new Random().Next(100, 1000);

int num1 = (num / 100) * 10;
int num3 = num % 10;

Console.WriteLine($"Начальное число {num}. Результат после удаления второй цифры: {num1 + num3}");


// 12. 


Console.Write("Введите первое число: ");
int numOne = Convert.ToInt32( Console.ReadLine() );  

Console.Write("Введите второе число: ");
int numTwo = Convert.ToInt32( Console.ReadLine() );
int result = numOne % numTwo;

if (result == 0)
{
    System.Console.WriteLine("кратно");
}
else
{
    System.Console.WriteLine($"Не кратно, остаток {result}");
}


// Вариант

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == 0 || number2 == 0) {
    System.Console.WriteLine("Одно из чисел является нулём");
    return;
}


int result = number1 % number2;

if (result == 0)     
    Console.WriteLine("кратно"); 
else     
    Console.WriteLine("не кратно, остаток " + result);


    