using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour{
    
    private bool isGameRunning;

    void Start(){
        isGameRunning = false;
        GameStart();
    }

    void GameStart(){

        isGameRunning = true;

    }

    void GameOver(){
    
        isGameRunning = false;

    }


}
