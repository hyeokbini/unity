using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float carspeed = 0;
    Vector2 startpos;
    Vector2 endpos;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {

        if(Input.GetMouseButtonDown(0))
        {
            this.startpos = Input.mousePosition;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            this.endpos = Input.mousePosition;
            float swipelength = endpos.x - startpos.x;

            this.carspeed = swipelength / 5000.0f;

            GetComponent<AudioSource>().Play();
        }

        transform.Translate(this.carspeed, 0, 0);
        this.carspeed *= 0.98f;
    }
}
