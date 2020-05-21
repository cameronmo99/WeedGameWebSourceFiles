using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

    public void startGame ()
    {
        //Loads the Main game scene
        SceneManager.LoadScene(1);
    }
}
