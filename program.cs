using System;
using QueenAttack.Models;


namespace QueenAttack
{
  public class Program 
  {
    public static void Main()
    {
      Console.WriteLine("Insert X for Queen: ");
      int x = int.Parse(Console.ReadLine());
      Console.WriteLine("Insert Y for Queen: ");
      int y = int.Parse(Console.ReadLine());
      Console.WriteLine("Insert X for a piece: ");
      int xU = int.Parse(Console.ReadLine());
      Console.WriteLine("Insert Y for a piece: ");
      int yU = int.Parse(Console.ReadLine());

      Queen queen = new Queen(x,y);
      if (queen.Attack(xU, yU))
      {
        Console.WriteLine("Queen will attack you!");
      }
      else
      {
        Console.WriteLine("Queen can't attack this field!");
      }
    }
  }
}