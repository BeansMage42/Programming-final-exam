using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject startMenu;
    [SerializeField] private GameObject gameOverMenu;
     
    [SerializeField] private TextMeshProUGUI playScore;
    [SerializeField] private TextMeshProUGUI bestScore;
    [SerializeField] private TextMeshProUGUI currentScore;

    public static UIManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = new UIManager();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        StartGame();
    }

    public void StartGame()
    {
        InputController.GameDisable();
        gameOverMenu.SetActive(false);
        startMenu.SetActive(true);
    }



    public void GameOver()
    {
        gameOverMenu.SetActive(true);
    }


    public void StartButton()
    {
        GameManager.instance.GameStart();
        startMenu.SetActive(false);
        InputController.GameEnable();
    }

    public void ResetButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void UpdateText()
    {

    }
}
