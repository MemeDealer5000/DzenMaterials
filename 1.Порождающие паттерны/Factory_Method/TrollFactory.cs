public class TrollFactory : EnemyFactory
{
    public override Enemy CreateEnemy()
    {
        return new Troll();
    }
}