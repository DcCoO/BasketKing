﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
    public ObstacleType type;
}

public enum ObstacleType {
    NORMAL,
    INVERT_SPIN,
    JUMP
}
