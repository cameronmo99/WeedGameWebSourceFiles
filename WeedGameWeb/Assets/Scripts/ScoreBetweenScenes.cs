using UnityEngine;
using System.Collections;

public class ScoreBetweenScenes : MonoBehaviour {

    public static int highScore;
    //Used to contain high score

    void Awake()
    {
        DontDestroyOnLoad(this);
        //Do not destroy on load
    }

    void Update()
    {
        highScore = PlayerPrefs.GetInt("highScore", highScore);
        //Set static variable to the player prefs highscore
    }
}
