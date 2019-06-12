using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

    public static BallController instance = null;
    [HideInInspector] public Rigidbody2D rb;
    [HideInInspector] public Transform t;
    TrailRenderer tr;

    public Color color;
    public Transform arrow;
    public SpriteRenderer arrowRenderer;

    Vector2 defaultPos;
    private void Awake() {
        instance = this;
        rb = GetComponent<Rigidbody2D>();
        tr = GetComponent<TrailRenderer>();
        defaultPos = transform.position;
        GetComponent<SpriteRenderer>().color = color;
        tr.startColor = new Color(color.r, color.g, color.b, 0.66f);
        tr.endColor = new Color(color.r, color.g, color.b, 0f);
        t = transform;
    }

    private void Update() {
        if (Input.GetMouseButtonDown(0) && rb.constraints != RigidbodyConstraints2D.FreezeAll) {
            ResetPosition();
        }
    }

    public void SetPosition(Vector2 newPosition) {
        defaultPos = newPosition;
        ResetPosition();
    }

    public void Throw(Vector2 direction, float power, float spin) {
        rb.constraints = RigidbodyConstraints2D.None;
        rb.AddForce(direction.normalized * power, ForceMode2D.Impulse);
        rb.AddTorque(-spin);
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
