using OOP;

namespace OOP.weapon
{
    public class AK47 : IShootable
    {
        public string Name { get; set; } = "AK47";
        public string Manufacturer { get; set; } = "KALASHNIKOV";
        public int Bullets { get; set; }

        public AK47(int bullets = 30)
        {
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
