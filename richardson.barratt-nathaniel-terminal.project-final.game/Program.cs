using System.ComponentModel.Design;
using System.IO;
Console.WriteLine("You have met a fork in your path.");
Console.WriteLine("To the left the path leads to a town, and to right the path leads to a mountain.");
Console.WriteLine("Where will you choose to go, left or right?");
Console.WriteLine("");
string playerInput1 = Console.ReadLine();
if (playerInput1 == "left")
{
    Console.WriteLine("");
    Console.WriteLine("You head towards the town down the left path.");
    Console.WriteLine("You reach the town of Wilekton, humbly bustling with locals in the streets.");
    Console.WriteLine("There is a fruit stand with ripe looking fruit on the table.");
    Console.WriteLine("Would you like to walk up to the shop?");
    Console.WriteLine("");

    string playerInput2 = Console.ReadLine();
    if (playerInput2 == "yes")
    {
        Console.WriteLine("");
        Console.WriteLine("You walk up to the stand, and the fellow there greets you.");
        Console.WriteLine("They are selling oranges for 30 cents.");
        Console.WriteLine("Would you like to purchase one?");
        Console.WriteLine("");

        string playerInput4 = Console.ReadLine();
        if (playerInput4 == "yes")
        {
            Console.WriteLine("");
            Console.WriteLine("You buy an orange from the tedner.");
            Console.WriteLine("It's nice and big. No wonder people say that local is better.");
        }
        else if (playerInput4 == "no")
        {
            Console.WriteLine("");
            Console.WriteLine("The tender looks offended, but quickly brushes it off as a joke");
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("The tender looks at you in a confused manner.");
        }
    }
    else if (playerInput2 == "no")
    {
        Console.WriteLine("");
        Console.WriteLine("You pass by the stand with a simple wave.");
        Console.WriteLine("");
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("People walk around you in the road as you are indecisive.");
    }
}
else if (playerInput1 == "right")
{
    Console.WriteLine("");
    Console.WriteLine("You head towards the mountain down the right path.");
    Console.WriteLine("You reach the base of the mountain, and it looks much larger than it did from afar.");
    Console.WriteLine("There appears to be a pathway up the mountain and a pathway around it.");
    Console.WriteLine("What path would you like to take, up or around?");
    Console.WriteLine("");

    string playerInput3 = Console.ReadLine();
    if (playerInput3 == "up")
    {
        Console.WriteLine("");
        Console.WriteLine("You head up the mountain path.");
        Console.WriteLine("The view is beautiful. You definitely made the right call.");
    }
    else if (playerInput3 == "around")
    {
        Console.WriteLine("");
        Console.WriteLine("You head around the mountain.");
        Console.WriteLine("You meet a small village. It's quite humble.");
        Console.WriteLine("You would definitely visit this village again");
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("Confused, you enter the den of a bear nearby and make good friends with it.");
    }
}
else
{
    Console.WriteLine("");
    Console.WriteLine("Your lack of decision lets you wander into the den of a wizard.");
    Console.WriteLine("You are blasted with many spells that ricochet of the walls, leaving you as silver fork.");
    Console.WriteLine("You're used as a utensil for years to come, wishing it all would stop.");
    Console.WriteLine("Shouldn't have rolled that Nat 1.");
}