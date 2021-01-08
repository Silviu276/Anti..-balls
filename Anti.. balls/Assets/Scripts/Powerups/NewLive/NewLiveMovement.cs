using System.Collections;
using UnityEngine;

public class NewLiveMovement : MonoBehaviour
{
    private float speed;
    private Rigidbody2D rb;
    private Vector2 movement;
    private void Start()
    {
        speed = SpawnClones.ballsSpeed;
        rb = GetComponent<Rigidbody2D>();
        movement.y = -1f;
        transform.position = new Vector2(Random.Range(-8.6f, 8.6f), 7f);
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
