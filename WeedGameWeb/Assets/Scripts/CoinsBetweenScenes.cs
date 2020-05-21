using UnityEngine;
using System.Collections;

public class CoinsBetweenScenes : MonoBehaviour {

    public static int coins;
    //Used to track total amount of coins

    void Awake()
    {
        DontDestroyOnLoad(this);
        //Do not destroy on load
    }
}
