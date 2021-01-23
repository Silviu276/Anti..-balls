using UnityEngine;

public class BlueBallCollision : MonoBehaviour
{
    /* -------------------
     * destroys the blue ball if it hits the wall
    ------------------- */

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // destroys the blue ball if it hits the upper wall
        if (collision.tag == "Walls")
        {
            Destroy(gameObject);
        }
    }
}
