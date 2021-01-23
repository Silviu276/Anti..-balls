using UnityEngine;

public class RedBallMovement : MonoBehaviour
{
    /* -------------------
     * initializes red ball speed
     * updates red ball speed
     * updates red ball position
    ------------------- */

    public float speed = 5f; // red ball speed
    private Rigidbody2D rb; // red ball rigidbody
    private Vector2 direction; // red ball travel direction

    // start method
    private void Start()
    {
        speed = SpawnClones.ballsSpeed; // initializes ball speed
        rb = GetComponent<Rigidbody2D>();
        direction.y = -1f; // because it moves just on the y axis
    }

    // fixedupdate method
    private void FixedUpdate()
    {
        speed = SpawnClones.ballsSpeed; // updates ball speed
        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime); // moves the ball at the next position
    }
}
