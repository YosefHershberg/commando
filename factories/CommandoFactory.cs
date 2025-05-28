using OOP.Utils;

namespace OOP
{
    class CommandoFactory
    {
        private List<Commando> CommandoList = new List<Commando>();

        public Commando CreateCommando(string name, string codeName, CommandoType commandoType)
        {
            Commando newCommando;
            switch (commandoType)
            {
                case CommandoType.Regular:
                    newCommando = new Commando(name, codeName);
                    break;
                case CommandoType.Air:
                    newCommando = new AirCommando(name, codeName);
                    break;
                case CommandoType.Sea:
                    newCommando = new SeaCommando(name, codeName);
                    break;
                default:
                    throw new ArgumentException("Invalid CommandoType", nameof(commandoType));
            }
            CommandoList.Add(newCommando);
            return newCommando;
        }
    }
}