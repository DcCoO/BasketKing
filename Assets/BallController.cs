using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

    public static BallController instance = null;
    [HideInInspector] public SpriteRenderer sr;
    [HideInInspector] public Rigidbody2D rb;
    [HideInInspector] public Transform t;
    public int ballIndex = 0;
    public BallList list;
    TrailRenderer tr;
    CircleCollider2D cc;

    [Header("Ball Attributes")]
    public float maxSpeed;
    public float maxSpin;
    
    public Transform arrow;
    public SpriteRenderer arrowRenderer;
    public AudioSource source;

    Vector2 defaultPos;
    private void Awake() {
        instance = this;
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        tr = GetComponent<TrailRenderer>();
        cc = GetComponent<CircleCollider2D>();
        defaultPos = transform.position;
        t = transform;
        SetBall();
    }

    private void Update() {
        if (Input.GetMouseButtonDown(0) && rb.constraints != RigidbodyConstraints2D.FreezeAll) {
            ResetPosition();
        }

        if (Input.GetKeyDown(KeyCode.A)) {
            NextBall();
        }
        source.volume = Mathf.Min(1f, rb.velocity.magnitude / 10f);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Obstacle") {
            source.Stop();
            source.Play();
        }
    }

    public void SetPosition(Vector2 newPosition) {
        defaultPos = newPosition;
        ResetPosition();
    }

    public void Throw(Vector2 direction, float speedScale, float spinScale) {
        rb.constraints = RigidbodyConstraints2D.None;
        rb.AddForce(direction.normalized * speedScale * maxSpeed, ForceMode2D.Impulse);
        rb.AddTorque(-spinScale * maxSpin);
    }

    public void ResetPosition() {
        if(gameObject.activeSelf) StartCoroutine(ResetPositionRoutine());
    }

    void OnBecameInvisible() {
        ResetPosition();
    }

    public void SetBall() {
        BallStats bs = BallStats.balls[ballIndex];

        //setting visual
        sr.sprite = list.spriteList[ballIndex];
        tr.startColor = bs.startColor;
        tr.endColor = bs.endColor;

        //setting physics
        rb.mass = bs.mass;
        rb.gravityScale = bs.gravityScale;
        maxSpeed = bs.maxSpeed;
        maxSpin = bs.maxSpin;
        cc.sharedMaterial.bounciness = bs.bounciness;

        //TODO: setting particle effect
    }

    public void NextBall() {
        ballIndex = (ballIndex + 1) % list.spriteList.Length;
        SetBall();
    }

    public void PreviousBall() {
        ballIndex = (ballIndex + list.spriteList.Length - 1) % list.spriteList.Length;
        SetBall();
    }


    IEnumerator ResetPositionRoutine() {
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
        rb.angularVelocity = 0;
        transform.rotation = Quaternion.identity;
        transform.position = defaultPos;
        tr.enabled = false;
        yield return new WaitForSeconds(0.3f);
        tr.enabled = true;        
    }
}


