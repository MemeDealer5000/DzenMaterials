public class WalkStrategy : IMovementStrategy
{
    public void Move(Transform characterTransform)
    {
        characterTransform.Translate(Vector3.forward * Time.deltaTime * 2f);
        Debug.Log("Walking...");
    }
}