using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

    public static BallController instance = null;
    [HideInInspector] public Rigidbody2D rb;
    [HideInInspector] public Transform t;
    TrailRenderer tr;

    [Header("Ball Attributes")]
    public float maxSpeed;
    public float maxSpin;

    public Color color;
    public Transform arrow;
    public SpriteRenderer arrowRenderer;
    public AudioSource source;

    Vector2 defaultPos;
    private void Awake() {
        instance = this;
        rb = GetComponent<Rigidbody2D>();
        tr = GetComponent<TrailRenderer>();
        defaultPos = transform.position;
        tr.startColor = new Color(color.r, color.g, color.b, 0.66f);
        tr.endColor = new Color(color.r, color.g, color.b, 0f);
        t = transform;
    }

    private void Update() {
        if (Input.GetMouseButtonDown(0) && rb.constraints != RigidbodyConstraints2D.FreezeAll) {
            ResetPosition();
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


