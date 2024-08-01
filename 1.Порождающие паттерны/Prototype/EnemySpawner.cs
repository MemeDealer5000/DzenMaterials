public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrototype;

    void Start()
    {
        // Клонирование прототипа и создание нового врага на сцене
        GameObject newEnemy = Instantiate(enemyPrototype);
        
        // Вы можете изменить параметры клона, если нужно
        newEnemy.GetComponent<Enemy>().health = 100;
        newEnemy.GetComponent<Enemy>().speed = 5;
    }
}
