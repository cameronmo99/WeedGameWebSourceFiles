using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AchievementPopup : MonoBehaviour {

    public GameObject AchieveUI;
    public Text AchieveText;

    public void Update()
    {
        if (CoinsBetweenScenes.coins == 30)
        {
            AchieveText.text = "You got the 30 Coin Achievment";
        }

        if (CoinsBetweenScenes.coins == 40)
        {
            AchieveText.text = "You got the 40 Coin Achievment";
        }

        if (CoinsBetweenScenes.coins == 50)
        {
            AchieveText.text = "You got the 50 Coin Achievment";
        }

        if (CoinsBetweenScenes.coins == 60)
        {
            AchieveText.text = "You got the 60 Coin Achievment";
        }
    }
}
