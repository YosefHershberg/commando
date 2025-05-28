
namespace OOP
{
    class SeaCommando : Commando
    {
        public SeaCommando(string name, string codeName) : base(name, codeName) { }

        public override void Attack()
        {
            Console.WriteLine("Sea Attack");
        }

        public void Swim()
        {
            Console.WriteLine("blblblblblblbl");
        }
    }
}