using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFollow : MonoBehaviour {
    Transform t;
    public Transform white, black;
    public Vector3 lightPosition;
    public float radius;
	// Use this for initialization
	void Start () {
        t = transform;
	}
	
	// Update is called once per frame
	void Update () {
        t.position = BallController.instance.t.position;
        white.localPosition = radius * ((lightPosition - t.position).normalized);
        black.localPosition = -radius * ((lightPosition - t.position).normalized);
    }
}
