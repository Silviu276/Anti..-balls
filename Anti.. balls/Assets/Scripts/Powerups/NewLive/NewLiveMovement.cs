using System.Collections;
using UnityEngine;

public class NewLiveMovement : MonoBehaviour
{
    /* -------------------
     * 
    ------------------- */

    private float speed; // the speed of the heart powerup
    private Rigidbody2D rb; // the heart body
    private Vector2 movement; // the heart 2D movement

    // start method
    private void Start()
    {
        speed = SpawnClones.ballsSpeed; // initializes heart speed
        rb = GetComponent<Rigidbody2D>();
        movement.y = -1f; // the heart will move down
        transform.position = new Vector2(Random.Range(-8.6f, 8.6f), 7f); // spawns at random x and constant y
    }

    // fixedupdate method
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime); // updates heart position
    }
}
