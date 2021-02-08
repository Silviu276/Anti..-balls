using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ItemsChanges : MonoBehaviour
{
    // item 1
    public static int startLivesMaxLevel = 5;
    public Text startLivesLevels;
    public Text startLivesPrice;

    // item 2
    public static int trajectoryLineMaxLevel = 16;
    public Text trajectoryLineLevels;
    public Text trajectoryLinePrice;

    // item 3
    public static int maxBallsMaxLevel = 10;
    public Text maxBallsLevels;
    public Text maxBallsPrice;

    // item 4
    public static int heartChanceMaxLevel = 10;
    public Text heartChanceLevels;
    public Text heartChancePrice;

    public Text moneyText;

    // start method
    private void Start()
    {
        PricesUpdate();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            MoneyUpdate(1000);
        }
    }

    public void BuyItem1StartLives()
    {
        if (PlayerPrefs.GetInt("StartLivesLevel") < startLivesMaxLevel 
            && PlayerPrefs.GetInt("Money") >= PlayerPrefs.GetInt("StartLivesPrice"))
        {
            PlayerPrefs.SetInt("StartLivesLevel", PlayerPrefs.GetInt("StartLivesLevel") + 1);
            startLivesLevels.text = $"Level: {PlayerPrefs.GetInt("StartLivesLevel")}/{startLivesMaxLevel}";
            MoneyUpdate(-PlayerPrefs.GetInt("StartLivesPrice"));
            Price1Update();
        }
    }

    public void BuyItem2TrajectoryLine()
    {
        if (PlayerPrefs.GetInt("TrajectoryLineLevel") < trajectoryLineMaxLevel 
            && PlayerPrefs.GetInt("Money") >= PlayerPrefs.GetInt("TrajectoryLinePrice"))
        {
            PlayerPrefs.SetInt("TrajectoryLineLevel", PlayerPrefs.GetInt("TrajectoryLineLevel") + 1);
            trajectoryLineLevels.text = $"Level: {PlayerPrefs.GetInt("TrajectoryLineLevel")}/{ItemsChanges.trajectoryLineMaxLevel}";
            MoneyUpdate(-PlayerPrefs.GetInt("TrajectoryLinePrice"));
            Price2Update();
        }
    }

    public void BuyItem3MaxBalls()
    {
        if (PlayerPrefs.GetInt("MaxBallsLevel") < maxBallsMaxLevel 
            && PlayerPrefs.GetInt("Money") >= PlayerPrefs.GetInt("MaxBallsPrice"))
        {
            PlayerPrefs.SetInt("MaxBallsLevel", PlayerPrefs.GetInt("MaxBallsLevel") + 1);
            maxBallsLevels.text = $"Level: {PlayerPrefs.GetInt("MaxBallsLevel")}/{maxBallsMaxLevel}";
            MoneyUpdate(-PlayerPrefs.GetInt("MaxBallsPrice"));
            Price3Update();
        }
    }

    public void BuyItem4HeartChance()
    {
        if (PlayerPrefs.GetInt("HeartChanceLevel") < heartChanceMaxLevel 
            && PlayerPrefs.GetInt("Money") >= PlayerPrefs.GetInt("HeartChancePrice"))
        {
            PlayerPrefs.SetInt("HeartChanceLevel", PlayerPrefs.GetInt("HeartChanceLevel") + 1);
            heartChanceLevels.text = $"Level: {PlayerPrefs.GetInt("HeartChanceLevel")}/{heartChanceMaxLevel}";
            MoneyUpdate(-PlayerPrefs.GetInt("HeartChancePrice"));
            Price4Update();
        }
    }

    private void PricesUpdate()
    {
        Price1Update();
        Price2Update();
        Price3Update();
        Price4Update();
    }

    private void Price1Update()
    {
        // Start Lives
        int nextLevel = PlayerPrefs.GetInt("StartLivesLevel") + 1;
        if (nextLevel <= 5)
        {
            PlayerPrefs.SetInt("StartLivesPrice", nextLevel * nextLevel * 5000);
            startLivesPrice.text = $"Price: {GameManager.TextSpacing(PlayerPrefs.GetInt("StartLivesPrice").ToString())} $";
        }
        else
        {
            startLivesPrice.text = "Price: SOLD";
        }
    }

    private void Price2Update()
    {
        // Trajectory Line
        int nextLevel = PlayerPrefs.GetInt("TrajectoryLineLevel") + 1;
        if (nextLevel <= 16)
        {
            PlayerPrefs.SetInt("TrajectoryLinePrice", 5000 + nextLevel * 2500);
            trajectoryLinePrice.text = $"Price: {GameManager.TextSpacing(PlayerPrefs.GetInt("TrajectoryLinePrice").ToString())} $";
        }
        else
        {
            trajectoryLinePrice.text = "Price: SOLD";
        }
    }

    private void Price3Update()
    {
        // Max Balls
        int nextLevel = PlayerPrefs.GetInt("MaxBallsLevel") + 1;
        if (nextLevel <= 10)
        {
            PlayerPrefs.SetInt("MaxBallsPrice", 9000 + nextLevel * 1000);
            maxBallsPrice.text = $"Price: {GameManager.TextSpacing(PlayerPrefs.GetInt("MaxBallsPrice").ToString())} $";
        }
        else
        {
            maxBallsPrice.text = "Price: SOLD";
        }
    }

    private void Price4Update()
    {
        // Heart Chance
        int nextLevel = PlayerPrefs.GetInt("HeartChanceLevel") + 1;
        if (nextLevel <= 10)
        {
            PlayerPrefs.SetInt("HeartChancePrice", nextLevel * 5000);
            heartChancePrice.text = $"Price: {GameManager.TextSpacing(PlayerPrefs.GetInt("HeartChancePrice").ToString())} $";
        }
        else
        {
            heartChancePrice.text = "Price: SOLD";
        }
    }
    private void MoneyUpdate(int sum)
    {
        PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") + sum);
        moneyText.text = $"{GameManager.TextSpacing(PlayerPrefs.GetInt("Money").ToString())} $";
    }
}
