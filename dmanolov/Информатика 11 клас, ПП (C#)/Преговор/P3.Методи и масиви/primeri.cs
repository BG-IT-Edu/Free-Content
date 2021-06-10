using System;
using System.Linq;

class Start {
  // опитайте да обясните всеки от методите
  public static void Hello(string name) {
    Console.WriteLine("Hello " + name);    
  }

  public static int Max(int a, int b) {
    if (a > b)
      return a;
    else return b;
  }

  public static int[] ArrayNX(int n, int x) {
    int[] arr = new int[n];
    for (int i = 0; i < n; i++) arr[i] = x;
    return arr;
  }

  public static void Demo () {
    // 00. Извикване на методи
    Hello("Pesho");
    Console.WriteLine(Max(2, 3));
    int[] nums = ArrayNX(5, 6);
    Console.WriteLine(string.Join(" ", nums));

    // 01. Прочитане на масив
    int n = int.Parse(Console.ReadLine());
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
      arr[i] = int.Parse(Console.ReadLine());
    }

    // 02. Прочитане на масив на един ред
    int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

    // 03. Извеждане на масив на един ред
    Console.WriteLine(string.Join(", ", arr)); 

    // 04. Извеждане на масив
    foreach (var element in arr1)
      Console.WriteLine(element);

    // 05.Сума на масив 
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
      sum += arr[i];
    Console.WriteLine("sum = " + sum);

    // 06.Брой на положителни елементи 
    var count = 0;
    for (int i = 0; i < arr.Length; i++)
      if (arr[i] > 0) 
        count++;
    Console.WriteLine("count = " + count);

    // 07.максимално число
    var max = arr[0];
    for (int i = 1; i < arr.Length; i++)
      if(arr[i] > max)
        max = arr[i];
    Console.WriteLine("max = " + max);
  }
}
