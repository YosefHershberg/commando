

namespace OOP
{
    class AirCommando : Commando
    {
        public AirCommando(string name, string codeName) : base(name, codeName) { }

        public override void Attack()
        {
            Console.WriteLine("Air Attack");
        }

        public void Parachute()
        {
            Console.WriteLine("WHEEEEE ITSS FUNNNN !!!");
        }
    }
}