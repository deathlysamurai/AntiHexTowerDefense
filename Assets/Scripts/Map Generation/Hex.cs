using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hex
{
    // X + Z + S = 0
    readonly int X;
    readonly int Z;

    float WIDTH_MULTIPLIER = Mathf.Sqrt(3) / 2;
    float height;

    public Hex(float hexHeight)
    {
        this.height = hexHeight;
    }

    public Hex(int x, int z, float hexHeight)
    {
        this.X = x;
        this.Z = z;

        this.height = hexHeight;
    }

    public float GetWidth()
    {
        return  WIDTH_MULTIPLIER * height;
    }

    public Vector3 Position()
    {
        float width = GetWidth();

        float verticalSpacing = height * .75f;
        float horizontalSpacing = width;

        float horizontalPosition = this.X * horizontalSpacing;

        if (this.Z % 2 == 1)
        {
            horizontalPosition += horizontalSpacing / 2f;
        }

        return new Vector3(horizontalPosition, 0, verticalSpacing * this.Z);
    }
}
