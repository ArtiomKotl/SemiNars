// // Демонстрация решения
// // Задача 24: Напишите программу, которая принимает на вход число (А)
// // и выдаёт сумму чисел от 1 до А.
// // 7 -> 28
// // 4 -> 10
// // 8 -> 36

// int SumFromOneToN(int n)
// {
//     if (n < 1)
//         return -1;

//     int result = 0;

//     int counter = 1;

//     while(counter <= n) {
//         result += counter;
//         counter++;
//     }

//     return result;  
// }

// Console.WriteLine("Программа вычисления суммы чисел от 1 до N:");
// Console.WriteLine("Введите число:");
// int.TryParse(Console.ReadLine(), out int n);

// if (n < 1) {
//     Console.WriteLine("Число должно быть положительным");
//     return;
// }

// int result = SumFromOneToN(n);
// Console.WriteLine($"Результат: {result}");


// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// int NumberDigits(int num)
// {
//     if (num < 1)
//         return -1;
//     int ind = 0;
//     while (num > 0)
//     {
//         num /= 10;
//         ind++;
//     }
//     return ind;
// }

// Console.WriteLine("Программа показывает количество цифр в ведённом числе.");
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num < 0)
// {
//     Console.WriteLine("Введено число меньше 1. Выполнение программы прервано.");
//     return;
// }

// Console.WriteLine(NumberDigits(num));



// int CountNumbersN(int n)
// {
//      if (n == 0)
//          return 1;

//     int result = 0;

//     result = (int)Math.Log10(Math.Abs(n)) + 1;

//     //  while(n / 10 == 0) {
//     //         n /= 10;
//     //         result++;
//     //  } 

//     return result;  
// }

// Console.WriteLine("Программа вычисления количества цифр в числе:");
// Console.WriteLine("Введите число:");
// int.TryParse(Console.ReadLine(), out int n);


// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// int N = getVar();
// System.Console.WriteLine( multipler(N) );

// // --- FUNCs --- //
// int multipler(int num){
//     int outNum = 1;
//     for (int i = 1; i < num+1; outNum *= i++){}

//     return outNum;
// }
// int getVar(){
//     int varValue = 0;
//     bool isNumeric = false;

//     while (!isNumeric) {
//         Console.Write($"Введите число: ");
//         isNumeric = int.TryParse(Console.ReadLine(), out varValue);
//     }

//     return varValue;
// }


//----------//

// int N = getVar();
// System.Console.WriteLine( multipler(N) );

// // --- FUNCs --- //
// int multipler(int num){
//     int outNum = 1;
//     for (int i = 1; i < num+1; outNum *= i++){}

//     return outNum;
// }
// int getVar(){
//     int varValue = 0;
//     bool isNumeric = false;

//     while (!isNumeric) {
//         Console.Write($"Введите число: ");
//         isNumeric = int.TryParse(Console.ReadLine(), out varValue);
//         if (varValue < 0) {
//             isNumeric = false;
//         }
//     }

//     return varValue;
// }



// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


// int[] arrNum = new int[8];

// for (int i = 0; i < arrNum.Length; i++)
// {
//     Random rnd = new Random();
//     arrNum[i] = rnd.Next(0, 2);
// }

// System.Console.Write($"[{String.Join(",", arrNum)}]\n");


//--------//

// int N = getVar();
// System.Console.Write($"[{String.Join(",", genArr(N))}]\n");

// // --- FUNC --- //
// int[] genArr(int N)
// {
//   int[] arrNum = new int[N];

//   Random rnd = new Random();
//   for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(0, 2)) { }

//   return arrNum;
// }

// int getVar()
// {
//   int varValue = 0;
//   bool isNumeric = false;

//   while (!isNumeric)
//   {
//     Console.Write($"Введите число: ");
//     isNumeric = int.TryParse(Console.ReadLine(), out varValue);
//     if (varValue < 0)
//     {
//       isNumeric = false;
//     }
//   }

//   return varValue;
// }

// int[] EnterArray(int N)
//{
// int[] array = new int[N];
// int len = array.Length;
// for (int i = 0; i < len; i++)
// {
//    array[i] = new Random().Next(0,2);
// }
// return array;
// }

// void PrintArray(int[] array){
// int len = array.Length;
// System.Console.Write("[");
// for (int i = 0; i < len; i++)

// {if (i == len -1)
//    System.Console.Write($"{array[i]}]");
// else System.Console.Write($"{array[i]},");
// }
// }



// System.Console.WriteLine("Задача 28");
// System.Console.WriteLine("Введите размерность массива");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] arr = EnterArray(N);
// //int[] arr = {0,0,0,0,0,0,0,0};
// System.Console.WriteLine("Ваш массив");
// PrintArray(arr);


int N = getVar();
printArr(N);

// --- FUNC --- //
int[] genArr(int N)
{
  int[] arrNum = new int[N];

  Random rnd = new Random();
  for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(0, 2)) { }

  return arrNum;
}

void printArr(int N)
{
  System.Console.Write($"[{String.Join(",", genArr(N))}]\n");
}

int getVar()
{
  int varValue = 0;
  bool isNumeric = false;

  while (!isNumeric)
  {
    Console.Write($"Введите число: ");
    isNumeric = int.TryParse(Console.ReadLine(), out varValue);
    if (varValue < 0)
    {
      isNumeric = false;
    }
  }

  return varValue;
}