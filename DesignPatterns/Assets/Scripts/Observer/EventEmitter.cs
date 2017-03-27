using UnityEngine;
using System.Collections;
using System;

public class EventEmitter : MonoBehaviour {

    public static Observable onKeyDown = new Observable();

    public KeyCode _keyCode;

    void Update()
    {
        if (Input.GetKeyDown(_keyCode))
            onKeyDown.Call();
    }
}
