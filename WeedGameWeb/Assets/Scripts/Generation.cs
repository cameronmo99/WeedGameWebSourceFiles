using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Generation : MonoBehaviour
{
    public GameObject[] PrefabArray = new GameObject[15];
    //Create GameObject array to hold prefabs

    public Transform[] CoinSpawnTransformArray = new Transform[9];
    //Create Transform array to hold coin spawns
    public Transform[] LaneSpawnTransformArray = new Transform[9];
    //Create Transform array to hold lane spawns
    public Transform[] EnvironmentSpawnTransformArray = new Transform[6];
    //Create Transform array to hold environment spawns

    public float timer;
    //Declare public float for timer
    public float distanceTrack;
    //Declare public float for tracking distance

    public Text score;
    //Declare public text to contain distance score
    public Text coinScore;
    //Declare public text to contain the coin score
    public Text staticCoins;

    public PlayerMove DataGrab;
    //Grab information from the player move script

    private int coinsPicked;
    //Declare private int to contain amount of coins picked up in current game session


    void Start()
    {
        score.GetComponent<Text>();
        //Grab text component

        FirstSpawns();
        //Spawn first lanes
    }

    void Update()
    {
        coinsPicked = DataGrab.coinsPickedUp;
        //Set coins picked to data grabbed from the player move script

        score.text = "Score: " + TrackDistance();
        //Track distance and set score text to the tracked distance

        GenerateTimed();
        //Generate game objects on timer

        SpawnCoins();
        //Generate the coins

        TrackCoins();
        //Track the coins picked up
    }

    void FirstSpawns()
    {
        for (int i = 0; i < 9; i++)
        {
            Instantiate(PrefabArray[0], LaneSpawnTransformArray[i].position, Quaternion.identity);
            //Instantiate 9 lines with a for loop
        }
    }
    //Function to be used for intial generation of 9 lanes

    void GenerateTimed()
    {
        timer = timer + Time.deltaTime;
        //Update the timer using deltaTime

        int newRandom;
        int newRandom2;
        int newRandom3;
        int newRandom4;
        int newRandom5;
        int newRandom6;
        int newRandom7;
        int newRandom8;
        int newRandom9;
        int newRandom10;
        int newRandom11;
        int newRandom12;
        //Declare 10 integers to be used to hold random numbers


        if (distanceTrack < 10)
        {
            if (timer > 1.5f)
            {
                newRandom2 = Random.Range(1, 5);
                switch (newRandom2)
                {
                    case 1:
                        Instantiate(PrefabArray[3], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[2], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Middle environment spawning done here according to random number 

                newRandom5 = Random.Range(1, 5);
                switch (newRandom5)
                {
                    case 1:
                        Instantiate(PrefabArray[3], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[2], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //High environment spawning done here according to random number

                newRandom6 = Random.Range(1, 5);
                switch (newRandom6)
                {
                    case 1:
                        Instantiate(PrefabArray[3], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[2], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Low environmnet spawning done here according to random number

                Instantiate(PrefabArray[0], LaneSpawnTransformArray[0].position, Quaternion.identity);
                Instantiate(PrefabArray[0], LaneSpawnTransformArray[1].position, Quaternion.identity);
                Instantiate(PrefabArray[0], LaneSpawnTransformArray[2].position, Quaternion.identity);
                //Instantiate normal lane preset in middle 

                Instantiate(PrefabArray[0], LaneSpawnTransformArray[3].position, Quaternion.identity);
                Instantiate(PrefabArray[0], LaneSpawnTransformArray[4].position, Quaternion.identity);
                Instantiate(PrefabArray[0], LaneSpawnTransformArray[5].position, Quaternion.identity);
                //Instantiate normal lane preset in high

                Instantiate(PrefabArray[0], LaneSpawnTransformArray[6].position, Quaternion.identity);
                Instantiate(PrefabArray[0], LaneSpawnTransformArray[7].position, Quaternion.identity);
                Instantiate(PrefabArray[0], LaneSpawnTransformArray[8].position, Quaternion.identity);
                //Instantiate normal lane preset in low

                timer = 0f;
                //Reset the timer
            }
        }

        else if (distanceTrack > 10 && distanceTrack < 20)
        {
            if (timer > 1.5f)
            {
                newRandom2 = Random.Range(1, 5);
                switch (newRandom2)
                {
                    case 1:
                        Instantiate(PrefabArray[3], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[2], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Middle environment spawning done here according to random number

                newRandom5 = Random.Range(1, 5);
                switch (newRandom5)
                {
                    case 1:
                        Instantiate(PrefabArray[3], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[2], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //High environment spawning done here according to random number

                newRandom6 = Random.Range(1, 5);
                switch (newRandom6)
                {
                    case 1:
                        Instantiate(PrefabArray[3], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[2], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Low environment spawning done here according to random number

                newRandom = Random.Range(1, 9);
                switch (newRandom)
                {
                    case 1:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Middle lane spawning done here according to random number, contains different lane presets

                newRandom3 = Random.Range(1, 9);
                switch (newRandom3)
                {
                    case 1:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //High lane spawning done here according to random number, contains different lane presets

                newRandom4 = Random.Range(1, 9);
                switch (newRandom4)
                {
                    case 1:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Low lane spawning done here according to random number, contains different lane presets

                timer = 0f;
                //Reset timer
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------//

        else if (distanceTrack > 20 && distanceTrack < 30)
        {
            if (timer > 1.5f)
            {
                newRandom2 = Random.Range(1, 5);
                switch (newRandom2)
                {
                    case 1:
                        Instantiate(PrefabArray[3], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[2], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Middle environment spawning done here according to random number

                newRandom5 = Random.Range(1, 5);
                switch (newRandom5)
                {
                    case 1:
                        Instantiate(PrefabArray[3], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[2], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //High environment spawning done here according to random number

                newRandom6 = Random.Range(1, 5);
                switch (newRandom6)
                {
                    case 1:
                        Instantiate(PrefabArray[3], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[2], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Low environment spawning done here according to random number

                newRandom = Random.Range(1, 9);
                switch (newRandom)
                {
                    case 1:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Middle lane spawning done here according to random number, contains different lane presets

                newRandom3 = Random.Range(1, 9);
                switch (newRandom3)
                {
                    case 1:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //High lane spawning done here according to random number, contains different lane presets

                newRandom4 = Random.Range(1, 9);
                switch (newRandom4)
                {
                    case 1:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Low lane spawning done here according to random number, contains different lane presets

                newRandom7 = Random.Range(1, 40);
                switch (newRandom7)
                {
                    case 1:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 9:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 10:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 11:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 12:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 13:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 14:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 15:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 16:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 17:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 18:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Insantiate obstacles for the middle set of lanes

                newRandom11 = Random.Range(1, 40);
                switch (newRandom11)
                {
                    case 1:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 9:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 10:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 11:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 12:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 13:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 14:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 15:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 16:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 17:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 18:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Insantiate obstacles for the High set of lanes

                newRandom12 = Random.Range(1, 40);
                switch (newRandom12)
                {
                    case 1:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 9:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 10:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 11:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 12:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 13:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 14:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 15:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 16:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 17:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 18:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Instantiate obstacles for low set of lanes

                timer = 0f;
                //Reset timer
            }
        }

        else if (distanceTrack > 30 && distanceTrack < 40)
        {
            if (timer > 1.5f)
            {
                newRandom2 = Random.Range(1, 5);
                switch (newRandom2)
                {
                    case 1:
                        Instantiate(PrefabArray[3], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[2], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Middle environment spawning done here according to random number

                newRandom5 = Random.Range(1, 5);
                switch (newRandom5)
                {
                    case 1:
                        Instantiate(PrefabArray[3], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[2], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //High environment spawning done here according to random number

                newRandom6 = Random.Range(1, 5);
                switch (newRandom6)
                {
                    case 1:
                        Instantiate(PrefabArray[3], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[2], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Low environment spawning done here according to random number

                newRandom = Random.Range(1, 9);
                switch (newRandom)
                {
                    case 1:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Middle lane spawning done here according to random number, contains different lane presets

                newRandom3 = Random.Range(1, 9);
                switch (newRandom3)
                {
                    case 1:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //High lane spawning done here according to random number, contains different lane presets

                newRandom4 = Random.Range(1, 9);
                switch (newRandom4)
                {
                    case 1:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Low lane spawning done here according to random number, contains different lane presets

                newRandom8 = Random.Range(1, 40);
                switch (newRandom8)
                {
                    case 1:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 9:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Instantiate enemies for middle set of lanes

                newRandom9 = Random.Range(1, 40);
                switch (newRandom9)
                {
                    case 1:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 9:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Instantiate enemies for high set of lanes

                newRandom10 = Random.Range(1, 40);
                switch (newRandom10)
                {
                    case 1:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 9:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Instantiate enemies for low set of lanes

                timer = 0f;
            }
        }

        else if (distanceTrack > 40 && distanceTrack < 50)
        {
            if (timer > 1.5f)
            {
                newRandom2 = Random.Range(1, 5);
                switch (newRandom2)
                {
                    case 1:
                        Instantiate(PrefabArray[3], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[2], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Middle environment spawning done here according to random number

                newRandom5 = Random.Range(1, 5);
                switch (newRandom5)
                {
                    case 1:
                        Instantiate(PrefabArray[3], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[2], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //High environment spawning done here according to random number

                newRandom6 = Random.Range(1, 5);
                switch (newRandom6)
                {
                    case 1:
                        Instantiate(PrefabArray[3], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[2], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Low environment spawning done here according to random number

                newRandom = Random.Range(1, 9);
                switch (newRandom)
                {
                    case 1:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Middle lane spawning done here according to random number, contains different lane presets

                newRandom3 = Random.Range(1, 9);
                switch (newRandom3)
                {
                    case 1:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //High lane spawning done here according to random number, contains different lane presets

                newRandom4 = Random.Range(1, 9);
                switch (newRandom4)
                {
                    case 1:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Low lane spawning done here according to random number, contains different lane presets

                newRandom8 = Random.Range(1, 40);
                switch (newRandom8)
                {
                    case 1:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Instantiate launch pads for middle set of lanes

                newRandom9 = Random.Range(1, 40);
                switch (newRandom9)
                {
                    case 1:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Instantiate launch for high set of lanes

                newRandom10 = Random.Range(1, 40);
                switch (newRandom10)
                {
                    case 1:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Instantiate launch pads for low set of lanes

                timer = 0f;
            }
        }

        else if (distanceTrack > 50 && distanceTrack < 70)
        {
            if (timer > 1.5f)
            {
                newRandom2 = Random.Range(1, 5);
                switch (newRandom2)
                {
                    case 1:
                        Instantiate(PrefabArray[3], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[2], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Middle environment spawning done here according to random number

                newRandom5 = Random.Range(1, 5);
                switch (newRandom5)
                {
                    case 1:
                        Instantiate(PrefabArray[3], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[2], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //High environment spawning done here according to random number

                newRandom6 = Random.Range(1, 5);
                switch (newRandom6)
                {
                    case 1:
                        Instantiate(PrefabArray[3], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[2], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Low environment spawning done here according to random number

                newRandom = Random.Range(1, 9);
                switch (newRandom)
                {
                    case 1:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Middle lane spawning done here according to random number, contains different lane presets

                newRandom3 = Random.Range(1, 9);
                switch (newRandom3)
                {
                    case 1:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //High lane spawning done here according to random number, contains different lane presets

                newRandom4 = Random.Range(1, 9);
                switch (newRandom4)
                {
                    case 1:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Low lane spawning done here according to random number, contains different lane presets

                newRandom8 = Random.Range(1, 40);
                switch (newRandom8)
                {
                    case 1:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Instantiate launch pads for middle set of lanes

                newRandom9 = Random.Range(1, 40);
                switch (newRandom9)
                {
                    case 1:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Instantiate launch for high set of lanes

                newRandom10 = Random.Range(1, 40);
                switch (newRandom10)
                {
                    case 1:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Instantiate launch pads for low set of lanes

                newRandom8 = Random.Range(1, 40);
                switch (newRandom8)
                {
                    case 1:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 9:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Instantiate enemies for middle set of lanes

                newRandom9 = Random.Range(1, 40);
                switch (newRandom9)
                {
                    case 1:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 9:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Instantiate enemies for high set of lanes

                newRandom10 = Random.Range(1, 40);
                switch (newRandom10)
                {
                    case 1:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 9:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Instantiate enemies for low set of lanes

                timer = 0f;
            }
        }

        else if (distanceTrack > 70 && distanceTrack < 90)
        {
            if (timer > 1.5f)
            {
                newRandom2 = Random.Range(1, 5);
                switch (newRandom2)
                {
                    case 1:
                        Instantiate(PrefabArray[3], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[2], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Middle environment spawning done here according to random number

                newRandom5 = Random.Range(1, 5);
                switch (newRandom5)
                {
                    case 1:
                        Instantiate(PrefabArray[3], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[2], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //High environment spawning done here according to random number

                newRandom6 = Random.Range(1, 5);
                switch (newRandom6)
                {
                    case 1:
                        Instantiate(PrefabArray[3], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[2], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Low environment spawning done here according to random number

                newRandom = Random.Range(1, 9);
                switch (newRandom)
                {
                    case 1:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Middle lane spawning done here according to random number, contains different lane presets

                newRandom3 = Random.Range(1, 9);
                switch (newRandom3)
                {
                    case 1:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //High lane spawning done here according to random number, contains different lane presets

                newRandom4 = Random.Range(1, 9);
                switch (newRandom4)
                {
                    case 1:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Low lane spawning done here according to random number, contains different lane presets

                newRandom8 = Random.Range(1, 40);
                switch (newRandom8)
                {
                    case 1:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Instantiate launch pads for middle set of lanes

                newRandom9 = Random.Range(1, 40);
                switch (newRandom9)
                {
                    case 1:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Instantiate launch for high set of lanes

                newRandom10 = Random.Range(1, 40);
                switch (newRandom10)
                {
                    case 1:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Instantiate launch pads for low set of lanes

                newRandom8 = Random.Range(1, 40);
                switch (newRandom8)
                {
                    case 1:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 9:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Instantiate enemies for middle set of lanes

                newRandom9 = Random.Range(1, 40);
                switch (newRandom9)
                {
                    case 1:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 9:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Instantiate enemies for high set of lanes

                newRandom10 = Random.Range(1, 40);
                switch (newRandom10)
                {
                    case 1:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 9:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Instantiate enemies for low set of lanes

                newRandom7 = Random.Range(1, 40);
                switch (newRandom7)
                {
                    case 1:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 9:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 10:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 11:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 12:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 13:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 14:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 15:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 16:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 17:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 18:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Insantiate obstacles for the middle set of lanes

                newRandom11 = Random.Range(1, 40);
                switch (newRandom11)
                {
                    case 1:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 9:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 10:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 11:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 12:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 13:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 14:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 15:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 16:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 17:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 18:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Insantiate obstacles for the High set of lanes

                newRandom12 = Random.Range(1, 40);
                switch (newRandom12)
                {
                    case 1:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 9:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 10:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 11:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 12:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 13:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 14:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 15:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 16:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 17:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 18:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Instantiate obstacles for low set of lanes

                timer = 0f;
            }
        }

        else if (distanceTrack > 90 && distanceTrack < 120)
        {
            if (timer > 1.5f)
            {
                newRandom2 = Random.Range(1, 5);
                switch (newRandom2)
                {
                    case 1:
                        Instantiate(PrefabArray[3], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[2], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Middle environment spawning done here according to random number

                newRandom5 = Random.Range(1, 5);
                switch (newRandom5)
                {
                    case 1:
                        Instantiate(PrefabArray[3], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[2], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //High environment spawning done here according to random number

                newRandom6 = Random.Range(1, 5);
                switch (newRandom6)
                {
                    case 1:
                        Instantiate(PrefabArray[3], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[2], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Low environment spawning done here according to random number

                newRandom = Random.Range(1, 9);
                switch (newRandom)
                {
                    case 1:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Middle lane spawning done here according to random number, contains different lane presets

                newRandom3 = Random.Range(1, 9);
                switch (newRandom3)
                {
                    case 1:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //High lane spawning done here according to random number, contains different lane presets

                newRandom4 = Random.Range(1, 9);
                switch (newRandom4)
                {
                    case 1:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Low lane spawning done here according to random number, contains different lane presets

                newRandom8 = Random.Range(1, 40);
                switch (newRandom8)
                {
                    case 1:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Instantiate launch pads for middle set of lanes

                newRandom9 = Random.Range(1, 40);
                switch (newRandom9)
                {
                    case 1:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Instantiate launch for high set of lanes

                newRandom10 = Random.Range(1, 40);
                switch (newRandom10)
                {
                    case 1:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Instantiate launch pads for low set of lanes

                newRandom8 = Random.Range(1, 40);
                switch (newRandom8)
                {
                    case 1:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 9:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 10:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 11:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 12:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 13:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 14:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 15:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 16:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 17:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 18:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Instantiate enemies for middle set of lanes

                newRandom9 = Random.Range(1, 40);
                switch (newRandom9)
                {
                    case 1:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 9:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 10:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 11:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 12:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 13:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 14:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 15:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 16:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 17:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 18:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Instantiate enemies for high set of lanes

                newRandom10 = Random.Range(1, 40);
                switch (newRandom10)
                {
                    case 1:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 9:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 10:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 11:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 12:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 13:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 14:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 15:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 16:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 17:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 18:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Instantiate enemies for low set of lanes

                newRandom7 = Random.Range(1, 40);
                switch (newRandom7)
                {
                    case 1:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 9:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 10:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 11:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 12:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 13:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 14:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 15:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 16:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 17:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 18:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Insantiate obstacles for the middle set of lanes

                newRandom11 = Random.Range(1, 40);
                switch (newRandom11)
                {
                    case 1:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 9:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 10:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 11:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 12:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 13:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 14:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 15:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 16:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 17:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 18:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Insantiate obstacles for the High set of lanes

                newRandom12 = Random.Range(1, 40);
                switch (newRandom12)
                {
                    case 1:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 9:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 10:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 11:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 12:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 13:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 14:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 15:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 16:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 17:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 18:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Instantiate obstacles for low set of lanes

                timer = 0f;
            }
        }

        else if (distanceTrack > 120)
        {
            if (timer > 1.5f)
            {
                newRandom2 = Random.Range(1, 5);
                switch (newRandom2)
                {
                    case 1:
                        Instantiate(PrefabArray[3], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[2], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Middle environment spawning done here according to random number

                newRandom5 = Random.Range(1, 5);
                switch (newRandom5)
                {
                    case 1:
                        Instantiate(PrefabArray[3], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[2], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[2].position, Quaternion.identity);
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //High environment spawning done here according to random number

                newRandom6 = Random.Range(1, 5);
                switch (newRandom6)
                {
                    case 1:
                        Instantiate(PrefabArray[3], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[2], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[5], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[6], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[11], EnvironmentSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Low environment spawning done here according to random number

                newRandom = Random.Range(1, 9);
                switch (newRandom)
                {
                    case 1:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Middle lane spawning done here according to random number, contains different lane presets

                newRandom3 = Random.Range(1, 9);
                switch (newRandom3)
                {
                    case 1:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //High lane spawning done here according to random number, contains different lane presets

                newRandom4 = Random.Range(1, 9);
                switch (newRandom4)
                {
                    case 1:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[0], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[4], LaneSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Low lane spawning done here according to random number, contains different lane presets

                newRandom8 = Random.Range(1, 40);
                switch (newRandom8)
                {
                    case 1:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Instantiate launch pads for middle set of lanes

                newRandom9 = Random.Range(1, 40);
                switch (newRandom9)
                {
                    case 1:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Instantiate launch for high set of lanes

                newRandom10 = Random.Range(1, 40);
                switch (newRandom10)
                {
                    case 1:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[14], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Instantiate launch pads for low set of lanes

                newRandom8 = Random.Range(1, 40);
                switch (newRandom8)
                {
                    case 1:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 9:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 10:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 11:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 12:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 13:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 14:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 15:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 16:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 17:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 18:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 19:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 20:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 21:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 22:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 23:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 24:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 25:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 26:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 27:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Instantiate enemies for middle set of lanes

                newRandom9 = Random.Range(1, 40);
                switch (newRandom9)
                {
                    case 1:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 9:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 10:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 11:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 12:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 13:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 14:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 15:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 16:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 17:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 18:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 19:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 20:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 21:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 22:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 23:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 24:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 25:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 26:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 27:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Instantiate enemies for high set of lanes

                newRandom10 = Random.Range(1, 40);
                switch (newRandom10)
                {
                    case 1:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 9:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 10:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 11:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 12:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 13:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 14:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 15:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 16:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 17:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 18:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 19:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 20:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 21:
                        Instantiate(PrefabArray[8], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 22:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 23:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 24:
                        Instantiate(PrefabArray[9], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 25:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 26:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 27:
                        Instantiate(PrefabArray[10], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Instantiate enemies for low set of lanes

                newRandom7 = Random.Range(1, 40);
                switch (newRandom7)
                {
                    case 1:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 9:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 10:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 11:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        break;
                    case 12:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 13:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 14:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        break;
                    case 15:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[1].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 16:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 17:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    case 18:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[0].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[2].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Insantiate obstacles for the middle set of lanes

                newRandom11 = Random.Range(1, 40);
                switch (newRandom11)
                {
                    case 1:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 9:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 10:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 11:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        break;
                    case 12:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 13:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 14:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        break;
                    case 15:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[4].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 16:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 17:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    case 18:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[3].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[5].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Insantiate obstacles for the High set of lanes

                newRandom12 = Random.Range(1, 40);
                switch (newRandom12)
                {
                    case 1:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 9:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 10:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 11:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        break;
                    case 12:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 13:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 14:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        break;
                    case 15:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[7].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 16:
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[7], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 17:
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[12], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    case 18:
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[6].position, Quaternion.identity);
                        Instantiate(PrefabArray[13], CoinSpawnTransformArray[8].position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                //Instantiate obstacles for low set of lanes

                timer = 0f;
            }
        }
    }


    void SpawnCoins()
    {
        timer = timer + Time.deltaTime;

        int coinRandom;
        int coinRandom2;
        int coinRandom3;

        if (timer > 1.5f)
        {
            coinRandom = Random.Range(1, 9);
            switch (coinRandom)
            {
                case 1:
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[0].position, Quaternion.identity);
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[1].position, Quaternion.identity);
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[2].position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[1].position, Quaternion.identity);
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[2].position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[0].position, Quaternion.identity);
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[1].position, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[0].position, Quaternion.identity);
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[2].position, Quaternion.identity);
                    break;
                case 5:
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[0].position, Quaternion.identity);
                    break;
                case 6:
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[1].position, Quaternion.identity);
                    break;
                case 7:
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[2].position, Quaternion.identity);
                    break;
                case 8:
                    break;
                default:
                    break;
            }

            coinRandom2 = Random.Range(1, 9);
            switch (coinRandom2)
            {
                case 1:
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[3].position, Quaternion.identity);
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[4].position, Quaternion.identity);
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[5].position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[4].position, Quaternion.identity);
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[5].position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[3].position, Quaternion.identity);
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[4].position, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[3].position, Quaternion.identity);
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[5].position, Quaternion.identity);
                    break;
                case 5:
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[3].position, Quaternion.identity);
                    break;
                case 6:
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[4].position, Quaternion.identity);
                    break;
                case 7:
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[5].position, Quaternion.identity);
                    break;
                case 8:
                    break;
                default:
                    break;
            }

            coinRandom3 = Random.Range(1, 9);
            switch (coinRandom3)
            {
                case 1:
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[6].position, Quaternion.identity);
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[7].position, Quaternion.identity);
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[8].position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[7].position, Quaternion.identity);
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[8].position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[6].position, Quaternion.identity);
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[7].position, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[6].position, Quaternion.identity);
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[8].position, Quaternion.identity);
                    break;
                case 5:
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[6].position, Quaternion.identity);
                    break;
                case 6:
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[7].position, Quaternion.identity);
                    break;
                case 7:
                    Instantiate(PrefabArray[1], CoinSpawnTransformArray[8].position, Quaternion.identity);
                    break;
                case 8:
                    break;
                default:
                    break;
            }
        }
    }

    int TrackDistance()
    {
        int DistanceNumber;

        distanceTrack = distanceTrack + Time.deltaTime;
        DistanceNumber = (int)distanceTrack;
        return DistanceNumber;
    }

    void TrackCoins()
    {
        coinScore.text = "Coins: " + coinsPicked.ToString();
        staticCoins.text = "ALL COINS: " + CoinsBetweenScenes.coins.ToString();
    }
}
