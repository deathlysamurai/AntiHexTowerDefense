using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utilities
{
    public static Vector3Int GetXZFromName(string name)
    {
        int x = int.Parse(name.Substring(0, name.IndexOf(',')));
        int z = int.Parse(name.Substring(name.IndexOf(',') + 1));
        return new Vector3Int(x, 0, z);
    }
}
