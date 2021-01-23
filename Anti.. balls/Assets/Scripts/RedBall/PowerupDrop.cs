using System.Collections;
using UnityEngine;

public class PowerupDrop : MonoBehaviour
{
    /* -------------------
     * spawns hearts
    ------------------- */

    private float newLiveChance = 0.1f; // new heart (life) 
    public GameObject newLiveObject; // heart

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BlueBall")
        {
            if (Random.Range(0f, 1f) <= newLiveChance)
            {
                Instantiate(newLiveObject);
            }
        }
    }
}
