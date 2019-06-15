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
        NotifyBalls();
    }

    public void Highlight() {
        if(id != chosenBall) print("My id is " + id);
    }

    public static int chosenBall = 0;
    public static Action NotifyBalls;
    public static void Choose(int n) {

    }
}
