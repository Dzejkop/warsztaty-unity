using UnityEngine;
using System.Collections.Generic;

public class ObjectConsumer : MonoBehaviour {

    public IObjectProvider _provider;

    int _iterator = 0;

    void Update()
    {
        if (_provider == null)
            return;

        if (_iterator >= _provider.Count())
            _iterator = 0;

        GameObject obj = _provider.Get(_iterator);
        Debug.Log("Object at " + _iterator.ToString() + " is named: " + obj.name);

        _iterator++;
    }
}
