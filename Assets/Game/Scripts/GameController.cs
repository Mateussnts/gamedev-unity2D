using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour{
    
    private bool isGameRunning;
    private int score = 0;

    public ObstacleGenerator generator;
    public GameConfiguration config;
    public TextMeshProUGUI scoreLabel;
    public GameUI gameStartUI;
    public GameUI gameOverUI;
    public Player player;


    public void Start(){
        isGameRunning = false;
        gameStartUI.Show();
        
    }

    private void Update(){
        scoreLabel.text = score.ToString("000000000.##");
        if (!isGameRunning) return;
        score++;
    }
    
    public void GameStart(){

        isGameRunning = true;
        generator.GeneratorObstacles();
        config.speed = 4f;
        gameStartUI.Hide();
        player.SetActive();

    }

    public void GameOver(){

        isGameRunning = false;
        generator.StopGenerator();
        config.speed = 0f;
        gameOverUI.Show();

    }


}
