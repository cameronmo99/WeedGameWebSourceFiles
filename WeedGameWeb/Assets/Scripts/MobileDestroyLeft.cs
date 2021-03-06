﻿using UnityEngine;
using System.Collections;

public class MobileDestroyLeft : MonoBehaviour
{

    public int highLife = 3;
    public int mediumLife = 2;
    public int lowLife = 1;

    public int highPress;
    public int lowPress;
    public int mediumPress;

    //Detects when an enemy enters and stays in the collider
    public void OnTriggerStay(Collider other)
    {
        //Checks the Enemy Tag
        if (other.gameObject.CompareTag("Enemy High"))
        {
            highPress++;

            //If the enemy losses the set amount of lives
            if (highLife <= highPress)
            {
                //The enemy is destroyed
                Destroy(other.gameObject);
                //Amount of presses is reset
                highPress = 0;
            }
        }

        //Checks the Enemy Tag
        if (other.gameObject.CompareTag("Enemy Medium"))
        {
            mediumPress++;
            //If the enemy losses the set amount of lives
            if (mediumLife <= mediumPress)
            {
                //The enemy is destroyed
                Destroy(other.gameObject);
                //Amount of presses is reset
                mediumPress = 0;
            }
        }
        //Checks the Enemy Tag
        if (other.gameObject.CompareTag("Enemy Low"))
        {

            {
                lowPress++;

                //If the enemy losses the set amount of lives
                if (lowLife <= lowPress)
                {
                    //The enemy is destroyed
                    Destroy(other.gameObject);
                    //Amount of presses is reset
                    lowPress = 0;
                }
            }
        }
    }
}
