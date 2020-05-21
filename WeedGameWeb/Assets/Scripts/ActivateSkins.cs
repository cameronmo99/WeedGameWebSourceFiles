using UnityEngine;
using System.Collections;

public class ActivateSkins : MonoBehaviour
{
    public GameObject normalSkin;
    public GameObject redSkin;
    public GameObject blueSkin;
    public GameObject purpleSkin;
    //Create public gameobjects to hold the player skins

    void Update()
    {
        if(BuyStuff.currentState == BuyStuff.States.normal)
        {
            normalSkin.SetActive(true);
            redSkin.SetActive(false);
            blueSkin.SetActive(false);
            purpleSkin.SetActive(false);
            //If the current state is normal, keep normal skin active and disable the rest
        }   

        else if(BuyStuff.currentState == BuyStuff.States.red)
        {
            normalSkin.SetActive(false);
            redSkin.SetActive(true);
            blueSkin.SetActive(false);
            purpleSkin.SetActive(false);
            //If the current state is red, keep red skin active and disable the rest
        }

        else if(BuyStuff.currentState == BuyStuff.States.blue)
        {
            normalSkin.SetActive(false);
            redSkin.SetActive(false);
            blueSkin.SetActive(true);
            purpleSkin.SetActive(false);
            //If the current state is blue, keep blue skin active and disable the rest
        }

        else if(BuyStuff.currentState == BuyStuff.States.purple)
        {
            normalSkin.SetActive(false);
            redSkin.SetActive(false);
            blueSkin.SetActive(false);
            purpleSkin.SetActive(false);
            //If the current state is purple, keep the purple skin active and disable the rest
        }

    }

}
