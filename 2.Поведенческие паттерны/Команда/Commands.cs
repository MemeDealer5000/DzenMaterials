// MoveForwardCommand.cs
public class MoveForwardCommand : ICommand
{
    private Transform _transform;
    private Vector3 _previousPosition;

    public MoveForwardCommand(Transform transform)
    {
        _transform = transform;
    }

    public void Execute()
    {
        _previousPosition = _transform.position;
        _transform.Translate(Vector3.forward * 2);
    }

    public void Undo()
    {
        _transform.position = _previousPosition;
    }
}

// JumpCommand.cs
public class JumpCommand : ICommand
{
    private Transform _transform;
    private Vector3 _previousPosition;

    public JumpCommand(Transform transform)
    {
        _transform = transform;
    }

    public void Execute()
    {
        _previousPosition = _transform.position;
        _transform.Translate(Vector3.up * 5);
    }

    public void Undo()
    {
        _transform.position = _previousPosition;
    }
}

// AttackCommand.cs
public class AttackCommand : ICommand
{
    public void Execute()
    {
        Debug.Log("Attack performed");
    }

    public void Undo()
    {
        Debug.Log("Attack undone");
    }
}
