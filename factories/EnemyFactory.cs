
namespace OOP
{
    class EnemyFactory
    {
        private List<Enemy> EnemyList = new List<Enemy>();

        public Enemy CreateEnemy(string name)
        {
            Enemy newEnemy = new Enemy(name);
            EnemyList.Add(newEnemy);
            return newEnemy;
        }
    }
}