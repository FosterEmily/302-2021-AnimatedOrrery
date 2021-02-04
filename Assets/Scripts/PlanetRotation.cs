using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public float rotate = 0f;
    void Update()
    {
        rotate++;
        transform.rotation = Quaternion.Euler(0, rotate, 0);

    }
}
