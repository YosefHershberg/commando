using System;
using OOP;

class Program
{
    static void Main()
    {
        Game myGame = new Game();
        AirCommando haim = new AirCommando("Haim", "The King");
        haim.Parachute();
    }
}
