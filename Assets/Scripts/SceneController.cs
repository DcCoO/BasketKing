using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

    public static SceneController instance = null;
    

    // Use this for initialization
    void Awake () {
        instance = this;
        /*
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
        */
	}
	
	public void LoadMenu() {
        SceneManager.LoadScene("Menu");
    }

    public void LoadSelectLevel() {
        SceneManager.LoadScene("LevelSelect");
    }

    public void LoadLevel(int level) {
        Memory.currentLevel = level;
        SceneManager.LoadScene("Game");
    }
}
