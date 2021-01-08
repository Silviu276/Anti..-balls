using UnityEngine;
using System.Collections;

public class BallCollision : MonoBehaviour
{
    public GameObject explosionPrefab;
    private AudioSource explosionSound;
    public GameObject scorePopupObject;

    // start method
    private void Start()
    {
        RespawnRedBall();
        explosionSound = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BlueBall")
        {
            Instantiate(explosionPrefab, transform.position, transform.rotation);
            Instantiate(scorePopupObject, transform.position, Quaternion.identity);
            StartCoroutine(BallCollisionWaitForRespawn());
            Destroy(collision.gameObject);
            SpawnClones.score++;
            explosionSound.Play();
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        // ball reaches the maximum point
        if (collision.name == "DespawnLine")
        {
            StartCoroutine(BallCollisionWaitForRespawn());
            GameManager.lives -= 1;
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
