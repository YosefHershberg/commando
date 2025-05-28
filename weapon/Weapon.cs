using System;

namespace OOP
{
    public class Weapon
    {
        public string Name { get; set; }
        public int Bullets { get; set; }

        public Weapon(string name, int bullets)
        {
            Name = name;
            Bullets = bullets;
        }

        public void Shoot()
        {
            if (Bullets > 0)
            {
                Bullets--;
                Console.WriteLine($"{Name} fired! Bullets left: {Bullets}");
            }
            else
            {
                Console.WriteLine($"{Name} is out of bullets!");
            }
        }
    }
}
