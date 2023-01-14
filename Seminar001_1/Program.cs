// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет
//3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//	3 -> Среда 
//5 -> Пятница

Console.Write("Введите номер (от 1 до 7) дня недели: ");
int numDay = Convert.ToInt32( Console.ReadLine() ); // читаем из консоли номер недели

switch (numDay)
{
   case 1:
        Console.Write("Понедельник");
        break;
   case 2:
        Console.Write("Вторник");
        break;
   case 3:
        Console.Write("Среда");
        break;
   case 4:
        Console.Write("Четверг");
        break;
   case 5:
        Console.Write("Пятница");
        break;
   case 6:
        Console.Write("Суббота");
        break;
   case 7:
        Console.Write("Воскресенье");
        break;

    default:
        Console.Write("Вы ввели не верный номер дня недели");
        break;
}

