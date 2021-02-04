using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonRevolutions : MonoBehaviour
{

    public Transform target;

    public float radius = 2;
    public float age = 0f;


    void Update()
    {

        age += Time.deltaTime * HudController.timeScale;

        Vector3 offset = new Vector3();
        offset.x = Mathf.Cos(age) * radius;
        offset.z = Mathf.Sin(age) * radius;
        //math

        transform.position = target.position + offset;


    }
}
