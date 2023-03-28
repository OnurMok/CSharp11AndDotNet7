
int x = 0;
while (x < 10)
{
    Console.WriteLine(x);
    x++;
}

string? password;

do
{
    Write("Enter your password: ");
    password = Console.ReadLine();
}
while (password.Length < 8 );
Console.WriteLine("Correct!");

for (int i = 0; i < 10; i++)
{
    WriteLine(i);
}

string[] names = { "Adam", "Barry", "Charlie" };

foreach (string name in names)
{
    WriteLine($"{name} has {name.Length} characters.");
}