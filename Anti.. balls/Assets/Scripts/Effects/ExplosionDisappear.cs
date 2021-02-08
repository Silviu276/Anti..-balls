using System.Collections;
using UnityEngine;

public class ExplosionDisappear : MonoBehaviour
{
    /* -------------------
     * waits 1 second until the explosion is destroyed
    ------------------- */

    // start method
    private void Start()
    {
        StartCoroutine(CameraShake.ShakeCamera());
        StartCoroutine(Disappear());
    }

    // waits 1 second and destroys the explosion
    IEnumerator Disappear()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
