using System.Text.RegularExpressions;
using UnityEngine;

public class LevelBall : MonoBehaviour {

    [HideInInspector] public Transform t;
    public SpriteRenderer sr;
    public int id;

    private void Awake() {
        t = transform;
        id = int.Parse(Regex.Match(gameObject.name, @"\d+").Value);
    }
    // Use this for initialization
    void Start () {

    }

    public Vector2 GetPosition() {
        return t.position;
    }

    private void OnMouseDown() {
        SceneController.instance.LoadLevel(id);
    }

    public void LoadLevel() {
        SceneController.instance.LoadLevel(1);
    }
	
	// TODO evento troca de string de fase 
}
