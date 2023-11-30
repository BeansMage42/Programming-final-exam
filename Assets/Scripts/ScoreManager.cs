using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static ScoreManager instance;
    private static int highScore;
    private int currentScore;
    private void Awake()
    {
        if (instance == null)
        {
            instance = new ScoreManager();
        }
        else
        {
            Destroy(gameObject);
        }

    }

    public void IncrementScore()
    {
        currentScore++;
        if(currentScore > highScore)
        {
            highScore = currentScore;
        }
    }

    public int getCurrentScore()
    {
        return (currentScore);
    }
        
}
