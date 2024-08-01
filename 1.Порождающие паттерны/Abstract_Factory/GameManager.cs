public class GameManager : MonoBehaviour
{
    private WorldFactory worldFactory;

    void Start()
    {
        // Выбираем соответствующую фабрику в зависимости от мира
        if (/* условие для Ледяного мира */)
        {
            worldFactory = new IceWorldFactory();
        }
        else
        {
            worldFactory = new FireWorldFactory();
        }

        // Создаем объекты через фабрику
        Enemy enemy = worldFactory.CreateEnemy();
        enemy.Attack();

        Item item = worldFactory.CreateItem();
        item.Use();
    }
}
