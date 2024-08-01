public class GameManager : MonoBehaviour
{
    private EnemyFactory enemyFactory;

    void Start()
    {
        // В зависимости от условий выбирается соответствующая фабрика
        if (/* условие для создания орков */)
        {
            enemyFactory = new OrcFactory();
        }
        else
        {
            enemyFactory = new TrollFactory();
        }

        // Создаем врага через фабрику
        Enemy enemy = enemyFactory.CreateEnemy();
        enemy.Attack();
    }
}
