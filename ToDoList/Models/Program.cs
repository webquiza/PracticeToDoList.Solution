using System;
using System.Collections.Generic;
using ToDoList.Models;

public class Program 
{
  public static void Main()
  {
    Console.WriteLine("Welcome to the To Do List");
    Console.WriteLine("Would you like to add an item to your list or view your list (Add/View)? ");
    Console.WriteLine("Type 'quit' to exit");
    
    string answer;
    while (answer = Console.ReadLine() != "quit")
    {
      // string result = answer;

      if (answer == "Add")
      { 
        Console.WriteLine("You are trying add");
        // Item.Add();
      }
      else if (answer == "View") 
      {
        Console.WriteLine("Yar trying view");
      }

    }
  }
}
