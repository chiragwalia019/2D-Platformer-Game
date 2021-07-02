using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slider6 : MonoBehaviour
{
    float movespeed = 2f;
    bool moveRight = true;

    private void Update()
    {
        if (transform.position.x > 7)
            moveRight = false;
        if (transform.position.x < -5.5)
            moveRight = true;

        if (moveRight)
            transform.position = new Vector2(transform.position.x + movespeed * Time.deltaTime, 2f); //-2 is transform.position.y

        else
            transform.position = new Vector2(transform.position.x - movespeed * Time.deltaTime, 2f);
    }
}
