using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotateObject : MonoBehaviour
{
    float timer = 0f;
    float speed = 2f;
    int phase = 0;



    void FixedUpdate()

    {
        timer += Time.fixedDeltaTime;
        if (timer > 1f)
        {
            phase++;
            phase %= 4;
            timer = 0;
        }

        switch (phase)
        {
            case 0:
                transform.Rotate(0f, speed * (1 - timer),0);
                break;
            case 1:
                transform.Rotate(0f,  -speed * timer,0f);
                break;
            case 2:
                transform.Rotate(0f, -speed * (1- timer), 0f);
                break;
            case 3:
                transform.Rotate(0f, speed * timer, 0f);
                break;
        }
    }
}
