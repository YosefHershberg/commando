using OOP;

namespace OOP.weapon
{
    public class Knife : IBreakable
    {
        public string Name { get; set; }
        public string MetalType { get; set; } // Iron/Steel
        public string Manufacturer { get; set; }
        public string Color { get; set; }
        public double Weight { get; set; }
        public string Status { get; set; } = "Whole";
        public int MaxHits { get; } = 10;
        public int CurrentHits { get; set; } = 0;

        public Knife(string name, string metalType, string manufacturer, string color, double weight)
        {
            Name = name;
            MetalType = metalType;
            Manufacturer = manufacturer;
            Color = color;
            Weight = weight;
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