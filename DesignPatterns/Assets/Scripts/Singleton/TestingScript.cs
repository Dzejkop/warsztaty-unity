using UnityEngine;
using System.Collections;

public class TestingScript : MonoBehaviour {

    public enum Mode
    {
        VerySimple,
        Simple,
        Singleton
    }

    public Mode _mode;

    void Start()
    {
        if (_mode == Mode.VerySimple)
        {
            SingletonVerySimple.instance.Hello();
        }

        if (_mode == Mode.Simple)
        {
            SingletonSimple.instance.Hello();
        }

        if (_mode == Mode.Singleton)
        {
            GameMaster.instance.Hello();
        }
    }
}
