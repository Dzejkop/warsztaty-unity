using UnityEngine;
using System.Collections;
using System;

public class Tester : MonoBehaviour, IObserver {

    public string _message;

    public void Call()
    {
        Debug.Log(_message);
    }

    void Start ()
    {
        EventEmitter.onKeyDown.Subscribe(this);
	}

}
