using System;
using RockPaperScissors.models;

namespace RockPaperScissors
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please choose Rock, Paper, or Scissors!");
      string playerInput = Console.ReadLine();
      string playerPlay = playerInput.ToLower();
    
      Console.WriteLine("You played: {0}", playerPlay);
      RPS game = new RPS();
      string cpuPlay = game.generateCpuPlay();
      Console.WriteLine("The cpu played: {0}", cpuPlay);

      RPS gameOutcome = new RPS();
      gameOutcome.comparePlays(cpuPlay, playerPlay);
      
    }
  }
}