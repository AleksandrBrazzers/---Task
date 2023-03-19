int number;
 Console.Write("Введите число: ");
        number = Convert.ToInt32(Console.ReadLine());
        {
            number = number / 1 % 10;
            Console.WriteLine("Последняя цифра введенного числа: " + number);
        }
//         int thirdDigit = number / 100 % 10;
//         if (thirdDigit == 0)
//  {
//             Console.WriteLine("Третьей цыфры нет.");
//         }
//         else
//         {
//             Console.WriteLine("Третья цифра " + thirdDigit);
// }