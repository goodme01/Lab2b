using System;

class Program {
  public static void Main (string[] args) {
    
    Console.WriteLine("Enter number:");
    var num1 = Console.ReadLine();
    
    Console.WriteLine("Enter another number:");
    var num2 = Console.ReadLine();
     
    int x1 = Convert.ToInt32(num1);
    int y1 = Convert.ToInt32(num2);

    Console.WriteLine("sum"); 
    Console.WriteLine(x1+y1);

    Console.WriteLine("diff"); 
    Console.WriteLine(x1-y1);

    Console.WriteLine("product"); 
    Console.WriteLine(x1*y1);

    Console.WriteLine("quotient"); 
    Console.WriteLine(x1/y1);

    Console.WriteLine("remainder"); 
    Console.WriteLine(x1%y1);

    




  }
}