using System.Collections;
using UnityEngine;

public class ExplosionDisappear : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Disappear());
    }
    IEnumerator Disappear()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
