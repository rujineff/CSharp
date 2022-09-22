//Change appearance of Console
Console.Title = "Matrix";
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WindowHeight = 40;

void TypeWriter(string text, int time = 50)
{
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(time);
    }
}

#region
//Presentation
Console.WriteLine("Press enter to begin");

Console.ReadLine();

TypeWriter("You wake up in a dark room \nyou do not know how you got there, but you have something in your hand. \n" + "It's a lighter and it's the only thing you have on you,\nyou do not have anything else in your pockets to help you.");

Console.WriteLine();

Console.WriteLine();

TypeWriter("Do you light the lighter?\n");

string? answer = Console.ReadLine();

if (answer == "no")
{
    //Console.ReadLine();
    Console.WriteLine();
    TypeWriter("You do not light the lighter and choice to sit in the dark not doing anything. \nbut you have the feeling that you won't be waiting for long.\n");
    TypeWriter("'Coward' ending");
    Console.ReadKey();
}

//LightTheLighter = true;
bool LightTheLighter = false;
if (answer == "yes")
{
    LightTheLighter = true;
}

if (LightTheLighter == true)
{
    Console.WriteLine();
    TypeWriter("You light the lighter, emitting a small flame.\n");
    TypeWriter("The flame does not light up the entire room but enough to make out your sorroundings.\n");
    TypeWriter("The room is not that big and there is alot of graffiti writen on the walls.\n");
    TypeWriter("But more importently on the ground there is an arrow writen down with a key in front of it.\n"); 
    TypeWriter("The arrow seem to be pointing to somewhere in the room.\n");
    TypeWriter("You follow the arrow leading to a door the key seems to fit in the key hole.\n");
    
    TypeWriter("\nDo you open the door?");
    Console.WriteLine("'Press enter to continue'");

    Console.ReadLine();
    Console.Clear();
}
#endregion

#region 
//TheDoctor
TypeWriter("you go through the door and enter a hallway.\n");
TypeWriter("The hallway has even more graffiti and you realise the place you are currently in is a abandoned hospital.\n");
TypeWriter("You walk through the hallway of the decaying hospital.\n");
TypeWriter("You turn a corner to see light coming from the other end of the hallway.\n");
Console.WriteLine();

Console.ReadLine();

TypeWriter("You walk toward the light and arrive at the end of the hallway, where a locked gate is blocking you.\n");
TypeWriter("But more importantly a person is standing behind the gate.\n");
TypeWriter("The person is a doctor wearing a white coat and more strangely has his entire face covered up with bandages.\n");
Console.ForegroundColor = ConsoleColor.White;
TypeWriter("Hey you there! come closure.\n");
TypeWriter("I need your help and you need my help.\n");
Console.ForegroundColor = ConsoleColor.DarkGreen;
TypeWriter("The doctor pulls out a gun from his pockets.\n");
Console.ForegroundColor = ConsoleColor.White;
TypeWriter("You see this gun, I need ammo for it.\n");
TypeWriter("I knew a guy here who used the same kind of ammo.\n");
TypeWriter("He is in the room at the other end of the hallway.\n");
TypeWriter("Find the room, get the ammo and bring it to me.\n");
TypeWriter("Can you do that for me?\n");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("Type *yes* or *no* ");

String question = Console.ReadLine();

if(question == "yes"){
Console.ForegroundColor = ConsoleColor.DarkGreen;
TypeWriter("Seeing no other choice you accept the doctors offer and head out.\n");
}

else if(question == "no"){
Console.ForegroundColor = ConsoleColor.DarkGreen;
TypeWriter("You do not trust the doctor but see no other options, and accept his offer.\n");
}
Console.Clear();
#endregion

#region 
//TheRoom
Console.ForegroundColor = ConsoleColor.DarkGreen;
TypeWriter("You walk down the hallway towards the room at the other end.\n");
TypeWriter("The lighter barely show you any of the sorroundings.\n");
TypeWriter("You even pass the room you woke up in.\n");
Console.WriteLine("");

TypeWriter("You finally see the door highlighted by the emergency sign above it.\n");
TypeWriter("but when you pass one of the rooms, you hear a voice.\n");

Console.ForegroundColor = ConsoleColor.DarkRed;
TypeWriter("Numbers... What do the number mean.\n");
TypeWriter("Remember... remember the numbers.\n");


    Random NumberGen = new Random();

    int roll = 0;
    int attempts = 0;

while(roll != 1 && attempts < 5) {
    roll = NumberGen.Next(1,9);
    Console.WriteLine(roll);
    attempts++;
}


Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("");
TypeWriter("Not wanting to found out the source of the mumblings you move past the room.\n");
TypeWriter("You finally get to the room at the other side of the hospital.\n");
TypeWriter("The door is unlocked and seeing anything noteworthy you go inside the room");
Console.Clear();
#endregion

#region 
//TheAmmo
TypeWriter("You enter the room.\n");
TypeWriter("It looks like a mess, with a lot of brokens things lying around.\n");
TypeWriter("But with your lighter, you see something lying up against the wall.\n");
TypeWriter("It's the body of the guy the doctor was talking about.\n");
TypeWriter("But more importantly you see some ammo lying beside him.\n");

{

    {
        Ammo();

        Console.ReadKey();
    }

    static void Ammo()
    {
        Random numberGen = new Random();

        int amount = numberGen.Next(2, 5);

        Console.WriteLine("You count them all and there is a total of " + amount + " magazines worth of ammo.\n");
    }
}

TypeWriter("You take all the ammo and go out of the room.\n");

#endregion

#region 
//ThePatient
TypeWriter("You go outside to the hallway again\n");
TypeWriter("But before you continue, you notice that the door containing the voice is wide open.\n");
TypeWriter("And before you notice you hear the voice again.\n");
Console.ForegroundColor = ConsoleColor.DarkRed;
TypeWriter("Numbers... more numbers... give me numbers.\n");
Console.ForegroundColor = ConsoleColor.DarkGreen;
TypeWriter("It's a patient and he is blocking your path.\n");
TypeWriter("But you come up with a distraction.\n");
{
    
    {
        string[] numbers = new string[4];

        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("Type in four numbers: ");

        numbers[0] = Console.ReadLine();
        numbers[1] = Console.ReadLine();
        numbers[2] = Console.ReadLine();
        numbers[3] = Console.ReadLine();

        Console.ReadKey();
    }
}
Console.ForegroundColor = ConsoleColor.DarkGreen;
TypeWriter("You give the patient four numbers.\n");
TypeWriter("The patient mumbles something and walks back in to the room.\n");
TypeWriter("You move on forward.\n");

Console.Clear();
#endregion

#region 
//THEEND
TypeWriter("You return back to the gate with the Doctor standing behind waiting.\n");
Console.ForegroundColor = ConsoleColor.White;
TypeWriter("You have returned, do you have what i need.\n");
Console.ForegroundColor = ConsoleColor.DarkGreen;
TypeWriter("'You show him the ammo.'\n");
Console.ForegroundColor = ConsoleColor.White;
TypeWriter("Good, good give it to me now!\n");
Console.ForegroundColor = ConsoleColor.DarkGreen;
TypeWriter("'You hand over the ammo'\n");
Console.ForegroundColor = ConsoleColor.White;
TypeWriter("Thank you, for trusting me.\n");
TypeWriter("A deal is a deal, here take this.\n");
Console.ForegroundColor = ConsoleColor.DarkGreen;
TypeWriter("The Doctor throughs a small item on the ground.\n");
TypeWriter("It's a key, with a tag that says 'emergency exit' on it.\n");
TypeWriter("You take the key, and when you look up the Doctor has already left.\n");
TypeWriter("Not wanting to spent anymore time in the hospital you head for the emergency exit.\n");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("'Good' ending");
Console.ReadLine();
#endregion