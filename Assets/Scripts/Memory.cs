using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Memory: IEnumerable<Node> {

    public static int currentLevel {
        get {
            return PlayerPrefs.GetInt("CurrentLevel", 0);
        }
        set {
            PlayerPrefs.SetInt("CurrentLevel", value);
        }
    }

    public static bool[] levels {
        get {
            bool[] levelArray = PlayerPrefsX.GetBoolArray("Levels", false, 50);
            if(!levelArray[0]) {
                levelArray[0] = true;
                PlayerPrefsX.SetBoolArray("Levels", levelArray);
                return levelArray;
            }
            return levelArray;
        }
        set {
            PlayerPrefsX.SetBoolArray("Levels", value);
        }
    }

    public static void WinLevel() {
        int n = currentLevel;
        bool[] levelArray = levels;
        levelArray[n] = true;

        foreach(int u in tree[n]) {
            if(tree[u].parent.All(v => levelArray[v])) {
                levelArray[u] = true;
            }
        }
        levels = levelArray;
    }

    //array operator em Memory percorre levels
    public bool this[int i] {
        get { return levels[i]; }
        set { bool[] levelArray = levels; levelArray[i] = value; PlayerPrefsX.SetBoolArray("Levels", levelArray); }
    }

    public static void UnlockLevel(int n) {
        bool[] levelArray = PlayerPrefsX.GetBoolArray("Levels", false, 50);
        levelArray[n] = true;
        PlayerPrefsX.SetBoolArray("Levels", levelArray);
    }

    //foreach em Memory percorre tree
    public IEnumerator<Node> GetEnumerator() {
        for(int i = 0; i < tree.Length; i++) {
            yield return tree[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return GetEnumerator();
    }


    //0: hidden
    //1: can buy
    //2: bought
    public static int[] balls {
        get {
            int[] ballArray = PlayerPrefsX.GetIntArray("Balls", 0, 16);
            if(ballArray[0] == 0) {
                ballArray[0] = 1;
                PlayerPrefsX.SetIntArray("Levels", ballArray);
            }
            return ballArray;
        }
        set {
            PlayerPrefsX.SetIntArray("Levels", value);
        }
    }

    










    public static Node[] tree = new Node[] {
        new Node(parent: new int[]{}, children: new int[]{1}),          //0
        new Node(parent: new int[]{0}, children: new int[]{2,3}),       //1
        new Node(parent: new int[]{1}, children: new int[]{4,5}),       //2
        new Node(parent: new int[]{1}, children: new int[]{5,6}),       //3
        new Node(parent: new int[]{2}, children: new int[]{7,8}),       //4
        new Node(parent: new int[]{2,3}, children: new int[]{7,8,9}),   //5
        new Node(parent: new int[]{3}, children: new int[]{8,9}),       //6
        new Node(parent: new int[]{4,5}, children: new int[]{}),        //7
        new Node(parent: new int[]{4,5,6}, children: new int[]{}),      //8
        new Node(parent: new int[]{5,6}, children: new int[]{}),        //9
    };




}



public class Node : IEnumerable<int> {
    public int[] parent;
    public int[] children;

    public Node(int[] parent, int[] children) {
        this.parent = parent; this.children = children;
    }

    public IEnumerator<int> GetEnumerator() {
        for (int i = 0; i < children.Length; i++) {
            yield return children[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return GetEnumerator();
    }
}

