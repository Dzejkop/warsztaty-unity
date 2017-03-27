using UnityEngine;
using System.Collections;

public class SingletonSimple : MonoBehaviour {

    private static SingletonSimple _instance;

    public static SingletonSimple instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<SingletonSimple>();

                if (_instance == null)
                {
                    GameObject obj = new GameObject();
                    _instance = obj.AddComponent<SingletonSimple>();
                    DontDestroyOnLoad(obj);
                }
            }

            
            return _instance;
        }
    }

    public void Hello()
    {
        Debug.Log("Hello from a Simple Singleton");
    }
}
