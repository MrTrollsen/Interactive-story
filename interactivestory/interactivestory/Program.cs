using System;

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.BackgroundColor = ConsoleColor.Black;

Console.WriteLine("INTERACTIVE STORY GAME");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("In this game You will have to choose 1 of multiple options,");
Console.WriteLine("choosing the wrong option can result in death...");
Console.WriteLine("");
Console.WriteLine("Press 'Enter' to continue.");
Console.ReadLine();
Console.Clear();

Console.Write("Player name:");
string playerName = Console.ReadLine();

if (playerName == "")
{
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("GAME OVER");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("you dont even know your own name?");
Console.WriteLine("");
Console.WriteLine("Press 'Enter' to exit.");
Console.ReadLine();
Environment.Exit(0);
}
else
{
Console.WriteLine("Your player name is " + playerName);
}
Console.WriteLine("");
Console.WriteLine("Press 'Enter' to continue.");
Console.ReadLine();
Console.Clear();

Console.WriteLine("Before the game starts, write the sum of 2+2 in letters to ");
Console.WriteLine("verify that you are a human or robot.");
string answer = Console.ReadLine();
Console.Clear();

if (answer == "four")
{
Console.WriteLine("you have succesfully verified.");
Console.WriteLine("");
Console.WriteLine("Press 'Enter' to start the game!");
Console.ReadLine();
Console.Clear();
}
else
{
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("GAME OVER");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("You failed to verify");
Console.WriteLine("");
Console.WriteLine("Press 'Enter' to Exit.");
Console.ReadLine();
Environment.Exit(0);
Console.Clear();
}

Console.WriteLine("You are walking on a trail in a forest in Sweden,");
Console.WriteLine("Suddenly you hear a loud noise from the bushes a few meters ahead of you.");
Console.WriteLine("Jordan comes running out of the bushes, he looks at you and says that he wants");
Console.WriteLine("all you bellonging or he will kill you, you have a few seconds to react.");
Console.WriteLine("What do you do?");
Console.WriteLine("A)Run");
Console.WriteLine("B)Fight");
Console.WriteLine("");
Console.Write("Choice: ");
string answer2 = Console.ReadLine().ToLower();
Console.Clear();

if (answer2 == "run")
{
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("GAME OVER");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("You get scared shitless and you run as fast as you can but You only manage to run 50 meters before you trip on a root.");
Console.WriteLine("You try to get back up again but it seems like you broke your ankle because of your weak bones, Jordan catches up and.");
Console.WriteLine("You lie there defenseless and you plead for mercy. Jordan conmpletely ignores you and grabs a rock and kills you");
Console.WriteLine("");
Console.WriteLine("Press 'Enter' to exit.");
Console.ReadLine();
Environment.Exit(0);
}
else if (answer2 == "fight")
{
Console.WriteLine("You stand your ground and Jordan takes out a knife from his pockets.");
Console.WriteLine("you look around for something to defend yourself with ");
Console.WriteLine("You grab a:");
Console.WriteLine("A)Stick");
Console.WriteLine("B)Rock");
Console.WriteLine("");
Console.Write("Choice: ");
}
else
{
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("GAME OVER");    
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("You failed to choose one of the available options");
Console.WriteLine("");
Console.WriteLine("Press 'Enter' to exit.");
Console.ReadLine();
Environment.Exit(0);
}
string answer3 = Console.ReadLine().ToLower();
Console.Clear();
if (answer3 == "stick")
{
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("VICTORY!");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Jordan charges towards you with his rock, you wait until he gets close and you thrust him with your stick.");
Console.WriteLine("Jordan falls to the ground and dies");
Console.WriteLine("");
Console.WriteLine("Press Enter to Exit the game.");
Console.ReadLine();
Environment.Exit(0);
}
else if (answer3 == "rock")
{
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("GAME OVER");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("You and Jordan take your rocks and throw them at eachother,");
Console.WriteLine("Both of you throw the rocks at the same time and hit eachother in the head.");
Console.WriteLine("Both of you fall to the ground and dies");
Console.WriteLine("Better luck next time");
Console.WriteLine("");
Console.WriteLine("Press 'Enter' to exit.");
Console.ReadLine();
Environment.Exit(0);
}
        
            

