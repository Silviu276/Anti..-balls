using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TwoBallsAction : MonoBehaviour
{
    private GameObject pointer;

    private void Start()
    {
        pointer = GameObject.Find("Pointer");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "BlueBall")
        {

        }
        else
        {
            Destroy(gameObject);
        }
    }

    //IEnumerator
}
