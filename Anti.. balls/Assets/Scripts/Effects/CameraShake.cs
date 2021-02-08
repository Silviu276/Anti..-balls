using System.Collections;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public static IEnumerator ShakeCamera()
    {
        float timeElapsed = 0f;
        Vector3 camPos = Camera.main.transform.position;
        while (timeElapsed < 0.15f)
        {
            Camera.main.transform.position = new Vector3(camPos.x + Random.Range(-0.2f, 0.2f), camPos.y + Random.Range(-0.2f, 0.2f),
                camPos.z);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        Camera.main.transform.position = new Vector3(camPos.x, camPos.y, camPos.z);
    }
}
