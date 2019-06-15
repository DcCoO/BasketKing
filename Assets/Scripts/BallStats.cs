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
        new BallStats("Classic", "The classic, nothing special about it.", 0, new Color().Hex("b54417", 1), new Color().Hex("b54417", 0.4f), 20, 5, 1, 1, 0.6f),
        new BallStats("Golden", "Heavy but can bounce.", 0, new Color().Hex("cb2b2b", 1), new Color().Hex("be973c", 0.4f), 20, 5, 1, 1, 0.6f),
        new BallStats("Coral", "Light ball with good spin.", 0, new Color().Hex("be973c", 1), new Color().Hex("cb2b2b", 0.4f), 20, 5, 1, 1, 0.6f),
        new BallStats("Melon", "It can go fast but won't rotate that much.", 0, new Color().Hex("b54417", 1), new Color().Hex("b54417", 0.4f), 20, 5, 1, 1, 0.6f),
        new BallStats("Shield", "Perfect bounce, no spin at all.", 0, new Color().Hex("cb2b2b", 1), new Color().Hex("be973c", 0.4f), 20, 5, 1, 1, 0.6f),
        new BallStats("Magnet", "This dude won't bounce.", 0, new Color().Hex("be973c", 1), new Color().Hex("cb2b2b", 0.4f), 20, 5, 1, 1, 0.6f),
        new BallStats("Rainbow", "Good speed and spin.", 0, new Color().Hex("be973c", 1), new Color().Hex("cb2b2b", 0.4f), 20, 5, 1, 1, 0.6f),
        new BallStats("Indigo", "Imported from Mars.", 0, new Color().Hex("be973c", 1), new Color().Hex("cb2b2b", 0.4f), 20, 5, 1, 1, 0.6f),
        new BallStats("Inter", "Improved classic: fast, heavy and can rotate.", 0, new Color().Hex("b54417", 1), new Color().Hex("b54417", 0.4f), 20, 5, 1, 1, 0.6f),
        new BallStats("Pitaya", "Great spin, small bounce.", 0, new Color().Hex("cb2b2b", 1), new Color().Hex("be973c", 0.4f), 20, 5, 1, 1, 0.6f),
        new BallStats("Tensai", "Super fast and super bouncy.", 0, new Color().Hex("be973c", 1), new Color().Hex("cb2b2b", 0.4f), 20, 5, 1, 1, 0.6f),
        new BallStats("Yoyo", "Imported from Mars, it rotates a lot.", 0, new Color().Hex("b54417", 1), new Color().Hex("b54417", 0.4f), 20, 5, 1, 1, 0.6f),
        new BallStats("Feather", "Lightest ball with perfect bounce.", 0, new Color().Hex("cb2b2b", 1), new Color().Hex("be973c", 0.4f), 20, 5, 1, 1, 0.6f),
        new BallStats("Wheel", "Rotates as hell.", 0, new Color().Hex("be973c", 1), new Color().Hex("cb2b2b", 0.4f), 20, 5, 1, 1, 0.6f),
        new BallStats("Iron", "He won't rotate and doesn't know gravity.", 0, new Color().Hex("be973c", 1), new Color().Hex("cb2b2b", 0.4f), 20, 5, 1, 1, 0.6f),
        new BallStats("Enlight", "???", 0, new Color().Hex("be973c", 1), new Color().Hex("cb2b2b", 0.4f), 20, 5, 1, 1, 0.6f),
    };

}
