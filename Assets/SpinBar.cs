using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinBar : MonoBehaviour {

    public static SpinBar instance = null;

    [Range(-1, 1)] public float value;
    public RectTransform handle;

    float maxWidth;

    private void Awake() {
        instance = this;
    }

    private void Start() {
        maxWidth = (float) Screen.width * 0.105f;
    }

    float mousePos, delta;
    public void BeginDrag() {
        mousePos = Input.mousePosition.x;
    }

    public void MoveDrag() {
        delta = Input.mousePosition.x - mousePos;
        handle.anchoredPosition = Mathf.Clamp(handle.anchoredPosition.x + delta , -maxWidth, maxWidth) * Vector2.right;
        mousePos = Input.mousePosition.x;
        value = handle.anchoredPosition.x / maxWidth;
    }

    public void EndDrag() {
        value = handle.anchoredPosition.x / maxWidth;
    }




}
