using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThrowerController : MonoBehaviour {
    
    float max = 0.4f * (float)Screen.height, scale;

    Vector2 beginPos, direction;
    BallController b;
    SpriteRenderer arrowOutline;

    private void Start() {
        b = BallController.instance;
        arrowOutline = b.arrow.GetComponent<SpriteRenderer>();
    }

    public void BeginTouch() {
        beginPos = Input.mousePosition;
    }

    public void DragTouch() {
        if (b == null) return;
        direction =  beginPos - (Vector2)Input.mousePosition;
        scale = Mathf.Min(1, direction.magnitude / max);
        b.arrow.localEulerAngles = new Vector3(0, 0, angle360(direction));
        //b.arrow.localScale = new Vector2(scale, b.arrow.localScale.y);
        b.arrowRenderer.color = Color.Lerp(Color.green, Color.red, scale);
        arrowOutline.size = new Vector2(2 * scale, arrowOutline.size.y);
        b.arrowRenderer.size = new Vector2(2 * scale, arrowOutline.size.y);
    }

    public void EndTouch() {
        if (b == null) return;
        arrowOutline.size = new Vector2(0, arrowOutline.size.y);
        b.arrowRenderer.size = new Vector2(0, arrowOutline.size.y);
        b.Throw(direction, scale, SpinBar.instance.value);
    }


    float angle360(Vector3 from) {
        float angle = Vector2.Angle(from, Vector2.right);
        return Input.mousePosition.y > beginPos.y ? 360 - angle : angle;
    }
}
