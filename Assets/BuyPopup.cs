using UnityEngine;
using UnityEngine.UI;

public class BuyPopup : MonoBehaviour {

    public static BuyPopup instance = null;
    public Image ballImage;
    public Text ballPrice;
    public Text ballDescription;
    public BallList ballList;

    private void Awake() {
        instance = this;
        Turn(false);
    }

    public void Turn(bool state) {
        gameObject.SetActive(state);
    }

    public void Choose(int n) {
        ballDescription.text = BallStats.balls[n].name + ": " + BallStats.balls[n].description;
        ballPrice.text = BallStats.balls[n].price.ToString();
        ballImage.sprite = ballList.spriteList[n];
        ParticleController.instance.SetColor(BallStats.balls[n].startColor, BallStats.balls[n].endColor);
        Turn(true);
    }

    public void Buy() {
        Turn(false);
    }
}
