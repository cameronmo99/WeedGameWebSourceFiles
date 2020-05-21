using UnityEngine;
using System.Collections;

public class OpenShop : MonoBehaviour {

    //public Canvas shop;
    public GameObject ShopCanvas;
    public GameObject MenuCanvas;
    public GameObject AchievementsCanvas;
    
        public void openshop()
    {
        //Enables the Shop Canvas and Disables the Menu Canvas
        ShopCanvas.SetActive(true);
        MenuCanvas.SetActive(false);

    }

    public void closeshop()
    {
        //Disables the Shop Canvas and Enables the Menu Canvas
        ShopCanvas.SetActive(false);
        MenuCanvas.SetActive(true);
    }

    public void achievementsOpen()
    {
        //Open achievements
        ShopCanvas.SetActive(false);
        MenuCanvas.SetActive(false);
        AchievementsCanvas.SetActive(true);
    }

    public void closeAchievements()
    {
        //close achievements
        MenuCanvas.SetActive(true);
        ShopCanvas.SetActive(false);
        AchievementsCanvas.SetActive(false);
    }
}