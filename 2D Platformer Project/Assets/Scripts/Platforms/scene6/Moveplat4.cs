using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveplat4 : MonoBehaviour
{
    public Sliding_h slider;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            slider.enabled = true;
        }
    }
}
