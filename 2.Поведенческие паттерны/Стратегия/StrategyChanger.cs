// StrategyChanger.cs
public class StrategyChanger : MonoBehaviour
{
    public Character character;

    void Start()
    {
        character.SetMoveStrategy(new WalkStrategy());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            character.SetMoveStrategy(new WalkStrategy());
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            character.SetMoveStrategy(new RunStrategy());
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            character.SetMoveStrategy(new FlyStrategy());
        }
    }
}
