// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal sisestada oma nime
//rakendus tervitab kasutajat nimepidi


Console.WriteLine("Enter your name:"); //Output
//string - sõne
string userName = Console.ReadLine(); //Input


Console.WriteLine("Hello " + userName + "!"); //Output
//string interpolation

Console.WriteLine($"Hello {userName} !"); //Output