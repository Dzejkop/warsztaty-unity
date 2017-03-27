using UnityEngine;
using System.Collections;

public abstract class IObjectProvider : MonoBehaviour {
    public abstract int Count();
    public abstract GameObject Get(int at);
}
