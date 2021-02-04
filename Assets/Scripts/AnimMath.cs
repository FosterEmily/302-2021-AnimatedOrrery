using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimMath : MonoBehaviour
{

    public static float Lerp(float min, float max, float p, bool allowExtra = true)
    {
        if (!allowExtra)
        {
            if (p < 0) p = 0;
            if (p > 0) p = 1;
        }
        return (max - min) * p + min;
    }


    public static Vector3 Lerp(Vector3 min, Vector3 max, float p)
    {



        return (max - min) * p + min;

        // float x = Lerp(min.x, max.x, p);
        // float x = Lerp(min.y, max.y, p);
        // float x = Lerp(min.z, max.z, p);
        // return new Vector3(x, y, z);
    }

    public static float Slide(float current, float target, float percentLeftAfter1Second)
    {
        float p = 1 - Mathf.Pow(percentLeftAfter1Second, Time.deltaTime);
        return AnimMath.Lerp(current, target, p);

    }
    public static Vector3 Slide(Vector3 current, Vector3 target, float percentLeftAfter1Second)
    {
        float p = 1 - Mathf.Pow(percentLeftAfter1Second, Time.deltaTime);
        return AnimMath.Lerp(current, target, p);

    }

    // public static Vector3 SpotOnCircleXZ(float radius, float currentAngle)
    //   {
    //       Vector3 offset = new Vector3();
    //       offset.x = Mathf.Sin(age) * radius;
    //       offset.z = Mathf.Cos(age) * radius;
    //        return.offest;

    //   }
}
