using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // pointer
    public GameObject pointer;

    public static int lives;

    public Text livesText;

    public Canvas gameOver;

    // start method
    private void Start()
    {
        Cursor.visible = false;
        pointer.SetActive(true);
        lives = 1;
    }
    private void Update()
    {
        if (lives <= 0)
        {
            Debug.Log("Lose");
        }
        livesText.text = $"x{lives} ";
    }
}
