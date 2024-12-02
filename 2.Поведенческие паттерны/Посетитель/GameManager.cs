// GameManager.cs
public class GameManager : MonoBehaviour
{
    private void Start()
    {
        IElement[] elements = FindObjectsOfType<MonoBehaviour>().OfType<IElement>().ToArray();
        ScoreVisitor scoreVisitor = new ScoreVisitor();

        foreach (IElement element in elements)
        {
            element.Accept(scoreVisitor);
        }

        Debug.Log("Total Score: " + scoreVisitor.GetScore());
    }
}
