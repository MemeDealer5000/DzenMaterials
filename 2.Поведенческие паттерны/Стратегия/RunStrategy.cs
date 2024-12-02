public class RunStrategy : IMovementStrategy
{
    public void Move(Transform characterTransform)
    {
        characterTransform.Translate(Vector3.forward * Time.deltaTime * 5f);
        Debug.Log("Running...");
    }
}