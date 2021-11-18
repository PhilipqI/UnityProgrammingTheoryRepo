using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Vector3Extension
{
    public static Vector2 AsVector2(this Vector3 vector3dim)
    {
        return new Vector2(vector3dim.x, vector3dim.y);
    }
}
