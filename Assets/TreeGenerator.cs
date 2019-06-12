using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGenerator : MonoBehaviour {

    public LevelBall[] levels;
    public Transform lines;
    public GameObject linePrefab;
	// Use this for initialization
	void Start () {
        StartCoroutine(CreateEdges());
    }

    IEnumerator CreateEdges() {
        bool[] levelArray = Memory.levels;

        //Color semiClear = new Color(1, 1, 1, 0.4f);

        Action<int, int> CreateEdge = (u, v) => {
            GameObject go = Instantiate(linePrefab, lines);
            LineRenderer lr = go.GetComponent<LineRenderer>();
            //TODO: escolhe cor da seta entre cada par
            if(!levelArray[v]) lr.endColor = Color.clear;

            lr.SetPositions(new Vector3[] { levels[u].GetPosition(), levels[v].GetPosition() });
        };



        for(int i = 0; i < Memory.tree.Length; i++) {
            //levels[i].sr.color = levelArray[i] ? Color.white : semiClear;
            if (levelArray[i]) {
                levels[i].sr.color = Color.white;
                foreach (int j in Memory.tree[i]) {
                    CreateEdge(i, j);
                    yield return null;
                }
            }
            yield return null;
        }
        
        

    }

    

    

}
