//  Random flip = new();
//  int coin = flip.Next(1,3);
//  Console.WriteLine($"The result is {(coin>1?"Heads":"Tails")}");

/* if permission is "Admin" && lvl >55 -> "Welcome, Super Admin user."
if permission Admin && lvl <= 55-> Welcome, Admin user.
if permission Manager && lvl >= 20 -> Contact an Admin for access.
if permission Manager &&  and lvl < 20 -> You do not have sufficient privileges.
if permisson is !Managert || !Admin -> You do not have sufficient privileges.
*/

string permission = "Admin|Manager";
int level = 20;
if (permission.Contains("Admin") && level >55)
{
    Console.WriteLine("Welcome, Super Admin user.");
}
else if (permission.Contains("Admin") && level <=55)
{
    Console.WriteLine("Welcome, Admin user.");
}
else if(permission.Contains("Manager")&& level >=20)
{
    Console.WriteLine("Contact an Admin for access.");
}
else if(permission.Contains("Manager")&& level <20)
{
    Console.WriteLine("You do not have sufficient privileges.");
}
else if(!permission.Contains("Manager") || !permission.Contains("Admin"))
{
    Console.WriteLine("You do not have sufficient privileges.");
}