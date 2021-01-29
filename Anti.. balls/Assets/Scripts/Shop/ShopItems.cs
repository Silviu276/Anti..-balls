using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShopItems : MonoBehaviour
{
    /* i must get
     * GameManager -> lives
     * BallSpawn -> trajectoryLine.localScale
     * BallSpawn -> maxBlueBalls
     * PowerupDrop -> newLiveChance
     */

    // item 1
    public Text startLivesLevels;

    // item 2
    public Text trajectoryLineLevels;

    // item 3
    public Text maxBallsLevels;

    // item 4
    public Text heartChanceLevels;

    public Text moneyText; // playtest

    // start method
    private void Start()
    {
        if (PlayerPrefs.GetInt("FirstOpening") == 0)
            FirstOpening();
        ShopCheck();
    }

    public static void FirstOpening() // should execute when the player first ever enters the game
    {
        PlayerPrefs.SetInt("StartLivesLevel", 1);
        PlayerPrefs.SetInt("TrajectoryLineLevel", 0);
        PlayerPrefs.SetInt("MaxBallsLevel", 0);
        PlayerPrefs.SetInt("HeartChanceLevel", 0);
        PlayerPrefs.SetInt("Money", 0); // playtest
        PlayerPrefs.SetInt("FirstOpening", 1);
    }

    private void ShopCheck()
    {
        startLivesLevels.text = $"Level: {PlayerPrefs.GetInt("StartLivesLevel")}/{ItemsChanges.startLivesMaxLevel}";
        trajectoryLineLevels.text = $"Level: {PlayerPrefs.GetInt("TrajectoryLineLevel")}/{ItemsChanges.trajectoryLineMaxLevel}";
        maxBallsLevels.text = $"Level: {PlayerPrefs.GetInt("MaxBallsLevel")}/{ItemsChanges.maxBallsMaxLevel}";
        heartChanceLevels.text = $"Level: {PlayerPrefs.GetInt("HeartChanceLevel")}/{ItemsChanges.heartChanceMaxLevel}";
        moneyText.text = GameManager.ScoreSpacing(PlayerPrefs.GetInt("Money").ToString()) + "$"; // playtest
    }

    // update method
    private void Update()
    {
        // just for test
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("GameScene");
            Cursor.visible = false;
        }

        // just for test
        if (Input.GetKeyDown(KeyCode.C))
        {
            PlayerPrefs.DeleteAll();
            Debug.Log("cleared");
        }
    }
}
