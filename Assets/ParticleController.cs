using UnityEngine;

public class ParticleController : MonoBehaviour {

    public static ParticleController instance;
    public ParticleSystem ps;

    private void Awake() {
        instance = this;
        print("ENTROU");
    }
    
    void Start () {
        float ratio = ((float)Screen.width / 600f);

        //main
        var main = ps.main;
        //main.startLifetime = ratio * main.startLifetime.constant;
        main.startSize = ratio * main.startSize.constant;

        //emission
        var emission = ps.emission;
        emission.rateOverTime = ratio * emission.rateOverTime.constant;

        //shape
        var shape = ps.shape;
        shape.radius *= ratio;
        //shape.arcSpeed = ratio;

        //noise
        var noise = ps.noise;
        noise.strength = ratio * noise.strength.constant;
	}
	
	// Update is called once per frame
	public void SetColor (Color start, Color end) {
        var color = ps.colorOverLifetime.color;

        Gradient grad = new Gradient();

        // Populate the color keys at the relative time 0 and 1 (0 and 100%)
        GradientColorKey[] colorKey = new GradientColorKey[2];
        colorKey[0].color = start;
        colorKey[0].time = 0.0f;
        colorKey[1].color = end;
        colorKey[1].time = 1.0f;

        // Populate the alpha  keys at relative time 0 and 1  (0 and 100%)
        GradientAlphaKey[] alphaKey = new GradientAlphaKey[2];
        alphaKey[0].alpha = 1.0f;
        alphaKey[0].time = 0.0f;
        alphaKey[1].alpha = 0.0f;
        alphaKey[1].time = 1.0f;

        grad.SetKeys(colorKey, alphaKey);

        color.gradient = grad; 
    }
}
