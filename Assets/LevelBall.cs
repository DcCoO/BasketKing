using UnityEngine;

public class LevelBall : MonoBehaviour {

    [HideInInspector] public Transform t;
    public SpriteRenderer sr;
    public int id;

    private void Awake() {
        t = transform;
    }
    // Use this for initialization
    void Start () {

    }

    public Vector2 GetPosition() {
        return t.position;
    }

    public void LoadLevel() {
        SceneController.instance.LoadLevel(1);
    }
	
	// TODO evento troca de string de fase 
}
