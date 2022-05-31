using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;

    public Animator animator;
    public Rigidbody2D rb;
    private Vector3 velocity = Vector3.zero;

    void FixedUpdate()
    {
        float horizontalMovement = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float verticallMovement = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        MovePlayer(horizontalMovement, verticallMovement);
        animator.SetFloat("HMovement", rb.velocity.x);
        animator.SetFloat("VMovement", rb.velocity.y);
        animator.SetFloat("Speed", rb.velocity.magnitude);
    }

        void MovePlayer(float _horizontalMovement, float _verticalMovement)
        {
            Vector3 targetVelocity = new Vector2(_horizontalMovement, _verticalMovement);
            rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, 0f);
        }
}
