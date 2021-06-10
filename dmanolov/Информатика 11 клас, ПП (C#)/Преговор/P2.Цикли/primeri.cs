using System;

class Start {
  public static void Demo () {
    // опитайте да обясните как действа всеки от примерите

    // 01.Цикъл for - четните числа до 100
    for (var i = 2; i <= 100; i=i+2)
    {
      Console.WriteLine(i);
    }
    
    // 02.Всички латински букви
    Console.Write("Latin alphabet:");
    for (var letter = 'a'; letter <= 'z'; letter++)
    {
      Console.Write(" " + letter);
    }
    Console.WriteLine();

    // 03.Обратно броене
    {
      var n = int.Parse(Console.ReadLine());
      for (var i = n; i >= 0; i--)
      {
        Console.Write(i + " ");
      }
      Console.WriteLine(" Start!");
    }

    // 04.Числата, завършващи на 7
    var count = 0;
    for (var i = 1; i <= 100; i++)
    {
      if (i % 10 == 7)
      {
          Console.Write(i + " ");
          count++;
      }
    }
    Console.WriteLine();
    Console.WriteLine("count = " + count);

    // 05.Сума и максимално число
    {
      Console.Write("n = ");
      var n = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter the numbers:");
      var sum = 0;
      var max = Int32.MinValue;
      for (var i = 0; i < n; i++)
      {
        var num = int.Parse(Console.ReadLine());
        sum = sum + num;
        if (num > max)
          max = num;
      }
      Console.WriteLine("sum = " + sum);
      Console.WriteLine("max = " + max);
    }

    // 06.Цикъл while - число от 1 до 100
    {
      var num = int.Parse(Console.ReadLine());
      while (num < 1 || num > 100)
      {
        Console.WriteLine("Invalid number!");
        num = int.Parse(Console.ReadLine());
      }
      Console.WriteLine($"The number is: {0}", num);
    }

    // 07.Цикъл do-while - сума на цифрите на число
    {
      var n = int.Parse(Console.ReadLine());
      var sum = 0;
      do
      {
        sum = sum + (n % 10);
        n = n / 10;
      } while (n > 0);
      Console.WriteLine($"Sum of digits: {0}", sum);
    }

    // 08.Вложени цикли - извеждане на прости числа
    for (var n = 1; n <= 100; n++)
    {
      var prime = true;
      for (var i = 2; i <= Math.Sqrt(n); i++)
        if (n % i == 0) {
            prime = false;
            break;
        }
      if (prime) 
        Console.Write(n + " ");
    }
    Console.WriteLine();
  }
}
