// You'll use the Random.Next() method to simulate rolling three six-sided dice. You'll evaluate the rolled values to calculate the score. 
//If the score is greater than an arbitrary total, then you'll display a winning message to the user. If the score is below the cutoff, you'll display a losing message to the user.

// If any two dice you roll result in the same value, you get two bonus points for rolling doubles.
// If all three dice you roll result in the same value, you get six bonus points for rolling triples.
// If the sum of the three dice rolls, plus any point bonuses, is 15 or greater, you win the game. Otherwise, you lose.

Random dice = new Random();
int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

int totalRolls = roll1 + roll2+roll3;
Console.WriteLine($"Dice rolls: + {roll1} + {roll2} + {roll3} = {totalRolls}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2 && roll2 == roll3)) 
    {
        Console.WriteLine("You rolled triples +6 too your total");
        totalRolls +=6;
    }
    else
    {
    Console.WriteLine("you rolled doubles +2 to your total");
    totalRolls += 2;
    }
    Console.WriteLine($"Your total including the bonus: {totalRolls}");
}

if (totalRolls >= 16)
{
    Console.WriteLine("You win a new car");
}
else if (totalRolls >= 10)
{
    Console.WriteLine("You win a new Laptop");
}
else if (totalRolls == 7)
{
    Console.WriteLine("You won a trip for two");
}
else
{
    Console.WriteLine("You win a kitten");
}

// only display one of t he messages
// Your subscription will expire soon. Renew now!  10 days or less

// Your subscription expires in _ days.  5 days or less
// Renew now and save 10%! 

// Your subscription expires within a day! one day
// Renew now and save 20%!

// Your subscription has expired. 0


Random  random = new Random();
int daysTillExpr = random.Next(12);
int discount = 0;

if (daysTillExpr <=10 && daysTillExpr>5)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else if (daysTillExpr <=5 && daysTillExpr>1)
{
    Console.WriteLine($"Your subscription expires in {daysTillExpr} days");
    discount = 10;
}
else if (daysTillExpr ==1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discount = 20;
}
else if (daysTillExpr ==0)
{
    Console.WriteLine("Your subscription has expired.");
}
if (discount >0)
{
    Console.WriteLine($"Renew now and save {discount}%.");
}
// just for reminder math.max
int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);
 