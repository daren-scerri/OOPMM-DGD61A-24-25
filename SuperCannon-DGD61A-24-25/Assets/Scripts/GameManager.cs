using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager>
{

    //public static GameManager myGameManager;
    [SerializeField] Text playerScoreText; 

    public void OnEnemyDie(int hitpoints)
    {
        GameData.Score += hitpoints;
        playerScoreText.text = "Score: " + GameData.Score.ToString();
    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
