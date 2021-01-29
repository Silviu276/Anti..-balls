using System.Collections;
using UnityEngine;

public class PowerupDrop : MonoBehaviour
{
    /* -------------------
     * stores powerup drop chances
     * spawns hearts
    ------------------- */

    public static float newLiveChance; // new heart (life) 
    public GameObject newLiveObject; // heart

    // start method
    private void Start()
    {
        newLiveChance = (10f + (PlayerPrefs.GetInt("HeartChanceLevel") * 2f)) / 100f;
    }

    // enters collision
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
