using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    // blue ball prefab
    public GameObject blueBall;
    // gets the mouse position
    Vector2 mousePosition;
    // blue ball parent
    public Transform blueBalls;

    // update method
    private void Update()
    {
        SpawnBlueBall();
        UpdateMousePosition();
    }

    // spawns blue ball if you press the mouse button
    private void SpawnBlueBall()
    {
        if (Input.GetButtonDown("Fire1") && blueBalls.childCount < 10)
        {
            Instantiate(blueBall, new Vector2(transform.position.x, transform.position.y), 
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
