using System;

namespace codeschoolC_basics
{
  class Program
  {
    static void Main(string[] args)
    {
      // Console.WriteLine("Type A Message");
      // Console.WriteLine("You said " + Console.ReadLine());
      Console.WriteLine("What is the name of your band?");
      string name = Console.ReadLine();
      Console.WriteLine("How many people are in your band?");
      // int num = int.Parse(Console.ReadLine());
      int num = 0;
      if(!int.TryParse(Console.ReadLine(), out num))
      {
        Console.WriteLine("Invalid Input");
        Environment.Exit(0);
      };
      if(num < 1)
      {
        Console.WriteLine("You must have at least one member.");
        Environment.Exit(0);
      }
      else if(num == 1)
        Console.WriteLine($"{name} is a solo act.");
      else if(num == 2)
        Console.WriteLine($"{name} is a duo.");
      else
        Console.WriteLine($"{name} has {num} members."); 
    }
  }
}
