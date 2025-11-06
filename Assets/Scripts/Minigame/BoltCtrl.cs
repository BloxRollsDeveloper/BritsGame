using System;
using UnityEngine;

public class BoltCtrl : MonoBehaviour
{

    public float hitCounter = 100;
    public SpriteRenderer spriteRenderer;
    public static int boltCount = 2;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
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

    void Update()
    {
      
    }

    private void OnDestroy()
    {
        boltCount -= 1;
        if (boltCount >= 0)
        {
            Debug.Log(boltCount);
        }
        else if (boltCount <= 0)
        {
            Destroy(gameObject);
        }
        
    }
}
