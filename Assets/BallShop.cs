using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class BallShop : MonoBehaviour {
    public int id;
    public Image frame, sprite, coin;
    public Text ballName, price;
	// Use this for initialization
	void Awake () {
        NotifyBalls += Highlight;
    }
	
	public void Select() {
        chosenBall = id;
        NotifyBalls();
    }

    public void Highlight() {
        if (id == chosenBall && ballName.text != string.Empty) {
            print("id = " + id + ", gameobject = " + gameObject.name);
            print(ballName.text);
            BuyPopup.instance.Choose(id);
        }
    }

    public static int chosenBall = 0;
    public static Action NotifyBalls;
}
