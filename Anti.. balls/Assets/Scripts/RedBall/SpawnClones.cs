using UnityEngine;

public class SpawnClones : MonoBehaviour
{
    // red ball prefab
    public GameObject redBall;

    // red balls transform
    public Transform redBalls;

    // balls speed
    public static float ballsSpeed = 4f;

    // score
    public static int score;
    private bool b1, b2, b3;

    // start method
    private void Start()
    {
        score = 0;
        b1 = b2 = b3 = false;
    }

    // update method
    private void Update()
    {
        SpawnRedBallClones();
    }

    // fixedupdate method
    private void FixedUpdate()
    {
        ballsSpeed += 0.0003f;
    }

    // verifies if it's the time to spawn another ball
    private void SpawnRedBallClones()
    {
        if (!b1 && score == 10)
        { b1 = true; Instantiate(redBall, redBalls); }
        if (!b2 && score == 40)
        { b2 = true; Instantiate(redBall, redBalls); }
        if (!b3 && score == 100)
        { b3 = true; Instantiate(redBall, redBalls); }
    }
}
