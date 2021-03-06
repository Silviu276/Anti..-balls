using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    /* -------------------
     * spawns blue balls
     * gets and updates the mouse position
    ------------------- */

    public GameObject blueBall; // blue ball prefab
    Vector2 mousePosition; // gets the mouse position
    public Transform blueBalls; // blue ball parent
    public Transform trajectoryLine;
    private int maxBlueBalls;

    // start method
    private void Start()
    {
        trajectoryLine.localScale = new Vector3(0.2f, PlayerPrefs.GetInt("TrajectoryLineLevel"), 1f);
        maxBlueBalls = 10 + PlayerPrefs.GetInt("MaxBallsLevel");
    }

    // update method
    private void Update()
    {
        SpawnBlueBall();
        UpdateMousePosition();
    }

    // spawns blue ball if you press the mouse button
    private void SpawnBlueBall()
    {
        if (Input.GetButtonDown("Fire1") && blueBalls.childCount < maxBlueBalls)
        {
            Instantiate(blueBall, new Vector2(transform.position.x - 0.3f, transform.position.y), 
                Quaternion.identity, blueBalls);
            Instantiate(blueBall, new Vector2(transform.position.x + 0.3f, transform.position.y),
                Quaternion.identity, blueBalls);
        }
    }

    // updates mouse position on screen
    private void UpdateMousePosition()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(mousePosition.x, -4.6f);
    }
}
