using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HudController : MonoBehaviour
{
    public GameObject cam;
    LookAt look;

    public static float timeScale = .5f;
    public static float currenTime;


    public void Start()
    {
        look = cam.GetComponent<LookAt>();
    }
    public void PauseBTTN(float amt)
    {


        timeScale = amt;

    }

    public void PlanetSelection(int amt)
    {

        look.lookAtValue = amt;


    }
}
