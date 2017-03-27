using UnityEngine;
using System.Collections;
using System;

public class ChildrenProvider : IObjectProvider
{
    public override int Count()
    {
        return transform.childCount;
    }

    public override GameObject Get(int at)
    {
        return transform.GetChild(at).gameObject;
    }
}
