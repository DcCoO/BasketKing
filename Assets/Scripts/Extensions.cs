using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Extensions {

	public static Color Hex(this Color c, string hex, float alpha) {
        c.r = (float)System.Convert.ToInt32(hex.Substring(0, 2), 16) / 255f;
        c.g = (float)System.Convert.ToInt32(hex.Substring(2, 2), 16) / 255f;
        c.b = (float)System.Convert.ToInt32(hex.Substring(4, 2), 16) / 255f;
        c.a = alpha;
        return c;
    }
}
