using UnityEngine;
using System.Collections;
using System;

public class NeighboursProvider : IObjectProvider
{
    public override int Count()
    {
        return transform.parent.childCount;
    }

    public override GameObject Get(int at)
    {
        return transform.parent.GetChild(at).gameObject;
    }
}
