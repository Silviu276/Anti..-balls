using UnityEngine;
using System.Collections;

public class BallCollision : MonoBehaviour
{
    /* -------------------
     * respawns red ball if it hits the despawn line
     * respawns red ball if it hits a wall
     * respawns red ball if it hits the player
     * updates the lives amount
     * updates the score
     * plays explosion sound
     * ends the game by making cursor visible
     * spawns another red ball
    ------------------- */

    public GameObject explosionPrefab;
    private AudioSource explosionSound;
    public GameObject scorePopupObject;
    public SpawnClones spawnClones;

    // start method
    private void Start()
    {
        RespawnRedBall();
        explosionSound = GetComponent<AudioSource>();
        spawnClones = GameObject.Find("GameManager").GetComponent<SpawnClones>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // ball hits the player
        if (collision.gameObject.tag == "BlueBall")
        {
            ComboManager.JustHit();
            Instantiate(explosionPrefab, transform.position, transform.rotation); // explosion
            Instantiate(scorePopupObject, transform.position, Quaternion.identity); // score popup
            StartCoroutine(BallCollisionWaitForRespawn()); // respawns the ball
            Destroy(collision.gameObject); // destroys the blue ball
            SpawnClones.hits++; // updates the hits occured
            explosionSound.Play(); // plays explosion sound
            spawnClones.SpawnRedBallClones(); // verifies if it's the time to spawn another red ball
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // ball reaches the maximum point
        if (collision.name == "DespawnLine")
        {
            StartCoroutine(BallCollisionWaitForRespawn());
            GameManager.lives -= 1;
            if (GameManager.lives <= 0)
            {
                Destroy(transform.parent.gameObject);
                Cursor.visible = true;
            }
        }
    }

    // respawns redball at random position
    private void RespawnRedBall()
    {
        transform.position = new Vector2(Random.Range(-8.6f, 8.6f), 7f);
    }

    // waits and respawns the ball if it hit a wall
    private IEnumerator BallCollisionWaitForRespawn()
    {
        transform.position = new Vector2(Random.Range(-500f, 500f), Random.Range(100f, 1100f));
        yield return new WaitForSeconds(Random.Range(0.3f, 1f));
        RespawnRedBall();
    }
}
