using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class MenuScores : MonoBehaviour {

    public Text text;
    //Access the coin text

    public Text text2;
    //Access the highscore text

	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
            //Load menu scene if the player presses escape
        }

        text.text = "Coins: " + CoinsBetweenScenes.coins.ToString();
        text2.text = "HighScore: " + ScoreBetweenScenes.highScore.ToString();
        //Set the text
	}
}
