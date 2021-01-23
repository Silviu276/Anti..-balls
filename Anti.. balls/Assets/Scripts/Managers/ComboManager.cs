using System.Collections;
using UnityEngine;

public class ComboManager : MonoBehaviour
{
    public static float lastHit; // the time when last hit occured
    public float delay; // max time to hit a ball or combo resets
    public static int combo, maxCombo;

    // start method
    private void Start()
    {
        combo = 0;
        lastHit = Time.time;
        maxCombo = 5;
    }

    // occurs when two balls just hit each other
    public static void JustHit()
    {
        if (combo < maxCombo)
            combo++;
        lastHit = Time.time;
    }

    // update method
    private void Update()
    {
        if (Time.time - lastHit > delay)
            combo = 0;
    }
}
