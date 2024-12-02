// Character.cs
public class Character : MonoBehaviour
{
    private IMoveStrategy moveStrategy;

    void Update()
    {
        if (moveStrategy != null)
        {
            moveStrategy.Move(transform);
        }
    }

    public void SetMoveStrategy(IMoveStrategy strategy)
    {
        moveStrategy = strategy;
    }
}
