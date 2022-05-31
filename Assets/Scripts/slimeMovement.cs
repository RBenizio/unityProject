using UnityEngine;

public class slimeMovement : MonoBehaviour
{

    public float slimeMoveSpeed;
    public Animator slimeAnimator;
    public Rigidbody2D slimeRb;
    public Transform player;
    void FixedUpdate()
    {
        Vector2 direction = player.position - transform.position;
        direction.Normalize();
        slimeRb.MovePosition(slimeRb.position + direction * slimeMoveSpeed * Time.fixedDeltaTime);
    }
}
