int number;
 Console.Write("Введите число: ");
        number = Convert.ToInt32(Console.ReadLine());
        int thirdDigit = number / 100 % 10;
        if (thirdDigit == 0)
 {
            Console.WriteLine("Третьей цыфры нет.");
        }
        else
        {
            Console.WriteLine("Третья цифра " + thirdDigit);
}