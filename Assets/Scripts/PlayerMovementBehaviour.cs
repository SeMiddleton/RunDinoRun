using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehaviour : MonoBehaviour
{
    private Rigidbody _rb;
    private Vector2 _moveDirection;

    public float Acceleration;
    public float MaxSpeed;
    public float JumpPower;
    public GroundColliderBehaviour GroundCollider;

    // Start is called before the first frame update

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    public void SetMoveDirection(Vector3 direction)
    {
        _moveDirection = direction;
    }

    public void Jump()
    {
        if (GroundCollider.IsGrounded)
            _rb.AddForce(Vector3.up * JumpPower, ForceMode.Impulse);
    }

    // Update is called once per frame

    private void FixedUpdate()
    {
        float acceleration = Acceleration;

        if (!GroundCollider.IsGrounded)

        _rb.AddForce(_moveDirection * acceleration * Time.deltaTime, ForceMode.VelocityChange);        
    }
}
