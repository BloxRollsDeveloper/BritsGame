using System;
using UnityEngine;

public class BoltCtrl : MonoBehaviour
{

    public float hitCounter = 100;
    public SpriteRenderer spriteRenderer;
    public static int Count = 2;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        hitCounter -= 1;
        Destroy(other.gameObject);
    }

    void Update()
    {
        if (hitCounter <= 0)
        {
            OnDestroy();
        }
    }

    private void OnDestroy()
    {
        Count -= 1;
        if (Count <= 0)
        {
            
        }
        else if (Count >= 0)
        {
            Destroy(gameObject);
        }
    }
}
