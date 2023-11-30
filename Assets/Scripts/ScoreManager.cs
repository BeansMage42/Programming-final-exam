using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static ScoreManager instanceS;
    private static int highScore;
    private int currentScore;
    private void Awake()
    {
        if (instanceS == null)
        {
            instanceS = this;
        }
        else
        {
            Destroy(gameObject);
        }

    }

    public void IncrementScore()
    {
        currentScore++;
        UIManager.instanceUI.UpdateText();
        if(currentScore > highScore)
        {
            highScore = currentScore;
        }
    }

    public int getCurrentScore()
    {
        return (currentScore);
    }
       
    public int getHighScore()
    {
        return (highScore);
    }
}
