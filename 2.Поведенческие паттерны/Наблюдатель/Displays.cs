// ScoreDisplay.cs
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour, IObserver
{
    public Text scoreText;

    public void UpdateData(int score)
    {
        scoreText.text = "Score: " + score;
    }
}


public class HealthDisplay : MonoBehaviour, IObserver
{
    public Text healthText;

    public void UpdateData(int health)
    {
        healthText.text = "Health: " + health;
    }
}
