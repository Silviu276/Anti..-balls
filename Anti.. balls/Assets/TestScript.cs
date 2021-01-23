using System.Collections;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public Animator gameOverAnimator;
    private bool plays;
    public void TheClick()
    {
        plays = gameOverAnimator.GetBool("plays");
        plays = true;
        gameOverAnimator.SetBool("plays", plays);
        Debug.Log(gameOverAnimator.GetBool("plays"));
    }
}
