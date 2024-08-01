public class Player : MonoBehaviour
{
    void Start()
    {
        // Доступ к Singleton
        GameManager.Instance.StartGame();
    }
}
