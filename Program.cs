// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


//  Console.WriteLine("Введите пятизначное число: ");
// string number = Console.ReadLine()!;
// int Length = number.Length;

// if (number.Length == 4)
// {
//    Console.WriteLine ($"{number} - пятнизначное число");

//    if (number [0] == number [4] && number [1] == number [3])
   
//       Console.WriteLine ($"{number} - число является палиндромом");}
// else 
// {
// Console.WriteLine ($"{number} - число не является палиндромом");
// }
   


   // Console.WriteLine("Введите пятизначное число: ");
   // int Number = Convert.ToInt32(Console.ReadLine());

   // if (Number >= 10000 && Number <= 100000)
   // {
   //    int firstDigit = Number/10000;
   //    int secondDigit = Number / 100 % 10;
   //    int thirdDigit = Number;
   //    int fourthDigit = Number%100;
   //    int fifthDigit = Number%10;

   //    if(firstDigit == fifthDigit && secondDigit == fourthDigit)
   //    {
   //       Console.WriteLine("Число является палиндромом");
   //    }
      
   // }

   // else{
   //    Console.WriteLine("Непятизначное число");
   // }




// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Write("Введите координату х1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату у1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());


// Console.Write("Введите координату х2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату у2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double D = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) );
// Console.WriteLine($"Расстояние между точками А:({x1},{y1},{x1}) и В:({x2},{y2},{x2})  равно: {Math.Round(D,2)}"); 


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= N; i++)
// {
//     Console.Write(Math.Pow(i, 3) + "\t"); 
// }
