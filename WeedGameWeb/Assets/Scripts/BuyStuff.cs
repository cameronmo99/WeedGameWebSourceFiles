using UnityEngine;
using System.Collections;

public class BuyStuff : MonoBehaviour
{
    public enum States
    {
        normal,
        red,
        blue,
        purple
    }
    //Colors that the player can access

    public static States currentState;
    //Used to track current state of player

    public bool redPressed = false;
    public bool normalPressed = false;
    public bool bluePressed = false;
    public bool purplePressed = false;
    public bool redBought = false;
    public bool blueBought = false;
    public bool purpleBought = false;
    //Bools used to track which states are active, bought and have been pressed

    public int redPrice = 30;
    public int bluePrice = 40;
    public int purplePrice = 50;

    public string current = currentState.ToString();
    //Used in inspector to track current state

    void Awake()
    {
        DontDestroyOnLoad(this);
        //Do not destroy this on load
    }

    void Start()
    {
        currentState = States.normal;
        //Set current state to normal at the start
    }

    public void SetStateNormal()
    {
        currentState = States.normal;
        //used for button to set the state to normal
    }

    public void SetStateRed()
    {
        if(redPressed == false)
        {
            if (CoinsBetweenScenes.coins >= redPrice)
            {
                if(redBought == false)
                {
                    CoinsBetweenScenes.coins = CoinsBetweenScenes.coins - redPrice;
                    currentState = States.red;
                    redPressed = true;
                    bluePressed = false;
                    purplePressed = false;
                    normalPressed = false;
                    redBought = true;
                }
                //If red has not been pressed, red has not been bought,
                //and coins are sufficient, minus the coins from the static coin variable and set current state to red, then disable other pressed bools
                
                else if(redBought == true)
                {
                    currentState = States.red;
                    redPressed = true;
                    bluePressed = false;
                    purplePressed = false;
                    normalPressed = false;
                }
                //if red has been bought, do not minus coins, just set the state and set the pressed bools
            }
        }
    }

    public void SetStateBlue()
    {
        if(bluePressed == false)
        {
            if(CoinsBetweenScenes.coins >= bluePrice)
            {
                if (blueBought == false)
                {
                    CoinsBetweenScenes.coins = CoinsBetweenScenes.coins - bluePrice;
                    currentState = States.blue;
                    redPressed = false;
                    bluePressed = true;
                    purplePressed = false;
                    normalPressed = false;
                    blueBought = true;
                }
                //If blue has not been pressed, blue has not been bought,
                //and coins are sufficient, minus the coins from the static coin variable and set current state to blue, then disable other pressed bools

                else if (blueBought == true)
                {
                    currentState = States.blue;
                    redPressed = false;
                    bluePressed = true;
                    purplePressed = false;
                    normalPressed = false;
                }
                //if blue has been bought, do not minus coins, just set state and set pressed bools
            }
        }
    }

    public void SetStatePurple()
    {
        if(purplePressed == false)
        {
            if(CoinsBetweenScenes.coins >= purplePrice)
            {
                if(purpleBought == false)
                {
                    CoinsBetweenScenes.coins = CoinsBetweenScenes.coins - purplePrice;
                    currentState = States.purple;
                    redPressed = false;
                    bluePressed = false;
                    normalPressed = false;
                    purplePressed = true;
                    purpleBought = true;
                }
                //If purple has not been pressed, purple has not been bought,
                //and coins are sufficient, minus the coins from the static coin variable and set current state to purple, then disable other pressed bools

                else if (purpleBought == true)
                {
                    currentState = States.purple;
                    redPressed = false;
                    bluePressed = false;
                    purplePressed = true;
                    normalPressed = false;
                }
                //If purple has been bought, do not minus coins, just stet the state and set the pressed bools
            }
        }
    }
}
