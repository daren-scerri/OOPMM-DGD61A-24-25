using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager>
{

    //public static GameManager myGameManager;
    [SerializeField] Text playerScoreText;
    [SerializeField] Text playerHealthText;

    public void OnEnemyDie(int hitpoints)
    {

        GameData.Score += hitpoints;
        playerScoreText.text = "Score: " + GameData.Score.ToString();
    }

    public void DisplayHealth()
    {
        playerHealthText.text = "Health: " + GameData.PlayerHealth.ToString();
    }



    // Start is called before the first frame update
    void Start()
    {
        GameData.PlayerHealth = 100;
        DisplayHealth();
        GameData.Score = 0;
    }

}
