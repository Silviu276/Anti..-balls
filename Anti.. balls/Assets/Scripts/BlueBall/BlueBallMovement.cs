using UnityEngine;

public class BlueBallMovement : MonoBehaviour
{
    // the blue ball speed
    public float speed;
    // the blue ball rigidbody
    private Rigidbody2D rb;
    // the blue ball travel direction
    private Vector2 direction;
    // verifies what balls have been spawned

    // start method
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        // because it will move just on the y axis
        direction.y = 1f;
        speed = SpawnClones.ballsSpeed;
    }

    // fixedupdate method
    private void FixedUpdate()
    {
        speed = SpawnClones.ballsSpeed;
        // moves the rb on the next position
        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
    }
}
