Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0) 
{
     Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    Console.WriteLine("Your subscription expires within a day!");
}
else if (daysUntilExpiration <= 5)
{
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
}
else if (daysUntilExpiration <= 10)
{
     Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0) 
{
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}

Console.WriteLine(daysUntilExpiration);
// if user sub expire in 10d or less 
// if user sub expires in 5d or less
// Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
// Console.WriteLine("Renew no and save 10%!");

// if user sub expires in 1d
// Console.WriteLine("Your subscription expires within a day!");
// Console.WriteLine("Renew and save 20%!");

//if user sub has already expired 
// Console.WriteLine("Your subscription has expired.");
