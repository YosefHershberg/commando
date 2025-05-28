
namespace OOP
{
    class Enemy
    {
        public string Name { get; set; }

        public int LifePercentage = 100;

        public bool isAlive { get; set; }

        public Enemy(string name)
        {
            this.Name = name;
        }

        public void Scream()
        {
            Console.WriteLine($"I am {this.Name} and I am the enemy!");
        }
    }
}