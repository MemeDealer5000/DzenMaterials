public class JumpStrategy : IMovementStrategy
{
    private bool isGrounded = true;

    public void Move(Transform characterTransform)
    {
        if (isGrounded)
        {
            characterTransform.Translate(Vector3.up * 2f);
            isGrounded = false;
        }
    }

    // Call this method when the character lands
    public void Land()
    {
        isGrounded = true;
        Debug.Log("Jumping...");
    }
}