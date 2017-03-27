using UnityEngine;
using System.Collections;

public class SingletonVerySimple : MonoBehaviour {

    private static SingletonVerySimple _instance;

    public static SingletonVerySimple instance
    {
        get
        {
            return _instance;
        }
    }

	void Awake()
    {
        if (_instance == null)
        {
            DontDestroyOnLoad(gameObject);
            _instance = this;
        }
        else if (_instance != this)
        {
            Debug.LogError("There should only ever be one instance of SingletonVerySimple.");
        }
    }

    public void Hello()
    {
        Debug.Log("Hello from a Very Simple Singleton");
    }
}
