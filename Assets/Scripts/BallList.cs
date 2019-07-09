using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "BallSpriteList", menuName = "Prefabs/BallSpriteList")]
public class BallList : ScriptableObject {
    public Sprite[] spriteList;

#if UNITY_EDITOR
    [MenuItem("Tools/Clear PlayerPrefs")]
    private static void NewMenuOption() {
        PlayerPrefs.DeleteAll();
    }
#endif

}


