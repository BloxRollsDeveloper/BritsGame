using System;
using UnityEngine;

public class BoltCtrl : MonoBehaviour
{

    public float hitCounter = 100;


    private void Start()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        hitCounter -= 1;
        Destroy(other.gameObject);
        if (hitCounter <= 0)
        {
            OnDestroy();
        }
    }


    private void OnDestroy()
    {
        gameObject.SetActive(false);
    }
}
