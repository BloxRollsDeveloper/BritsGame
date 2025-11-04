using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class MiniGamePlayerCtrl : MonoBehaviour
{
    public float moveSpeed;
    
    public Rigidbody2D _rigidbody2D;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    
    private InputSystem _input;
    void Start()
    {
        _input = GetComponent<InputSystem>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (_input.Attack)
        {
            Instantiate(bulletPrefab, bulletSpawn.position, Quaternion.identity); 
        }
        _rigidbody2D.linearVelocityX = (_input.Horizontal * moveSpeed);
    }
}
