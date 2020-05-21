using UnityEngine;
using System.Collections;

public class Achievements : MonoBehaviour {

    public GameObject Achieve30;
    public GameObject Achieve40;
    public GameObject Achieve50;
    public GameObject Achieve60;

    public int _30achieve = 30;
    public int _40achieve = 40;
    public int _50achieve = 50;
    public int _60achieve = 60;

    void Update()
    {
        if(CoinsBetweenScenes.coins >= _30achieve)
        {
            Achieve30.SetActive(true);
        }

        if(CoinsBetweenScenes.coins >= _40achieve)
        {
            Achieve40.SetActive(true);
        }

        if (CoinsBetweenScenes.coins >= _50achieve)
        {
            Achieve50.SetActive(true);
        }

        if (CoinsBetweenScenes.coins >= _60achieve)
        {
            Achieve60.SetActive(true);
        }
    }
}
