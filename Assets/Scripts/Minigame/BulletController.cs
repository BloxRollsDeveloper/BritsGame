using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float moveSpeed = 5;
    
    public Rigidbody2D _rigidbody2D;

    
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        Destroy(gameObject,5);
    }
    void Update()
    {
        _rigidbody2D.linearVelocity = new Vector2(0f, moveSpeed);
    }
}
