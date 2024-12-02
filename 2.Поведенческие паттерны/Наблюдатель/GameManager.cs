// GameManager.cs
public class GameManager : MonoBehaviour
{
    public PlayerScore playerScore;
    public ScoreDisplay scoreDisplay;
    public HealthDisplay healthDisplay;

    void Start()
    {
        // Регистрируем наблюдателей
        playerScore.RegisterObserver(scoreDisplay);
        playerScore.RegisterObserver(healthDisplay);

        // Инициализируем начальные значения
        playerScore.ChangeScore(0);
        playerScore.ChangeScore(100);  // Добавляем очки для теста
    }
}
