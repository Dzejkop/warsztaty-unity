using UnityEngine;
using System.Collections;

public class GameMaster : Singleton<GameMaster> {
    public void Hello()
    {
        Debug.Log("Hello from Game Master");
    }
}
