using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roulettescript : MonoBehaviour
{
    float rotspeed = 0;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.rotspeed = 10;
        }

        transform.Rotate(0, 0, this.rotspeed);

        //감쇠계수감속
        this.rotspeed *= 0.98f;

        //선형감속
        /*if (rotspeed > 0)
        {
            this.rotspeed -= 0.1f;
        }*/
    }
}
