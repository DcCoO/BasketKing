using System.Text.RegularExpressions;
using UnityEngine;

public class LevelBall : MonoBehaviour {

    [HideInInspector] public Transform t;
    public SpriteRenderer sr;
    public int id;

    private void Awake() {
        t = transform;
    }

    private void Start() {
        id = int.Parse(Regex.Match(gameObject.name, @"\d+").Value);
        sr.sprite = SpriteHolder.GetBall(levelBall[id]);
    }

    public Vector2 GetPosition() {
        return t.position;
    }

    private void OnMouseDown() {
        if (sr.color.a < 0.9f) return;
        SceneController.instance.LoadLevel(id);
    }

    public void LoadLevel() {
        SceneController.instance.LoadLevel(1);
    }

    public static int[] levelBall = {
        0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
        1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
        2, 2, 2, 2, 2, 2, 2, 2, 2, 2,
        3, 3, 3, 3, 3, 3, 3, 3, 3, 3,
        4, 4, 4, 4, 4, 4, 4, 4, 4, 4
    };

	
	// TODO evento troca de string de fase 
}
