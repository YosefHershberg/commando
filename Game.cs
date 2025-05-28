using OOP.Utils;

namespace OOP
{
    class Game
    {
        private WeaponFactory WeaponFactory;
        private EnemyFactory EnemyFactory;
        private CommandoFactory CommandoFactory;

        public Game()
        {
            WeaponFactory = new WeaponFactory();
            CommandoFactory = new CommandoFactory();
            EnemyFactory = new EnemyFactory();
        }

        public Enemy CreateEnemy(string name)
        {
            Enemy newEnemy = EnemyFactory.CreateEnemy(name);
            return newEnemy;
        }

        public Commando CreateCommando(string name, string codeName, CommandoType commandoType)
        {
            Commando newCommando = CommandoFactory.CreateCommando(name, codeName, commandoType);
            return newCommando;
        }
        public object CreateWeapon(string weaponType)
        {
            return WeaponFactory.CreateWeapon(weaponType);
        }

        public IShootable CreateM16()
        {
            return (IShootable)WeaponFactory.CreateWeapon("M16");
        }

        public IShootable CreateAK47()
        {
            return (IShootable)WeaponFactory.CreateWeapon("AK47");
        }

        public IBreakable CreateRock()
        {
            return (IBreakable)WeaponFactory.CreateWeapon("Rock");
        }

        public IBreakable CreateKnife()
        {
            return (IBreakable)WeaponFactory.CreateWeapon("Knife");
        }
    }
}