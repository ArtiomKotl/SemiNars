//16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
//5, 25  ->  да
//-4, 16  ->  да
//25, 5  ->  да
//8,9  ->  нет

Console.WriteLine("Введите 2 числа, программа проверит, является ли одно из них квадратом второго");

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

int meth1(int arg1) {
    int result = arg1 * arg1;
    return result;
}
if (meth1(number1) == number2 || meth1(number2) == number1) Console.WriteLine("да");
else Console.WriteLine("нет");


// -------------------- // 


Console.Write("Введите первое число: ");
int numOne = Convert.ToInt32( Console.ReadLine() );  

Console.Write("Введите второе число: ");
int numTwo = Convert.ToInt32( Console.ReadLine() );  

double sqrtNumOne = Math.Sqrt(numOne);
double sqrtnumTwo = Math.Sqrt(numTwo);

System.Console.WriteLine(sqrtNumOne == Math.Abs(numTwo) || sqrtnumTwo == Math.Abs(numOne) ? "Да" : "Нет");

// -------------------- // 

double powNumOne = Math.Pow(numOne, 2);
double pownumTwo = Math.Pow(numTwo, 2);

System.Console.WriteLine(powNumOne == numTwo || pownumTwo == numOne ? "Да" : "Нет");

// -------------------- // 

Console.WriteLine("Введите 2 числа, программа проверит, является ли одно из них квадратом второго");

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

int meth1(int arg1) {
    int result = (int) Math.Pow(arg1, 2);
    return result;
}

if (meth1(number1) == number2 || meth1(number2) == number1) Console.WriteLine("да");
else Console.WriteLine("нет");