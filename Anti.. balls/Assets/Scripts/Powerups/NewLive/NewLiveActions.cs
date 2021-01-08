using System.Collections;
using UnityEngine;

public class NewLiveActions : MonoBehaviour
{
    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "BlueBall")
        {
            GameManager.lives += 1;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        else if (collision.name == "DespawnLine")
        {
            Destroy(gameObject);
        }
    }
}
