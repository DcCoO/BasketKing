using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour {

    public static Basket instance = null;
    Animator anim;
    AudioSource source;

    public AudioClip score, rimshot;

    private void Awake() {
        instance = this;
    }

    void Start() {
        anim = GetComponent<Animator>();
        source = GetComponent<AudioSource>();
    }

    bool triggerUpper = false, triggerLower = false;

    private void OnCollisionEnter2D(Collision2D collision) {
        anim.SetTrigger("Shake");
        source.Stop();
        source.clip = rimshot;
        source.Play();
    }

    public void Trigger(bool upper, bool lower) {
        if (upper) {
            triggerUpper = true;
            StartCoroutine(DunkRoutine());
        }
        else {
            triggerLower = true;
        }
    }

    IEnumerator DunkRoutine() {
        if (triggerLower) {
            yield return new WaitForSeconds(2f);
            triggerUpper = triggerLower = false;
        }
        else {
            float startTime = Time.time;
            yield return new WaitUntil(() => triggerLower || Time.time - startTime > 1.5f);
            if (triggerLower) {
                anim.SetTrigger("Point");
                print("PONTO!");
                source.Stop();
                source.clip = score;
                source.Play();

                //return to menu
                Memory.WinLevel();
                yield return new WaitForSeconds(1.5f);
                SceneController.instance.LoadSelectLevel();


            }
            triggerUpper = triggerLower = false;
        }
    }

}
