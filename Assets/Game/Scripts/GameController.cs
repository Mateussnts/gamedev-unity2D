using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour{
    
    private bool isGameRunning;

    public ObstacleGenerator generator;
    public GameConfiguration config;

    void Start(){
        isGameRunning = false;
        GameStart();
    }

    void GameStart(){

        isGameRunning = true;
        generator.GeneratorObstacles();
        config.speed = 4f;

    }

    public void GameOver(){

        isGameRunning = false;
        generator.StopGenerator();
        config.speed = 0f;

    }


}
