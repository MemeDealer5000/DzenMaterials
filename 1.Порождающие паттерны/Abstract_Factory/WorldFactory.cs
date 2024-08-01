public abstract class WorldFactory
{
    public abstract Enemy CreateEnemy();
    public abstract Item CreateItem();
}

public class IceWorldFactory : WorldFactory
{
    public override Enemy CreateEnemy()
    {
        return new IceEnemy();
    }

    public override Item CreateItem()
    {
        return new IceItem();
    }
}

public class FireWorldFactory : WorldFactory
{
    public override Enemy CreateEnemy()
    {
        return new FireEnemy();
    }

    public override Item CreateItem()
    {
        return new FireItem();
    }
}
