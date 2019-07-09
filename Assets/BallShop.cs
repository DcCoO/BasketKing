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
	void Start () {
        NotifyBalls += Highlight;
    }
	
	public void Select() {
        chosenBall = id;
        NotifyBalls();
    }

    public void Highlight() {
        if (id == chosenBall && ballName.text != string.Empty) {
            //if(gameObject) print("id = " + id + ", gameobject = " + gameObject.name);
            print(ballName.text);
            BuyPopup.instance.Choose(id);
        }
    }

    public static void Clear() {
        chosenBall = 0;
        NotifyBalls = null;
    }

    public static int chosenBall = 0;
    public static Action NotifyBalls;
}
