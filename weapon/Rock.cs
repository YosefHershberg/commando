using OOP;

namespace OOP.weapon
{
    public class Rock : IBreakable
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }
        public string Status { get; set; } = "Whole";
        public int MaxHits { get; } = 5;
        public int CurrentHits { get; set; } = 0;

        public Rock(string name, double weight, string color)
        {
            Name = name;
            Weight = weight;
            Color = color;
        }

        public void Hit()
        {
            if (Status == "Broken") return;
            CurrentHits++;
            if (CurrentHits >= MaxHits)
                Status = "Broken";
        }
    }
}