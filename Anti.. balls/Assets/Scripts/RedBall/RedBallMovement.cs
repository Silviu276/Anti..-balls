using UnityEngine;

public class RedBallMovement : MonoBehaviour
{
    // red ball speed
    public float speed = 5f;
    // red ball rigidbody
    private Rigidbody2D rb;
    // red ball travel direction
    private Vector2 direction;

    // start method
    private void Start()
    {
        speed = SpawnClones.ballsSpeed;
        rb = GetComponent<Rigidbody2D>();
        // because it moves just on the y axis
        direction.y = -1f;
    }

    // fixedupdate method
    private void FixedUpdate()
    {
        speed = SpawnClones.ballsSpeed;
        // moves the ball at the next position
        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
    }
}
