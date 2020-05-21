using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changemodel : MonoBehaviour
{
    public Texture Criminal;
    public Texture Cyborg;
    public Texture SkaterM;
    public Texture SkaterF;


    public GameObject Player;
    public Renderer PlayerRenderer;


    public void ChangeModelCriminal()
    {
        PlayerRenderer.material.SetTexture("_MainTex", Criminal);
    }

    public void ChangeModelCyborg()
    {
        PlayerRenderer.material.SetTexture("_MainTex", Cyborg);
    }

    public void ChangeModelSkaterM()
    {
        PlayerRenderer.material.SetTexture("_MainTex", SkaterM);
    }

    public void ChangeModelSkaterF()
    {
        PlayerRenderer.material.SetTexture("_MainTex", SkaterF);
    }
}
