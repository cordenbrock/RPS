using System;

namespace RockPaperScissors.models
{
  public class RPS
  {

    string[] options = { "rock", "paper", "scissors" }; // access modifier? make static?

    public string generateCpuPlay() 
      {
        Random rnd = new Random();
        int randomNum = rnd.Next(0,3);
        return options[randomNum];
      }
      
    public void comparePlays(string cpuPlay, string playerPlay)
      {
        if (cpuPlay == "rock" && playerPlay == "scissors") 
        {
          Console.WriteLine("You lose!");
        }
        else if (cpuPlay == "rock" && playerPlay == "paper") 
        {
          Console.WriteLine("You win!");
        }        
        else if (cpuPlay == "rock" && playerPlay == "rock") 
        {
          Console.WriteLine("It's a tie!");
        }        
        else if (cpuPlay == "scissors" && playerPlay == "scissors") 
        {
          Console.WriteLine("It's a tie!");
        }        
        else if (cpuPlay == "scissors" && playerPlay == "paper") 
        {
          Console.WriteLine("You lose!");
        }        
        else if (cpuPlay == "scissors" && playerPlay == "rock") 
        {
          Console.WriteLine("You win!");
        }        
        else if (cpuPlay == "paper" && playerPlay == "scissors") 
        {
          Console.WriteLine("You win!");
        }
        else if (cpuPlay == "paper" && playerPlay == "paper") 
        {
          Console.WriteLine("It's a tie!");
        }        
        else if (cpuPlay == "paper" && playerPlay == "rock") 
        {
          Console.WriteLine("You lose!");
        }
      }

  }
}