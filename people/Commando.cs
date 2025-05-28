using System;
using OOP.Utils;

namespace OOP
{
    public class Commando
    {
        public string Name { get; set; }
        public string CodeName { get; set; }
        public string[] Tools = { "Chisel", "Hammer", "Rope", "Bag", "Water bag" };
        public Weapon Weapon { get; set; }
        public Status Status { get; set; }

        public Commando(string name, string codeName)
        {
            Name = name;
            CodeName = codeName;
            Status = Status.Standing;
        }

        public void Walk()
        {
            Status = Status.Walking;
            Console.WriteLine($"{CodeName} is walking stealthily.");
        }

        public void Hide()
        {
            Status = Status.Standing;
            Console.WriteLine($"{CodeName} is hiding in the shadows.");
        }

        public virtual void Attack()
        {
            Console.WriteLine($"Fighter {this.Name} is attacking");
        }
    }
}