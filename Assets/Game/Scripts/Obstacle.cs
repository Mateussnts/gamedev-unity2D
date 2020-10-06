using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour{
    
    private Rigidbody2D obsRB;

    void Start(){
        
        obsRB = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update(){

        obsRB.velocity = new Vector2(-5f, 0f);    
    }
}
