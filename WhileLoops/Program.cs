
Random rnd = new Random();
int cpuRandom;

bool loopActive = true; //bool võib olla true/false

while(loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    Console.WriteLine($"cpu has generated {cpuRandom}."); //sellega saab näha ebaausalt, mis numbri programm genereeris
    Console.WriteLine("Make a guess. Enter a number 1-3");

    int userNumber = Int32.Parse(Console.ReadLine()); //algul loeb programm kasutaja vastust sõne formaadis ja siis muudab numbriks

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Congratulations, you won!");
        //loopActive = false //vaja selleks, et kui kasutaja vastus on õige, siis väljutakse loopist ja soovitakse head päeva
        break; // võib kasutada "loopActive = false" asemel
    }
    else 
    {
        Console.WriteLine("Oops. Try again.");
    }
}

Console.WriteLine("Have a nice day!");
