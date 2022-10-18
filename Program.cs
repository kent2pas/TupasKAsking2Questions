//Kent Tupas
//10/17/2022
//github mini challenge 3
// update and upload to github
//

Console.Clear();
string name, wakeup;


Console.WriteLine("__________________________________________________________________");
Console.WriteLine("Hello fellow human. What is your name?");
name = Console.ReadLine();
while(name != "no"){
Console.WriteLine("");
Console.WriteLine($"Soooo what time did you you wake up {name}?" );
wakeup = Console.ReadLine();
Console.WriteLine("");

Console.WriteLine($"Wow you woke up at {wakeup}!!!");
Console.WriteLine("");
Console.WriteLine("Type no to stop or yes to retry");
name = Console.ReadLine();
Console.WriteLine("__________________________________________________________________");
}

