using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteHolder : MonoBehaviour {

    public static SpriteHolder instance = null;
    public BallList list;
    private void Awake() {
        instance = this;
    }

    public static Sprite GetBall(int index) {
        return instance.list.spriteList[index];
    }
}
