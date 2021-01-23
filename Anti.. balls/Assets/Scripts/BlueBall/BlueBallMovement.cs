using UnityEngine;

public class BlueBallMovement : MonoBehaviour
{
    /* -------------------
     * updates blue balls position
     * initializes blue balls speed
     * updates blue balls speed
    ------------------- */

    public float speed; // the blue ball speed
    private Rigidbody2D rb; // the blue ball rigidbody
    private Vector2 direction; // the blue ball travel direction

    // start method
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        direction.y = 1f; // because it will move just on the y upper axis
        speed = SpawnClones.ballsSpeed; // initializes with the start speed (4f for now)
    }

    // fixedupdate method
    private void FixedUpdate()
    {
        speed = SpawnClones.ballsSpeed; // updates the speed
        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime); // moves the rb on the next position
    }
}
