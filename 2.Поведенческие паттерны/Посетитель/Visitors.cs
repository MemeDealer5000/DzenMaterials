// ScoreVisitor.cs
public class ScoreVisitor : IVisitor
{
    private int score;

    public void Visit(Player player)
    {
        score += 100;
        Debug.Log("Player visited. Score: " + score);
    }

    public void Visit(Enemy enemy)
    {
        score += 50;
        Debug.Log("Enemy visited. Score: " + score);
    }

    public void Visit(Item item)
    {
        score += 10;
        Debug.Log("Item visited. Score: " + score);
    }

    public int GetScore()
    {
        return score;
    }
}
