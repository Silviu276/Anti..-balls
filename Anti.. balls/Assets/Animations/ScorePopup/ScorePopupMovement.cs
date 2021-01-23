using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScorePopupMovement : MonoBehaviour
{
    /* -------------------
     * moves score popup objects
     * sets score text
     * updates game session score live
    ------------------- */

    private int scoreAmount;
    private Text scoreText; // the text that displays the score

    // start method
    private void Start()
    {
        scoreAmount = ComboManager.combo * 10;
        scoreText = GetComponentInChildren<Text>();
        scoreText.text = scoreAmount.ToString();
        GameManager.score += scoreAmount;
    }

    // fixedupdate method
    private void FixedUpdate()
    {
        transform.Translate(0f, 0.02f, 0f);
    }
}
