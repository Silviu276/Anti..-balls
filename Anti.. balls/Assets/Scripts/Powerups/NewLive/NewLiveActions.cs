using System.Collections;
using UnityEngine;

public class NewLiveActions : MonoBehaviour
{
    /* -------------------
     * gives the player one more life
     * destroys the heart
    ------------------- */

    // start method
    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "BlueBall") // the heart powerup hits the player
        {
            GameManager.lives += 1;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        else if (collision.name == "DespawnLine") // the heart powerup despawns
        {
            Destroy(gameObject);
        }
    }
}
