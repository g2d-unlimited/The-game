using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hex
{
    public readonly int Q; //Column
    public readonly int R; //Row
    public readonly int S;
    static readonly float WIDTH_MULT = Mathf.Sqrt(3) / 2;
    public Hex(int q, int r)
    {
        this.Q = q;
        this.R = r;
        this.S = (-q + r);
    }
    public Vector3 Position()
    {
        float radius = 1f;
        float height = radius * 2;
        float width = WIDTH_MULT * height;
        float horizontal = width;
        float verical = height * 3 / 4;
        return new Vector3(
            horizontal * (Q + R / 2f),
            verical * R,
            0);
    }
}
