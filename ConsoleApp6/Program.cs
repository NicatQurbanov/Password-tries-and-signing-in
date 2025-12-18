Console.WriteLine("Enter your nickname:\n");string? nickname = Console.ReadLine();Console.WriteLine("\nEnter your password:\n");string? password = Console.ReadLine();
nicknameSignIn:Console.Clear();Console.WriteLine("\nLet's sign in!\n\nEnter your nickname:\n");while (Console.ReadLine() != nickname)
{
    Console.Clear();
    Console.WriteLine("User not found.");
    Console.ReadLine();
    goto nicknameSignIn;
}

int tryCount = 3;

passwordSignIn:
Console.Clear();Console.WriteLine("\nLet's sign in!\n\nEnter your password:\n");while (Console.ReadLine() != password && tryCount > 0)
{
    tryCount--;
    Console.Clear();
    Console.WriteLine($"Wrong password! Remaining tries {tryCount}");
    Console.ReadLine();
    goto passwordSignIn;
}

if (tryCount <= 0)
{
    Console.Clear();
    Console.WriteLine("You are blocked!");
}
else
{
    Console.Clear();
    Console.WriteLine($"Welcome, {nickname}!");
}