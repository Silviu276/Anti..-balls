using System.Collections;
using UnityEngine;

public class PowerupDrop : MonoBehaviour
{
    private float newLiveChance = 0.1f;

    public GameObject newLiveObject;

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
