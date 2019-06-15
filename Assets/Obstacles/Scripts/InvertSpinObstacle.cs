using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvertSpinObstacle : Obstacle {

    private void Start() {
        
    }
    private void Update() {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        print("trigou");
        BallController.instance.rb.angularVelocity *= -1;
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        print("bateu");
        //BallController.instance.rb.angularVelocity *= -1;
    }
    
}
