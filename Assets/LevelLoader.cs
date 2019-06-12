using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //LoadLevel();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("a")) {
            PrintLevel();
        }
	}

    public void LoadLevel() {
        int level = PlayerPrefs.GetInt("CurrentLevel", 1);
        Level lvl = JsonUtility.FromJson<Level>(LevelList.level[level - 1]);
        BallController.instance.SetPosition(lvl.ballPosition);
        Basket.instance.transform.position = lvl.basketPosition;
    }

    public void PrintLevel() {
        Level level = new Level();

        level.ballPosition = BallController.instance.transform.position;
        level.basketPosition = Basket.instance.transform.position;
        Obstacle[] gs = FindObjectsOfType<Obstacle>();

        level.obstacles = new int[gs.Length];
        level.obstaclePositions = new Vector2[gs.Length];

        for (int i = 0; i < gs.Length; i++) {
            level.obstacles[i] = (int)gs[i].type;
            level.obstaclePositions[i] = gs[i].transform.position;
        }

        string json = JsonUtility.ToJson(level);
        Debug.Log(json);
    }
}
