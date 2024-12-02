// CharacterController.cs
public class CharacterController : MonoBehaviour
{
    private CommandInvoker _commandInvoker;
    private Transform _characterTransform;

    void Start()
    {
        _commandInvoker = new CommandInvoker();
        _characterTransform = transform;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _commandInvoker.ExecuteCommand(new MoveForwardCommand(_characterTransform));
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            _commandInvoker.ExecuteCommand(new JumpCommand(_characterTransform));
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            _commandInvoker.ExecuteCommand(new AttackCommand());
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            _commandInvoker.UndoCommand();
        }
    }
}
