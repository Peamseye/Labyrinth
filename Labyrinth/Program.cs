using System;

string room = "start";

Console.WriteLine("You enter a house, and hear the door close behind you with a loud thud! You quickly check behind you, and notice that it is locked!");
Console.WriteLine();

while (room != "end")
{
  if (room == "start")
  {
    Console.WriteLine();
    Console.WriteLine("You are in the lobby.");
    Console.WriteLine("Before you, there is a single door. It appears to be unlocked. Do you want to go through it?");
    Console.WriteLine();
    Console.WriteLine("a = Go Forward");
    string a = Console.ReadLine();
    
    if (a == "a")
    {
      room = "hallway";
    }
  }

  else if (room == "hallway")
  {
    Console.WriteLine();
    Console.WriteLine("You enter a small hallway.");
    Console.WriteLine("You have the door behind you, and you also see a door in front of you.");
    Console.WriteLine("Do you want to go further into the house, or do you want to return to the lobby?");
    Console.WriteLine();
    Console.WriteLine("a = Go Forward      b = Go backwards");

    string a = Console.ReadLine();
    if (a == "a")
    {
      room = "end";
    }
    else if (a == "b")
    {
      room = "start";
    }
  }

}