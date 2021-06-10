using System;

class Start {
  public static void Demo () {
    // 01.Слепване на низове
    var firstName= "Maria";
    var lastName= "Ivanova";
    var str= firstName + " " +lastName;
    Console.WriteLine(str); 

    // 02.Въвеждане, извеждане, закръгляване
    Console.Write("Enter circle radius. r = ");
    var r = double.Parse(Console.ReadLine());
    var area = Math.Round(Math.PI * r * r, 2);
    var perimeter = Math.Round(2 * Math.PI * r, 2);
    Console.WriteLine("Area = " + area);
    Console.WriteLine("Perimeter = " + perimeter);

    // 03.Форматирано извеждане
    var name = Console.ReadLine();
    var age = int.Parse(Console.ReadLine());
    var town = Console.ReadLine();
    Console.WriteLine("I am {0}, {1}-years old, from {2}.", name, age, town);
    Console.WriteLine($"Hello {name}!");

    // 04.Форматирано извеждане на дробни числа
    double R = double.Parse(Console.ReadLine());
    Console.WriteLine("S = {0:f2}", Math.PI * R * R);
    Console.WriteLine("P = {0:0.##}", 2 * Math.PI * R);

    // 05.Булев тип данни, условни команди
    var x = double.Parse(Console.ReadLine());
    var y = double.Parse(Console.ReadLine());
    var in1or3 = (x > 0 && y > 0) || (x < 0 && y < 0);
    if (in1or3)
      { Console.WriteLine("Point is in I or III quadrant"); }
    else
      { Console.WriteLine("On X or Y axis or in II or IV quadrant"); }

    // 06.Команда за избор на вариант
    int day = int.Parse(Console.ReadLine());
    switch (day)
    {
      case 1: Console.WriteLine("Monday"); break;
      case 2: Console.WriteLine("Tuesday"); break;
      case 3: Console.WriteLine("Wednesday"); break;
      case 4: Console.WriteLine("Thursday"); break;
      case 5: Console.WriteLine("Friday"); break;
      case 6: Console.WriteLine("Saturday"); break;
      case 7: Console.WriteLine("Sunday"); break;
      default: Console.WriteLine("Error"); break;
    }
  }
}
