using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float moveSpeed = 5;
    
    private Rigidbody2D _rigidbody2D;
    // Update is called once per frame
    void Update()
    {
        _rigidbody2D.linearVelocity = new Vector2(0f, moveSpeed);
    }
}
