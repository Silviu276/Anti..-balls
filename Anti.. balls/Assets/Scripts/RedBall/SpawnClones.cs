using UnityEngine;

public class SpawnClones : MonoBehaviour
{
    /* -------------------
     * sets the scene objects speed
     * spawns red ball clones
     * stores the score
    ------------------- */

    public GameObject redBall; // red ball prefab
    public Transform redBalls; // red balls transform
    public static float ballsSpeed; // balls speed
    public static int hits; // score
    private bool b1, b2, b3; // checks what balls are in scene

    // start method
    private void Awake()
    {
        hits = 0;
        b1 = b2 = b3 = false;
        ballsSpeed = 4f;
    }

    // fixedupdate method
    private void FixedUpdate()
    {
        ballsSpeed += 0.0003f; // increases all the scene objects speed
    }

    // verifies if it's the time to spawn another ball
    public void SpawnRedBallClones()
    {
        if (!b1 && hits == 10)
        { b1 = true; Instantiate(redBall, redBalls); }
        if (!b2 && hits == 40)
        { b2 = true; Instantiate(redBall, redBalls); }
        if (!b3 && hits == 100)
        { b3 = true; Instantiate(redBall, redBalls); }
    }
}
