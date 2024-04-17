// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter to your age: ");
int age = Convert.ToInt32(Console.ReadLine());

if (age >= 18)
{
    Console.WriteLine("You are now signed up!");
}
else if ( age < 0 )
{
    Console.WriteLine("");
}
else
{
    Console.WriteLine("You must be 21+ to sign up");
}