using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimation : MonoBehaviour
{
    public Animation Run;
    public Animation Jump;
    public GameObject Player;

    public void Start()
    {
        Player.GetComponent<Animation>().Play("Root│Jump");
    }

    public void RunAnimation()
    {
        Player.GetComponent<Animation>().Play("Root│Run");

    }
}
