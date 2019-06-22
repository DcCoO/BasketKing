using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopBuilder : MonoBehaviour {

    public GameObject ballShop;
    public BallList ballList;
    public BallShop[] balls;
	// Use this for initialization
	void Start () {

        int[] ballState = Memory.balls;

        balls = new BallShop[BallStats.balls.Length];
		for(int i = 0; i < BallStats.balls.Length; i++) {
            balls[i] = Instantiate(ballShop, transform).GetComponent<BallShop>();
            balls[i].id = i;
            if (ballState[i] == 0) {
                balls[i].ballName.text = string.Empty;
                balls[i].price.text = string.Empty;
                balls[i].coin.color = Color.clear;
                balls[i].sprite.sprite = ballList.spriteList[BallStats.balls.Length]; //locker
                balls[i].gameObject.name = "Ball Shop " + i;
                balls[i].frame.color = new Color().Hex("ffffff", 0.2f);
            }
            else if (ballState[i] == 1) {
                balls[i].ballName.text = BallStats.balls[i].name;
                balls[i].price.text = BallStats.balls[i].price.ToString();
                balls[i].sprite.sprite = ballList.spriteList[i];
                balls[i].gameObject.name = "Ball Shop " + i;
            }
            else {
                balls[i].ballName.text = BallStats.balls[i].name;
                balls[i].price.text = BallStats.balls[i].price.ToString();
                balls[i].sprite.sprite = ballList.spriteList[i];
                balls[i].gameObject.name = "Ball Shop " + i;
                balls[i].frame.color = BallStats.balls[i].startColor;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
