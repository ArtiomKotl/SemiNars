// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8


Console.WriteLine("Введите чило от 10 до 100");
if (int.TryParse(Console.ReadLine(), out int number))
{
  int firstDigit = number / 10;
  int secondDigit = number % 10;

  int maxDigit = 0;

  if (firstDigit > secondDigit)
    maxDigit = firstDigit;
  else
    maxDigit = secondDigit;

  Console.WriteLine("Наибольшая цифра в числе " + number + ": " + maxDigit);
}

else
  Console.WriteLine("Ввод неверный. Пожалуйста, введите корректное число");