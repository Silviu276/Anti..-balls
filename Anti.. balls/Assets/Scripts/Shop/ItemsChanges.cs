using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ItemsChanges : MonoBehaviour
{
    // item 1
    public static int startLivesMaxLevel = 5;
    public Text startLivesLevels;

    // item 2
    public static int trajectoryLineMaxLevel = 16;
    public Text trajectoryLineLevels;

    // item 3
    public static int maxBallsMaxLevel = 10;
    public Text maxBallsLevels;

    // item 4
    public static int heartChanceMaxLevel = 10;
    public Text heartChanceLevels;

    // start method
    private void Start()
    {
        
    }

    public void BuyItem1StartLives()
    {
        if (PlayerPrefs.GetInt("StartLivesLevel") < startLivesMaxLevel)
        {
            PlayerPrefs.SetInt("StartLivesLevel", PlayerPrefs.GetInt("StartLivesLevel") + 1);
            startLivesLevels.text = $"Level: {PlayerPrefs.GetInt("StartLivesLevel")}/{startLivesMaxLevel}";
        }
    }

    public void BuyItem2TrajectoryLine()
    {
        if (PlayerPrefs.GetInt("TrajectoryLineLevel") < trajectoryLineMaxLevel)
        {
            PlayerPrefs.SetInt("TrajectoryLineLevel", PlayerPrefs.GetInt("TrajectoryLineLevel") + 1);
            trajectoryLineLevels.text = $"Level: {PlayerPrefs.GetInt("TrajectoryLineLevel")}/{ItemsChanges.trajectoryLineMaxLevel}";
        }
    }

    public void BuyItem3MaxBalls()
    {
        if (PlayerPrefs.GetInt("MaxBallsLevel") < maxBallsMaxLevel)
        {
            PlayerPrefs.SetInt("MaxBallsLevel", PlayerPrefs.GetInt("MaxBallsLevel") + 1);
            maxBallsLevels.text = $"Level: {PlayerPrefs.GetInt("MaxBallsLevel")}/{maxBallsMaxLevel}";
        }
    }

    public void BuyItem4HeartChance()
    {
        if (PlayerPrefs.GetInt("HeartChanceLevel") < heartChanceMaxLevel)
        {
            PlayerPrefs.SetInt("HeartChanceLevel", PlayerPrefs.GetInt("HeartChanceLevel") + 1);
            heartChanceLevels.text = $"Level: {PlayerPrefs.GetInt("HeartChanceLevel")}/{heartChanceMaxLevel}";
        }
    }
}
