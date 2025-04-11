using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private RigidBody2D _rigidBody2D;
    private BoxCollider2D _collider2D;
    private GroundSensor _groundSensor;

    public float playerspeed = 4.5f;
    public

    void Awake()
    {
        _rigidBody2D = GetComponent<RigidBody2D>();
        GroundSensor _groundSensor = GetInParent<GroundSensor>();
    }

    void FixedUpdate()
    {
        if()
        {
            float speed = Input.GetAxisRaw("Horizontal") * time.deltaTime;
            transform.rotation
        }
        

    }
    

    void Jump()
    {
        _rigidbody2D(Vector2.up*jump)
    }
}
