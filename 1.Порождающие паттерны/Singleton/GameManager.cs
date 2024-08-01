public class GameManager : MonoBehaviour
{
    // Статическое свойство для доступа к экземпляру Singleton
    public static GameManager Instance { get; private set; }

    // Метод Awake вызывается перед методом Start
    void Awake()
    {
        // Проверяем, есть ли уже экземпляр GameManager
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Сохраняем объект при загрузке новых сцен
        }
        else
        {
            Destroy(gameObject); // Уничтожаем дубликат, если экземпляр уже существует
        }
    }

    // Пример метода, доступного через Singleton
    public void StartGame()
    {
        Debug.Log("Game Started!");
    }
}
