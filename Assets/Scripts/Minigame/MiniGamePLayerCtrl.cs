using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class MiniGamePLayerCtrl : MonoBehaviour
{
    public float moveSpeed;
    public float left;
    public float right;

    public float horizontalAxis;
    public Rigidbody2D _rigidbody2D;

    void Update()
    {
        if (Keyboard.current.aKey.isPressed)
        {
            left = -1f;
        }
        else  
        {
            left = 0f;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            right = 1f;
        }
        else  
        {
            right = 0f;
        }

        horizontalAxis = left + right;
        
        _rigidbody2D.linearVelocity = new Vector2(horizontalAxis, 0f) * moveSpeed;
    }
}
