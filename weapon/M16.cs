using OOP;

namespace OOP.weapon
{
    public class M16 : IShootable
    {
        public string Name { get; set; } = "M16";
        public string Manufacturer { get; set; } = "COLT";
        public int Bullets { get; set; }

        public M16(int bullets = 29)
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
