using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public static GameManager instance;
    [SerializeField ] private PlatFormSpawner spawner;
    private void Awake()
    {
        {
            if (instance == null)
            {
                instance = new GameManager();
            }
            else
            {
                Destroy(gameObject);
            }


        }

        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameStart()
    {
        spawner.startGame();
    }

    public void GameOver()
    {
        InputController.GameDisable();
        UIManager.instance.GameOver();
    }
}
