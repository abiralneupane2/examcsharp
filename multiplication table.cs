using System;
class TableOfMultiplication {
  static void Main() {
    Console.WriteLine("Enter an integer");
    int n = Convert.ToInt32(Console.ReadLine());
    for(int i=1;i<11;i++){
        Console.WriteLine("{0} X {1} =", n, i);
    }
  }
}
