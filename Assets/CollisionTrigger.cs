using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTrigger : MonoBehaviour {

    public bool upper, lower;
    public Basket basket;

    private void OnTriggerEnter2D(Collider2D collision) {
        basket.Trigger(upper, lower);
    }


}
