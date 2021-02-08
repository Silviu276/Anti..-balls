using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShopItems : MonoBehaviour
{
    /*
     */

    // item 1
    public Text startLivesLevels;

    // item 2
    public Text trajectoryLineLevels;

    // item 3
    public Text maxBallsLevels;

    // item 4
    public Text heartChanceLevels;

    public Text moneyText;

    // start method
    private void Awake()
    {
        if (PlayerPrefs.GetInt("FirstOpening") == 0)
            FirstOpening();
        ShopCheck();
    }

    public static void FirstOpening() // should execute when the player first ever enters the game
    {
        // levels
        PlayerPrefs.SetInt("StartLivesLevel", 1);
        PlayerPrefs.SetInt("TrajectoryLineLevel", 0);
        PlayerPrefs.SetInt("MaxBallsLevel", 0);
        PlayerPrefs.SetInt("HeartChanceLevel", 0);

        // money
        PlayerPrefs.SetInt("Money", 0);

        // prices
        PlayerPrefs.SetInt("StartLivesPrice", 5000); // price =  (level + 1) * (level + 1)* 5000
        PlayerPrefs.SetInt("TrajectoryLinePrice", 2500); // price = 5000 + (level + 1) * 2500
        PlayerPrefs.SetInt("MaxBallsPrice", 10000); // price = 9000 + (level + 1) * 1000
        PlayerPrefs.SetInt("HeartChancePrice", 5000); // price = (level + 1) * 5000
        

        PlayerPrefs.SetInt("FirstOpening", 1);
    }

    private void ShopCheck()
    {
        startLivesLevels.text = $"Level: {PlayerPrefs.GetInt("StartLivesLevel")}/{ItemsChanges.startLivesMaxLevel}";
        trajectoryLineLevels.text = $"Level: {PlayerPrefs.GetInt("TrajectoryLineLevel")}/{ItemsChanges.trajectoryLineMaxLevel}";
        maxBallsLevels.text = $"Level: {PlayerPrefs.GetInt("MaxBallsLevel")}/{ItemsChanges.maxBallsMaxLevel}";
        heartChanceLevels.text = $"Level: {PlayerPrefs.GetInt("HeartChanceLevel")}/{ItemsChanges.heartChanceMaxLevel}";
        moneyText.text = GameManager.TextSpacing(PlayerPrefs.GetInt("Money").ToString()) + " $";
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
