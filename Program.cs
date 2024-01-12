// See https://aka.ms/new-console-template for more information

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

if ((roll1 == roll2) || (roll2==roll3) || (roll1==roll3)){
    total += 2;
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
}

if (total >= 15) {
    Console.WriteLine("You win1");
}
if (total < 15) {
    Console.WriteLine("Sorry, you lose.");
}


Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
