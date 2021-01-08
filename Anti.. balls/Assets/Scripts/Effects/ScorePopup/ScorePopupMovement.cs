using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScorePopupMovement : MonoBehaviour
{
    public int scoreAmount;
    private void Start()
    {
        scoreAmount = 10;
        GetComponentInChildren<Text>().text = scoreAmount.ToString();
    }
    private void FixedUpdate()
    {
        transform.Translate(0f, 0.02f, 0f);
    }
}
