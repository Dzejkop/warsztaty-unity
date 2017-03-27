using UnityEngine;
using System.Collections.Generic;

public class Observable {

    private List<IObserver> _observers = new List<IObserver>();

    public void Subscribe(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Unsubscribe(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Call()
    {
        foreach (IObserver o in _observers)
        {
            o.Call();
        }
    }
}
