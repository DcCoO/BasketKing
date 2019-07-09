using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStats {

    public string name, description;
    public int price;
    public Color startColor, endColor;
    public int maxSpin, maxSpeed;
    public float gravityScale, mass, bounciness;

    public BallStats(string name, string description, int price, Color startColor, Color endColor, int maxSpin, int maxSpeed, float gravityScale, float mass, float bounciness) {
        this.name = name;
        this.description = description;
        this.price = price;
        this.startColor = startColor;
        this.endColor = endColor;
        this.maxSpin = maxSpin;
        this.maxSpeed = maxSpeed;
        this.gravityScale = gravityScale;
        this.mass = mass;
        this.bounciness = bounciness;
    }

    //TODO: balancear atributos, cor ja foi ate a 3
    public static BallStats[] balls = {
        new BallStats("Classic", "The classic, nothing special about it.", 0, new Color().Hex("B54417", 1), new Color().Hex("B54417", 0), 30, 7, 1, 1, 0.6f),
        new BallStats("Golden", "Heavy but can bounce.", 0, new Color().Hex("BD963E", 1), new Color().Hex("CB2B2B", 0), 20, 5, 1, 1, 0.6f),
        new BallStats("Coral", "Light ball with good spin.", 0, new Color().Hex("C92D2D", 1), new Color().Hex("EEDDDD", 0), 20, 5, 1, 1, 0.6f),
        new BallStats("Melon", "It can go fast but won't rotate that much.", 0, new Color().Hex("37946E", 1), new Color().Hex("DF7126", 0), 20, 5, 1, 1, 0.6f),
        new BallStats("Shield", "Perfect bounce, no spin at all.", 0, new Color().Hex("FFFFFF", 1), new Color().Hex("922A20", 0), 20, 5, 1, 1, 0.6f),
        new BallStats("Magnet", "This dude won't bounce.", 0, new Color().Hex("1EA8B9", 1), new Color().Hex("1EA8B9", 0), 20, 5, 1, 1, 0.6f),
        new BallStats("Rainbow", "Good speed and spin.", 0, new Color().Hex("3447BA", 1), new Color().Hex("E51C1C", 0), 20, 5, 1, 1, 0.6f),
        new BallStats("Indigo", "Imported from Mars.", 0, new Color().Hex("2F4DBE", 1), new Color().Hex("DF7126", 0), 20, 5, 1, 1, 0.6f),
        new BallStats("Inter", "Improved classic: fast, heavy and can rotate.", 0, new Color().Hex("C5BD1A", 1), new Color().Hex("FFFFFF", 0), 20, 5, 1, 1, 0.6f),
        new BallStats("Pitaya", "Great spin, small bounce.", 0, new Color().Hex("FF0000", 1), new Color().Hex("FFFFFF", 0), 20, 5, 1, 1, 0.6f),
        new BallStats("Tensai", "Super fast and super bouncy.", 0, new Color().Hex("FF0000", 1), new Color().Hex("FF0000", 0), 20, 5, 1, 1, 0.6f),
        new BallStats("Yoyo", "Imported from Mars, it rotates a lot.", 0, new Color().Hex("388623", 1), new Color().Hex("B69829", 0), 20, 5, 1, 1, 0.6f),
        new BallStats("Feather", "Lightest ball with perfect bounce.", 0, new Color().Hex("99E550", 1), new Color().Hex("FFFFFF", 0), 20, 5, 1, 1, 0.6f),
        new BallStats("Wheel", "Rotates as hell.", 0, new Color().Hex("FFE153", 1), new Color().Hex("AB3434", 0), 20, 5, 1, 1, 0.6f),
        new BallStats("Iron", "He won't rotate and doesn't know gravity.", 0, new Color().Hex("5D83A1", 1), new Color().Hex("5D83A1", 0), 20, 5, 1, 1, 0.6f),
        new BallStats("Enlight", "???", 0, new Color().Hex("BBDDC8", 1), new Color().Hex("60933E", 0), 20, 5, 1, 1, 0.6f),
    };

    

}
