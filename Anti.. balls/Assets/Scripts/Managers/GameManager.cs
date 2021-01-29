using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    /* -------------------
     * sets cursor visibility
     * sets pointer visibility
     * stores lives
     * verifies if you lost
     * updates lives amount text
     * shows a game over window
     * resets the timescale at normal
     * plays game over score animation
     * sets game over score text
    ------------------- */

    public GameObject pointer; // pointer
    public static int lives; // lives
    public Text livesText; // displays lives amount
    public Canvas gameOver; // canvas showed when is game over
    public Animator gameOverScoreAnimator; // animator controller for score showed at game over
    public GameObject blueBalls; // the object that holds all the blue balls
    private bool inGame; // verifies if the player is still in the game
    public static int score; // score in this session
    public Text gameOverScore; // the text that shows the score at game over

    // start method
    private void Start()
    {
        if (PlayerPrefs.GetInt("FirstOpening") == 0)
            ShopItems.FirstOpening();
        Cursor.visible = false;
        pointer.SetActive(true);
        lives = PlayerPrefs.GetInt("StartLivesLevel");
        inGame = true;
        score = 0;
    }

    // update method
    private void Update()
    {
        livesText.text = $"x{lives} "; // updates lives amount

        if (Input.GetKeyDown(KeyCode.R)) // just for test - reloads the scene
        {
            SceneManager.LoadScene("GameScene");
            Time.timeScale = 1f;
        }

        if (lives <= 0 && inGame) // the player lost
        {
            inGame = false; // the player is not in the game anymore
            Destroy(pointer);
            Destroy(blueBalls);
            gameOver.gameObject.SetActive(true); // game over canvas shows up
            gameOverScore.text = $"SCORE\n{ScoreSpacing(score.ToString())}";
            gameOverScoreAnimator.SetBool("plays", true); // score animation plays
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") + score); // playtest
        }

        // just for test
        /*if (Input.GetKeyDown(KeyCode.W) && Time.timeScale < 1.0f)
            Time.timeScale += 0.1f;
        else if (Input.GetKeyDown(KeyCode.S))
            Time.timeScale -= 0.1f;*/

        // just for test
        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene("ShopScene");

        // just for test
        if (Input.GetKeyDown(KeyCode.E))
            Application.Quit();
    }

    // creates a space at every 3 decimals in a number for better readability
    public static string ScoreSpacing(string textToBeSpaced)
    {
        string spacedText = string.Empty;
        int contor = 0;
        for (int i = textToBeSpaced.Length - 1; i >= 0; i--)
        {
            if (contor == 3)
            {
                spacedText = $"{textToBeSpaced[i]}.{spacedText}";
                contor = 0;
            }
            else
                spacedText = $"{textToBeSpaced[i]}{spacedText}";
            contor++;
        }
        return spacedText;
    }
}
